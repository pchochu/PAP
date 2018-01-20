using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class NameChecker
    {
        private List<string> listOfNames;
        private static NameChecker myinstance;

        public static NameChecker GetInstance()
        {
            return myinstance = myinstance ?? new NameChecker();
        }

        private NameChecker()
        {
            listOfNames = new List<string>();
        }

        public void AddName(string newname)
        {
            foreach (string s in listOfNames)
            {
                if (s.Equals(newname))
                {
                    return;
                }
            }
            listOfNames.Add(newname);
        }

        public void PrintAll()
        {
            foreach (string s in listOfNames)
            {
                Console.WriteLine(s);
            }
        }
    }
}
