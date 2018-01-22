using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xamlSkusam
{
    public class Student : IEquatable<Student>
    {
        private static int id = 0;
        private int idd;
        private string name;
        private string lastname;
        

        public string LastName
        {
            get { return lastname; }
        }

        public int Id
        {
            get { return id; }
        }

        public Student(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
            id += 1;
            idd = id;
        }


        public override string ToString()
        {
            return String.Format("{0} {1} s id: {2}", this.name, this.lastname, this.idd);
        }


        public int Compare(Student x, Student y)
        {
            return ((x.idd.ToString()).CompareTo(y.idd.ToString()));
        }

        public bool Equals(Student other)
        {
            return ((this.idd.ToString()).Equals(other.idd.ToString()));
        }
    }
}
