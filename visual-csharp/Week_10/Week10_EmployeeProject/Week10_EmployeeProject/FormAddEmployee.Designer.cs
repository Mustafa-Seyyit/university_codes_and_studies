namespace Week10_EmployeeProject
{
    partial class FormAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEmployee));
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnSelectYourPhoto = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cmbEmployeeList = new System.Windows.Forms.ComboBox();
            this.cmbJobTitles = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureProfilePhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditEmployee.Location = new System.Drawing.Point(1000, 55);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(233, 38);
            this.btnEditEmployee.TabIndex = 30;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnSelectYourPhoto
            // 
            this.btnSelectYourPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectYourPhoto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectYourPhoto.Location = new System.Drawing.Point(1000, 187);
            this.btnSelectYourPhoto.Name = "btnSelectYourPhoto";
            this.btnSelectYourPhoto.Size = new System.Drawing.Size(233, 38);
            this.btnSelectYourPhoto.TabIndex = 29;
            this.btnSelectYourPhoto.Text = "Select Your Photo";
            this.btnSelectYourPhoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelectYourPhoto.UseVisualStyleBackColor = true;
            this.btnSelectYourPhoto.Click += new System.EventHandler(this.btnSelectYourPhoto_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateEmployee.Image")));
            this.btnUpdateEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(734, 453);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(260, 151);
            this.btnUpdateEmployee.TabIndex = 28;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddEmployee.Location = new System.Drawing.Point(1000, 452);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(233, 151);
            this.btnAddEmployee.TabIndex = 27;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cmbEmployeeList
            // 
            this.cmbEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbEmployeeList.FormattingEnabled = true;
            this.cmbEmployeeList.Location = new System.Drawing.Point(734, 58);
            this.cmbEmployeeList.Name = "cmbEmployeeList";
            this.cmbEmployeeList.Size = new System.Drawing.Size(260, 37);
            this.cmbEmployeeList.TabIndex = 26;
            this.cmbEmployeeList.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeList_SelectedIndexChanged);
            // 
            // cmbJobTitles
            // 
            this.cmbJobTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbJobTitles.FormattingEnabled = true;
            this.cmbJobTitles.Location = new System.Drawing.Point(212, 453);
            this.cmbJobTitles.Name = "cmbJobTitles";
            this.cmbJobTitles.Size = new System.Drawing.Size(366, 37);
            this.cmbJobTitles.TabIndex = 23;
            this.cmbJobTitles.SelectedIndexChanged += new System.EventHandler(this.cmbJobTitles_SelectedIndexChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalary.Location = new System.Drawing.Point(212, 505);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(366, 35);
            this.txtSalary.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Salary : ";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMobileNo.Location = new System.Drawing.Point(212, 281);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(366, 35);
            this.txtMobileNo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Job Title : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mobile No : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(212, 405);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(366, 35);
            this.txtEmail.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email : ";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastName.Location = new System.Drawing.Point(212, 240);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(366, 35);
            this.txtLastName.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddress.Location = new System.Drawing.Point(212, 327);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(366, 72);
            this.txtAddress.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Last Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address : ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstName.Location = new System.Drawing.Point(212, 190);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(366, 35);
            this.txtFirstName.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(196, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Employee Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(904, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "Photo : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "First Name : ";
            // 
            // pictureProfilePhoto
            // 
            this.pictureProfilePhoto.Location = new System.Drawing.Point(1000, 240);
            this.pictureProfilePhoto.Name = "pictureProfilePhoto";
            this.pictureProfilePhoto.Size = new System.Drawing.Size(233, 200);
            this.pictureProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProfilePhoto.TabIndex = 31;
            this.pictureProfilePhoto.TabStop = false;
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 664);
            this.Controls.Add(this.pictureProfilePhoto);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnSelectYourPhoto);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.cmbEmployeeList);
            this.Controls.Add(this.cmbJobTitles);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Name = "FormAddEmployee";
            this.Text = "FormAddEmployee";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureProfilePhoto;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnSelectYourPhoto;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cmbEmployeeList;
        private System.Windows.Forms.ComboBox cmbJobTitles;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}