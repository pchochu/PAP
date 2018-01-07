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
using Lib_DbOperacie;

namespace Admin
{
    public partial class RegistraciaAdmin : Form
    {
        UzivateliaInfo info = new Adm();
        Operacie op = new Operacie();
        public RegistraciaAdmin(UzivateliaInfo info)
        {
            InitializeComponent();
            this.info = info;
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
            hlavneA li = new hlavneA(info);
            this.Close();
            li.Show();
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

                info = vyplnInfo();

                if (info.zaregistruj())
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
    }
    }

