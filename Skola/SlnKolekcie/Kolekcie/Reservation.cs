using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcie
{
    public class Reservation : IComparer<Reservation>
    {

        private string name;
        private string lastName;
        private string subName;
        private Lecture lec;

        public Reservation(string name, string lastName, string subName, Lecture lec)
        {
            this.name = name;
            this.lastName = lastName;
            this.subName = subName;
            this.lec = lec;
        }

        public override string ToString()
        {
            return String.Format("Rezervacia: Student {0} {1}, predmet {2}, lekcia {3}", name, lastName, subName, lec);
        }
        public int Compare(Reservation x, Reservation y)
        {
            return (x.name + x.lastName + x.subName).CompareTo(y.lastName + y.name + y.subName);
        }
    }
}
