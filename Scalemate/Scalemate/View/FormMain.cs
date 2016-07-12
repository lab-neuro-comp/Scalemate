using System;
using System.Windows.Forms;
using Scalemate.Controller;

namespace Scalemate.View
{
    public partial class FormMain : Form
    {
        public string[] Tests { get; private set; }
        private Tester Mate { get; set; }

        public FormMain()
        {
            InitializeComponent();
            Mate = new Tester();

            /// SET TESTS
            var lines = Mate.LoadKinds();
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

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            FormInventory form = new FormInventory(Mate);
            form.Mother = this;

            form.Mate.SetTest(Tests[listKind.SelectedIndex]);
            form.Mate.SetPatient(textPatient.Text);
            await form.CollectInformation();
            await form.Instruct();

            form.Start();
        }
    }
}
