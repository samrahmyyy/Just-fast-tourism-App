using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_tour.Checkout_Pricing;

namespace Z_tour.Trips
{
    public partial class hurghada : Form
    {
        public hurghada()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            checkout checkout = new checkout(); 
            checkout.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
