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
        UzivateliaInfo info = new UzivateliaInfo();
        Film f = new Film();
        int pocitadlo = 1;
        Operacie o = new Operacie();
       
        public UzivatelPridajcs(UzivateliaInfo info)
        {
            InitializeComponent();
            this.info = info;
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
            if (f != null)
            {
                meno.Text = f.meno;
                popis.Text = f.popis;
                MemoryStream ms = new MemoryStream(f.obrazok);
                obrazok.Image = Image.FromStream(ms);
            }
            else
            {
                meno.Text = "Už nie sú ďalšie filmy";
                popis.Hide();
                obrazok.Hide();
                dalsi.Hide();
                pridaj.Hide();

            }
        }

        private void ukonci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
