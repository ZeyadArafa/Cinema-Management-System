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
    public partial class Relation : Form
    {
        public Relation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConcessionsPayment concessionsPayment = new ConcessionsPayment();
            concessionsPayment.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerConcession customerConcession = new CustomerConcession();
            customerConcession.Show();
        }
    }
}
