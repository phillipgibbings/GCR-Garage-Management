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
using System.Configuration;

namespace GCR_Garage_Management
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            //New Main Check for FirstRun if true run First run form if false run Login form

            bool Firstrun = bool.Parse(ConfigurationManager.AppSettings["FirstRun"]);

            if (Firstrun == true)
            {
                Frm_FirstRun FirstRun = new Frm_FirstRun();
                FirstRun.ShowDialog();
            }
            else
            {
                Frm_Login Login = new Frm_Login();
                Login.ShowDialog();
            }

            //Loads user login form to force user login
            //Frm_Login frm = new Frm_Login(); //Login Form

            /*
                Edit to test individual forms without Logging in
                Comment out Frm_Login, Uncomment the required form to test
                Main Form will not run with Logged User as Blank
            */
            //Frm_FirstRun frm = new Frm_FirstRun(); //First Run Form
            //Frm_CreateDatabase frm = new Frm_CreateDatabase(); //Create Database Form
            //Frm_NewUser frm = new Frm_NewUser(); // Create User Form
            //Frm_DeleteUser frm = new Frm_DeleteUser(); // Delete User Form
            //Frm_UpdateUser frm = new Frm_UpdateUser(); // Update User Form

            //frm.ShowDialog();

            //Shows user logged in after Authentication
            string LoggedInUser = Frm_Login.LoggedInUser.ToString();
            lblLoggedUser.Text = LoggedInUser;

            string ConnectionString = ConfigurationManager.ConnectionStrings["SQLEXPRESS.ConnectionString"].ConnectionString;
           
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                if (LoggedInUser == "")
                {
                    string LoggedUserErrorMBMessage = "An unauthorised attempt to bypass authentication has occured\nThis applicaion will now close, Please login correctly!!";
                    string LoggedUserErrorMBTitle = "Unauthorsied Access";

                    MessageBox.Show(LoggedUserErrorMBMessage, LoggedUserErrorMBTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    //Check for Admin rights and enable/disable controls accordingly
                    try
                    {
                        con.Open();
                        SqlCommand checkUser = new SqlCommand(@"SELECT isAdmin from Users where Username = @Username", con);
                        checkUser.Parameters.Add(new SqlParameter("@Username", LoggedInUser));
                        bool isAdmin = (bool)checkUser.ExecuteScalar();
                        con.Close();

                        if (isAdmin == true)
                        {
                            tsm_Admin.Enabled = true;
                            tsm_UpdateSoftware.Enabled = true;
                            tsm_Logs.Enabled = true;

                        }
                        else
                        {
                            tsm_Admin.Enabled = false;
                            tsm_UpdateSoftware.Enabled = false;
                            tsm_Logs.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NewUser frm = new Frm_NewUser();
            frm.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DeleteUser frm = new Frm_DeleteUser();
            frm.ShowDialog();
        }

        private void modifyUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_UpdateUser frm = new Frm_UpdateUser();
                frm.ShowDialog();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_About frm = new frm_About();
            frm.ShowDialog();
        }

        private void editDatabaseSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DatabaseManagement frm = new frm_DatabaseManagement();
            frm.ShowDialog();
        }
    }
}
