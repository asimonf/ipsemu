using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Infinity_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            App app = new App();
            Application.Run(app);
        }
    }
}