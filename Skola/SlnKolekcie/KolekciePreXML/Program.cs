using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekciePreXML
{
    class Program
    {
        static void Main(string[] args)
        {
            MainSerializationTask mts = new MainSerializationTask();
            mts.SerializationDummystudent();
            mts.DeserializeDummyStudent();

            mts.SerializeDummySubject();
            mts.DeserializeDummySubject();

            mts.SerializeLecture();
            mts.DeserializeLecture();
            Console.ReadLine();
        }
    }
}
