namespace WindowsFormsApp1
{
    partial class FormAddJobTitle
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
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.btnAddTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Job Title : ";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtJobTitle.Location = new System.Drawing.Point(180, 58);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(366, 35);
            this.txtJobTitle.TabIndex = 4;
            // 
            // btnAddTitle
            // 
            this.btnAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddTitle.Image = global::WindowsFormsApp1.Properties.Resources.floppy_disk__1_;
            this.btnAddTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTitle.Location = new System.Drawing.Point(370, 99);
            this.btnAddTitle.Name = "btnAddTitle";
            this.btnAddTitle.Size = new System.Drawing.Size(176, 151);
            this.btnAddTitle.TabIndex = 5;
            this.btnAddTitle.Text = "Add Title";
            this.btnAddTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddTitle.UseVisualStyleBackColor = true;
            this.btnAddTitle.Click += new System.EventHandler(this.btnAddTitle_Click);
            // 
            // FormAddJobTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTitle);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.label2);
            this.Name = "FormAddJobTitle";
            this.Text = "FormAddJobTitle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Button btnAddTitle;
    }
}