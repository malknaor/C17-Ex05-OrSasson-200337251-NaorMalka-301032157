using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace C17_Ex05_Or_200337251_Naor_301032157
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GameSettings());
            Application.Run(new BoardForm(5, C17_Ex02_Naor_301032157_Or_200337251.ePlayerType.Computer));
        }
    }
}