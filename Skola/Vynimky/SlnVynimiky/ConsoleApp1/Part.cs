using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Part
    {
        private int cena; 

        public Part(int cena)
        {
            this.cena = cena;
        }

        public int GetZbytkovaCena()
        {
            if(cena < 0)
            {
                throw new ExceptionNegativePrice(cena, String.Format("Problem v vypoctom zbytkovej hodnoty, zaporna vstupna cena {0}", cena));
            }
            else
            {
                return cena;
            }
        }

        public override string ToString()
        {
            return this.cena.ToString();
        }
    }
}
