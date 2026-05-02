namespace WindowsFormsApp4
{
    partial class Form1
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
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnLoadUserFromFile = new System.Windows.Forms.Button();
            this.btnSaveUsersAsFile = new System.Windows.Forms.Button();
            this.btnRemoveUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewUsers
            // 
            this.listViewUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(0, 192);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(800, 258);
            this.listViewUsers.TabIndex = 0;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(107, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 20);
            this.txtID.TabIndex = 2;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(31, 132);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(212, 44);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(107, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(136, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name  :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 69);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(136, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Age : ";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(107, 95);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(136, 20);
            this.txtAge.TabIndex = 2;
            // 
            // btnLoadUserFromFile
            // 
            this.btnLoadUserFromFile.Location = new System.Drawing.Point(636, 132);
            this.btnLoadUserFromFile.Name = "btnLoadUserFromFile";
            this.btnLoadUserFromFile.Size = new System.Drawing.Size(152, 44);
            this.btnLoadUserFromFile.TabIndex = 3;
            this.btnLoadUserFromFile.Text = "Load User";
            this.btnLoadUserFromFile.UseVisualStyleBackColor = true;
            this.btnLoadUserFromFile.Click += new System.EventHandler(this.btnLoadUserFromFile_Click);
            // 
            // btnSaveUsersAsFile
            // 
            this.btnSaveUsersAsFile.Location = new System.Drawing.Point(478, 132);
            this.btnSaveUsersAsFile.Name = "btnSaveUsersAsFile";
            this.btnSaveUsersAsFile.Size = new System.Drawing.Size(152, 44);
            this.btnSaveUsersAsFile.TabIndex = 3;
            this.btnSaveUsersAsFile.Text = "Save User As File";
            this.btnSaveUsersAsFile.UseVisualStyleBackColor = true;
            this.btnSaveUsersAsFile.Click += new System.EventHandler(this.btnSaveUsersAsFile_Click);
            // 
            // btnRemoveUsers
            // 
            this.btnRemoveUsers.Location = new System.Drawing.Point(262, 132);
            this.btnRemoveUsers.Name = "btnRemoveUsers";
            this.btnRemoveUsers.Size = new System.Drawing.Size(152, 44);
            this.btnRemoveUsers.TabIndex = 3;
            this.btnRemoveUsers.Text = "Remove User";
            this.btnRemoveUsers.UseVisualStyleBackColor = true;
            this.btnRemoveUsers.Click += new System.EventHandler(this.btnRemoveUsers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveUsers);
            this.Controls.Add(this.btnSaveUsersAsFile);
            this.Controls.Add(this.btnLoadUserFromFile);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnLoadUserFromFile;
        private System.Windows.Forms.Button btnSaveUsersAsFile;
        private System.Windows.Forms.Button btnRemoveUsers;
    }
}