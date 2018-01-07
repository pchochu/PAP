using System;
using Uzivatelia;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class hlavneA : Form
    {
        UzivateliaInfo info = new Adm();
        public hlavneA(UzivateliaInfo info)
        {
            InitializeComponent();
            this.info = info;
        }

        private void Vlastny_Click(object sender, EventArgs e)
        {
            vlastnyFilm vf = new vlastnyFilm();
            vf.Show();
        }

        private void Nove_Click(object sender, EventArgs e)
        {
            PridajZNetu pn = new PridajZNetu(info);
            pn.Show();
        }

        private void filmyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZobrazFilmy zf = new ZobrazFilmy();
            zf.Show();
        }

        private void uživateľovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZobrazUzivatelov zu = new ZobrazUzivatelov();
            zu.Show();
        }

        private void hlavneA_Load(object sender, EventArgs e)
        {
            meno.Text = info.menoPriezvisko;
        }

        private void pridaj_Click(object sender, EventArgs e)
        {
            RegistraciaAdmin ra = new RegistraciaAdmin(info);
            this.Close();
            ra.Show();
        }
    }
}
