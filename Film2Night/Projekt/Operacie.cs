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
                     AttachDbFilename=C:\Users\JCH\source\repos\Film2Night\Databaza\DB.mdf;
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

        private void pridajFilmDoDB(SqlConnection sqlconn, Film film)
        {
            SqlCommand pridaj = new SqlCommand("PridajFilm", sqlconn);
            pridaj.CommandType = CommandType.StoredProcedure;
            pridaj.Parameters.AddWithValue("@meno", film.meno);
            pridaj.Parameters.AddWithValue("@popis", film.popis);
            pridaj.Parameters.AddWithValue("@Obrazok", film.obrazok);
            pridaj.ExecuteNonQuery();
        }

    }

}
