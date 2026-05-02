namespace Ders3
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
            this.ntf_icon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ntf_icon1
            // 
            this.ntf_icon1.Icon = ((System.Drawing.Icon)(resources.GetObject("ntf_icon1.Icon")));
            this.ntf_icon1.Text = "notifyIcon1";
            this.ntf_icon1.Visible = true;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(266, 163);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(195, 64);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "hata gösterelim";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ntf_icon1;
        private System.Windows.Forms.Button btn_1;
    }
}

