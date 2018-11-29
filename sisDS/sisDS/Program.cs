using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sisDS
{
    static class Program
    {

        public static string conect = "Integrated Security=SSPI;Persist Security Info=False;User ID=LuisLopes;Initial Catalog=escola;Data Source=DESKTOP-4UTDGLB";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
