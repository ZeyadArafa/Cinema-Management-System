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

namespace Cinema_Management_System
{
    public partial class Seat : Form
    {
        //old sql
        //SqlConnection con = new SqlConnection(@"Data Source=ZEYAD\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True;TrustServerCertificate=True");
        //
        //new sql  
        SqlConnection con = new SqlConnection(@"Data Source=ZEYAD\SQLEXPRESS;Initial Catalog=Cinema_1;Integrated Security=True;TrustServerCertificate=True");
        //
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public Seat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Seat";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }
    }
}
