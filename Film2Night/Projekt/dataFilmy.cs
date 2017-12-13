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
    public partial class dataFilmy : Form
    {
        public dataFilmy()
        {
            InitializeComponent();
        }

        private void dataFilmy_Load(object sender, EventArgs e)
        {
            int i = 0;
            Data d = new Data();
            List<Film> json = new List<Film>();
            json = d.napln();

            foreach (Film film in json)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(film.meno);
                item.SubItems.Add(film.popis);
                filmy.Items.Add(item);
                i++;
            }
        }
    }
}
