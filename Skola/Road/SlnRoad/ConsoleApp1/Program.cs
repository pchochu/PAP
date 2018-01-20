using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Road r1 = new Road(TypeOfRoad.dialnica, 1);

            Manager rn = new Manager(5);
            rn.AddRoad(TypeOfRoad.triedaI, 28);
            rn.AddRoad(TypeOfRoad.dialnica, 150);
            rn.AddRoad(TypeOfRoad.triedaII, 3);
            rn.PrintRoads();
            rn.RemoveAt(1);
            rn.AddRoad(TypeOfRoad.triedaII, 300);
            rn.PrintRoads();

            Console.WriteLine(rn[3].ID);

            Console.WriteLine(rn.GetIndexOfRoad(rn[3]));

            Console.ReadLine();
        }
    }
}
