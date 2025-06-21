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
    public partial class Sharm : Form
    {
        public Sharm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Sharm_Review sharm_Review = new Sharm_Review(); 
            sharm_Review.Show();   
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Sharm_Review2 sharm_Review2 = new Sharm_Review2();
            sharm_Review2.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
