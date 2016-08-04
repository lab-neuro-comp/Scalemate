using System;
using System.Windows.Forms;
using Scalemate.Controller;

namespace Scalemate.View
{
    public partial class FormMain : Form
    {
        public string[] Tests { get; private set; }

        public FormMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            var lines = Tester.LoadKinds();
            Tests = new string[lines.Length];
            int i = 0;

            foreach (var line in lines)
            {
                var stuff = line.Split(' ');
                var name = stuff[1];

                for (int j = 2; j < stuff.Length; ++j)
                    name = name + " " + stuff[j];

                Tests[i++] = stuff[0];
                listKind.Items.Add(name);
            }

            listKind.SetSelected(0, true);
        }

        /// <summary>
        /// Begins the test as selected by the user. Before this, the application will 
        /// check for the presence of the survey and the instructions commands.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonStart_Click(object sender, EventArgs e)
        {
            Tester mate = new Tester(Tests[listKind.SelectedIndex], textPatient.Text);
            FormInventory form = new FormInventory(mate);
            form.Mother = this;

            await form.CollectInformation();
            await form.Instruct();
            form.Start();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
