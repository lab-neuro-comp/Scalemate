using System;
using System.Windows.Forms;
using Scalemate.View;

namespace Scalemate
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
