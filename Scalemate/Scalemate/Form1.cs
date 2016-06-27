using System;
using System.Windows.Forms;

namespace Scalemate
{
    public partial class Form1 : Form
    {
        public string[] Tests { get; private set; }

        public Form1()
        {
            InitializeComponent();

            /// SET TESTS
            DataAcessLayer DAL = new DataAcessLayer();
            var lines = DAL.Load(@"assets\kinds.txt");
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
            FormInventory form = new FormInventory();
            form.Mother = this;
            form.Patient = textPatient.Text;
            form.Test = Tests[listKind.SelectedIndex];
            await form.CollectInformation();
            await form.Instruct();
            form.Start();
        }
    }
}
