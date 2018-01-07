using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class ZobrazUzivatelov : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                                            AttachDbFilename=C:\Users\Peto\Documents\GitHub\PAP\Film2Night\Databaza\DB.mdf;
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
        }
    }
}
