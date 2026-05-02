namespace comboBox3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_bx = new System.Windows.Forms.TextBox();
            this.cmb_bx = new System.Windows.Forms.ComboBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_onceki = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // txt_bx
            // 
            this.txt_bx.Location = new System.Drawing.Point(254, 113);
            this.txt_bx.Name = "txt_bx";
            this.txt_bx.Size = new System.Drawing.Size(100, 20);
            this.txt_bx.TabIndex = 9;
            // 
            // cmb_bx
            // 
            this.cmb_bx.FormattingEnabled = true;
            this.cmb_bx.Location = new System.Drawing.Point(202, 162);
            this.cmb_bx.Name = "cmb_bx";
            this.cmb_bx.Size = new System.Drawing.Size(224, 21);
            this.cmb_bx.TabIndex = 8;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(441, 110);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(360, 110);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Option";
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.Location = new System.Drawing.Point(477, 160);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(39, 23);
            this.btn_sonraki.TabIndex = 11;
            this.btn_sonraki.Text = ">";
            this.btn_sonraki.UseVisualStyleBackColor = true;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // btn_onceki
            // 
            this.btn_onceki.Location = new System.Drawing.Point(432, 160);
            this.btn_onceki.Name = "btn_onceki";
            this.btn_onceki.Size = new System.Drawing.Size(39, 23);
            this.btn_onceki.TabIndex = 10;
            this.btn_onceki.Text = "<";
            this.btn_onceki.UseVisualStyleBackColor = true;
            this.btn_onceki.Click += new System.EventHandler(this.btn_onceki_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sonraki);
            this.Controls.Add(this.btn_onceki);
            this.Controls.Add(this.txt_bx);
            this.Controls.Add(this.cmb_bx);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_bx;
        private System.Windows.Forms.ComboBox cmb_bx;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_onceki;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

