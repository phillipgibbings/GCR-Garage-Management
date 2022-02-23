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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            //Loads user login form to force user login
            Frm_Login frm = new Frm_Login();
            frm.ShowDialog();

            //Shows current logged in user on Main form
            lblLoggedUser.Text = Frm_Login.LoggedInUser.ToString();

            //Check Database connection status and shows if open/closed

            string ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Open)
                {
                    lblConStatus.Text = "Server Connection Open";
                }
                else if(con.State == ConnectionState.Closed)
                {
                    lblConStatus.Text = "Server Connection Closed";
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
    }
}
