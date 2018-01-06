using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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


            using (WebClient wc = new WebClient())
            {
                try { 
                var json = wc.DownloadString("https://api.themoviedb.org/3/movie/popular?api_key=0e0a1e5f7cbfcba8a2a28c3b1406eebf&language=en-US&page=1");

                dynamic pole = JsonConvert.DeserializeObject(json);

                foreach (var film in pole.results)
                {
                    Film F = new Film();
                    F.meno = film.title;
                    F.popis = film.overview;
                    filmy.Add(F);
                }
                }
                catch(WebException)
                {
                    return null;
                }

            }
                return filmy;
        }
    }
}
