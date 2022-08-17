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
using System.Configuration;

namespace GCR_Garage_Management
{
    public partial class Frm_NewUser : Form
    {
        public Frm_NewUser()
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
            string ConnectionString = ConfigurationManager.ConnectionStrings["SQLEXPRESS.ConnectionString"].ConnectionString;

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand checkUser = new SqlCommand(@"SELECT Username from Users where Username = @Username", con);
            checkUser.Parameters.Add(new SqlParameter("@Username", Username));
            string UsernameExists = (string)checkUser.ExecuteScalar();

            if (Username == "")
            {
                string MBmessage = "Username cannot be blank. Please enter a username";
                string MBcaption = "Error";
                MessageBox.Show(MBmessage, MBcaption, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if(Password == "")
            {
                string MBmessage = "Password cannot be blank. Please enter a password";
                string MBcaption = "Error";
                MessageBox.Show(MBmessage, MBcaption, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else if(UsernameExists == Username)
                {
                string MBmessage = "User " + Username + " already exists \nPlease choose another Username";
                string MBcaption = "Error";
                MessageBox.Show(MBmessage, MBcaption, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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
                    string MBmessage = "Added " + Username + " into the Database as Admin User";
                    string MBcaption = "User Created";
                    MessageBox.Show(MBmessage, MBcaption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtUsername.Clear();
                    txtPassword.Clear();
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
                    //con.Open();

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
                    string MBmessage = "Added " + Username + " into the Database as a Basic User";
                    string MBcaption = "User Created";
                    MessageBox.Show(MBmessage, MBcaption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                con.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_NewUser_Load(object sender, EventArgs e)
        {

        }
    }
}