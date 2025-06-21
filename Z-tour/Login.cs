using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Z_tour
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=X-Tour_Users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string login = "Select * FROM tbl_suers WHERE username= '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
                cmd = new OleDbCommand(login, con);
                OleDbDataReader dr = cmd.ExecuteReader();


                if (dr.Read() == true)
                {
                    new Main_Application().Show();
                    this.Hide();
                }
               /* else
                {
                    MessageBox.Show("Invaliad Username or Password , Please Try Again", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    txtusername.Focus();
                }*/
                con.Close();
            }
            catch (Exception ex) {

                MessageBox.Show("Invaliad Username or Password , Please Try Again", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Text = "";
                txtpassword.Text = "";
                txtusername.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtusername.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void checkbxshowpas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxshowpas.Checked)
            {
                txtpassword.PasswordChar = '\0';

            }
            else
            {
                txtpassword.PasswordChar = '•';

            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitapplication_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are U Sure U Wish To Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
