using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoznam
{
    public class Polozka
    {
        private int data;

        public int Data
        {
            get { return data; }
            set
            {
                if(value < 0) { this.data = 0;  }
                else { this.data = value; }
            }
        }

        private Polozka dalsi;

        public Polozka Dalsi { get { return dalsi; } }

        private Polozka predosli;

        public Polozka Predosli { get { return predosli; } }

        public Polozka(int noveData)
        {
            this.Data = noveData;
        }

        public Polozka PridajPolozku(int data)
        {
            Polozka p = new Polozka(data);
            p.predosli = this;
            this.dalsi = p;

            return p;
        }

        public void Vypis()
        {
            Console.WriteLine(this.data);
            if(dalsi != null)
            {
                dalsi.Vypis();
            }
        }

        public bool OdoberNasledujuceho()
        {
            if(dalsi != null)
            {
                this.dalsi = this.dalsi.dalsi;

                if (this.dalsi != null)
                {
                    this.dalsi.predosli = this;
                }

                return true;
            }
            return false;
        }

    }
}
