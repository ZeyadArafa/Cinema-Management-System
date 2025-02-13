using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Management_System
{
    public partial class Begin_Menu : Form
    {
        public Begin_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActorsDirectors actorsDirectors = new ActorsDirectors();
            actorsDirectors.Show(this);
        }

        private void Begin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MoviesGenres moviesGenres = new MoviesGenres();
            moviesGenres.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            staffManagement.Show(this);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CustomersTicket customersTicket = new CustomersTicket();
            customersTicket.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RoomsConcessions roomsConcessions = new RoomsConcessions();
            roomsConcessions.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(); 
            payment.Show(this);
        }
    }
}
