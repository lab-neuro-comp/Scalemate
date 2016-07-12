using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Scalemate.Controller;
using Scalemate.Model;

namespace Scalemate.View
{
    public partial class FormInventory : Form
    {
        public Form Mother { get; set; }
        public Tester Mate { get; private set; }
        private int NoQuestions { get; set; }
        private int CurrentQuestion { get; set; }
        private Queue<string> Questions { get; set; }
        private int[] Answers { get; set; }
        private int Score { get; set; }
        private bool ReverseScore { get; set; }
        public string[] Survey { get; set; }

        public FormInventory(Tester mate)
        {
            Mate = mate;
            InitializeComponent();
            ReverseScore = false;
            Survey = null;
        }

        public void Start()
        {
            string[] raw = DataAccessLayer.Load(DataAccessLayer.GetInventoryPath(Mate.Test));
            NoQuestions = int.Parse(raw[0]);
            Questions = new Queue<string>(Rest(raw));
            Answers = new int[Questions.Count / (NoQuestions + 1)];
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

            try
            {
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
            catch (IndexOutOfRangeException e)
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
            //var form = new FormResult();
            //form.Mother = Mother;
            //form.Test = Mate.Test;
            //form.Patient = Mate.Patient;
            //form.Answers = Answers;
            //form.Survey = Survey;
            //form.CalculateScore(Score);
            //form.Show();
            Mother.Show();
            this.Close();
        }
    }
}

