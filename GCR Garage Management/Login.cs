using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GCR_Garage_Management
{
    public partial class Frm_Login : Form
    {
        public static string LoggedInUser = "";

        public Frm_Login()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            string ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand checkUser = new SqlCommand(@"SELECT Username from Users where Username = @Username", con);
            checkUser.Parameters.Add(new SqlParameter("@Username", Username));
            string UsernameExists = (string)checkUser.ExecuteScalar();

            if (UsernameExists == Username)
            {
                try
                {
                    SqlCommand verify = new SqlCommand(@"SELECT HashedPassword from Users where Username = @Username2", con);
                    verify.Parameters.Add(new SqlParameter("@Username2", Username));
                    var hashedPassword = (string)verify.ExecuteScalar();

                    if (BCrypt.Net.BCrypt.Verify(Password, hashedPassword))
                    {
                        LoggedInUser = Username;
                        con.Close();
                        this.Close();
                    }
                    else
                    {
                        string MBmessage = "Incorrect Username and or Password";
                        string MBcaption = "Authentication Failed";
                        MessageBox.Show(MBmessage, MBcaption, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string MBmessage = "User doesnt exist!";
                string MBcaption = "Authentication Failed";
                MessageBox.Show(MBmessage, MBcaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}