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

        private void frm_Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gCRMDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gCRMDBDataSet.Users);

            if (con.State == ConnectionState.Open)
            {
                lblSQLConnection.Text = "SQL Connection Open !";
                con.Close();
            }
            else if(con.State == ConnectionState.Closed)
            {
                lblSQLConnection.Text = "SQL Connection Closed !";
            }

        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True";
                con.Open();
                lblSQLConnection.Text = "SQL Connection Open !";

                string userid = txtUsername.Text;
                string password = txtPassword.Text;

                SqlCommand cmd = new SqlCommand("select Username,Password from Users where Username='" + txtUsername.Text
                                                                        + "'and Password='" + txtPassword.Text + "'", con);
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    const string MBmessage = "You have logged in successfully";
                    const string MBcaption = "Authentication Successful";
                    MessageBox.Show(MBmessage, MBcaption);
                    lblSQLConnection.Text = "SQL Connection Closed !";
                    LoggedInUser = userid;
                    this.Close();
            }
                else
                {
                    const string MBmessage = "Incorrect Username and or Password";
                    const string MBcaption = "Authentication Failed";
                    MessageBox.Show(MBmessage, MBcaption);
                    lblSQLConnection.Text = "SQL Connection Closed !";
            }
                con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
