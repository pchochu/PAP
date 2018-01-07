
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
using WF_Bezny;
using Admin;
using Lib_DbOperacie;

namespace Uvod
{
    public partial class logIn : Form
    {
        UzivateliaInfo info = new UzivateliaInfo();
        Operacie op = new Operacie();
        public logIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UzivateliaInfo informacie = vyplnInfo();
            DataTable dt = op.logIn(informacie);

            if (dt.Rows.Count == 1)
            {

                UzivateliaInfo prihlaseny = vyplnUzivatela(dt);

                prihlas(prihlaseny);

            }
            else
            {
                MessageBox.Show("Invalidne prihlasovacie udaje");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registracia rg = new registracia();
            this.Hide();
            rg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public UzivateliaInfo vyplnInfo()
        {
            UzivateliaInfo vypln = new UzivateliaInfo();
            vypln.userMeno = textBox2.Text.Trim();
            vypln.heslo = textBox1.Text.Trim();
            return vypln;
        }

        public UzivateliaInfo vyplnUzivatela(DataTable dt)
        {
            UzivateliaInfo vyplneny = new UzivateliaInfo();
            vyplneny.menoPriezvisko = dt.Rows[0][3].ToString();
            vyplneny.typ = dt.Rows[0][4].ToString();
            vyplneny.userMeno = dt.Rows[0][1].ToString();
            vyplneny.Id = int.Parse(dt.Rows[0][0].ToString());
            return vyplneny;
        }

        public void prihlas(UzivateliaInfo prihlaseny)
        {
            if (prihlaseny.typ.Equals("A"))
            {
                otvorAdmin(prihlaseny);
            }
            else
            {
                otvorBezne(prihlaseny);
            }
        }

        public void otvorAdmin(UzivateliaInfo informacie)
        {
            hlavneA hlA = new hlavneA(informacie);
            this.Hide();
            hlA.Show();
        }

        public void otvorBezne(UzivateliaInfo informacie)
        {
            hlavne hl = new hlavne(informacie);
            this.Hide();
            hl.Show();
        }
    }
}
