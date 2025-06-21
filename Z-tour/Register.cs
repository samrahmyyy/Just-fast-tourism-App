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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=X-Tour_Users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        internal class Show
        {
            public Show()
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" && txtpassword.Text == "" && txtcompassword.Text == "" && txtemail.Text == "")
            {
                MessageBox.Show("Username & Password field are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == txtcompassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_suers VALUES ('" + txtusername.Text + "' , '" + txtpassword.Text + "' , '" + txtemail.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtusername.Text = "";
                txtpassword.Text = "";
                txtcompassword.Text = "";
                txtemail.Text = "";

                MessageBox.Show("Your Account has been successfully created", "Registeration Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Password doesn't match , please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtcompassword.Text = "";
                txtpassword.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtcompassword.Text = "";
            txtemail.Text = "";
            txtusername.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void checkbxshowpas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxshowpas.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtcompassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
                txtcompassword.PasswordChar = '•';
            }
        }

        private void exitapplication_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are U Sure U Wish To Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
