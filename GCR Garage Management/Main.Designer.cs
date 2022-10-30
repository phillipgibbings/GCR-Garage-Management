
namespace GCR_Garage_Management
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_Jobs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_CreateNewJob = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_AmmendExistingJob = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_DeleteExistingJob = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDatabaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Logs = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_UpdateSoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts_Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblUserLoggedIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabJobs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabJobs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Jobs,
            this.exitApplicationToolStripMenuItem,
            this.tsm_Admin,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MainMenu";
            // 
            // tsm_Jobs
            // 
            this.tsm_Jobs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_CreateNewJob,
            this.tsm_AmmendExistingJob,
            this.tsb_DeleteExistingJob});
            this.tsm_Jobs.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Jobs.Image")));
            this.tsm_Jobs.Name = "tsm_Jobs";
            this.tsm_Jobs.Size = new System.Drawing.Size(127, 20);
            this.tsm_Jobs.Text = "Job Management";
            // 
            // tsm_CreateNewJob
            // 
            this.tsm_CreateNewJob.Image = ((System.Drawing.Image)(resources.GetObject("tsm_CreateNewJob.Image")));
            this.tsm_CreateNewJob.Name = "tsm_CreateNewJob";
            this.tsm_CreateNewJob.Size = new System.Drawing.Size(189, 22);
            this.tsm_CreateNewJob.Text = "Create New Job";
            // 
            // tsm_AmmendExistingJob
            // 
            this.tsm_AmmendExistingJob.Image = ((System.Drawing.Image)(resources.GetObject("tsm_AmmendExistingJob.Image")));
            this.tsm_AmmendExistingJob.Name = "tsm_AmmendExistingJob";
            this.tsm_AmmendExistingJob.Size = new System.Drawing.Size(189, 22);
            this.tsm_AmmendExistingJob.Text = "Ammend Existing Job";
            // 
            // tsb_DeleteExistingJob
            // 
            this.tsb_DeleteExistingJob.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DeleteExistingJob.Image")));
            this.tsb_DeleteExistingJob.Name = "tsb_DeleteExistingJob";
            this.tsb_DeleteExistingJob.Size = new System.Drawing.Size(189, 22);
            this.tsb_DeleteExistingJob.Text = "Delete Existing Job";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitApplicationToolStripMenuItem.Image")));
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // tsm_Admin
            // 
            this.tsm_Admin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsm_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareUsersToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.tsm_Logs});
            this.tsm_Admin.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Admin.Image")));
            this.tsm_Admin.Name = "tsm_Admin";
            this.tsm_Admin.ShowShortcutKeys = false;
            this.tsm_Admin.Size = new System.Drawing.Size(114, 20);
            this.tsm_Admin.Text = "Administration";
            // 
            // softwareUsersToolStripMenuItem
            // 
            this.softwareUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.modifyUserToolStripMenuItem});
            this.softwareUsersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("softwareUsersToolStripMenuItem.Image")));
            this.softwareUsersToolStripMenuItem.Name = "softwareUsersToolStripMenuItem";
            this.softwareUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.softwareUsersToolStripMenuItem.Text = "Users";
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewUserToolStripMenuItem.Image")));
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            this.createNewUserToolStripMenuItem.Click += new System.EventHandler(this.createNewUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteUserToolStripMenuItem.Image")));
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // modifyUserToolStripMenuItem
            // 
            this.modifyUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifyUserToolStripMenuItem.Image")));
            this.modifyUserToolStripMenuItem.Name = "modifyUserToolStripMenuItem";
            this.modifyUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyUserToolStripMenuItem.Text = "Modify User";
            this.modifyUserToolStripMenuItem.Click += new System.EventHandler(this.modifyUserToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDatabaseSettingsToolStripMenuItem});
            this.databaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("databaseToolStripMenuItem.Image")));
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // editDatabaseSettingsToolStripMenuItem
            // 
            this.editDatabaseSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editDatabaseSettingsToolStripMenuItem.Image")));
            this.editDatabaseSettingsToolStripMenuItem.Name = "editDatabaseSettingsToolStripMenuItem";
            this.editDatabaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.editDatabaseSettingsToolStripMenuItem.Text = "Database Management";
            this.editDatabaseSettingsToolStripMenuItem.Click += new System.EventHandler(this.editDatabaseSettingsToolStripMenuItem_Click);
            // 
            // tsm_Logs
            // 
            this.tsm_Logs.Image = ((System.Drawing.Image)(resources.GetObject("tsm_Logs.Image")));
            this.tsm_Logs.Name = "tsm_Logs";
            this.tsm_Logs.Size = new System.Drawing.Size(180, 22);
            this.tsm_Logs.Text = "Logs";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.tsm_UpdateSoftware});
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Information";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // tsm_UpdateSoftware
            // 
            this.tsm_UpdateSoftware.Image = ((System.Drawing.Image)(resources.GetObject("tsm_UpdateSoftware.Image")));
            this.tsm_UpdateSoftware.Name = "tsm_UpdateSoftware";
            this.tsm_UpdateSoftware.Size = new System.Drawing.Size(180, 22);
            this.tsm_UpdateSoftware.Text = "Update Software";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Progress,
            this.lblUserLoggedIn,
            this.lblLoggedUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts_Progress
            // 
            this.ts_Progress.Name = "ts_Progress";
            this.ts_Progress.Size = new System.Drawing.Size(100, 16);
            this.ts_Progress.Visible = false;
            // 
            // lblUserLoggedIn
            // 
            this.lblUserLoggedIn.Image = ((System.Drawing.Image)(resources.GetObject("lblUserLoggedIn.Image")));
            this.lblUserLoggedIn.Name = "lblUserLoggedIn";
            this.lblUserLoggedIn.Size = new System.Drawing.Size(99, 17);
            this.lblUserLoggedIn.Text = "Logged in as : ";
            this.lblUserLoggedIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(0, 17);
            this.lblLoggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabJobs
            // 
            this.tabJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabJobs.Controls.Add(this.tabPage1);
            this.tabJobs.Enabled = false;
            this.tabJobs.Location = new System.Drawing.Point(0, 27);
            this.tabJobs.Name = "tabJobs";
            this.tabJobs.SelectedIndex = 0;
            this.tabJobs.Size = new System.Drawing.Size(1008, 677);
            this.tabJobs.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recent";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabJobs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCR Garage Management";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabJobs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_Jobs;
        private System.Windows.Forms.ToolStripMenuItem tsm_CreateNewJob;
        private System.Windows.Forms.ToolStripMenuItem tsm_AmmendExistingJob;
        private System.Windows.Forms.ToolStripMenuItem tsb_DeleteExistingJob;
        private System.Windows.Forms.ToolStripMenuItem softwareUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDatabaseSettingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserLoggedIn;
        private System.Windows.Forms.ToolStripStatusLabel lblLoggedUser;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabJobs;
        public System.Windows.Forms.ToolStripMenuItem tsm_Admin;
        public System.Windows.Forms.ToolStripMenuItem tsm_UpdateSoftware;
        private System.Windows.Forms.ToolStripProgressBar ts_Progress;
        private System.Windows.Forms.ToolStripMenuItem tsm_Logs;
        private System.Windows.Forms.TabPage tabPage1;
    }
}