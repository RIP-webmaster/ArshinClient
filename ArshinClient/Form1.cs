//Svitkin, 2022
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Metrology.Communication;

namespace ArshinClient
{
    public partial class Form1 : Form
    {
        ArshinLoader loader = new ArshinLoader();

        public Form1()
        {
            InitializeComponent();
            numVerificationYear.Value = DateTime.Now.Year;
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            if (tbRegnum.Text.Length == 0)
            {
                MessageBox.Show("Введите заводской номер");
                return;
            }

            VerificationData[] res = loader.GetVerificationData(
                (int)numVerificationYear.Value, tbRegnum.Text, cbExact.Checked);

            if (res.Length == 0)
            {
                tbResults.Text = "Ничего не найдено!";
                return;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < res.Length; i++)
            {
                sb.AppendLine("Запись №"+(i+1).ToString());
                sb.AppendLine(res[i].ToText());
            }

            tbResults.Text = sb.ToString();
        }
    }
}
