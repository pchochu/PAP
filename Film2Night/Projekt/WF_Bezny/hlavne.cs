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
    public partial class hlavne : Form
    {
        UzivateliaInfo info = new UzivateliaInfo();
        public hlavne(UzivateliaInfo info)
        {
            InitializeComponent();
            this.info = info;
        }

        private void hlavne_Load(object sender, EventArgs e)
        {
            meno.Text = info.menoPriezvisko;
        }

        private void pridaj_Click(object sender, EventArgs e)
        {
            UzivatelPridajcs pridaj = new UzivatelPridajcs(info);
            pridaj.Show();
        }
    }
}
