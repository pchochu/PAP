using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Room
    {
        int embededPrice;
        List<Majetok> items = new List<Majetok>();

        public Room()
        {
            Random r = new Random();
            embededPrice = r.Next(-10, 10);
            AddMajetek();
        }

        public void AddMajetek()
        {
            Majetok m = new Majetok();
            m.AddParts(new int[3] { 2, 3, 1 });
            items.Add(m);

            m = new Majetok();
            m.AddParts(new int[3] { 1, -3, -5 });
            items.Add(m);
        }

        public double SpoctiZbytkovaHodnota()
        {
            double result = 0;

            foreach (Majetok m in items)
            {
                try
                {
                    result += m.GetZbytkovaCena();
                }
                catch (ExceptionNegativePrice)
                {
                    result += 0; //ignoruji celou polozku
                }
            }

            return result + embededPrice;
        }

    }
}
