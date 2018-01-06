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

        private void PridajZNetu_Load(object sender, EventArgs e)
        {
            json = d.napln();

            meno.Text = json[i].meno;
            popis.Text = json[i].popis;
        }

        private void Dalsi_Click(object sender, EventArgs e)
        {
            json = d.napln();
            i++;
            meno.Text = json[i].meno;
            popis.Text = json[i].popis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hlavneA h = new hlavneA(info);
            h.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hladajObrazok ho = new hladajObrazok(json[i].meno, json[i].popis, info);
            ho.Show();
        }
    }
}
