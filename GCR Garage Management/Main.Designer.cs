
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ammendExistingJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.deleteExistingJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDatabaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabJobs = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.administrationToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewJobToolStripMenuItem,
            this.ammendExistingJobToolStripMenuItem,
            this.deleteExistingJobToolStripMenuItem});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 20);
            this.toolStripMenuItem1.Text = "Job Management";
            // 
            // createNewJobToolStripMenuItem
            // 
            this.createNewJobToolStripMenuItem.Enabled = false;
            this.createNewJobToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewJobToolStripMenuItem.Image")));
            this.createNewJobToolStripMenuItem.Name = "createNewJobToolStripMenuItem";
            this.createNewJobToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.createNewJobToolStripMenuItem.Text = "Create New Job";
            // 
            // ammendExistingJobToolStripMenuItem
            // 
            this.ammendExistingJobToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.ammendExistingJobToolStripMenuItem.Enabled = false;
            this.ammendExistingJobToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ammendExistingJobToolStripMenuItem.Image")));
            this.ammendExistingJobToolStripMenuItem.Name = "ammendExistingJobToolStripMenuItem";
            this.ammendExistingJobToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ammendExistingJobToolStripMenuItem.Text = "Ammend Existing Job";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // deleteExistingJobToolStripMenuItem
            // 
            this.deleteExistingJobToolStripMenuItem.Enabled = false;
            this.deleteExistingJobToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteExistingJobToolStripMenuItem.Image")));
            this.deleteExistingJobToolStripMenuItem.Name = "deleteExistingJobToolStripMenuItem";
            this.deleteExistingJobToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.deleteExistingJobToolStripMenuItem.Text = "Delete Existing Job";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareUsersToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.administrationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administrationToolStripMenuItem.Image")));
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.ShowShortcutKeys = false;
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.administrationToolStripMenuItem.Text = "Software Settings";
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
            this.softwareUsersToolStripMenuItem.Text = "Software User\'s";
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
            this.deleteUserToolStripMenuItem.Enabled = false;
            this.deleteUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteUserToolStripMenuItem.Image")));
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            // 
            // modifyUserToolStripMenuItem
            // 
            this.modifyUserToolStripMenuItem.Enabled = false;
            this.modifyUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifyUserToolStripMenuItem.Image")));
            this.modifyUserToolStripMenuItem.Name = "modifyUserToolStripMenuItem";
            this.modifyUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyUserToolStripMenuItem.Text = "Modify User";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDatabaseSettingsToolStripMenuItem});
            this.databaseToolStripMenuItem.Enabled = false;
            this.databaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("databaseToolStripMenuItem.Image")));
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // editDatabaseSettingsToolStripMenuItem
            // 
            this.editDatabaseSettingsToolStripMenuItem.Enabled = false;
            this.editDatabaseSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editDatabaseSettingsToolStripMenuItem.Image")));
            this.editDatabaseSettingsToolStripMenuItem.Name = "editDatabaseSettingsToolStripMenuItem";
            this.editDatabaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.editDatabaseSettingsToolStripMenuItem.Text = "Edit Database Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.updateSoftwareToolStripMenuItem});
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Enabled = false;
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Information";
            // 
            // updateSoftwareToolStripMenuItem
            // 
            this.updateSoftwareToolStripMenuItem.Enabled = false;
            this.updateSoftwareToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateSoftwareToolStripMenuItem.Image")));
            this.updateSoftwareToolStripMenuItem.Name = "updateSoftwareToolStripMenuItem";
            this.updateSoftwareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateSoftwareToolStripMenuItem.Text = "Update Software";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitApplicationToolStripMenuItem.Image")));
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblLoggedUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "Logged in as : ";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(0, 17);
            // 
            // tabJobs
            // 
            this.tabJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabJobs.Enabled = false;
            this.tabJobs.Location = new System.Drawing.Point(0, 27);
            this.tabJobs.Name = "tabJobs";
            this.tabJobs.SelectedIndex = 0;
            this.tabJobs.Size = new System.Drawing.Size(800, 398);
            this.tabJobs.TabIndex = 2;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabJobs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCR Garage Management";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createNewJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ammendExistingJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteExistingJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDatabaseSettingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLoggedUser;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.TabControl tabJobs;
    }
}