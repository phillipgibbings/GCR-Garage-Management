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
    public partial class Frm_UpdateUser : Form
    {
        public Frm_UpdateUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_UpdateUser_Load(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword2.Text == txtPassword1.Text)
            {
                lblPasswordMatch.Text = "[ Password Matches ]";
                lblPasswordMatch.ForeColor = Color.Green;
            }
            else if (txtPassword2.Text != txtPassword1.Text)
            {
                lblPasswordMatch.Text = "[ Password does not match! ]";
                lblPasswordMatch.ForeColor = Color.Red;
            }
        }

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword1.Text == txtPassword2.Text)
            {
                lblPasswordMatch.Text = "[ Password Matches ]";
                lblPasswordMatch.ForeColor = Color.Green;
            }
            else if (txtPassword1.Text != txtPassword2.Text)
            {
                lblPasswordMatch.Text = "[ Password does not match! ]";
                lblPasswordMatch.ForeColor = Color.Red;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True";
            string Username = cbUsername.Text;

            SqlConnection con = new SqlConnection(ConnectionString);

            bool MessageboxValidation = true;

            string Password = txtPassword2.Text;

            try
            {

                if (MessageBox.Show("Passwordchange cannot be undone!\n\nAre you sure you want to update it?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageboxValidation ? MessageBoxDefaultButton.Button2 : MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();

                        string passwordToHash = Password;
                        string passwordSalt = BCrypt.Net.BCrypt.GenerateSalt((16));
                        string hashToStoreInDatabase = BCrypt.Net.BCrypt.HashPassword(passwordToHash, passwordSalt);

                        SqlCommand userUpdate = new SqlCommand(@"UPDATE Users set HashedPassword ='" + hashToStoreInDatabase +"', PasswordSalt ='"+ passwordSalt + "' WHERE Username=@Username", con);
                        userUpdate.Parameters.AddWithValue("@Username", Username);
                        userUpdate.ExecuteNonQuery();
                        MessageBox.Show("Password for " + cbUsername.Text + " Updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                else
                {
                    MessageBox.Show("Password not updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
