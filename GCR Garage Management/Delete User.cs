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
                string ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True";

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Close();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True";
            string Username = cbUsername.Text;

            SqlConnection con = new SqlConnection(ConnectionString);

            bool MessageboxValidation = true;

            try
            {

                if (MessageBox.Show("This cannot be undone\n\nAre you sure?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageboxValidation ? MessageBoxDefaultButton.Button2 : MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand userDelete = new SqlCommand("DELETE FROM Users WHERE Username=@Username", con);
                        userDelete.Parameters.AddWithValue("@Username", Username);
                        userDelete.ExecuteNonQuery();
                        MessageBox.Show("User " + cbUsername.Text + " Deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    MessageBox.Show("User not deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
