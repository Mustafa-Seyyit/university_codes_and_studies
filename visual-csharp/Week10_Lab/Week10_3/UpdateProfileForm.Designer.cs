namespace Week10_3
{
    partial class UpdateProfileForm
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
            btnUpdate = new Button();
            txtAge = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 165);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(179, 46);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(91, 129);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 132);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 3;
            label5.Text = "Age : ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(91, 100);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Address : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Name : ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(91, 42);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "Password : ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(91, 13);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 7;
            label1.Text = "Email : ";
            // 
            // UpdateProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(208, 217);
            Controls.Add(btnUpdate);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "UpdateProfileForm";
            Text = "UpdateProfileForm";
            Load += UpdateProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox txtAge;
        private Label label5;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
    }
}