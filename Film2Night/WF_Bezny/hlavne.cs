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

namespace WF_Bezny
{
    public partial class hlavne : Form
    {
        UzivateliaInfo bezny = new Bezny();
        public hlavne(UzivateliaInfo info)
        {
            InitializeComponent();
            this.bezny = info;
        }

        private void hlavne_Load(object sender, EventArgs e)
        {
            meno.Text = bezny.menoPriezvisko;
        }

        private void pridaj_Click(object sender, EventArgs e)
        {
            UzivatelPridajcs pridaj = new UzivatelPridajcs(bezny);
            pridaj.Show();
        }

        private void moje_Click(object sender, EventArgs e)
        {
            MojeFilmy mf = new MojeFilmy(bezny);
            mf.Show();
        }
    }
}
