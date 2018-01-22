using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcie
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject s1 = new Subject("PAP");
            DateTime t1 = new DateTime(2017, 11, 2, 13, 0, 0);
            DateTime t2 = new DateTime(2017, 10, 2, 15, 0, 0);
            s1.AddLecture(new Lecture(t1, "Q05"));
            s1.AddLecture(new Lecture(t2, "Q05"));
            Console.WriteLine(s1.ToString());


            ReservationSystem rst = new ReservationSystem();
            rst.AddStudent(new Student("Jan", "Novak"));
            rst.AddStudent(new Student("Peter", "Pan"));
            rst.AddStudent(new Student("Jan", "Novak"));

            rst.PrintStudents();

            Console.ReadLine();
        }
    }
}
