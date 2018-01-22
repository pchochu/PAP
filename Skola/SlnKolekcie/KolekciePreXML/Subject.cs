using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekciePreXML
{
    public class Subject
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        private List<Lecture> lectures;

        public Subject(string name)
        {
            this.name = name;
            lectures = new List<Lecture>(10);
        }

        public override string ToString()
        {
            string s = name + "\n";
            foreach (var lec in lectures)
            {
                s += "    " + lec.ToString() + "\n";
            }
            return s;
        }

        public bool ContainsLecture(Lecture lec)
        {
            return lectures.Contains(lec);
        }

        public void AddLecture(Lecture newLec)
        {
            if (!ContainsLecture(newLec))
            {
                lectures.Add(newLec);
            }
        }

        public void RemoveLecture(Lecture remLec)
        {
            lectures.Remove(remLec);
        }

        public ReadOnlyCollection<Lecture> GetLecturesForRead()
        {
            return lectures.AsReadOnly();
        }
    }
}
