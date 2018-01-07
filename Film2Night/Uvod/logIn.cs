
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
        UzivateliaInfo admin = new UzivateliaInfo();
        UzivateliaInfo bezny = new Bezny();
        public logIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UzivateliaInfo informacie = vyplnInfo();
            DataTable dt = informacie.logIn();

            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][4].ToString().Equals("A"))
                {
                    
                    admin = vyplnUzivatela(dt);
                    otvorAdmin(admin);
                }
                else
                {
                    bezny = vyplnBezneho(dt);
                    otvorBezne(bezny);
                }

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

        public UzivateliaInfo vyplnBezneho(DataTable dt)
        {
            UzivateliaInfo vyplneny = new Bezny();
            vyplneny.menoPriezvisko = dt.Rows[0][3].ToString();
            vyplneny.typ = dt.Rows[0][4].ToString();
            vyplneny.userMeno = dt.Rows[0][1].ToString();
            vyplneny.Id = int.Parse(dt.Rows[0][0].ToString());
            return vyplneny;
        }


        public void otvorAdmin(UzivateliaInfo admin)
        {
            hlavneA hlA = new hlavneA(admin);
            this.Hide();
            hlA.Show();
        }

        public void otvorBezne(UzivateliaInfo bezny)
        {
            hlavne hl = new hlavne(bezny);
            this.Hide();
            hl.Show();
        }
    }
}
