using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KolekciePreXML
{
    [Serializable]
    public class Lecture:IEquatable<Lecture>, ISerializable
    {
        private DateTime start;

        private string classRoom;

        public string ClassRoom
        { get { return classRoom; } }

        public Lecture(DateTime when, string where)
        {
            start = when;
            classRoom = where;
        }

        public override string ToString()
        {
            return String.Format("lecture {0} at {1}", start.DayOfWeek.ToString(), start.Hour.ToString());
        }
        public bool Equals(Lecture other)
        {
            return ((this.start.DayOfWeek == other.start.DayOfWeek) &
                (this.start.Hour == other.start.Hour)) &
                (this.classRoom == other.ClassRoom);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //serializacia
            info.AddValue("start", start);
            info.AddValue("cRoom", classRoom);
        }

        public Lecture(SerializationInfo info, StreamingContext context)
        {
            //deserialization
            classRoom = info.GetString("cRoom");
            start = info.GetDateTime("start");
        }
    }
}
