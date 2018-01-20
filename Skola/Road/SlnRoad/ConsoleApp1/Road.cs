using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum TypeOfRoad { nespecfikovane, dialnica, triedaI, triedaII }
    public class Road
    {
        private static int lastID = 0;
        private int id;
        private double km;
        private TypeOfRoad roadType;

        public int ID { get { return this.id; } }

        public Road(TypeOfRoad road, double lenght)
        {
            id = Road.lastID++;
            km = lenght;
            roadType = road;
        }


        public override string ToString()
        {
            return String.Format("Road id :{0}, lenght:{1}, type: {2}", id, km, roadType);
        }

        public override bool Equals(object obj)
        {
            Type a = obj.GetType();
            Type b = typeof(Road);

            if(a == b)
            {
                return (this.id == ((Road)obj).id);
            }
            return false;

        }
    }

   
}
