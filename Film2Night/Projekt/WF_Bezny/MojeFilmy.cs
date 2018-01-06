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

namespace Projekt
{
    public partial class MojeFilmy : Form
    {
        Operacie o = new Operacie();
        UzivateliaInfo info = new UzivateliaInfo();
        int pocitadlo = 0;
        public MojeFilmy(UzivateliaInfo info)
        {
            InitializeComponent();
            this.info = info;

        }

        private void MojeFilmy_Load(object sender, EventArgs e)
        {
            zobraz(info, 0);
        }

        private void zobraz(UzivateliaInfo info, int pocitadlo)
        {
            Film f = new Film();
            f = o.nacitajMojFilm(info, pocitadlo);
            if (f == null)
            {
                meno.Text = "V DB už nemáš ďalšie filmy";
                popis.Hide();
                pictureBox1.Hide();
                Dalsi.Hide();
                Videl.Hide();
            }
            else
            {
                meno.Text = f.meno;
                popis.Text = f.popis;
                MemoryStream ms = new MemoryStream(f.obrazok);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void Dalsi_Click(object sender, EventArgs e)
        {
            pocitadlo++;
            zobraz(info, pocitadlo);
        }

        private void Koniec_Click(object sender, EventArgs e)
        {
            hlavne h = new hlavne(info);
            h.Show();
            this.Close();
        }

        private void Videl_Click(object sender, EventArgs e)
        {
            Film f = new Film();
            f = o.nacitajMojFilm(info, pocitadlo);
            o.videl(info.Id, f.Id);
        }
    }
}
