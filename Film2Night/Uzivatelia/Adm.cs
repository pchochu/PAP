using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_DbOperacie;

namespace Uzivatelia
{
    public class Adm: UzivateliaInfo
    {
        Operacie o = new Operacie();
        public override bool zaregistruj()
        {
            if (o.zaregistrujAdmina(heslo, userMeno, menoPriezvisko))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string text()
        {
            return "som v adminovy";
        }
    }
}
