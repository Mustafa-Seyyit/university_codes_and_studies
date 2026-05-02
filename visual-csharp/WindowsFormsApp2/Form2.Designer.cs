
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(201, 42);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(12, 39);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(182, 225);
            this.lstNumbers.TabIndex = 6;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(12, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(182, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(200, 12);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(75, 23);
            this.btnAddNumber.TabIndex = 4;
            this.btnAddNumber.Text = "Add";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 276);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnAddNumber);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAddNumber;
    }
}