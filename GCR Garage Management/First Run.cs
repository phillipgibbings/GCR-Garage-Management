using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace GCR_Garage_Management
{
    public partial class Frm_FirstRun : Form
    {
        SqlDataSourceEnumerator servers;
        System.Data.DataTable tableServers;

        public static string DBusername;
        public static string DBpassword;
        public static string DBserver;
        public static string DBname;
        public int DatabaseCount;

        public static string DBFinalConnection; //Final Connection to be saved to settings
        public static string InitialDBConnection; //Default DB connection 

        public Frm_FirstRun()
        {
            InitializeComponent();
            // Set Form/Control sizes & locations
            this.Size = new Size(492, 144);
            this.gb_InitialDBconnection.Size = new Size(450, 55);
            this.btnExit.Location = new Point(340, 74);

        }

        private void cb_DBServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Database.Enabled = true;
            cb_Database.Items.Clear();
            btn_NewDatabase.Enabled = true;
        }

        private void btn_DBInitialFind_Click(object sender, EventArgs e)
        {
            servers = SqlDataSourceEnumerator.Instance;
            tableServers = new DataTable();

            //Initial DB Find Button -- Populate found Local Servers into List
            try
            {
                tableServers = servers.GetDataSources();

                foreach (DataRow dataRow in tableServers.Rows)
                {
                    if (String.IsNullOrEmpty(dataRow["InstanceName"].ToString()))
                    {
                        cb_DBInitialList.Items.Add(dataRow["ServerName"].ToString());
                    }
                    else
                    {
                        cb_DBInitialList.Items.Add(dataRow["ServerName"] + "\\" + dataRow["InstanceName"]);
                    }
                }

                if (cb_DBInitialList.Items.Count == 0)
                {
                    MessageBox.Show("No servers found...", "Error");
                }

                else if (cb_DBInitialList.Items.Count >= 0)
                {
                    string FoundServers = cb_DBInitialList.Items.Count.ToString();
                    MessageBox.Show("Total Found = " + FoundServers, "Found Servers");
                    this.Size = new Size(492, 217);
                    cb_DBInitialList.Enabled = true;
                    cb_DBInitialList.Text = "Please Select a Server...";
                    btn_DBInitialSearch.Visible = false;
                    cb_DBInitialList.Width = 382;
                    gb_InitialDBconnection.Height = 135;
                    lbl_InitialDBusername.Visible = true;
                    txt_InitialDBUsername.Visible = true;
                    lbl_InitialDBpassword.Visible = true;
                    txt_InitialDBPassword.Visible = true;
                    cb_InitialDBShowpassword.Visible = true;
                    btn_InitialDBTestConnection.Visible = true;
                    btnExit.Location = new Point(340, 151);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_InitialDBTestConnection_Click(object sender, EventArgs e)
        {
            DBusername = txt_InitialDBUsername.Text;
            DBpassword = txt_InitialDBPassword.Text;
            DBserver = cb_DBInitialList.Text;

            string ConnectionString = @"Data Source=" + DBserver + ";User ID=" + DBusername + ";Password=" + DBpassword;

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    if (DBserver == "Please Select a Server...")
                    {
                        MessageBox.Show("Please select server", "Error");
                    }
                    else if (DBusername == "")
                    {
                        MessageBox.Show("Please enter username", "Error");
                    }
                    else if (DBpassword == "")
                    {
                        MessageBox.Show("Please enter password", "Error");
                    }
                    else
                    {
                        con.Open();

                        if (con.State == ConnectionState.Open)
                        {
                            InitialDBConnection = ConnectionString;
                            MessageBox.Show("Connection Successful", "Connection");
                            this.Size = new Size(492, 265);
                            btn_LoadDatabase.Visible = true;
                            gb_InitialDBconnection.Height = 163;
                            btn_SaveDatabaseConfig.Visible = true;
                            this.btnExit.Location = new Point(340, 185);
                        }
                        else
                        {
                            MessageBox.Show("Connection to server failed\nPlease check your settings", "Connection Error");
                        }

                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_LoadDatabase_Click(object sender, EventArgs e)
        {
            this.cb_Database.Enabled = true;
            this.btn_NewDatabase.Enabled = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(492, 375);
            this.btnExit.Location = new Point(340, 304);
            this.gb_SelectDatabase.Visible = true;

            string Connectionstring = InitialDBConnection;

            //Load Database names into Combobox
            try
            {
                using (SqlConnection con = new SqlConnection(Connectionstring))
                {
                    // Open connection
                    con.Open();

                    //Get databases names from server into a datareader 
                    string select = "select name from sys.databases;";

                    SqlCommand com = new SqlCommand(select, con);
                    SqlDataReader dr = com.ExecuteReader();

                    while (dr.Read())
                    {
                        cb_Database.Items.Add(dr[0].ToString());
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void btn_NewDatabase_Click(object sender, EventArgs e)
        {
            //Load Form to add a new Database

            Frm_CreateDatabase frm = new Frm_CreateDatabase();
            frm.ShowDialog();
        }

        public void btn_DatabaseRefresh_Click(object sender, EventArgs e)
        {
            string Connectionstring = InitialDBConnection;
            cb_Database.Items.Clear();

            try
            {
                using (SqlConnection con = new SqlConnection(Connectionstring))
                {
                    // Open connection
                    con.Open();

                    //Get databases names from server into a datareader 
                    string select = "select name from sys.databases;";

                    SqlCommand com = new SqlCommand(select, con);
                    SqlDataReader dr = com.ExecuteReader();

                    while (dr.Read())
                    {
                        cb_Database.Items.Add(dr[0].ToString());
                    }

                    con.Close();
                }

                MessageBox.Show("Database's Reloaded, Refreshed");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btn_SaveInitialConfig_Click(object sender, EventArgs e)
        {
            DBname = cb_Database.Text;

            //Set the final data source string -- Data Source=SERVERNAME; Initial Catalog=DATABASENAME; User ID=SERVERUSERNAME; Password=SERVERPASSWORD;
            string DBFinalConnection = "Data Source=" + DBserver + ";Initial Catalog=" + DBname + ";User ID=" + DBusername + ";Password=" + DBpassword;

            if (DBname == "")
            {
                MessageBox.Show("Select a server", "Error");
            }
            else
            {
                try
                {
                    // Write  the connection string to App.config
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    var connectionString = DBFinalConnection;

                    connectionStringsSection.ConnectionStrings["SQLEXPRESS.ConnectionString"].ConnectionString = DBFinalConnection;
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");
                    MessageBox.Show("Connection Updated", "Updated");

                    this.btnExit.Location = new Point(341, 414);
                    this.gb_CreateDatabaseTables.Visible = true;
                    this.gb_CreateDatabaseTables.Enabled = true;
                    this.Size = new Size(492, 480);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }  
        }

        private void btnCreateTables_Click(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["SQLEXPRESS.ConnectionString"].ConnectionString;

            //Add Tabels with columns to Database
            using (var con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    try
                    {
                        con.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }

                if (con.State == ConnectionState.Open)
                {
                    try
                    {
                        string strDBCreateUser = "CREATE TABLE Users (Username nvarchar(50) primary key, HashedPassword nvarchar(max), PasswordSalt nvarchar(50), isAdmin BIT )";
                        var cmdCreateUser = con.CreateCommand();
                        cmdCreateUser.CommandText = strDBCreateUser;
                        cmdCreateUser.ExecuteNonQuery();

                        MessageBox.Show("1 Table Added", "Successful", MessageBoxButtons.OK);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.btnExit.Location = new Point(341, 527);
                this.gb_DefaultAdmin.Visible = true;
                this.gb_DefaultAdmin.Enabled = true;
                this.Size = new Size(492, 600);
            }
        }

        private void btnDAAdd_Click(object sender, EventArgs e)
        {
            //Add the default Admin User
            string Password = txtDAPassword.Text;
            string Username = txtDAUsername.Text;
            string isAdmin = "TRUE";
            string passwordToHash = Password;
            string passwordSalt = BCrypt.Net.BCrypt.GenerateSalt((16));
            string hashToStoreInDatabase = BCrypt.Net.BCrypt.HashPassword(passwordToHash, passwordSalt);
            
            string ConnectionString = ConfigurationManager.ConnectionStrings["SQLEXPRESS.ConnectionString"].ConnectionString;
            string query = "INSERT INTO Users (Username, HashedPassword, PasswordSalt, isAdmin)" + " VALUES (@Username, @HashedPassword, @PasswordSalt, @isAdmin)";

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@HashedPassword", hashToStoreInDatabase);
                cmd.Parameters.AddWithValue("@PasswordSalt", passwordSalt);
                cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                string MBmessage = "Default admin added \nPasswords for these accounts are not recoverable!!\n\nPlease make a note and keep them in a safe location";
                string MBcaption = "Default Admin Created";
                MessageBox.Show(MBmessage, MBcaption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtDAUsername.Clear();
                txtDAPassword.Clear();
                this.btnExit.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Update App.Settings with the default  settings as definded during initial configuration
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["FirstRun"].Value = false.ToString();
            config.AppSettings.Settings["Username"].Value = DBusername;
            config.AppSettings.Settings["Password"].Value = DBpassword;
            config.AppSettings.Settings["Server"].Value = DBserver;
            config.AppSettings.Settings["Database"].Value = DBname;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("The application will now close\nPlease reload the application with the updated configuration", "Configuration Updated");
            Application.Exit();
        }

        private void cb_InitialDBShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_InitialDBShowpassword.Checked)
            {
                txt_InitialDBPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txt_InitialDBPassword.UseSystemPasswordChar = true;
            }
        }

        private void cbDAShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDAShowPassword.Checked)
            {
                txtDAPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtDAPassword.UseSystemPasswordChar = true;
            }
        }

    }

}