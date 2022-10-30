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
    public partial class Frm_CreateDatabase : Form
    {
        public Frm_CreateDatabase()
        {
            InitializeComponent();

        }

        private void btnAddDatabase_Click(object sender, EventArgs e)
        {
            string ConnectionString = Frm_FirstRun.InitialDBConnection.ToString();
            string DatabaseName = txtDatabaseName.Text;

            using (var con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    try
                    {
                        con.Open();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }

                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        var command = con.CreateCommand();
                        command.CommandText = "CREATE DATABASE " + DatabaseName;
                        command.ExecuteNonQuery();
                        MessageBox.Show(" Database created successfully", "Successful");
                        this.Close();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    con.Close();
                    this.Close();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDatabaseName_MouseClick(object sender, MouseEventArgs e)
        {
            txtDatabaseName.Text = "";
        }
    }
}
