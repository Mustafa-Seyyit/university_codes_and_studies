namespace Ders2
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.rb_PHP = new System.Windows.Forms.RadioButton();
            this.rb_Java = new System.Windows.Forms.RadioButton();
            this.rb_Python = new System.Windows.Forms.RadioButton();
            this.rb_CSharp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(390, 169);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(141, 13);
            this.lbl_1.TabIndex = 9;
            this.lbl_1.Text = "seçiminiz burada gözükücek";
            // 
            // rb_PHP
            // 
            this.rb_PHP.AutoSize = true;
            this.rb_PHP.Location = new System.Drawing.Point(248, 128);
            this.rb_PHP.Name = "rb_PHP";
            this.rb_PHP.Size = new System.Drawing.Size(47, 17);
            this.rb_PHP.TabIndex = 8;
            this.rb_PHP.TabStop = true;
            this.rb_PHP.Text = "PHP";
            this.rb_PHP.UseVisualStyleBackColor = true;
            this.rb_PHP.CheckedChanged += new System.EventHandler(this.radios_CheckedChanged);
            // 
            // rb_Java
            // 
            this.rb_Java.AutoSize = true;
            this.rb_Java.Location = new System.Drawing.Point(248, 169);
            this.rb_Java.Name = "rb_Java";
            this.rb_Java.Size = new System.Drawing.Size(48, 17);
            this.rb_Java.TabIndex = 7;
            this.rb_Java.TabStop = true;
            this.rb_Java.Text = "Java";
            this.rb_Java.UseVisualStyleBackColor = true;
            this.rb_Java.CheckedChanged += new System.EventHandler(this.radios_CheckedChanged);
            // 
            // rb_Python
            // 
            this.rb_Python.AutoSize = true;
            this.rb_Python.Location = new System.Drawing.Point(248, 206);
            this.rb_Python.Name = "rb_Python";
            this.rb_Python.Size = new System.Drawing.Size(58, 17);
            this.rb_Python.TabIndex = 6;
            this.rb_Python.TabStop = true;
            this.rb_Python.Text = "Python";
            this.rb_Python.UseVisualStyleBackColor = true;
            this.rb_Python.CheckedChanged += new System.EventHandler(this.radios_CheckedChanged);
            // 
            // rb_CSharp
            // 
            this.rb_CSharp.AutoSize = true;
            this.rb_CSharp.Location = new System.Drawing.Point(248, 88);
            this.rb_CSharp.Name = "rb_CSharp";
            this.rb_CSharp.Size = new System.Drawing.Size(39, 17);
            this.rb_CSharp.TabIndex = 5;
            this.rb_CSharp.TabStop = true;
            this.rb_CSharp.Text = "C#";
            this.rb_CSharp.UseVisualStyleBackColor = true;
            this.rb_CSharp.CheckedChanged += new System.EventHandler(this.radios_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.rb_PHP);
            this.Controls.Add(this.rb_Java);
            this.Controls.Add(this.rb_Python);
            this.Controls.Add(this.rb_CSharp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.RadioButton rb_PHP;
        private System.Windows.Forms.RadioButton rb_Java;
        private System.Windows.Forms.RadioButton rb_Python;
        private System.Windows.Forms.RadioButton rb_CSharp;
    }
}

