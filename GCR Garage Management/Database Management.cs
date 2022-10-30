using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GCR_Garage_Management
{
    public partial class frm_DatabaseManagement : Form
    {
        public frm_DatabaseManagement()
        {
            InitializeComponent();
        }

        private void Database_Management_Load(object sender, EventArgs e)
        {
            tbUsername.Text = ConfigurationManager.AppSettings["Username"].ToString();
            tbServer.Text = ConfigurationManager.AppSettings["Server"].ToString();
            tbDatabase.Text = ConfigurationManager.AppSettings["Database"].ToString();
            tbBackupLocation.Text = ConfigurationManager.AppSettings["BackupFolder"].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            // read connectionstring from config file
            var connectionString = ConfigurationManager.ConnectionStrings["SQLEXPRESS.ConnectionString"].ConnectionString;

            // read backup folder from config file Default = ("C:/temp/")
            var backupFolder = ConfigurationManager.AppSettings["BackupFolder"];

            var sqlConStrBuilder = new SqlConnectionStringBuilder(connectionString);

            // set backupfilename ("C:/temp/MyDatabase-2013-12-07.bak")
            var backupFileName = String.Format("{0}{1}-{2}.bak",
                backupFolder, sqlConStrBuilder.InitialCatalog,
                DateTime.Now.ToString("[ddMMyyyy][HHmmss]"));
            try
            {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = String.Format("BACKUP DATABASE {0} TO DISK='{1}'",
                    sqlConStrBuilder.InitialCatalog, backupFileName);

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = dialog.SelectedPath;
                tbBackupLocation.Text = dialog.SelectedPath + @"\";
                try
                {
                    System.Security.AccessControl.DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message, folderPath, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["BackupFolder"].Value = tbBackupLocation.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Settings Updated and Saved", "Configuration Updated");
        }
    }
}
