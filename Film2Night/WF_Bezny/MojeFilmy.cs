using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uzivatelia;
using Lib_DbOperacie;
using System.IO;

namespace WF_Bezny
{
    public partial class MojeFilmy : Form
    {
        Operacie o = new Operacie();
        UzivateliaInfo info = new UzivateliaInfo();
        int pocitadlo = 0;
        int i = 0;
        public MojeFilmy(UzivateliaInfo info)
        {
            InitializeComponent();
            this.info = info;
        }

        private void MojeFilmy_Load(object sender, EventArgs e)
        {
            zobraz(info, 0, i);
        }

        private void Koniec_Click(object sender, EventArgs e)
        {
            hlavne h = new hlavne(info);
            this.Close();
        }

        private void Videl_Click(object sender, EventArgs e)
        {
            Film f = new Film();
            f = o.nacitajMojFilm(info, pocitadlo, 0);
            o.videl(info.Id, f.Id);
            MessageBox.Show("Film bol nastavený na už videný");
        }

        private void Dalsi_Click(object sender, EventArgs e)
        {
            pocitadlo++;
            zobraz(info, pocitadlo, i);
        }

        private void zobraz(UzivateliaInfo info, int pocitadlo, int i)
        {
            Film f = new Film();
            f = o.nacitajMojFilm(info, pocitadlo, i);
            if (f == null)
            {
                popis.Text = "V DB už nemáš ďalšie filmy";
                meno.Hide();
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

        private void nevidenéFilmyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Videl.Show();
            i = 0;
            pocitadlo = 0;
            zobraz(info, pocitadlo, i);
        }

        private void videnéFilmyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Videl.Hide();
            Dalsi.Show();
            meno.Show();
            popis.Show();
            pictureBox1.Show();
            i = 1;
            pocitadlo = 0;
            zobraz(info, pocitadlo, i);
        }

        private void všetkyFilmyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Videl.Hide();
            Dalsi.Show();
            meno.Show();
            popis.Show();
            pictureBox1.Show();
            i = 2;
            pocitadlo = 0;
            zobraz(info, pocitadlo, i);
        }
    }
}
