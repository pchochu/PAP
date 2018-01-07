using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uzivatelia;

namespace Admin
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UzivateliaInfo info = new UzivateliaInfo();
            info.menoPriezvisko = "admin";
            info.userMeno = "admin";
            info.Id = 20;
            info.typ = "A";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new hlavneA(info));
        }
    }
}
