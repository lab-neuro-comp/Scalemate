using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scalemate.Controller;
using Scalemate.Model;

namespace Scalemate.View
{
    public partial class FormResult : Form
    {
        public Form Mother { get; set; }
        public string Test { get; set; }
        public string Patient { get; set; }
        public int[] Answers { get; set; }
        public string[] Survey { get; set; } = null;

        public FormResult()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        public void CalculateScore(int score)
        {
            DataParser DP;
            string[] results = DataAccessLayer.Load(DataAccessLayer.GetResultsPath(Test));
            string result = "";

            /* Obtain result */
            foreach (var line in results)
            {
                DP = new DataParser(line);
                int lowerbound = DP.Lowerbound;
                int upperbound = DP.Upperbound;
                string message = DP.Message;

                if (score >= lowerbound && score < upperbound)
                {
                    result = message;
                    break;
                }
            }

            /* Write answers */
            string[] parts = { Test, Patient, string.Format("{0}", score), result };
            DataAccessLayer.Save(DataAccessLayer.GenerateResultsPath(Patient, Test), GenerateCSV(parts));
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GenerateTXT(string[] parts)
        {
            int index = 0;
            string[] outlet = new string[parts.Length + 1];

            foreach (var part in parts)
            {
                outlet[index++] = part;
            }
            index = 1;
            outlet[outlet.Length - 1] = Answers.Aggregate("Respostas:\r\n",
                (acc, x) => string.Format("{0}  {1}. {2}\r\n", acc, index++, x));

            return outlet.Aggregate("", (acc, x) => string.Format("{0}{1}\r\n", acc, x));
        }

        private string GenerateCSV(string[] stuff)
        {
            string outlet = "";

            if (Survey == null)
            {
                outlet = stuff.Aggregate("", (box, it) => box + it + "\t") +
                         Answers.Aggregate("\r\n", (box, it) => box + it + "\r\n");
            }
            else
            {
                outlet = stuff.Aggregate("", (box, it) => box + it + "\t") +
                         Survey.Aggregate("\r\n", (box, it) => box + it + "\r\n") +
                         Answers.Aggregate("", (box, it) => box + it + "\r\n");
            }

            return outlet;
        }
    }
}
