using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmy;
using Lib_DbOperacie;

namespace Uzivatelia
{
    public class Bezny: UzivateliaInfo
    {
        Operacie o = new Operacie();
        public override Film NacitajMojFilm(int pocitadlo, int i)
        {
            return o.nacitajMojFilm(Id.ToString(),pocitadlo, i);
        }

        public override void videl(int Filmid)
        {
            o.videl(Id, Filmid);
        }
    }
}
