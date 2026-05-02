namespace Week10_EmployeeProject
{
    partial class FormJobTitle
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
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtJobTitle.Location = new System.Drawing.Point(170, 14);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(366, 35);
            this.txtJobTitle.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Job Title : ";
            // 
            // btnAddTitle
            // 
            this.btnAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddTitle.Image = global::Week10_EmployeeProject.Properties.Resources.floppy_disk__1_;
            this.btnAddTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTitle.Location = new System.Drawing.Point(360, 55);
            this.btnAddTitle.Name = "btnAddTitle";
            this.btnAddTitle.Size = new System.Drawing.Size(176, 151);
            this.btnAddTitle.TabIndex = 8;
            this.btnAddTitle.Text = "Add Title";
            this.btnAddTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddTitle.UseVisualStyleBackColor = true;
            this.btnAddTitle.Click += new System.EventHandler(this.btnAddTitle_Click);
            // 
            // FormJobTitle
            // 
            this.AcceptButton = this.btnAddTitle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 316);
            this.Controls.Add(this.btnAddTitle);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.label2);
            this.Name = "FormJobTitle";
            this.Text = "FormJobTitle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTitle;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label label2;
    }
}