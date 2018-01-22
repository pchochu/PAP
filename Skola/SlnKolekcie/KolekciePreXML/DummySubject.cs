using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KolekciePreXML
{
    [Serializable]
    [XmlRoot("Predmet")]
    public class DummySubject
    {
        public string Jmeno;

        [XmlArray("Subjects"), XmlArrayItem(typeof(DummyLecture), ElementName = "hodina")]
        public List<DummyLecture> Lectures;

        public DummySubject()
        { }

        public DummySubject(string name)
        {
            Jmeno = name;
            Lectures = new List<DummyLecture>(100);
        }

        public override string ToString()
        {
            string s = Jmeno + "\n";
            foreach (var lec in Lectures)
            {
                s += "    " + lec.ToString() + "\n";
            }
            return s;
        }

        public bool ContainsLecture(DummyLecture lec)
        {
            return Lectures.Contains(lec);
        }

        public void AddLecture(DummyLecture newLecture)
        {
            if (!ContainsLecture(newLecture))
            {
                Lectures.Add(newLecture);
            }
        }

        public void RemoveLecture(DummyLecture lecToDelete)
        {
            Lectures.Remove(lecToDelete);
        }

        public ReadOnlyCollection<DummyLecture> GetLecturesForRead()
        {
            return Lectures.AsReadOnly();
        }

    }
}
