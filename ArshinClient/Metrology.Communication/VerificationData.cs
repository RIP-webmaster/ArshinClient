//Svitkin, 2022
using System;
using System.Collections.Generic;
using System.Text;

namespace Metrology.Communication
{
    public class VerificationData
    {
        public string VriId { get; set; }
        public string OrgTitle { get; set; }
        public string DeviceTypeNumber { get; set; }
        public string DeviceType { get; set; }
        public string DeviceNotation { get; set; }
        public string DeviceModification { get; set; }
        public string Regnum { get; set; }
        public DateTime VerificationDate { get; set; }
        public DateTime ValidUntilDate { get; set; }
        public string ResultDocnum { get; set; }
        public bool Applicability { get; set; }

        public string ToText()
        {
            StringBuilder sb = new StringBuilder(100);
            sb.AppendLine("Заводской номер: " + this.Regnum);
            sb.AppendLine("Тип: " + this.DeviceType);
            sb.AppendLine("Модель: " + this.DeviceModification);
            sb.AppendLine("Дата поверки: " + this.VerificationDate.ToShortDateString());
            
            if (!this.Applicability)
            {
                sb.AppendLine("Результат: [Не прошел поверку!]");
            }
            else
            {
                sb.AppendLine("Действителен до: " + this.ValidUntilDate.ToShortDateString());
            }

            return sb.ToString();
        }
    }
}
