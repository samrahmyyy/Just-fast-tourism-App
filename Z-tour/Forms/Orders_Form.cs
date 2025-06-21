using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z_tour.Forms
{
    public partial class Orders_Form : Form
    {
        public Orders_Form()
        {
            InitializeComponent();
        }

        private void checkoutBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.checkoutBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.checkoutDataSet);

        }

        private void Orders_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'checkoutDataSet.checkout' table. You can move, or remove it, as needed.
            this.checkoutTableAdapter.Fill(this.checkoutDataSet.checkout);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            string s = Searchordertxt.Text;
            this.checkoutTableAdapter.Search(this.checkoutDataSet.checkout , s);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
