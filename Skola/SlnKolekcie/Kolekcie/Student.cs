using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcie
{

    public struct BaseInfo : IComparable<BaseInfo>
    {

        private string name;
        private string lastName;

        public string Name
        {
            get { return this.name; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public BaseInfo(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        public int CompareTo(BaseInfo other)
        {
            return ((this.name + this.lastName).CompareTo(other.name + other.lastName));
        }
    }
    public class Student
    {
        private BaseInfo info; 

        public BaseInfo Info
        {
            get { return this.info; }
        }

        public Student(string name, string lastname)
        {
            info = new BaseInfo(name, lastname);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", info.Name, info.LastName);
        }
    }
}
