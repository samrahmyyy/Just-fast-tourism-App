using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_tour.Content_Reviews;

namespace Z_tour.Forms
{
    public partial class London : Form
    {
        public London()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LondonReview londonReview = new LondonReview();
            londonReview.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
