namespace Ornek1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tx_bx_ID = new System.Windows.Forms.TextBox();
            this.tx_bx_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(743, 278);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(42, 39);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID:";
            // 
            // tx_bx_ID
            // 
            this.tx_bx_ID.Location = new System.Drawing.Point(116, 39);
            this.tx_bx_ID.Name = "tx_bx_ID";
            this.tx_bx_ID.Size = new System.Drawing.Size(100, 20);
            this.tx_bx_ID.TabIndex = 2;
            // 
            // tx_bx_name
            // 
            this.tx_bx_name.Location = new System.Drawing.Point(116, 77);
            this.tx_bx_name.Name = "tx_bx_name";
            this.tx_bx_name.Size = new System.Drawing.Size(100, 20);
            this.tx_bx_name.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(42, 77);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(45, 119);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(141, 119);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 130;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 134;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tx_bx_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tx_bx_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tx_bx_ID;
        private System.Windows.Forms.TextBox tx_bx_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
    }
}

