using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cinema_Management_System
{
    public partial class Director : Form
    {
        //old sql
        //SqlConnection con = new SqlConnection(@"Data Source=ZEYAD\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True;TrustServerCertificate=True");
        //
        //new sql  
        SqlConnection con = new SqlConnection(@"Data Source=ZEYAD\SQLEXPRESS;Initial Catalog=Cinema_1;Integrated Security=True;TrustServerCertificate=True");
        //
        public Director()
        {
            InitializeComponent();
        }

        private void Director_Load(object sender, EventArgs e)
        {
            // Optional: Automatically load data on form load
        }

        // Method to load data into the DataGridView
        private void LoadData()
        {
            try
            {
                if (con.State == ConnectionState.Closed) // Ensure the connection is closed before opening
                {
                    con.Open();
                }

                string query = "SELECT first_name, last_name FROM Director";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) // Ensure the connection is closed
                {
                    con.Close();
                }
            }
        }

        // VIEW Operation (Display the database in the DataGridView)
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // INSERT Operation
        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "INSERT INTO Director (first_name, last_name) VALUES (@FirstName, @LastName)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", comboBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", comboBox2.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully!");
                LoadData(); // Refresh the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // UPDATE Operation
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to update.");
                    return;
                }

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "UPDATE Director SET first_name=@FirstName, last_name=@LastName WHERE first_name=@OldFirstName AND last_name=@OldLastName";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FirstName", comboBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", comboBox2.Text);
                cmd.Parameters.AddWithValue("@OldFirstName", dataGridView1.SelectedRows[0].Cells["first_name"].Value.ToString());
                cmd.Parameters.AddWithValue("@OldLastName", dataGridView1.SelectedRows[0].Cells["last_name"].Value.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully!");
                LoadData(); // Refresh the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // DELETE Operation
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.");
                    return;
                }

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "DELETE FROM Director WHERE first_name=@FirstName AND last_name=@LastName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", dataGridView1.SelectedRows[0].Cells["first_name"].Value.ToString());
                cmd.Parameters.AddWithValue("@LastName", dataGridView1.SelectedRows[0].Cells["last_name"].Value.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Successfully!");
                LoadData(); // Refresh the grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // SELECT Operation
        private void Select_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells["first_name"].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells["last_name"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to view details.");
            }
        }
    }

}
