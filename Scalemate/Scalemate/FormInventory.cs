using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Scalemate
{
    public partial class FormInventory : Form
    {
        public Form Mother { get; set; }
        public string Test { get; set; }
        public string Patient { get; set; }
        private int NoQuestions { get; set; }
        private int CurrentQuestion { get; set; }
        private Queue<string> Questions { get; set; }
        private int[] Answers { get; set; }
        private int Score { get; set; }
        private bool ReverseScore { get; set; }
        public string[] Survey { get; set; }

        public FormInventory()
        {
            InitializeComponent();
            ReverseScore = false;
            Survey = null;
        }

        public void Start()
        {
            DataAcessLayer DAL = new DataAcessLayer();
            string[] raw = DAL.Load(DAL.GetInventoryPath(Test));
            NoQuestions = int.Parse(raw[0]);
            Questions = new Queue<string>(Rest(raw));
            Answers = new int[Questions.Count/(NoQuestions+1)];
            Score = CurrentQuestion = 0;
            
            CreateRows();
            SetQuestions();
            this.Show();
            Mother.Hide();
        }

        private void SetQuestions()
        {
            labelQuestion.Text = Questions.Dequeue();
            Radios.ToList().ForEach(radio => radio.Text = Questions.Dequeue());

            if (labelQuestion.Text[0] == '*')
            {
                labelQuestion.Text = labelQuestion.Text.Substring(1);
                ReverseScore = true;
            }
            else
            {
                ReverseScore = false;
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Score += ExtractScore();

            if (Questions.Count == 0)
                ShowResults();
            else
                SetQuestions();
        }

        private int ExtractScore()
        {
            int result = 0;

            foreach (var radio in Radios)
            {
                if (radio.Checked)
                    break;
                else
                    result++;
            }

            result = (ReverseScore) ? Radios.Length - (1 + result) : result;
            Answers[CurrentQuestion++] = result;
            return result;
        }

        private void ShowResults()
        {
            var form = new FormResult();
            form.Mother = Mother;
            form.Test = Test;
            form.Patient = Patient;
            form.Answers = Answers;
            form.Survey = Survey;
            form.CalculateScore(Score);
            form.Show();
            this.Close();
        }
    }
}

