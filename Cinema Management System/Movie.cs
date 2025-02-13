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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinema_Management_System
{
    public partial class Movie : Form
    {
        //old sql
        //SqlConnection con = new SqlConnection(@"Data Source=ZEYAD\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True;TrustServerCertificate=True");
        //
        //new sql  
        SqlConnection con = new SqlConnection(@"Data Source=ZEYAD\SQLEXPRESS;Initial Catalog=Cinema_1;Integrated Security=True;TrustServerCertificate=True");
        //
        SqlCommand cmd;
        SqlCommandBuilder scb;
        SqlDataAdapter adpt;
        DataTable dt;
        public Movie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Movie";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected in the DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the movie ID from the selected row (assuming the first column contains the movie ID)
                    int movieId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    // Open the connection
                    con.Open();

                    // SQL query to delete the movie by ID
                    string deleteQuery = "DELETE FROM Movie WHERE movie_id = @MovieId";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                    deleteCmd.Parameters.AddWithValue("@MovieId", movieId);

                    // Execute the query
                    deleteCmd.ExecuteNonQuery();

                    MessageBox.Show("Record deleted successfully.");

                    // Refresh the DataGridView
                    string refreshQuery = "SELECT * FROM Movie";
                    SqlDataAdapter da = new SqlDataAdapter(refreshQuery, con);
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Please select a movie to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        // Insert Functionality (button2_Click)
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Insert the record
                string insertQuery = "INSERT INTO Movie (title, type, duration, description, trailer_link, director_id, genera_id) " +
                                     "VALUES (@Title, @Type, @Duration, @Description, @TrailerLink, @DirectorId, @GeneraId)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                insertCmd.Parameters.AddWithValue("@Title", comboBox1.Text);
                insertCmd.Parameters.AddWithValue("@Type", comboBox2.Text);
                insertCmd.Parameters.AddWithValue("@Duration", int.Parse(textBox1.Text));
                insertCmd.Parameters.AddWithValue("@Description", textBox5.Text);
                insertCmd.Parameters.AddWithValue("@TrailerLink", textBox2.Text);
                insertCmd.Parameters.AddWithValue("@DirectorId", int.Parse(textBox3.Text));
                insertCmd.Parameters.AddWithValue("@GeneraId", int.Parse(textBox4.Text));

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.");

                // Refresh the DataGridView
                string refreshQuery = "SELECT * FROM Movie";
                SqlDataAdapter da = new SqlDataAdapter(refreshQuery, con);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }






        private void Movie_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        // Update Functionality (button3_Click)
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Open connection to database
                    con.Open();

                    // Create the update query
                    string updateQuery = "UPDATE Movie SET " +
                                         "title = @Title, " +
                                         "type = @Type, " +
                                         "duration = @Duration, " +
                                         "description = @Description, " +
                                         "trailer_link = @TrailerLink, " +
                                         "director_id = @DirectorId, " +
                                         "genera_id = @GeneraId " +
                                         "WHERE movie_id = @MovieId";

                    // Create SqlCommand with parameters
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);

                    // Add parameters for the query
                    updateCmd.Parameters.AddWithValue("@MovieId", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)); // Movie ID from selected row
                    updateCmd.Parameters.AddWithValue("@Title", comboBox1.Text); // New title
                    updateCmd.Parameters.AddWithValue("@Type", comboBox2.Text); // New type
                    updateCmd.Parameters.AddWithValue("@Duration", int.Parse(textBox1.Text)); // New duration (from textbox)
                    updateCmd.Parameters.AddWithValue("@Description", textBox5.Text); // New description (from textbox)
                    updateCmd.Parameters.AddWithValue("@TrailerLink", textBox2.Text); // New trailer link (from textbox)
                    updateCmd.Parameters.AddWithValue("@DirectorId", int.Parse(textBox3.Text)); // New director ID (from textbox)
                    updateCmd.Parameters.AddWithValue("@GeneraId", int.Parse(textBox4.Text)); // New genera ID (from textbox)

                    // Execute the update query
                    updateCmd.ExecuteNonQuery();

                    // Display success message
                    MessageBox.Show("Record updated successfully.");

                    // Refresh DataGridView
                    RefreshGridView();
                }
                else
                {
                    MessageBox.Show("Please select a movie to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void RefreshGridView()
        {
            string query = "SELECT * FROM Movie";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
