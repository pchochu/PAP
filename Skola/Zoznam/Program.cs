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
            Polozka prva = new Polozka(1);
            Polozka p = prva.PridajPolozku(-2);

            p.Vypis();
            Console.ReadKey();
        }
    }
}
