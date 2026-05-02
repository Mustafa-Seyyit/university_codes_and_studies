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
            this.cmb_bx1 = new System.Windows.Forms.ComboBox();
            this.btn_aktar = new System.Windows.Forms.Button();
            this.lst_bx1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmb_bx1
            // 
            this.cmb_bx1.FormattingEnabled = true;
            this.cmb_bx1.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Artvin",
            "Tokat",
            "Karabük",
            "Sivas"});
            this.cmb_bx1.Location = new System.Drawing.Point(163, 147);
            this.cmb_bx1.Name = "cmb_bx1";
            this.cmb_bx1.Size = new System.Drawing.Size(121, 21);
            this.cmb_bx1.TabIndex = 0;
            // 
            // btn_aktar
            // 
            this.btn_aktar.Location = new System.Drawing.Point(312, 163);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(91, 53);
            this.btn_aktar.TabIndex = 1;
            this.btn_aktar.Text = "----->";
            this.btn_aktar.UseVisualStyleBackColor = true;
            this.btn_aktar.Click += new System.EventHandler(this.btn_aktar_Click);
            // 
            // lst_bx1
            // 
            this.lst_bx1.FormattingEnabled = true;
            this.lst_bx1.Location = new System.Drawing.Point(442, 147);
            this.lst_bx1.Name = "lst_bx1";
            this.lst_bx1.Size = new System.Drawing.Size(169, 147);
            this.lst_bx1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_bx1);
            this.Controls.Add(this.btn_aktar);
            this.Controls.Add(this.cmb_bx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_bx1;
        private System.Windows.Forms.Button btn_aktar;
        private System.Windows.Forms.ListBox lst_bx1;
    }
}

