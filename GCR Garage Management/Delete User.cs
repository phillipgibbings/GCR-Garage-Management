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
    public partial class Frm_DeleteUser : Form
    {
        public Frm_DeleteUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_DeleteUser_Load(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["SQLEXPRESS.ConnectionString"].ConnectionString;

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Username from Users", con)
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    cbUsername.Items.Add(ds.Tables[0].Rows[i][0].ToString());

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["SQLEXPRESS.ConnectionString"].ConnectionString;
            string Username = cbUsername.Text;

            SqlConnection con = new SqlConnection(ConnectionString);

            bool MessageboxValidation = true;

            try
            {
                //Message Box Strings User Delete Confirmation
                string MBMessage = "This cannot be undone\n\nAre you sure?";
                string MBTitle = "Confirmation!";

                if (MessageBox.Show(MBMessage, MBTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageboxValidation ? MessageBoxDefaultButton.Button2 : MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        //Message Box Strings Deleted confirmed
                        string MBMessage1 = "User" + cbUsername.Text + " Deleted!";
                        string MBTitle1 = "Confirmation";

                        con.Open();
                        SqlCommand userDelete = new SqlCommand("DELETE FROM Users WHERE Username=@Username", con);
                        userDelete.Parameters.AddWithValue("@Username", Username);
                        userDelete.ExecuteNonQuery();
                        MessageBox.Show(MBMessage1, MBTitle1, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cbUsername.Items.Clear();
                        cbUsername.Text = "";

                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select Username from Users", con);
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            cbUsername.Items.Add(ds.Tables[0].Rows[i][0].ToString());

                        con.Close();
                    }

                }
                else
                {
                    //Message Box String User not deleted
                    string MBMessage2 = "User not deleted!";
                    string MBTitle2 = "Confirmation";

                    MessageBox.Show(MBMessage2, MBTitle2, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
