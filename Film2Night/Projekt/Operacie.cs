using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Projekt
{
    public class Operacie
    {
        string conn = (@"Data Source=(LocalDB)\MSSQLLocalDB;
                     AttachDbFilename=C:\Users\Peto\Documents\GitHub\PAP\Film2Night\Databaza\DB.mdf;
                     Integrated Security=True; Connect Timeout=30");

        public bool zaregistruj(UzivateliaInfo info)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();
                if (kontrolujUzivatela(sqlconn, info.userMeno))
                {
                    return false;
                }
                else
                {
                    pridajUzivatela(sqlconn, info);
                    return true;                  
                }
                
            }
        }

        private bool kontrolujUzivatela(SqlConnection sqlconn, string meno)
        {
            SqlCommand kontroluj = new SqlCommand("KontrolujExistuje", sqlconn);
            kontroluj.CommandType = CommandType.StoredProcedure;
            kontroluj.Parameters.AddWithValue("@userMeno", meno);
            SqlDataReader reader = kontroluj.ExecuteReader();

            bool kontr = reader.HasRows ? true : false;
            reader.Close();
            return kontr;
        }

        private void pridajUzivatela(SqlConnection sqlconn, UzivateliaInfo info)
        {
            SqlCommand pridaj = new SqlCommand("PridajUzivatela", sqlconn);
            pridaj.CommandType = CommandType.StoredProcedure;
            pridaj.Parameters.AddWithValue("@meno", info.userMeno);
            pridaj.Parameters.AddWithValue("@heslo", info.heslo);
            pridaj.Parameters.AddWithValue("@menoPriezvisko", info.menoPriezvisko);
            pridaj.ExecuteNonQuery();
        }

        public DataTable logIn(UzivateliaInfo info)
        {
            string dotaz = "Select * from [Table] Where meno = '" + info.userMeno + "' and heslo = '" + info.heslo + "'";
            SqlDataAdapter sda = new SqlDataAdapter(dotaz, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        public bool pridajFilm(Film film)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();
                if (kontrolujFilm(sqlconn, film.meno))
                {
                    return false;
                }
                else
                {
                    pridajFilmDoDB(sqlconn, film);
                    return true;
                }
            }         
        }

        public bool pridajPar(int idUzi, int idFilm)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
                sqlconn.Open();
                if (kontrolujPar(sqlconn, idUzi, idFilm))
                {
                    return true;
                }
                else
                {
                    pridajParDoDB(sqlconn, idUzi, idFilm);
                    return false;
                }
            }
        }

        public Film nacitajFilm(int i)
        {
            try
            {
                Film f = new Film();
                string poradie = i.ToString();
                string dotaz = "Select * from Filmy where Id = '" + poradie + "'";
                SqlDataAdapter sda = new SqlDataAdapter(dotaz, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                f.meno = dt.Rows[0][1].ToString();
                f.popis = dt.Rows[0][2].ToString();
                f.obrazok = ((byte[])dt.Rows[0][3]);
                f.Id = int.Parse(dt.Rows[0][0].ToString());
                return f;
            }
            catch(IndexOutOfRangeException)
            {
                return null;
            }
        }

        public Film nacitajMojFilm(UzivateliaInfo info, int i)
        {
            try
            {
                Film f = new Film();
                string uzID = info.Id.ToString();
                string dotaz = "Select * From UzivatelFilm where Uzivatel ='" + uzID + "' and Pozrel ='0'";
                SqlDataAdapter sda = new SqlDataAdapter(dotaz, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                f.Id = int.Parse(dt.Rows[i][2].ToString());
                return nacitajFilm(f.Id);
            }
            catch (IndexOutOfRangeException)
            {
                return null; 
            }
           }

        public void videl(int uziId, int filmId)
        {
            using (SqlConnection sqlconn = new SqlConnection(conn))
            {
       
                sqlconn.Open();
                SqlCommand dotaz = new SqlCommand("UPDATE UzivatelFilm set Pozrel = 1 where Uzivatel = " + uziId.ToString() +
                    " and Film = " + filmId.ToString(), sqlconn);
                dotaz.ExecuteNonQuery();
            }
        }


        private bool kontrolujFilm(SqlConnection sqlconn, string meno)
        {
            SqlCommand kontroluj = new SqlCommand("KontrolujFilm", sqlconn);
            kontroluj.CommandType = CommandType.StoredProcedure;
            kontroluj.Parameters.AddWithValue("@Meno", meno);
            SqlDataReader reader = kontroluj.ExecuteReader();

            bool kontr = reader.HasRows ? true : false;
            reader.Close();
            return kontr;
        }

        private bool kontrolujPar(SqlConnection sqlconn, int idUzi, int idFilm)
        {
            SqlCommand kontroluj = new SqlCommand("KontrolujPar", sqlconn);
            kontroluj.CommandType = CommandType.StoredProcedure;
            kontroluj.Parameters.AddWithValue("@idUzi", idUzi);
            kontroluj.Parameters.AddWithValue("@idFilm", idFilm);
            SqlDataReader reader = kontroluj.ExecuteReader();

            bool kontr = reader.HasRows ? true : false;
            reader.Close();
            return kontr;
        }


        private void pridajFilmDoDB(SqlConnection sqlconn, Film film)
        {
            SqlCommand pridaj = new SqlCommand("PridajFilm", sqlconn);
            pridaj.CommandType = CommandType.StoredProcedure;
            pridaj.Parameters.AddWithValue("@meno", film.meno);
            pridaj.Parameters.AddWithValue("@popis", film.popis);
            pridaj.Parameters.AddWithValue("@obrazok", film.obrazok);
            pridaj.ExecuteNonQuery();
        }

        private void pridajParDoDB(SqlConnection sqlconn, int idUzi, int idFilm)
        {
            SqlCommand pridaj = new SqlCommand("NovyUzivFilm", sqlconn);
            pridaj.CommandType = CommandType.StoredProcedure;
            pridaj.Parameters.AddWithValue("@uzivatel", idUzi);
            pridaj.Parameters.AddWithValue("@film", idFilm);
            pridaj.ExecuteNonQuery();

        }

        
    }

}
