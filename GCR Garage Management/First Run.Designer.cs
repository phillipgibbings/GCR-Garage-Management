
namespace GCR_Garage_Management
{
    partial class Frm_FirstRun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FirstRun));
            this.gb_SelectDatabase = new System.Windows.Forms.GroupBox();
            this.btn_DatabaseRefresh = new System.Windows.Forms.Button();
            this.btn_SaveDatabaseConfig = new System.Windows.Forms.Button();
            this.btn_NewDatabase = new System.Windows.Forms.Button();
            this.cb_Database = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_CreateDatabaseTables = new System.Windows.Forms.GroupBox();
            this.btnCreateTables = new System.Windows.Forms.Button();
            this.gb_DefaultAdmin = new System.Windows.Forms.GroupBox();
            this.btnDAAdd = new System.Windows.Forms.Button();
            this.cbDAShowPassword = new System.Windows.Forms.CheckBox();
            this.txtDAPassword = new System.Windows.Forms.TextBox();
            this.txtDAUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gb_InitialDBconnection = new System.Windows.Forms.GroupBox();
            this.btn_LoadDatabase = new System.Windows.Forms.Button();
            this.cb_InitialDBShowpassword = new System.Windows.Forms.CheckBox();
            this.btn_InitialDBTestConnection = new System.Windows.Forms.Button();
            this.txt_InitialDBPassword = new System.Windows.Forms.TextBox();
            this.txt_InitialDBUsername = new System.Windows.Forms.TextBox();
            this.lbl_InitialDBpassword = new System.Windows.Forms.Label();
            this.lbl_InitialDBusername = new System.Windows.Forms.Label();
            this.btn_DBInitialSearch = new System.Windows.Forms.Button();
            this.cb_DBInitialList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_SelectDatabase.SuspendLayout();
            this.gb_CreateDatabaseTables.SuspendLayout();
            this.gb_DefaultAdmin.SuspendLayout();
            this.gb_InitialDBconnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_SelectDatabase
            // 
            this.gb_SelectDatabase.Controls.Add(this.btn_DatabaseRefresh);
            this.gb_SelectDatabase.Controls.Add(this.btn_SaveDatabaseConfig);
            this.gb_SelectDatabase.Controls.Add(this.btn_NewDatabase);
            this.gb_SelectDatabase.Controls.Add(this.cb_Database);
            this.gb_SelectDatabase.Controls.Add(this.label6);
            this.gb_SelectDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_SelectDatabase.Location = new System.Drawing.Point(13, 182);
            this.gb_SelectDatabase.Name = "gb_SelectDatabase";
            this.gb_SelectDatabase.Size = new System.Drawing.Size(452, 116);
            this.gb_SelectDatabase.TabIndex = 0;
            this.gb_SelectDatabase.TabStop = false;
            this.gb_SelectDatabase.Text = "2. Select the Database";
            this.gb_SelectDatabase.Visible = false;
            // 
            // btn_DatabaseRefresh
            // 
            this.btn_DatabaseRefresh.Location = new System.Drawing.Point(170, 54);
            this.btn_DatabaseRefresh.Name = "btn_DatabaseRefresh";
            this.btn_DatabaseRefresh.Size = new System.Drawing.Size(134, 23);
            this.btn_DatabaseRefresh.TabIndex = 16;
            this.btn_DatabaseRefresh.Text = "Refresh DB List";
            this.btn_DatabaseRefresh.UseVisualStyleBackColor = true;
            this.btn_DatabaseRefresh.Click += new System.EventHandler(this.btn_DatabaseRefresh_Click);
            // 
            // btn_SaveDatabaseConfig
            // 
            this.btn_SaveDatabaseConfig.Location = new System.Drawing.Point(310, 83);
            this.btn_SaveDatabaseConfig.Name = "btn_SaveDatabaseConfig";
            this.btn_SaveDatabaseConfig.Size = new System.Drawing.Size(134, 23);
            this.btn_SaveDatabaseConfig.TabIndex = 9;
            this.btn_SaveDatabaseConfig.Text = "Save  Database Settings";
            this.btn_SaveDatabaseConfig.UseVisualStyleBackColor = true;
            this.btn_SaveDatabaseConfig.Visible = false;
            this.btn_SaveDatabaseConfig.Click += new System.EventHandler(this.btn_SaveInitialConfig_Click);
            // 
            // btn_NewDatabase
            // 
            this.btn_NewDatabase.Enabled = false;
            this.btn_NewDatabase.Location = new System.Drawing.Point(310, 54);
            this.btn_NewDatabase.Name = "btn_NewDatabase";
            this.btn_NewDatabase.Size = new System.Drawing.Size(134, 23);
            this.btn_NewDatabase.TabIndex = 15;
            this.btn_NewDatabase.Text = "Create A New Database";
            this.btn_NewDatabase.UseVisualStyleBackColor = true;
            this.btn_NewDatabase.Click += new System.EventHandler(this.btn_NewDatabase_Click);
            // 
            // cb_Database
            // 
            this.cb_Database.Enabled = false;
            this.cb_Database.FormattingEnabled = true;
            this.cb_Database.Location = new System.Drawing.Point(73, 25);
            this.cb_Database.Name = "cb_Database";
            this.cb_Database.Size = new System.Drawing.Size(371, 21);
            this.cb_Database.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Database :";
            // 
            // gb_CreateDatabaseTables
            // 
            this.gb_CreateDatabaseTables.Controls.Add(this.label1);
            this.gb_CreateDatabaseTables.Controls.Add(this.btnCreateTables);
            this.gb_CreateDatabaseTables.Enabled = false;
            this.gb_CreateDatabaseTables.Location = new System.Drawing.Point(13, 304);
            this.gb_CreateDatabaseTables.Name = "gb_CreateDatabaseTables";
            this.gb_CreateDatabaseTables.Size = new System.Drawing.Size(452, 107);
            this.gb_CreateDatabaseTables.TabIndex = 12;
            this.gb_CreateDatabaseTables.TabStop = false;
            this.gb_CreateDatabaseTables.Text = "3. Create Mandatory Tables";
            this.gb_CreateDatabaseTables.Visible = false;
            // 
            // btnCreateTables
            // 
            this.btnCreateTables.Location = new System.Drawing.Point(6, 19);
            this.btnCreateTables.Name = "btnCreateTables";
            this.btnCreateTables.Size = new System.Drawing.Size(438, 61);
            this.btnCreateTables.TabIndex = 13;
            this.btnCreateTables.Text = "Add mandatory Tables and Data";
            this.btnCreateTables.UseVisualStyleBackColor = true;
            this.btnCreateTables.Click += new System.EventHandler(this.btnCreateTables_Click);
            // 
            // gb_DefaultAdmin
            // 
            this.gb_DefaultAdmin.Controls.Add(this.btnDAAdd);
            this.gb_DefaultAdmin.Controls.Add(this.cbDAShowPassword);
            this.gb_DefaultAdmin.Controls.Add(this.txtDAPassword);
            this.gb_DefaultAdmin.Controls.Add(this.txtDAUsername);
            this.gb_DefaultAdmin.Controls.Add(this.label3);
            this.gb_DefaultAdmin.Controls.Add(this.label2);
            this.gb_DefaultAdmin.Enabled = false;
            this.gb_DefaultAdmin.Location = new System.Drawing.Point(13, 417);
            this.gb_DefaultAdmin.Name = "gb_DefaultAdmin";
            this.gb_DefaultAdmin.Size = new System.Drawing.Size(452, 104);
            this.gb_DefaultAdmin.TabIndex = 1;
            this.gb_DefaultAdmin.TabStop = false;
            this.gb_DefaultAdmin.Text = "4. Default Software Administrator";
            this.gb_DefaultAdmin.Visible = false;
            // 
            // btnDAAdd
            // 
            this.btnDAAdd.Location = new System.Drawing.Point(345, 73);
            this.btnDAAdd.Name = "btnDAAdd";
            this.btnDAAdd.Size = new System.Drawing.Size(100, 23);
            this.btnDAAdd.TabIndex = 9;
            this.btnDAAdd.Text = "Add Admin";
            this.btnDAAdd.UseVisualStyleBackColor = true;
            this.btnDAAdd.Click += new System.EventHandler(this.btnDAAdd_Click);
            // 
            // cbDAShowPassword
            // 
            this.cbDAShowPassword.AutoSize = true;
            this.cbDAShowPassword.Location = new System.Drawing.Point(236, 77);
            this.cbDAShowPassword.Name = "cbDAShowPassword";
            this.cbDAShowPassword.Size = new System.Drawing.Size(102, 17);
            this.cbDAShowPassword.TabIndex = 8;
            this.cbDAShowPassword.Text = "Show Password";
            this.cbDAShowPassword.UseVisualStyleBackColor = true;
            this.cbDAShowPassword.CheckedChanged += new System.EventHandler(this.cbDAShowPassword_CheckedChanged);
            // 
            // txtDAPassword
            // 
            this.txtDAPassword.Location = new System.Drawing.Point(74, 47);
            this.txtDAPassword.Name = "txtDAPassword";
            this.txtDAPassword.Size = new System.Drawing.Size(371, 20);
            this.txtDAPassword.TabIndex = 6;
            this.txtDAPassword.UseSystemPasswordChar = true;
            // 
            // txtDAUsername
            // 
            this.txtDAUsername.Location = new System.Drawing.Point(74, 20);
            this.txtDAUsername.Name = "txtDAUsername";
            this.txtDAUsername.Size = new System.Drawing.Size(371, 20);
            this.txtDAUsername.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username :";
            // 
            // btnExit
            // 
            this.btnExit.Enabled = false;
            this.btnExit.Location = new System.Drawing.Point(341, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Save and Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gb_InitialDBconnection
            // 
            this.gb_InitialDBconnection.Controls.Add(this.btn_LoadDatabase);
            this.gb_InitialDBconnection.Controls.Add(this.cb_InitialDBShowpassword);
            this.gb_InitialDBconnection.Controls.Add(this.btn_InitialDBTestConnection);
            this.gb_InitialDBconnection.Controls.Add(this.txt_InitialDBPassword);
            this.gb_InitialDBconnection.Controls.Add(this.txt_InitialDBUsername);
            this.gb_InitialDBconnection.Controls.Add(this.lbl_InitialDBpassword);
            this.gb_InitialDBconnection.Controls.Add(this.lbl_InitialDBusername);
            this.gb_InitialDBconnection.Controls.Add(this.btn_DBInitialSearch);
            this.gb_InitialDBconnection.Controls.Add(this.cb_DBInitialList);
            this.gb_InitialDBconnection.Controls.Add(this.label7);
            this.gb_InitialDBconnection.Location = new System.Drawing.Point(13, 13);
            this.gb_InitialDBconnection.Name = "gb_InitialDBconnection";
            this.gb_InitialDBconnection.Size = new System.Drawing.Size(452, 163);
            this.gb_InitialDBconnection.TabIndex = 13;
            this.gb_InitialDBconnection.TabStop = false;
            this.gb_InitialDBconnection.Text = "1. Initial DB connection";
            // 
            // btn_LoadDatabase
            // 
            this.btn_LoadDatabase.Location = new System.Drawing.Point(344, 132);
            this.btn_LoadDatabase.Name = "btn_LoadDatabase";
            this.btn_LoadDatabase.Size = new System.Drawing.Size(100, 23);
            this.btn_LoadDatabase.TabIndex = 9;
            this.btn_LoadDatabase.Text = "Load Database\'s";
            this.btn_LoadDatabase.UseVisualStyleBackColor = true;
            this.btn_LoadDatabase.Visible = false;
            this.btn_LoadDatabase.Click += new System.EventHandler(this.btn_LoadDatabase_Click);
            // 
            // cb_InitialDBShowpassword
            // 
            this.cb_InitialDBShowpassword.AutoSize = true;
            this.cb_InitialDBShowpassword.Location = new System.Drawing.Point(235, 107);
            this.cb_InitialDBShowpassword.Name = "cb_InitialDBShowpassword";
            this.cb_InitialDBShowpassword.Size = new System.Drawing.Size(102, 17);
            this.cb_InitialDBShowpassword.TabIndex = 8;
            this.cb_InitialDBShowpassword.Text = "Show Password";
            this.cb_InitialDBShowpassword.UseVisualStyleBackColor = true;
            this.cb_InitialDBShowpassword.Visible = false;
            this.cb_InitialDBShowpassword.CheckedChanged += new System.EventHandler(this.cb_InitialDBShowpassword_CheckedChanged);
            // 
            // btn_InitialDBTestConnection
            // 
            this.btn_InitialDBTestConnection.Location = new System.Drawing.Point(344, 103);
            this.btn_InitialDBTestConnection.Name = "btn_InitialDBTestConnection";
            this.btn_InitialDBTestConnection.Size = new System.Drawing.Size(100, 23);
            this.btn_InitialDBTestConnection.TabIndex = 7;
            this.btn_InitialDBTestConnection.Text = "Test Connection";
            this.btn_InitialDBTestConnection.UseVisualStyleBackColor = true;
            this.btn_InitialDBTestConnection.Visible = false;
            this.btn_InitialDBTestConnection.Click += new System.EventHandler(this.btn_InitialDBTestConnection_Click);
            // 
            // txt_InitialDBPassword
            // 
            this.txt_InitialDBPassword.Location = new System.Drawing.Point(79, 77);
            this.txt_InitialDBPassword.Name = "txt_InitialDBPassword";
            this.txt_InitialDBPassword.Size = new System.Drawing.Size(365, 20);
            this.txt_InitialDBPassword.TabIndex = 6;
            this.txt_InitialDBPassword.Text = "1d3m0io48Z!!";
            this.txt_InitialDBPassword.UseSystemPasswordChar = true;
            this.txt_InitialDBPassword.Visible = false;
            // 
            // txt_InitialDBUsername
            // 
            this.txt_InitialDBUsername.Location = new System.Drawing.Point(79, 51);
            this.txt_InitialDBUsername.Name = "txt_InitialDBUsername";
            this.txt_InitialDBUsername.Size = new System.Drawing.Size(365, 20);
            this.txt_InitialDBUsername.TabIndex = 5;
            this.txt_InitialDBUsername.Text = "sa";
            this.txt_InitialDBUsername.Visible = false;
            // 
            // lbl_InitialDBpassword
            // 
            this.lbl_InitialDBpassword.AutoSize = true;
            this.lbl_InitialDBpassword.Location = new System.Drawing.Point(11, 79);
            this.lbl_InitialDBpassword.Name = "lbl_InitialDBpassword";
            this.lbl_InitialDBpassword.Size = new System.Drawing.Size(59, 13);
            this.lbl_InitialDBpassword.TabIndex = 4;
            this.lbl_InitialDBpassword.Text = "Password :";
            this.lbl_InitialDBpassword.Visible = false;
            // 
            // lbl_InitialDBusername
            // 
            this.lbl_InitialDBusername.AutoSize = true;
            this.lbl_InitialDBusername.Location = new System.Drawing.Point(11, 55);
            this.lbl_InitialDBusername.Name = "lbl_InitialDBusername";
            this.lbl_InitialDBusername.Size = new System.Drawing.Size(61, 13);
            this.lbl_InitialDBusername.TabIndex = 3;
            this.lbl_InitialDBusername.Text = "Username :";
            this.lbl_InitialDBusername.Visible = false;
            // 
            // btn_DBInitialSearch
            // 
            this.btn_DBInitialSearch.Location = new System.Drawing.Point(353, 22);
            this.btn_DBInitialSearch.Name = "btn_DBInitialSearch";
            this.btn_DBInitialSearch.Size = new System.Drawing.Size(91, 23);
            this.btn_DBInitialSearch.TabIndex = 2;
            this.btn_DBInitialSearch.Text = "Search";
            this.btn_DBInitialSearch.UseVisualStyleBackColor = true;
            this.btn_DBInitialSearch.Click += new System.EventHandler(this.btn_DBInitialFind_Click);
            // 
            // cb_DBInitialList
            // 
            this.cb_DBInitialList.Enabled = false;
            this.cb_DBInitialList.FormattingEnabled = true;
            this.cb_DBInitialList.Location = new System.Drawing.Point(62, 23);
            this.cb_DBInitialList.Name = "cb_DBInitialList";
            this.cb_DBInitialList.Size = new System.Drawing.Size(285, 21);
            this.cb_DBInitialList.TabIndex = 1;
            this.cb_DBInitialList.Text = "Please search for servers...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Servers :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "only 1 table and 4 colums currently";
            // 
            // Frm_FirstRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 561);
            this.ControlBox = false;
            this.Controls.Add(this.gb_InitialDBconnection);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gb_CreateDatabaseTables);
            this.Controls.Add(this.gb_DefaultAdmin);
            this.Controls.Add(this.gb_SelectDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_FirstRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Run Configuration";
            this.gb_SelectDatabase.ResumeLayout(false);
            this.gb_SelectDatabase.PerformLayout();
            this.gb_CreateDatabaseTables.ResumeLayout(false);
            this.gb_CreateDatabaseTables.PerformLayout();
            this.gb_DefaultAdmin.ResumeLayout(false);
            this.gb_DefaultAdmin.PerformLayout();
            this.gb_InitialDBconnection.ResumeLayout(false);
            this.gb_InitialDBconnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SelectDatabase;
        private System.Windows.Forms.GroupBox gb_DefaultAdmin;
        private System.Windows.Forms.TextBox txtDAPassword;
        private System.Windows.Forms.TextBox txtDAUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbDAShowPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_CreateDatabaseTables;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateTables;
        private System.Windows.Forms.Button btnDAAdd;
        private System.Windows.Forms.GroupBox gb_InitialDBconnection;
        private System.Windows.Forms.Button btn_DBInitialSearch;
        private System.Windows.Forms.ComboBox cb_DBInitialList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_InitialDBShowpassword;
        private System.Windows.Forms.Button btn_InitialDBTestConnection;
        private System.Windows.Forms.TextBox txt_InitialDBPassword;
        private System.Windows.Forms.TextBox txt_InitialDBUsername;
        private System.Windows.Forms.Label lbl_InitialDBpassword;
        private System.Windows.Forms.Label lbl_InitialDBusername;
        private System.Windows.Forms.Button btn_SaveDatabaseConfig;
        private System.Windows.Forms.Button btn_LoadDatabase;
        public System.Windows.Forms.ComboBox cb_Database;
        public System.Windows.Forms.Button btn_NewDatabase;
        public System.Windows.Forms.Button btn_DatabaseRefresh;
        private System.Windows.Forms.Label label1;
    }
}