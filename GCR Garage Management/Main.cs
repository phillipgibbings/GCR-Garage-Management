using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NewUser frm = new frm_NewUser();
            frm.ShowDialog();
        }
    }
}
