using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z_tour.Forms;

namespace Z_tour
{
    public partial class Main_Application : Form
    {
        
        public Main_Application()
        {
            InitializeComponent();
        }
        private Form activeForm;

       

        // class to open form in middle of main application.
        private void OpenchildForm(Form childform, object btSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.PanelMainapplicationcenter.Controls.Add(childform);
            this.PanelMainapplicationcenter.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        
        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Menuswitcher.Height =Dashboard.Height;
            Menuswitcher.Top = Dashboard.Top;
            OpenchildForm(new Forms.Dashboard_Form() , sender);
             /*Sorry :[
            MessageBox.Show("You Earned 10K Dollars");
             */
        }

        private void Myticket_Click(object sender, EventArgs e)
        {
            
            Menuswitcher.Height = Booking.Height;
            Menuswitcher.Top = Booking.Top;
            OpenchildForm(new Forms.Booking_Form(), sender);
        }

        private void Favourite_Click(object sender, EventArgs e)
        {
           
           
        }

        private void Message_Click(object sender, EventArgs e)
        {
            Menuswitcher.Height = Notifcation.Height;
            Menuswitcher.Top = Notifcation.Top;
            OpenchildForm(new Forms.Notifcation_Form(), sender);
        }

        private void Transcation_Click(object sender, EventArgs e)
        {
            Menuswitcher.Height = Orders.Height;
            Menuswitcher.Top = Orders.Top;
            OpenchildForm(new Forms.Orders_Form(), sender);
        }
        bool darkmode = false;


        private void Settings_Click(object sender, EventArgs e)
        {

            Menuswitcher.Height = Dark_mode.Height;
            Menuswitcher.Top = Dark_mode.Top;
            OpenchildForm(new Forms.Settings_Form(), sender);
            // To Switch betwwen Dark mode & Normal mode.
            darkmode = !darkmode;
            if (darkmode == true)
            {
                //// Change Background Color.
                this.BackColor = Color.DarkGray;
                menu.BackColor = Color.DarkGray;
                profilesection.BackColor = Color.DarkGray;
                PanelMainapplicationcenter.BackColor = Color.DarkGray;
            
               
            }
            else
            {
                this.BackColor = Color.Teal;
                menu.BackColor = Color.Teal;
                profilesection.BackColor = Color.Teal;
                PanelMainapplicationcenter.BackColor = Color.Teal;
            }
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            //Beside Highlighter.
            Menuswitcher.Height = Logout.Height;
            Menuswitcher.Top = Logout.Top;
            // To Log Out
            DialogResult = MessageBox.Show("Are U Sure wanna to log out", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void exitapplication_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are You Sure You Wish To Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void PanelMainapplicationcenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are You Sure You Wish To Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
