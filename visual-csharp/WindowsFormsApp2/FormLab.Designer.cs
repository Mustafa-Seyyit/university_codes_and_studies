
namespace WindowsFormsApp2
{
    partial class FormLab
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRemoveSelectedUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name : ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(75, 12);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name : ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(75, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(12, 64);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(77, 28);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstUsers.HideSelection = false;
            this.lstUsers.Location = new System.Drawing.Point(0, 152);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(591, 369);
            this.lstUsers.TabIndex = 3;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(98, 64);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(77, 28);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRemoveSelectedUser
            // 
            this.btnRemoveSelectedUser.Location = new System.Drawing.Point(13, 111);
            this.btnRemoveSelectedUser.Name = "btnRemoveSelectedUser";
            this.btnRemoveSelectedUser.Size = new System.Drawing.Size(162, 35);
            this.btnRemoveSelectedUser.TabIndex = 4;
            this.btnRemoveSelectedUser.Text = "Remove Selected User From Database";
            this.btnRemoveSelectedUser.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedUser.Click += new System.EventHandler(this.btnRemoveSelectedUser_Click);
            // 
            // FormLab
            // 
            this.AcceptButton = this.btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 521);
            this.Controls.Add(this.btnRemoveSelectedUser);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "FormLab";
            this.Text = "FormLab";
            this.Load += new System.EventHandler(this.FormLab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRemoveSelectedUser;
    }
}