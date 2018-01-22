using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KolekciePreXML
{
    [Serializable]
    public class DummyLecture : IEquatable<DummyLecture>
    {
        public DateTime Start { get; set; }

        [XmlElement("trida")]
        public string ClassRoom { get; set; }

        public DummyLecture(DateTime kdy, string kde)
        {
            Start = kdy;
            ClassRoom = kde;
        }

        public DummyLecture()
        { }

        public override string ToString()
        {
            return String.Format("lecture {0} at {1}h", Start.DayOfWeek.ToString(), Start.Hour.ToString());
        }

        public bool Equals(DummyLecture other)
        {
            return ((Start.DayOfWeek == other.Start.DayOfWeek) &
                (Start.Hour.Equals(other.Start.Hour)) &
                (ClassRoom.Equals(other.ClassRoom)));
        }
    }
}
