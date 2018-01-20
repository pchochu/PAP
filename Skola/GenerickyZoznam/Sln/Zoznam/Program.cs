using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoznam
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoznamik<Prvok> prvni = new Zoznamik<Prvok>(new Prvok(1, true));
            prvni.PridajNaslednika(new Prvok(2, false));
            Zoznamik<Prvok> ukazatel = prvni.Dalsi.PridajNaslednika(new Prvok(3, true));
            ukazatel.PridajNaslednika(new Prvok(4, false));

            prvni.Vypis();

            Console.WriteLine(prvni.Najdi(new Prvok(3, true)));

            Console.ReadLine();
        }
    }
}
