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

namespace Cinema_Management_System
{
    public partial class ActorsDirectors : Form
    {
        public ActorsDirectors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actors actors = new Actors();
            actors.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            director.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();    
            manager.Show();
        }
    }
}
