namespace Week10_3
{
    partial class NewRecordForm
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
            btnAddNewRecord = new Button();
            txtAuthor = new TextBox();
            label6 = new Label();
            txtBookName = new TextBox();
            label7 = new Label();
            label1 = new Label();
            txtPageCount = new TextBox();
            SuspendLayout();
            // 
            // btnAddNewRecord
            // 
            btnAddNewRecord.Location = new Point(10, 97);
            btnAddNewRecord.Name = "btnAddNewRecord";
            btnAddNewRecord.Size = new Size(179, 46);
            btnAddNewRecord.TabIndex = 11;
            btnAddNewRecord.Text = "Add New Record";
            btnAddNewRecord.UseVisualStyleBackColor = true;
            btnAddNewRecord.Click += btnAddNewRecord_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(89, 41);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 44);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 7;
            label6.Text = "Author : ";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(89, 12);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(100, 23);
            txtBookName.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 15);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 8;
            label7.Text = "Book Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 73);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 7;
            label1.Text = "Page Count : ";
            // 
            // txtPageCount
            // 
            txtPageCount.Location = new Point(89, 70);
            txtPageCount.Name = "txtPageCount";
            txtPageCount.Size = new Size(100, 23);
            txtPageCount.TabIndex = 9;
            // 
            // NewRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 164);
            Controls.Add(btnAddNewRecord);
            Controls.Add(txtPageCount);
            Controls.Add(label1);
            Controls.Add(txtAuthor);
            Controls.Add(label6);
            Controls.Add(txtBookName);
            Controls.Add(label7);
            Name = "NewRecordForm";
            Text = "NewRecordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNewRecord;
        private TextBox txtAuthor;
        private Label label6;
        private TextBox txtBookName;
        private Label label7;
        private Label label1;
        private TextBox txtPageCount;
    }
}