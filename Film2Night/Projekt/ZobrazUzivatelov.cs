using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekt
{
    public partial class ZobrazUzivatelov : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                                            AttachDbFilename=C:\Users\JCH\source\repos\Film2Night\Databaza\DB.mdf;
                                                            Integrated Security=True; Connect Timeout=30");
        public ZobrazUzivatelov()
        {
            InitializeComponent();
        }

        private void ZobrazUzivatelov_Load(object sender, EventArgs e)
        {
            string dotaz = "Select * from [Table] Where typ = 'U'";
            SqlDataAdapter sda = new SqlDataAdapter(dotaz, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            nahladUziv.DataSource = dt;
            nahladUziv.Columns[0].Visible = false;
            nahladUziv.Columns[2].Visible = false;
            nahladUziv.Columns[4].Visible = false;
        }
    }
}
