using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uzivatelia;
using Lib_DbOperacie;

namespace WF_Bezny
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
            try
            {
                while (o.mamFilm(f.Id, info.Id))
                {
                    pocitadlo++;
                    f = o.nacitajFilm(pocitadlo);
                }
            }
            catch (NullReferenceException)
            {
                meno.Text = "V DB nie sú žiadne filmy";
                popis.Hide();
                obrazok.Hide();
                dalsi.Hide();
                pridaj.Hide();
            }

            if (f != null)
            {
                meno.Text = f.meno;
                popis.Text = f.popis;
                MemoryStream ms = new MemoryStream(f.obrazok);
                obrazok.Image = Image.FromStream(ms);
            }
            else
            {
                meno.Text = "V DB nie sú žiadne filmy";
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

        private void pridaj_Click(object sender, EventArgs e)
        {
            f = o.nacitajFilm(pocitadlo);
            int idFilm = f.Id;
            int idUzivatel = info.Id;

            if (o.pridajPar(idUzivatel, idFilm))
            {
                MessageBox.Show("Takýto film už v DB máš");
            }
            else
            {
                MessageBox.Show("Film bol pridaný do DB");
            }
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
    }
}
