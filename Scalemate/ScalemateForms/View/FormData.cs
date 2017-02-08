using System;
using System.Linq;
using System.Windows.Forms;

namespace ScalemateForms.View
{
    public partial class FormData : Form
    {
        public bool Ended { get; set; }
        public bool Completed { get; set; }
        public string[] Survey { get; private set; }

        public FormData()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Ended = false;
            Completed = false;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            bool everythingAnswered = true;
            var answers = Answers.Select((it) => it.Text);

            answers.ToList().ForEach((answer) => everythingAnswered &= answer.Length > 0);
            if (everythingAnswered)
            {
                Ended = true;
                Completed = true;
                Survey = answers.ToArray<string>();
            }
            else
            {
                MessageBox.Show("Responda todas as perguntas.", "Aviso!");
            }
        }
    }
}
