using Uzivatelia;
using DbOperacie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Admin
{
    public partial class hladajObrazok : Form
    {
        string miesto = "";
        string meno;
        string popis;
        string url;

        UzivateliaInfo info = new UzivateliaInfo();
        Operacie o = new Operacie();
        public hladajObrazok(string meno, string popis, UzivateliaInfo info, string url)
        {
            InitializeComponent();
            this.meno = meno;
            this.popis = popis;
            this.info = info;
            this.url = url;
        }

        private void hladajObrazok_Load(object sender, EventArgs e)
        {
            obraz.ImageLocation = "http://image.tmdb.org/t/p/w185/" + url;
        }

        private void Pridaj_Click(object sender, EventArgs e)
        {
            Film film = vyplnInfo();

            if (o.pridajFilm(film))
            {
                MessageBox.Show("Film bol pridany");
            }
            else
            {
                MessageBox.Show("Film s takymto menom uz existuje");
            }
        }

        private void Hladaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|.*jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                miesto = dialog.FileName.ToString();
                obraz.ImageLocation = miesto;
            }
        }

        private byte[] Obrazok()
        {
            byte[] obrazok = null;

            FileStream stream = new FileStream(miesto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            obrazok = br.ReadBytes((int)stream.Length);

            return obrazok;
        }

        private Film vyplnInfo()
        {
            Film f = new Film();
            f.meno = meno;
            f.popis = popis;
            f.obrazok = Obrazok();

            return f;
        }

    }
}
