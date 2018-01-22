using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Majetok
    {
        List<Part> parts = new List<Part>();
        int cena;

        public Majetok()
        {
            Random r = new Random();
            cena = r.Next(-10, 10);
        }

        public void AddParts(int[] ceny)
        {
            foreach(int i in ceny)
            {
                parts.Add(new Part(i));
            }
        }

        public double GetZbytkovaCena()
        {
            double pomZb = 0;

            foreach(Part p in parts)
            {
                try
                {
                    pomZb += p.GetZbytkovaCena();
                }
                catch (ExceptionNegativePrice e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(String.Format("Cast majetku ma zadanu zle nakupnu cenu. Tuto cenu nezaratam {0}", p.ToString()));
                }
            }
            return cena * 0.5 + pomZb;
        }
    }
}
