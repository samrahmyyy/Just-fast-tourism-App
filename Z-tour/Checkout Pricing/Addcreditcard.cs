using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_tour.Checkout_Pricing
{
    public partial class Addcreditcard : Form
    {
        public Addcreditcard()
        {
            InitializeComponent();
        }

        private void Addcreditcard_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (confirmcheckbox.Checked)
            {
                MessageBox.Show("Your Credit Added Sucessfully", "Confirmation Process", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show ("Please , Confirm if U checked a box" , "Wrong Confirmation" , MessageBoxButtons.RetryCancel , MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
