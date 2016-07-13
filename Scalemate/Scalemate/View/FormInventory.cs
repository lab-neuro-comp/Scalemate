using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Scalemate.Controller;

namespace Scalemate.View
{
    public partial class FormInventory : Form
    {
        public Form Mother { get; set; }
        public Tester Mate { get; private set; }
        private int NoOptions { get; set; }
        private int CurrentQuestion { get; set; }
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
            WindowState = FormWindowState.Maximized;
            NoOptions = Mate.GetNoOptions();
            Answers = new int[Mate.GetNoQuestions()];
            Score = CurrentQuestion = 0;

            CreateRows();
            SetQuestions();
            this.Show();
            Mother.Hide();
        }

        private void SetQuestions()
        {
            labelQuestion.Text = Mate.Question;
            Radios.ToList().ForEach(radio => radio.Text = Mate.NextOption());
            ReverseScore = Mate.ReverseScore;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Score += ExtractScore();

            if (Mate.Ended)
                ShowResults();
            else
            {
                Mate.Continue();
                SetQuestions();
            }
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
            form.Test = Mate.Test;
            form.Patient = Mate.Patient;
            form.Answers = Answers;
            form.Survey = Survey;
            form.CalculateScore(Score);
            form.Show();
            this.Close();
        }
    }
}

