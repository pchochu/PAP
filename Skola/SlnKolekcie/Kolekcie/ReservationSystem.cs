using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcie
{
    public class ReservationSystem
    {
        private SortedList<BaseInfo, Student> students;
        private Dictionary<string, Subject> subjects;
        private SortedDictionary<Reservation, Reservation> reservations;

        public ReservationSystem()
        {
            students = new SortedList<BaseInfo, Student>();
            subjects = new Dictionary<string, Subject>();
            reservations = new SortedDictionary<Reservation, Reservation>();
        }

        public bool AddSubject(string nameOfSubject)
        {
            if (subjects.ContainsKey(nameOfSubject)) return false;
            Subject newSubject = new Subject(nameOfSubject);
            subjects.Add(nameOfSubject, newSubject);
            return true;
        }

        public Subject GetSubject(string nameOfSubject)
        {
            try
            {
                return subjects[nameOfSubject];
            }
            catch (KeyNotFoundException e)
            {
                return null;
            }
        }

        public bool AddStudent(Student newStudent)
        {
            try
            {
                students.Add(newStudent.Info, newStudent);
                return true;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public void PrintStudents()
        {
            Console.WriteLine("Students in system: ");
            foreach(KeyValuePair<BaseInfo, Student> kv in students)
            {
                Console.WriteLine(kv.Value.ToString());
            }
        }

        public Student GetStudent(string name, string lastName)
        {
            BaseInfo info = new BaseInfo(name, lastName);
            return students[info];
        }

        public bool RemoveStudent(string name, string lastName)
        {
            BaseInfo info = new BaseInfo(name, lastName);
            return students.Remove(info);
        }

        public Lecture AddLectureForSubject(string nameOfSubject, DateTime when, string classRoom)
        {
            if (!subjects.ContainsKey(nameOfSubject))
            {
                Console.WriteLine("Cannot add lecture. Subject is not existing");
                return null;
            }

            Lecture lec = new Lecture(when, classRoom);

            if (subjects[nameOfSubject].ContainsLecture(lec))
            {
                Console.WriteLine("Cannot add lecture. Lecture is already existing");
                return null;
            }

            subjects[nameOfSubject].AddLecture(lec);
            return lec;
        }

        public bool CreateReservation(string name, string lastName, string subjectName, Lecture lec)
        {
            Student who = new Student(name, lastName);
            if (who == null) return false;

            Subject sub = GetSubject(subjectName);
            if (sub == null) return false;

            if (!sub.ContainsLecture(lec)) return false;

            Reservation r = new Reservation(name, lastName, subjectName, lec);
            reservations.Add(r, r);
            return true;
        }
    }
}
