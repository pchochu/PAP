using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xamlSkusam
{
    class Program
    {
        static void Main(string[] args)
        {
            RezervacniSystem r = new RezervacniSystem();
            r.AddStudentDic("Peter", "Chochula");
            r.AddStudentDic("Peter", "Honza");
            r.AddStudentDic("Jan", "Novak");
            r.AddStudentDic("Maria", "Bobulkova");

            r.AddStudentList("Peter", "Chochula");
            r.AddStudentList("Peter", "Honza");
            r.AddStudentList("Jan", "Novak");
            r.AddStudentList("Maria", "Bobulkova");

            r.PrintStudents();
            Console.ReadLine();
        }
    }
}
