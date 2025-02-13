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
    public partial class RoomsConcessions : Form
    {
        public RoomsConcessions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Concession concession = new Concession();
            concession.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seat seat = new Seat();
            seat.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Relation relation = new Relation();
            relation.Show();
        }
    }
}
