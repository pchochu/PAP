using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{

    public partial class UzivatelPridajcs : Form
    {
        Film f = new Film();
        int pocitadlo = 1;
        Operacie o = new Operacie();
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                                            AttachDbFilename=C:\Users\Peto\Documents\GitHub\PAP\Film2Night\Databaza\DB.mdf;
                                                            Integrated Security=True; Connect Timeout=30");
        public UzivatelPridajcs()
        {
            InitializeComponent();
        }

        private void UzivatelPridajcs_Load(object sender, EventArgs e)
        {
            f = o.nacitajFilm(pocitadlo);
            
            meno.Text = f.meno;
            popis.Text = f.popis;
            MemoryStream kktina = new MemoryStream(f.obrazok);
            obrazok.Image = Image.FromStream(kktina);
        }

        private void dalsi_Click(object sender, EventArgs e)
        {
            pocitadlo++;

            f = o.nacitajFilm(pocitadlo);
            meno.Text = f.meno;
            popis.Text = f.popis;
            MemoryStream ms = new MemoryStream(f.obrazok);
            obrazok.Image = Image.FromStream(ms);
        }
    }
}
