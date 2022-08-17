using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

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
            string ConnectionString = ConfigurationManager.ConnectionStrings["SQLEXPRESS.ConnectionString"].ConnectionString;
            string Username = cbUsername.Text;

            SqlConnection con = new SqlConnection(ConnectionString);

            bool MessageboxValidation = true;

            string Password = txtPassword2.Text;

            try
            {
                //Message box strings Password Confirmation
                string MBMessage = "A password change cannot be undone!\n\nAre you sure you want to update it?";
                string MBTitle = "Confirmation";

                if (MessageBox.Show(MBMessage, MBTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageboxValidation ? MessageBoxDefaultButton.Button2 : MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();

                        string passwordToHash = Password;
                        string passwordSalt = BCrypt.Net.BCrypt.GenerateSalt((16));
                        string hashToStoreInDatabase = BCrypt.Net.BCrypt.HashPassword(passwordToHash, passwordSalt);

                        string MBMessage1 = "Password for " + cbUsername.Text + " Updated!";
                        string MBTitle1 = "Confirmation";
                        
                        SqlCommand userUpdate = new SqlCommand(@"UPDATE Users set HashedPassword =@HashedPassword, PasswordSalt =@PasswordSalt WHERE Username =@Username", con);
                        userUpdate.Parameters.AddWithValue("@Username", Username);
                        userUpdate.Parameters.AddWithValue("@HashedPassword", hashToStoreInDatabase);
                        userUpdate.Parameters.AddWithValue("@PasswordSalt", passwordSalt);
                        userUpdate.ExecuteNonQuery();

                        MessageBox.Show(MBMessage1, MBTitle1, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cbUsername.Text = "";
                        con.Close();
                    }

                }
                else
                {
                    //Message box Strings Password Not Updated
                    string MBMessage2 = "Password not updated!";
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
