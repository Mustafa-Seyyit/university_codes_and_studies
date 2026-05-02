namespace LabWeek_9
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtGrade = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Name : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(87, 29);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 61);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Grade : ";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(87, 58);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(100, 23);
            txtGrade.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(87, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 121);
            Controls.Add(btnAdd);
            Controls.Add(txtGrade);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtGrade;
        private Button btnAdd;
    }
}