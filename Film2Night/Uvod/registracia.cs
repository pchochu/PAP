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
using Lib_DbOperacie;

namespace Uvod
{
    public partial class registracia : Form
    {
        UzivateliaInfo info = new UzivateliaInfo();
        Operacie op = new Operacie();
        public registracia()
        {
            InitializeComponent();
        }

        private void TlacitkoRegistracia_Click(object sender, EventArgs e)
        {
            if (KontrolaUdajov())
            {
                MessageBox.Show("Prosim vypln vsetko");
            }
            else if (KontrolaHesiel())
            {
                MessageBox.Show("Hesla sa nezhoduju");
            }
            else
            {

                UzivateliaInfo informacie = vyplnInfo();

                if (informacie.zaregistruj())
                {
                    MessageBox.Show("Bol si zaregistrovany");
                    zobrazLi();
                }
                else
                {
                    MessageBox.Show("Uzivatel s takymto menom uz existuje");
                }

            }

            Clear();
        }

        private void Clear()
        {
            userMeno.Text = "";
            menoPriezvisko.Text = "";
            heslo.Text = "";
            heslo2.Text = "";
        }

        private bool KontrolaUdajov()
        {
            return userMeno.Text == "" || heslo.Text == "" || menoPriezvisko.Text == "" ? true : false;
        }

        private bool KontrolaHesiel()
        {
            return heslo.Text != heslo2.Text ? true : false;
        }

        private UzivateliaInfo vyplnInfo()
        {
            info.heslo = heslo.Text.Trim();
            info.userMeno = userMeno.Text.Trim();
            info.menoPriezvisko = menoPriezvisko.Text.Trim();
            return info;
        }

        private void zobrazLi()
        {
            logIn li = new logIn();
            this.Hide();
            li.Show();
        }
    }
}
