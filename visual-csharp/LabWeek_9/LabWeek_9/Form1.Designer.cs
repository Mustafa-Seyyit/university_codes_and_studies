namespace LabWeek_9
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
            lstStudents = new ListBox();
            btnAddNew = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(18, 15);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(171, 229);
            lstStudents.TabIndex = 0;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(12, 250);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 250);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 327);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(lstStudents);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstStudents;
        private Button btnAddNew;
        private Button btnUpdate;
    }
}