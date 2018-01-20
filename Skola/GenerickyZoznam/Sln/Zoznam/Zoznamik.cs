using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoznam
{
    public class Zoznamik<T> where T : IMyData, IEquatable<T>
    {
        private static int maxID = 0;

        private int id;
        private T data;

        public T Data
        {
            get { return data; }
            set { this.data = value; }
        }

        private Zoznamik<T> dalsi;
        public Zoznamik<T> Dalsi
        {
            get { return dalsi; }
        }

        private Zoznamik<T> predosli;

        public Zoznamik<T> Predosli
        {
            get { return predosli; }
        }

        public Zoznamik(T noveData)
        {
            this.id = maxID++;
            this.data = noveData;
        }

        public Zoznamik<T> PridajNaslednika(T data)
        {
            Zoznamik<T> z = new Zoznamik<T>(data);
            this.dalsi = z;
            z.predosli = this;

            return z;
        }

        public void Vypis()
        {
            Console.WriteLine(this.data.NejakeVypisky());
            if(dalsi != null) { dalsi.Vypis(); };
        }

        public bool OdoberNaslednika()
        {
            if(dalsi == null)
            {
                return false;
            }
            else
            {
                this.dalsi = dalsi.dalsi;
                if (dalsi != null)
                {
                    dalsi.predosli = this;
                }
                return true;
            }
        }
        
        private int Dopredu(T hladane)
        {
            if(this.data.Equals(hladane)) { return this.id; }
            if(dalsi == null) { return -1; }
            return dalsi.Dopredu(hladane);
        }

        private int Dozadu(T hladane)
        {
            if (this.data.Equals(hladane)) { return this.id; }
            if (predosli == null) { return -1; }
            return dalsi.Dozadu(hladane);
        }

        public int Najdi(T hladane)
        {
            int result = Dopredu(hladane);
            if(result == -1) { result = Dozadu(hladane); }
            return result;
        }
    }
}
