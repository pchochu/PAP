using Uzivatelia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_Data;
using Filmy;

namespace Admin
{
    public partial class PridajZNetu : Form
    {

        int i = 0;
        Data d = new Data();
        List<Film> json = new List<Film>();
        UzivateliaInfo info = new UzivateliaInfo();
        public PridajZNetu(UzivateliaInfo info)
        {
            InitializeComponent();
            this.info = info;
        }

        private void Dalsi_Click(object sender, EventArgs e)
        {
            try
            {
                json = d.napln();
                i++;
                meno.Text = json[i].meno;
                popis.Text = json[i].popis;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                popis.Hide();
                Dalsi.Hide();
                button3.Hide();
                meno.Text = "Uz nemam pre teba ďalšie filmy";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hladajObrazok ho = new hladajObrazok(json[i].meno, json[i].popis, info, json[i].url);
            ho.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PridajZNetu_Load(object sender, EventArgs e)
        {
            json = d.napln();

            meno.Text = json[i].meno;
            popis.Text = json[i].popis;
        }
    }
}
