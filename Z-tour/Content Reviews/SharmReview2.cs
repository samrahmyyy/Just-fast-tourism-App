﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_tour.Checkout_Pricing;

namespace Z_tour.Content_Reviews
{
    public partial class Sharm_Review2 : Form
    {
        public Sharm_Review2()
        {
            InitializeComponent();
        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            checkout checkout = new checkout();
            checkout.Show(); 
            
        }
    }
}
