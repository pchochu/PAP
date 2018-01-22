using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KolekciePreXML
{
    public class MainSerializationTask
    {
        public void SerializationDummystudent()
        {
            DummyStudent ds = new DummyStudent("Jan", "Novak");
            XmlSerializer mySerializer = new XmlSerializer(typeof(DummyStudent));
            StreamWriter myWriter = new StreamWriter("fileDummyStudent.xml");
            mySerializer.Serialize(myWriter, ds);
            myWriter.Close();
        }

        public void DeserializeDummyStudent()
        {
            FileStream myFileStream = new FileStream("fileDummyStudent.xml", FileMode.Open);
            XmlSerializer mySerializer = new XmlSerializer(typeof(DummyStudent));
            DummyStudent ds = (DummyStudent)mySerializer.Deserialize(myFileStream);
            Console.WriteLine(ds.Jmeno);
            myFileStream.Close();
        }

        public void SerializeDummySubject()
        {
            DummySubject dsubj = new DummySubject("PAP");
            DateTime t1 = new DateTime(2017, 11, 2, 13, 0, 0);
            DateTime t2 = new DateTime(2017, 11, 2, 14, 0, 0);
            dsubj.AddLecture(new DummyLecture(t1, "Q05"));
            dsubj.AddLecture(new DummyLecture(t2, "Q05"));

            XmlSerializer mySerializer = new XmlSerializer(typeof(DummySubject));
            StreamWriter myWriter = new StreamWriter("fileDummySubject.xml");
            mySerializer.Serialize(myWriter, dsubj);

            myWriter.Close();
        }

        public void DeserializeDummySubject()
        {
            FileStream myStream = new FileStream("fileDummySubject.xml", FileMode.Open);
            XmlSerializer mySerializer = new XmlSerializer(typeof(DummySubject));
            DummySubject ds = (DummySubject)mySerializer.Deserialize(myStream);

            Console.WriteLine(ds);
            myStream.Close();
        }

        public void SerializeLecture()
        {
            FileStream myFileStream = new FileStream("fileLecture.xml", FileMode.Create);
            IFormatter formater = new BinaryFormatter();

            DateTime t2 = new DateTime(2017, 11, 2, 14, 0, 0);
            Lecture lec = new Lecture(t2, "Q01");

            formater.Serialize(myFileStream, lec);

            myFileStream.Close();
        }

        public void DeserializeLecture()
        {
            FileStream myFileStream = new FileStream("fileLecture.xml", FileMode.Open);
            IFormatter formater = new BinaryFormatter();

            Lecture lec = (Lecture)formater.Deserialize(myFileStream);
            Console.WriteLine(lec);

            myFileStream.Close();
        }
    }
}
