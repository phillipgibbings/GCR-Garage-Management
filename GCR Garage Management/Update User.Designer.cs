
namespace GCR_Garage_Management
{
    partial class Frm_UpdateUser
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbUpdateUser = new System.Windows.Forms.GroupBox();
            this.lblPasswordMatch = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbUsername = new System.Windows.Forms.ComboBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUpdateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(158, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbUpdateUser
            // 
            this.gbUpdateUser.Controls.Add(this.lblPasswordMatch);
            this.gbUpdateUser.Controls.Add(this.btnUpdate);
            this.gbUpdateUser.Controls.Add(this.cbUsername);
            this.gbUpdateUser.Controls.Add(this.txtPassword2);
            this.gbUpdateUser.Controls.Add(this.txtPassword1);
            this.gbUpdateUser.Controls.Add(this.label3);
            this.gbUpdateUser.Controls.Add(this.label2);
            this.gbUpdateUser.Controls.Add(this.label1);
            this.gbUpdateUser.Controls.Add(this.btnCancel);
            this.gbUpdateUser.Location = new System.Drawing.Point(12, 12);
            this.gbUpdateUser.Name = "gbUpdateUser";
            this.gbUpdateUser.Size = new System.Drawing.Size(326, 143);
            this.gbUpdateUser.TabIndex = 1;
            this.gbUpdateUser.TabStop = false;
            this.gbUpdateUser.Text = "Update User Information";
            // 
            // lblPasswordMatch
            // 
            this.lblPasswordMatch.AutoSize = true;
            this.lblPasswordMatch.Location = new System.Drawing.Point(9, 119);
            this.lblPasswordMatch.Name = "lblPasswordMatch";
            this.lblPasswordMatch.Size = new System.Drawing.Size(0, 13);
            this.lblPasswordMatch.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(239, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbUsername
            // 
            this.cbUsername.FormattingEnabled = true;
            this.cbUsername.Location = new System.Drawing.Point(109, 33);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Size = new System.Drawing.Size(205, 21);
            this.cbUsername.TabIndex = 6;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(109, 84);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(205, 20);
            this.txtPassword2.TabIndex = 5;
            this.txtPassword2.UseSystemPasswordChar = true;
            this.txtPassword2.TextChanged += new System.EventHandler(this.txtPassword2_TextChanged);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(109, 58);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(205, 20);
            this.txtPassword1.TabIndex = 4;
            this.txtPassword1.UseSystemPasswordChar = true;
            this.txtPassword1.TextChanged += new System.EventHandler(this.txtPassword1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            // 
            // Frm_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 166);
            this.ControlBox = false;
            this.Controls.Add(this.gbUpdateUser);
            this.Name = "Frm_UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update User";
            this.Load += new System.EventHandler(this.Frm_UpdateUser_Load);
            this.gbUpdateUser.ResumeLayout(false);
            this.gbUpdateUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbUpdateUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbUsername;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPasswordMatch;
    }
}