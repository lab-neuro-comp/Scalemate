using System;
using System.Linq;
using System.Windows.Forms;

namespace Scalemate
{
    public partial class FormResult : Form
    {
        public Form Mother { get; set; }
        public string Test { get; set; }
        public string Patient { get; set; }
        public int[] Answers { get; set; }

        public FormResult()
        {
            InitializeComponent();
        }

        public void CalculateScore(int score)
        {
            DataParser DP;
            DataAcessLayer DAL = new DataAcessLayer();
            string[] results = DAL.Load(DAL.GetResultsPath(Test));
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
            string[] parts = {Test, Patient, string.Format("{0}", score), result };
            DAL.Save(DAL.GenerateResultsPath(Patient, Test), GenerateCSV(parts));
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            Mother.Show();
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
            outlet[outlet.Length-1] = Answers.Aggregate("Respostas:\r\n", 
                (acc, x) => string.Format("{0}  {1}. {2}\r\n", acc, index++, x));
            
            return outlet.Aggregate("", (acc, x) => string.Format("{0}{1}\r\n", acc, x));
        }

        private string GenerateCSV(string[] stuff)
        {
            return stuff.Aggregate("", (box, it) => box + it + "\t") +
                   Answers.Aggregate("\r\n", (box, it) => box + it + "\r\n");
        }
    }
}
