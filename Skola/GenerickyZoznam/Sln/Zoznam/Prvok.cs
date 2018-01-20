using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoznam
{
    public class Prvok: IMyData, IEquatable<Prvok>
    {
        private int pocet;
        private bool zoSeveru;

        public Prvok(int pocet, bool suZoSeveru)
        {
            this.pocet = pocet;
            this.zoSeveru = suZoSeveru;
        }

        public bool Equals(Prvok other)
        {
            return ((this.pocet == other.pocet) && (this.zoSeveru == other.zoSeveru));
        }

        public string NejakeVypisky()
        {
            return String.Format("Polozka obsahuje {0} medvedov, zo severu {1}", pocet, zoSeveru);
        }
    }
}
