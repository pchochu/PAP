using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Projekt
{
    public class Data 
    {
        public List<Film> napln()
        {
            List<Film> filmy = new List<Film>();

            using (StreamReader r = new StreamReader(@"C:\Users\JCH\Desktop\zaloha.txt"))
            {
                string json = r.ReadToEnd();
                dynamic pole = JsonConvert.DeserializeObject(json);
                foreach (var film in pole)
                {
                    Film f = new Film();
                    f.meno = film.title;
                    f.popis = film.storyline;
                    filmy.Add(f);
                }
            }
                return filmy;
        }
    }
}
