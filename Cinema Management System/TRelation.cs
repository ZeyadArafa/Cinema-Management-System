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
    public partial class TRelation : Form
    {
        public TRelation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket_Seat ticket_Seat = new Ticket_Seat();
            ticket_Seat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ticket_Payment ticket_Payment = new Ticket_Payment();   
            ticket_Payment.Show();
        }
    }
}
