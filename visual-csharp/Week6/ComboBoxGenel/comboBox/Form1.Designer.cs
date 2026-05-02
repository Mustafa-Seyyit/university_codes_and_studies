namespace comboBox
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
            this.cmb_Box = new System.Windows.Forms.ComboBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_bx = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Box
            // 
            this.cmb_Box.FormattingEnabled = true;
            this.cmb_Box.Location = new System.Drawing.Point(257, 171);
            this.cmb_Box.Name = "cmb_Box";
            this.cmb_Box.Size = new System.Drawing.Size(258, 21);
            this.cmb_Box.TabIndex = 0;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(254, 128);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(41, 13);
            this.lbl_1.TabIndex = 1;
            this.lbl_1.Text = "Option:";
            // 
            // txt_bx
            // 
            this.txt_bx.Location = new System.Drawing.Point(306, 128);
            this.txt_bx.Name = "txt_bx";
            this.txt_bx.Size = new System.Drawing.Size(100, 20);
            this.txt_bx.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(440, 128);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "ekle";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt_bx);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.cmb_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Box;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_bx;
        private System.Windows.Forms.Button btn;
    }
}

