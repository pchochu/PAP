using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_DbOperacie;
using Filmy;

namespace Uzivatelia
{
    public class UzivateliaInfo
    {
        Operacie o = new Operacie();
        public string userMeno { get; set; }
        public string menoPriezvisko { get; set; }
        public string heslo { get; set; }
        public string heslo2 { get; set; }
        public string typ { get; set; }
        public int Id { get; set; }

        public bool zaregistruj()
        {
            if(o.zaregistruj(heslo, userMeno, menoPriezvisko))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable logIn()
        {
            return o.logIn(userMeno, heslo);
        }

        public virtual Film NacitajMojFilm(int pocitadlo, int i)
        {
            return null;
        }


        public virtual void videl(int id)
        {

        }
    }
}
