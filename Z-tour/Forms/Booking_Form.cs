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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Z_tour.Forms
{
   
    public partial class Booking_Form  : Form
    {
        public Booking_Form()
        {
            InitializeComponent();
            // To Add items to the combobox Directly.

            Travelitemscombobox.Items.Add("Sharm El Sheikh");
            Travelitemscombobox.Items.Add("Dubai");
            Travelitemscombobox.Items.Add("London");

            // Selectedindexchanged this item to select an item from combobox to open a new form.

            Travelitemscombobox.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = Travelitemscombobox.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Sharm El Sheikh":

                    Sharm sharm = new Sharm();                                               
                    sharm.Show();

                    break;

                case "London":
                    London london= new London();
                    london.Show();

                    break;

                case "Dubai":
                    Dubai dubaics = new Dubai();
                    dubaics.Show();

                    break;

                default:
                    MessageBox.Show("Unknown selection");
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            hurghada hurghada = new hurghada();
            hurghada.Show();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            G_trip g_Trip = new G_trip();
            g_Trip.Show();
           
        }
    }
}
