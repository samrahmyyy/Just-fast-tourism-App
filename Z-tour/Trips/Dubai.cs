using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_tour.Content_Reviews
{
    public partial class Dubai : Form
    {
        public Dubai()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Dubai_Review1 dubai_Review1 = new Dubai_Review1();
            dubai_Review1.Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Dubai_Review2 dubai_Review2 = new Dubai_Review2();
            dubai_Review2.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
