using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Scalemate;

namespace ScalemateForms.View
{
    public partial class FormInventory : Form
    {
        public Form Mother { get; set; }
        public Tester Mate { get; private set; }
        private int NoOptions { get; set; }
        private int CurrentQuestion { get; set; }
        public string[] Survey { get; set; }

        /// <summary>
        /// Generates a form for the test. To begin this process, create a form then
        /// call the `Start()` method. Do not forget to call `CollectInformation()` and
        /// `Instruct()`before beginning to better interact with user.
        /// </summary>
        /// <param name="mate">A ScalemateForms controller to this test</param>
        public FormInventory(Tester mate)
        {
            Mate = mate;
            InitializeComponent();
            Survey = null;
        }

        /// <summary>
        /// Starts the test execution. Draws a window with the question and its
        /// options as described by the tests' files. Will go on until there are
        /// no more questions left, when will call a `FormResult` to instruct the
        /// patient to end the test application.
        /// </summary>
        public void Start()
        {
            WindowState = FormWindowState.Maximized;
            NoOptions = Mate.NoOptions;
            CurrentQuestion = 0;

            CreateRows();
            SetQuestions();
            this.Show();
            Mother.Hide();
        }

        private void SetQuestions()
        {
            labelQuestion.Text = Mate.Question;
            var options = new Queue<string>(Mate.NoOptions);
            Radios.ToList().ForEach(radio => radio.Text = options.Dequeue());
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            // Extract the answer given by the patient
            int result = 0;
            foreach (var radio in Radios)
                if (radio.Checked)
                    break;
                else
                    result++;
            Mate.Listen(result);

            // Update form
            if (Mate.Ended)
            {
                ShowResults();
            }
            else
            {
                Mate.Continue();
                SetQuestions();
            }
        }

        private void ShowResults()
        {
            var form = new FormResult(Mate);
            form.Mother = Mother;
            form.Show();
            this.Close();
        }
    }
}

