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
            frm_Login frm = new frm_Login();
            frm.ShowDialog();

            //Shows current logged in user on Main form
            lblLoggedUser.Text = frm_Login.LoggedInUser.ToString();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
