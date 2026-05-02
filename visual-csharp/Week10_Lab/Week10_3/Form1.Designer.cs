namespace Week10_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnSignIn = new Button();
            txtPasswordSignIn = new TextBox();
            label6 = new Label();
            txtEmailSignIn = new TextBox();
            label7 = new Label();
            tabPage2 = new TabPage();
            btnRegister = new Button();
            txtAge = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtPasswordRegister = new TextBox();
            label2 = new Label();
            txtEmailRegister = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(323, 257);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSignIn);
            tabPage1.Controls.Add(txtPasswordSignIn);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtEmailSignIn);
            tabPage1.Controls.Add(label7);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(315, 229);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sign In";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(10, 64);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(179, 46);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPasswordSignIn
            // 
            txtPasswordSignIn.Location = new Point(89, 35);
            txtPasswordSignIn.Name = "txtPasswordSignIn";
            txtPasswordSignIn.Size = new Size(100, 23);
            txtPasswordSignIn.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 38);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 2;
            label6.Text = "Password : ";
            // 
            // txtEmailSignIn
            // 
            txtEmailSignIn.Location = new Point(89, 6);
            txtEmailSignIn.Name = "txtEmailSignIn";
            txtEmailSignIn.Size = new Size(100, 23);
            txtEmailSignIn.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 9);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 3;
            label7.Text = "Email : ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRegister);
            tabPage2.Controls.Add(txtAge);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtAddress);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtName);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtPasswordRegister);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtEmailRegister);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(315, 229);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Register";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(8, 176);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(179, 46);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(87, 140);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 143);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 0;
            label5.Text = "Age : ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(87, 111);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 114);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 0;
            label4.Text = "Address : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 85);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Name : ";
            // 
            // txtPasswordRegister
            // 
            txtPasswordRegister.Location = new Point(87, 53);
            txtPasswordRegister.Name = "txtPasswordRegister";
            txtPasswordRegister.Size = new Size(100, 23);
            txtPasswordRegister.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 56);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Password : ";
            // 
            // txtEmailRegister
            // 
            txtEmailRegister.Location = new Point(87, 24);
            txtEmailRegister.Name = "txtEmailRegister";
            txtEmailRegister.Size = new Size(100, 23);
            txtEmailRegister.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 27);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Email : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 257);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnRegister;
        private TextBox txtEmailRegister;
        private Label label1;
        private TextBox txtAge;
        private Label label5;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private TextBox txtPasswordRegister;
        private Label label2;
        private TextBox txtPasswordSignIn;
        private Label label6;
        private TextBox txtEmailSignIn;
        private Label label7;
        private Button btnSignIn;
    }
}