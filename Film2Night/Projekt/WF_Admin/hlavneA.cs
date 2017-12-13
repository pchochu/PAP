using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class hlavneA : Form
    {

        UzivateliaInfo info = new UzivateliaInfo();


        public hlavneA(UzivateliaInfo info)
        {
            InitializeComponent();
            this.info = info;
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

        private void Vlastny_Click(object sender, EventArgs e)
        {
            vlastnyFilm vf = new vlastnyFilm();
            vf.Show();
        }

        private void Nove_Click(object sender, EventArgs e)
        {
            dataFilmy df = new dataFilmy();
            df.Show();
        }

        private void filmyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZobrazFilmy zf = new ZobrazFilmy();
            zf.Show();
        }
    }
}
