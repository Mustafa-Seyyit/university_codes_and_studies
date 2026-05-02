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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic_bx1 = new System.Windows.Forms.PictureBox();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.rb_stretchımage = new System.Windows.Forms.RadioButton();
            this.rb_autosize = new System.Windows.Forms.RadioButton();
            this.rb_zoom = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bx1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_bx1
            // 
            this.pic_bx1.Image = ((System.Drawing.Image)(resources.GetObject("pic_bx1.Image")));
            this.pic_bx1.Location = new System.Drawing.Point(33, 26);
            this.pic_bx1.Name = "pic_bx1";
            this.pic_bx1.Size = new System.Drawing.Size(511, 357);
            this.pic_bx1.TabIndex = 0;
            this.pic_bx1.TabStop = false;
            // 
            // rb_normal
            // 
            this.rb_normal.AutoSize = true;
            this.rb_normal.Location = new System.Drawing.Point(641, 177);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(56, 17);
            this.rb_normal.TabIndex = 1;
            this.rb_normal.TabStop = true;
            this.rb_normal.Text = "normal";
            this.rb_normal.UseVisualStyleBackColor = true;
            this.rb_normal.CheckedChanged += new System.EventHandler(this.rb_normal_CheckedChanged);
            // 
            // rb_stretchımage
            // 
            this.rb_stretchımage.AutoSize = true;
            this.rb_stretchımage.Location = new System.Drawing.Point(643, 212);
            this.rb_stretchımage.Name = "rb_stretchımage";
            this.rb_stretchımage.Size = new System.Drawing.Size(85, 17);
            this.rb_stretchımage.TabIndex = 2;
            this.rb_stretchımage.TabStop = true;
            this.rb_stretchımage.Text = "stretchımage";
            this.rb_stretchımage.UseVisualStyleBackColor = true;
            this.rb_stretchımage.CheckedChanged += new System.EventHandler(this.rb_stretchımage_CheckedChanged);
            // 
            // rb_autosize
            // 
            this.rb_autosize.AutoSize = true;
            this.rb_autosize.Location = new System.Drawing.Point(643, 250);
            this.rb_autosize.Name = "rb_autosize";
            this.rb_autosize.Size = new System.Drawing.Size(64, 17);
            this.rb_autosize.TabIndex = 3;
            this.rb_autosize.TabStop = true;
            this.rb_autosize.Text = "autosize";
            this.rb_autosize.UseVisualStyleBackColor = true;
            this.rb_autosize.CheckedChanged += new System.EventHandler(this.rb_autosize_CheckedChanged);
            // 
            // rb_zoom
            // 
            this.rb_zoom.AutoSize = true;
            this.rb_zoom.Location = new System.Drawing.Point(643, 283);
            this.rb_zoom.Name = "rb_zoom";
            this.rb_zoom.Size = new System.Drawing.Size(50, 17);
            this.rb_zoom.TabIndex = 4;
            this.rb_zoom.TabStop = true;
            this.rb_zoom.Text = "zoom";
            this.rb_zoom.UseVisualStyleBackColor = true;
            this.rb_zoom.CheckedChanged += new System.EventHandler(this.rb_zoom_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_zoom);
            this.Controls.Add(this.rb_autosize);
            this.Controls.Add(this.rb_stretchımage);
            this.Controls.Add(this.rb_normal);
            this.Controls.Add(this.pic_bx1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_bx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_bx1;
        private System.Windows.Forms.RadioButton rb_normal;
        private System.Windows.Forms.RadioButton rb_stretchımage;
        private System.Windows.Forms.RadioButton rb_autosize;
        private System.Windows.Forms.RadioButton rb_zoom;
    }
}

