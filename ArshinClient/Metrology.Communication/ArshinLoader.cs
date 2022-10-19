//Svitkin, 2022
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Metrology.Communication
{
    class ArshinLoader
    {
        const string BaseURL = "https://fgis.gost.ru/fundmetrology/eapi/";

        WebClient wc;        

        public ArshinLoader()
        {
            wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
        }

        string DoRequest(string url)
        {
            return wc.DownloadString(url);
        }

        string GetVerificationDataString(int year, string regnum, bool exact)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(BaseURL);
            sb.Append("vri?year=");
            sb.Append(year.ToString());
            sb.Append("&search=");

            if (exact)
            {
                sb.Append(regnum);
            }
            else
            {                
                sb.Append(regnum);
                sb.Append('*');
            }

            sb.Append("&rows=20");
            return DoRequest(sb.ToString());
        }

        public VerificationData[] GetVerificationData(int year, string regnum, bool exact)
        {
            string json = GetVerificationDataString(year, regnum, exact);
            JObject j = JObject.Parse(json);
            JObject result = j["result"] as JObject;
            JArray items = result["items"] as JArray;
            List<VerificationData> ret = new List<VerificationData>(items.Count);

            for (int i = 0; i < items.Count; i++)
            {
                JToken x = items[i];
                VerificationData data = new VerificationData();
                data.VriId = items[i]["vri_id"].Value<string>();

                if (items[i]["org_title"] != null)
                {
                    data.OrgTitle = items[i]["org_title"].Value<string>();
                }
                else
                {
                    data.OrgTitle = string.Empty;
                }

                if (items[i]["mit_number"] != null)
                {
                    data.DeviceTypeNumber = items[i]["mit_number"].Value<string>();
                }
                else
                {
                    data.DeviceTypeNumber = string.Empty;
                }

                data.DeviceType = items[i]["mit_title"].Value<string>();
                data.DeviceNotation = items[i]["mit_notation"].Value<string>();
                data.DeviceModification = items[i]["mi_modification"].Value<string>();
                data.Regnum = items[i]["mi_number"].Value<string>();

                string datestr = items[i]["verification_date"].Value<string>();
                DateTime date;

                if (DateTime.TryParse(datestr, out date))
                {
                    data.VerificationDate = date;
                }

                if (items[i]["valid_date"] != null)
                {
                    datestr = items[i]["valid_date"].Value<string>();

                    if (DateTime.TryParse(datestr, out date))
                    {
                        data.ValidUntilDate = date;
                    }
                }
                
                data.ResultDocnum = items[i]["result_docnum"].Value<string>();
                data.Applicability = items[i]["applicability"].Value<bool>();
                ret.Add(data);
            }
            
            return ret.ToArray();
        }
    }
}
