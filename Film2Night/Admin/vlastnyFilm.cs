using Uzivatelia;
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
using Lib_DbOperacie;

namespace Admin
{
    public partial class vlastnyFilm : Form
    {
        string miesto = "";
        Operacie op = new Operacie();
        public vlastnyFilm()
        {
            InitializeComponent();
        }

        private void HladajObrazok_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|.*jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                miesto = dialog.FileName.ToString();
                obraz.ImageLocation = miesto;
            }
        }

        private void Uloz_Click(object sender, EventArgs e)
        {
            if (KontrolaUdajov())
            {
                MessageBox.Show("Prosim vypln vsetko");
            }
            else
            {
                Film film = vyplnInfo();

                if (op.pridajFilm(film))
                {
                    MessageBox.Show("Film bol pridany");
                }
                else
                {
                    MessageBox.Show("Film s takymto menom uz existuje");
                }

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

        private bool KontrolaUdajov()
        {
            return MenoFilmu.Text.Trim() == "" || PopisFilmu.Text.Trim() == "" || Obrazok() == null ? true : false;
        }

        private Film vyplnInfo()
        {
            Film film = new Film();
            film.meno = meno.Text.Trim();
            film.popis = popis.Text.Trim();
            film.obrazok = Obrazok();
            return film;
        }
    }
}
