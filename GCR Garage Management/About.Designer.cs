namespace GCR_Garage_Management
{
    partial class frm_About
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.llblCreatedBy = new System.Windows.Forms.LinkLabel();
            this.lblAssembllyName = new System.Windows.Forms.Label();
            this.lblAssemblyVersion = new System.Windows.Forms.Label();
            this.rtbRevision = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 473);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Revision History";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(12, 486);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(68, 13);
            this.lblCreatedBy.TabIndex = 3;
            this.lblCreatedBy.Text = "Created By : ";
            // 
            // llblCreatedBy
            // 
            this.llblCreatedBy.AutoSize = true;
            this.llblCreatedBy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblCreatedBy.LinkColor = System.Drawing.Color.RoyalBlue;
            this.llblCreatedBy.Location = new System.Drawing.Point(89, 486);
            this.llblCreatedBy.Name = "llblCreatedBy";
            this.llblCreatedBy.Size = new System.Drawing.Size(78, 13);
            this.llblCreatedBy.TabIndex = 4;
            this.llblCreatedBy.TabStop = true;
            this.llblCreatedBy.Text = "Phillip Gibbings";
            this.llblCreatedBy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblAssembllyName
            // 
            this.lblAssembllyName.AutoSize = true;
            this.lblAssembllyName.Location = new System.Drawing.Point(12, 441);
            this.lblAssembllyName.Name = "lblAssembllyName";
            this.lblAssembllyName.Size = new System.Drawing.Size(35, 13);
            this.lblAssembllyName.TabIndex = 5;
            this.lblAssembllyName.Text = "label2";
            // 
            // lblAssemblyVersion
            // 
            this.lblAssemblyVersion.AutoSize = true;
            this.lblAssemblyVersion.Location = new System.Drawing.Point(12, 463);
            this.lblAssemblyVersion.Name = "lblAssemblyVersion";
            this.lblAssemblyVersion.Size = new System.Drawing.Size(35, 13);
            this.lblAssemblyVersion.TabIndex = 6;
            this.lblAssemblyVersion.Text = "label2";
            // 
            // rtbRevision
            // 
            this.rtbRevision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRevision.Location = new System.Drawing.Point(15, 25);
            this.rtbRevision.Name = "rtbRevision";
            this.rtbRevision.ReadOnly = true;
            this.rtbRevision.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbRevision.Size = new System.Drawing.Size(773, 404);
            this.rtbRevision.TabIndex = 7;
            this.rtbRevision.Text = "Unable to load About.txt";
            // 
            // frm_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.rtbRevision);
            this.Controls.Add(this.lblAssemblyVersion);
            this.Controls.Add(this.lblAssembllyName);
            this.Controls.Add(this.llblCreatedBy);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_About";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.frm_About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.LinkLabel llblCreatedBy;
        private System.Windows.Forms.Label lblAssembllyName;
        private System.Windows.Forms.Label lblAssemblyVersion;
        private System.Windows.Forms.RichTextBox rtbRevision;
    }
}