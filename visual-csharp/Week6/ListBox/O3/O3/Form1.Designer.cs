namespace O3
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
            this.btn_addList = new System.Windows.Forms.Button();
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.tx_bx_fullName = new System.Windows.Forms.TextBox();
            this.tx_bx_EMail = new System.Windows.Forms.TextBox();
            this.lbl_EMail = new System.Windows.Forms.Label();
            this.tx_bx_Age = new System.Windows.Forms.TextBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lst_bx1 = new System.Windows.Forms.ListBox();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addList
            // 
            this.btn_addList.Location = new System.Drawing.Point(49, 156);
            this.btn_addList.Name = "btn_addList";
            this.btn_addList.Size = new System.Drawing.Size(156, 40);
            this.btn_addList.TabIndex = 0;
            this.btn_addList.Text = "Listeye Ekle";
            this.btn_addList.UseVisualStyleBackColor = true;
            this.btn_addList.Click += new System.EventHandler(this.btn_addList_Click);
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.AutoSize = true;
            this.lbl_fullName.Location = new System.Drawing.Point(46, 44);
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.Size = new System.Drawing.Size(51, 13);
            this.lbl_fullName.TabIndex = 1;
            this.lbl_fullName.Text = "fullName:";
            // 
            // tx_bx_fullName
            // 
            this.tx_bx_fullName.Location = new System.Drawing.Point(105, 41);
            this.tx_bx_fullName.Name = "tx_bx_fullName";
            this.tx_bx_fullName.Size = new System.Drawing.Size(100, 20);
            this.tx_bx_fullName.TabIndex = 2;
            // 
            // tx_bx_EMail
            // 
            this.tx_bx_EMail.Location = new System.Drawing.Point(105, 78);
            this.tx_bx_EMail.Name = "tx_bx_EMail";
            this.tx_bx_EMail.Size = new System.Drawing.Size(100, 20);
            this.tx_bx_EMail.TabIndex = 4;
            // 
            // lbl_EMail
            // 
            this.lbl_EMail.AutoSize = true;
            this.lbl_EMail.Location = new System.Drawing.Point(46, 78);
            this.lbl_EMail.Name = "lbl_EMail";
            this.lbl_EMail.Size = new System.Drawing.Size(39, 13);
            this.lbl_EMail.TabIndex = 3;
            this.lbl_EMail.Text = "E-Mail:";
            // 
            // tx_bx_Age
            // 
            this.tx_bx_Age.Location = new System.Drawing.Point(105, 116);
            this.tx_bx_Age.Name = "tx_bx_Age";
            this.tx_bx_Age.Size = new System.Drawing.Size(100, 20);
            this.tx_bx_Age.TabIndex = 6;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(46, 119);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(29, 13);
            this.lbl_Age.TabIndex = 5;
            this.lbl_Age.Text = "Age:";
            // 
            // lst_bx1
            // 
            this.lst_bx1.FormattingEnabled = true;
            this.lst_bx1.Location = new System.Drawing.Point(356, 41);
            this.lst_bx1.Name = "lst_bx1";
            this.lst_bx1.Size = new System.Drawing.Size(179, 147);
            this.lst_bx1.TabIndex = 7;
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.Location = new System.Drawing.Point(356, 203);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(179, 46);
            this.btn_SaveFile.TabIndex = 8;
            this.btn_SaveFile.Text = "Dosyaya kaydet";
            this.btn_SaveFile.UseVisualStyleBackColor = true;
            this.btn_SaveFile.Click += new System.EventHandler(this.btn_SaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SaveFile);
            this.Controls.Add(this.lst_bx1);
            this.Controls.Add(this.tx_bx_Age);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.tx_bx_EMail);
            this.Controls.Add(this.lbl_EMail);
            this.Controls.Add(this.tx_bx_fullName);
            this.Controls.Add(this.lbl_fullName);
            this.Controls.Add(this.btn_addList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addList;
        private System.Windows.Forms.Label lbl_fullName;
        private System.Windows.Forms.TextBox tx_bx_fullName;
        private System.Windows.Forms.TextBox tx_bx_EMail;
        private System.Windows.Forms.Label lbl_EMail;
        private System.Windows.Forms.TextBox tx_bx_Age;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.ListBox lst_bx1;
        private System.Windows.Forms.Button btn_SaveFile;
    }
}

