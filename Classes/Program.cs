using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SkounyCrypt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string openFile = String.Empty;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0) openFile = args[0];
            try
            {
                Application.Run(new FormMain(openFile));
            }
            catch { }
        }
    }
}
