namespace WindowsFormsApp2
{
    partial class FormAddSales
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
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(77, 12);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year : ";
            // 
            // btnAddSales
            // 
            this.btnAddSales.Location = new System.Drawing.Point(32, 64);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(145, 32);
            this.btnAddSales.TabIndex = 2;
            this.btnAddSales.Text = "Add";
            this.btnAddSales.UseVisualStyleBackColor = true;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(77, 38);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount : ";
            // 
            // FormAddSales
            // 
            this.AcceptButton = this.btnAddSales;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 108);
            this.Controls.Add(this.btnAddSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtYear);
            this.Name = "FormAddSales";
            this.Text = "FormAddSales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
    }
}