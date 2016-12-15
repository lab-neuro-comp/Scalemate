using System;
using System.Windows.Forms;
using ScalemateForms.View;

namespace ScalemateForms
{
    static class Program
    {
        /// <summary>
        /// The application begins by calling the Main Form,
        /// the class for the main screen
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}

// wake up, skip school, turn on the atari.
// with my console, i'm in control.
// let my mind go, till it becomes a downfall, then turn it out loud
// chiptune
