using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uzivatelia;

namespace WF_Bezny
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UzivateliaInfo vyplneny = new UzivateliaInfo();
            vyplneny.menoPriezvisko = "Peter Novak";
            vyplneny.typ = "U";
            vyplneny.userMeno = "Peter";
            vyplneny.Id = 1;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new hlavne(vyplneny));
        }
    }
}
