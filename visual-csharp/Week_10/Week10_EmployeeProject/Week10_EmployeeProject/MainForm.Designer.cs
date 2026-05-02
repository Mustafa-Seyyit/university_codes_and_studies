namespace Week10_EmployeeProject
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEmployees = new System.Windows.Forms.Button();
            this.btnAddJobTitle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(637, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Insert Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(381, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "C#";
            // 
            // btnAddEmployees
            // 
            this.btnAddEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddEmployees.Location = new System.Drawing.Point(666, 390);
            this.btnAddEmployees.Name = "btnAddEmployees";
            this.btnAddEmployees.Size = new System.Drawing.Size(142, 56);
            this.btnAddEmployees.TabIndex = 4;
            this.btnAddEmployees.Text = "Employees";
            this.btnAddEmployees.UseVisualStyleBackColor = true;
            this.btnAddEmployees.Click += new System.EventHandler(this.btnAddEmployees_Click);
            // 
            // btnAddJobTitle
            // 
            this.btnAddJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddJobTitle.Location = new System.Drawing.Point(666, 296);
            this.btnAddJobTitle.Name = "btnAddJobTitle";
            this.btnAddJobTitle.Size = new System.Drawing.Size(142, 56);
            this.btnAddJobTitle.TabIndex = 5;
            this.btnAddJobTitle.Text = "Job Title";
            this.btnAddJobTitle.UseVisualStyleBackColor = true;
            this.btnAddJobTitle.Click += new System.EventHandler(this.btnAddJobTitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Week10_EmployeeProject.Properties.Resources.SQLite_Logo_wine;
            this.pictureBox1.Location = new System.Drawing.Point(100, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEmployees);
            this.Controls.Add(this.btnAddJobTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEmployees;
        private System.Windows.Forms.Button btnAddJobTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}