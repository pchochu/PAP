using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            NameChecker a = NameChecker.GetInstance();
            a.AddName("first");
            a.PrintAll();

            NameChecker b = NameChecker.GetInstance();
            b.PrintAll();

            Console.ReadLine();
        }
    }
}
