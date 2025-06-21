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
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
        }

        private void checkout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'checkoutDataSet.checkout' table. You can move, or remove it, as needed.
            this.checkoutTableAdapter.Fill(this.checkoutDataSet.checkout);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Addcreditcard addcreditcard = new Addcreditcard();
            addcreditcard.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                String p = Packagenametxt.Text;
                string ci = checkindatetxt.Text;
                string co = checkoutdatetxt.Text;
                string i = indvidualtxt.Text;
                string d = destinationtxt.Text;
                int r = Convert.ToInt16(roomstxt.Text);
                this.checkoutTableAdapter.Insertcheckout(p, ci, co, i, d, r);
                MessageBox.Show("Added Sucessfully", "Checkout Sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Validate();
                this.checkoutBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You entered a wrong format , please Try Again" , "Error" , MessageBoxButtons.RetryCancel , MessageBoxIcon.Error);
            }



        }

        private void checkoutBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.checkoutBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.checkoutDataSet);

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
