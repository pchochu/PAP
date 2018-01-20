using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Manager
    {
        private Road[] roads;

        public Manager(int maxNumberOfRoads)
        {
            roads = new Road[maxNumberOfRoads];
        }

        public void PrintRoads()
        {
            Console.WriteLine("ITEMS OF ROAD MANAGER");
            foreach(Road r in roads)
            {
                if (r == null) continue;
                Console.WriteLine(r.ToString());
            }
        }

        public bool AddRoad(TypeOfRoad roadT, double lenght)
        {
            Road newRoad = new Road(roadT, lenght);
            int i = 0;

            foreach(Road r in roads)
            {
                if (r == null)
                {
                    roads[i] = newRoad;
                    return true;
                }
                i++;
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if( index > roads.Length)
            {
                Console.WriteLine("Pole nie je tak dlhe");
                return false;
            }
            else if(roads[index] != null)
            {
                roads[index] = null;
                Console.WriteLine("Prvo bol odobrany");
                return true;
            }
            Console.WriteLine("Na danej pozici sa nic nenachadza");
            return false;
        }

        public Road this[int id]
        {
            get
            {
                foreach (Road r in roads)
                {
                    if (r == null) continue;
                    if (r.ID == id) return r;
                }
                return null;
            }
        }


        public List<Road> ConvertToList()
        {
            return roads.ToList<Road>();
        }

        public int GetIndexOfRoad(Road roadToFind)
        {
            return Array.IndexOf(roads, roadToFind);
        }
    }
}
