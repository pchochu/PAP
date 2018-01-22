using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xamlSkusam
{
    public class RezervacniSystem
    {
        private SortedList<Student, Student> studentsList;
        private SortedDictionary<string, Student> studentsDic;

        public RezervacniSystem()
        {
            studentsList = new SortedList<Student, Student>();
            studentsDic = new SortedDictionary<string, Student>();
        }

        public bool AddStudentList(string name, string lastName)
        {
            Student s = new Student(name, lastName);
            if (studentsList.ContainsKey(s))
            {
                return false;
            }

            studentsList.Add(s, s);
            return true;
        }

        public bool AddStudentDic(string name, string lastName)
        {
            Student s = new Student(name, lastName);
            string str = s.LastName;
            if (studentsDic.ContainsKey(str))
            {
                return false;
            }

            studentsDic.Add(str, s);
            return true;
        }

        public void PrintStudents()
        {
            Console.WriteLine("----LIST----");
            foreach(KeyValuePair<Student, Student> sl in studentsList)
            {
                Console.WriteLine(sl.ToString());
            }

            Console.WriteLine("----DIC-----");
            foreach(KeyValuePair<string, Student> sd in studentsDic)
            {
                Console.WriteLine(sd.ToString());
            }
        }
    }
}
