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
    public partial class frm_Login : Form
    {
        SqlConnection con = new SqlConnection();
        public static string LoggedInUser = "";

        public frm_Login()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True";

            InitializeComponent();

        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True";
                string Username = txtUsername.Text;
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand checkUser = new SqlCommand(@"SELECT HashedPassword from Users where Username = @Username", con);
                checkUser.Parameters.Add(new SqlParameter("@Username", Username));
                var hashedPassword = (string)checkUser.ExecuteScalar();
;
                if (BCrypt.Net.BCrypt.Verify(txtPassword.Text, hashedPassword) == true)
                {
                    //string MBmessage = "You have logged in successfully";
                    //string MBcaption = "Authentication Successful";
                    //MessageBox.Show(MBmessage, MBcaption);
                    LoggedInUser = Username;
                    con.Close();
                    this.Close();
                }
                else
                {
                    string MBmessage = "Incorrect Username and or Password";
                    string MBcaption = "Authentication Failed";
                    MessageBox.Show(MBmessage, MBcaption);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}