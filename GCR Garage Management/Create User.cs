using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCR_Garage_Management
{
    public partial class frm_NewUser : Form
    {
        public frm_NewUser()
        {
            InitializeComponent();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if (Username == "")
            {
                const string MBmessage = "Username cannot be blank. Please enter a username";
                const string MBcaption = "Error";
                MessageBox.Show(MBmessage, MBcaption);
            }
            else if(Password == "")
            {
                const string MBmessage = "Password cannot be blank. Please enter a password";
                const string MBcaption = "Error";
                MessageBox.Show(MBmessage, MBcaption);
            }
            else if(cbAdmin.Checked == true)
            {
                string isAdmin = "TRUE";
                string query = "INSERT INTO Users (Username, Password, isAdmin) VALUES (@Username, @Password, @isAdmin)";

                SqlConnection con = new SqlConnection
                {
                    ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True"
                };
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
                cmd.ExecuteNonQuery(); 
            }
            else if(cbAdmin.Checked == false)
            {
                string isAdmin = "FALSE";
                string query = "INSERT INTO Users (Username, Password, isAdmin) VALUES (@Username, @Password, @isAdmin)";

                SqlConnection con = new SqlConnection
                {
                    ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True"
                };
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
                cmd.ExecuteNonQuery();
            }

            //this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}