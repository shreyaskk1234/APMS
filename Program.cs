using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace APMS
{
    static class Program
    {
        static public mainapms apms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            apms = new mainapms();
            Application.Run(apms);
        }
    }
}
