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
using Z_tour.Trips;

namespace Z_tour.Forms
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void label24_Click(object sender, EventArgs e)
        {
            LondonReview londonReview = new LondonReview();
            londonReview.Show();

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label35_Click(object sender, EventArgs e)
        {
            Dubai_Review1 dubai_Review1 = new Dubai_Review1();
            dubai_Review1.Show();

        }

        private void label31_Click(object sender, EventArgs e)
        {
            parisreview parisreview= new parisreview();
            parisreview.Show();
        }

        private void Guna2Button9_Click(object sender, EventArgs e)
        {
             this.BackColor = Color.Gray;
            panel1.BackColor = Color.Gray;
            
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Favourite_Form favourite_Form = new Favourite_Form();
            favourite_Form.Show();
        }
    }
}
