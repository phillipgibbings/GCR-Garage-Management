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
using BCrypt.Net;

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
                string MBmessage = "Username cannot be blank. Please enter a username";
                string MBcaption = "Error";
                MessageBox.Show(MBmessage, MBcaption);
            }
            else if(Password == "")
            {
                string MBmessage = "Password cannot be blank. Please enter a password";
                string MBcaption = "Error";
                MessageBox.Show(MBmessage, MBcaption);
            }
            else if(cbAdmin.Checked == true)
            {
                string isAdmin = "TRUE";
                string query = "INSERT INTO Users (Username, HashedPassword, PasswordSalt, isAdmin)" + " VALUES (@Username, @HashedPassword, @PasswordSalt, @isAdmin)";
                string passwordToHash = Password;
                string passwordSalt = BCrypt.Net.BCrypt.GenerateSalt((16));
                string hashToStoreInDatabase = BCrypt.Net.BCrypt.HashPassword(passwordToHash, passwordSalt);

                try
                {
                    SqlConnection con = new SqlConnection
                    {
                        ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True"
                    };
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@HashedPassword", hashToStoreInDatabase);
                    cmd.Parameters.AddWithValue("@PasswordSalt", passwordSalt); 
                    cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    string MBmessage = "Admin user " + Username + " added";
                    string MBcaption = "User Created";
                    MessageBox.Show(MBmessage, MBcaption);
                    this.Close();
                }
            }
            else if(cbAdmin.Checked == false)
            {
                string isAdmin = "FALSE";
                string query = "INSERT INTO Users (Username, HashedPassword, PasswordSalt, isAdmin)" + " VALUES (@Username, @HashedPassword, @PasswordSalt, @isAdmin)";
                string passwordToHash = Password;
                string passwordSalt = BCrypt.Net.BCrypt.GenerateSalt((16));
                string hashToStoreInDatabase = BCrypt.Net.BCrypt.HashPassword(passwordToHash, passwordSalt);

                try
                {
                    SqlConnection con = new SqlConnection
                    {
                        ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True"
                    };
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@HashedPassword", hashToStoreInDatabase);
                    cmd.Parameters.AddWithValue("@PasswordSalt", passwordSalt);
                    cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    string MBmessage = "Basic user " + Username + " added";
                    string MBcaption = "User Created";
                    MessageBox.Show(MBmessage, MBcaption);
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}