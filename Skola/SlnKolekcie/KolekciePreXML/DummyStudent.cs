using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KolekciePreXML
{
    public class DummyStudent
    {
        private static int lastID = 0;

        [XmlElement("idcko")]

        public int ID { get; set; }

        public string Jmeno { get; set; }

        public string Prijmeni { get; set; }

        public DummyStudent(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            ID = lastID++;
        }

        public DummyStudent()
        { }
    }
}
