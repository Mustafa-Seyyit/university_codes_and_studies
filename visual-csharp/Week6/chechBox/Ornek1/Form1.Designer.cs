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
            this.ck_bx_futbol = new System.Windows.Forms.CheckBox();
            this.ck_bx_basketbol = new System.Windows.Forms.CheckBox();
            this.ck_bx_box = new System.Windows.Forms.CheckBox();
            this.ck_bx_voleybol = new System.Windows.Forms.CheckBox();
            this.lbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ck_bx_futbol
            // 
            this.ck_bx_futbol.AutoSize = true;
            this.ck_bx_futbol.Location = new System.Drawing.Point(130, 90);
            this.ck_bx_futbol.Name = "ck_bx_futbol";
            this.ck_bx_futbol.Size = new System.Drawing.Size(52, 17);
            this.ck_bx_futbol.TabIndex = 0;
            this.ck_bx_futbol.Text = "futbol";
            this.ck_bx_futbol.UseVisualStyleBackColor = true;
            this.ck_bx_futbol.CheckedChanged += new System.EventHandler(this.checkBox_isChanged);
            // 
            // ck_bx_basketbol
            // 
            this.ck_bx_basketbol.AutoSize = true;
            this.ck_bx_basketbol.Location = new System.Drawing.Point(130, 145);
            this.ck_bx_basketbol.Name = "ck_bx_basketbol";
            this.ck_bx_basketbol.Size = new System.Drawing.Size(72, 17);
            this.ck_bx_basketbol.TabIndex = 1;
            this.ck_bx_basketbol.Text = "basketbol";
            this.ck_bx_basketbol.UseVisualStyleBackColor = true;
            this.ck_bx_basketbol.CheckedChanged += new System.EventHandler(this.checkBox_isChanged);
            // 
            // ck_bx_box
            // 
            this.ck_bx_box.AutoSize = true;
            this.ck_bx_box.Location = new System.Drawing.Point(130, 203);
            this.ck_bx_box.Name = "ck_bx_box";
            this.ck_bx_box.Size = new System.Drawing.Size(43, 17);
            this.ck_bx_box.TabIndex = 2;
            this.ck_bx_box.Text = "box";
            this.ck_bx_box.UseVisualStyleBackColor = true;
            this.ck_bx_box.CheckedChanged += new System.EventHandler(this.checkBox_isChanged);
            // 
            // ck_bx_voleybol
            // 
            this.ck_bx_voleybol.AutoSize = true;
            this.ck_bx_voleybol.Location = new System.Drawing.Point(130, 268);
            this.ck_bx_voleybol.Name = "ck_bx_voleybol";
            this.ck_bx_voleybol.Size = new System.Drawing.Size(65, 17);
            this.ck_bx_voleybol.TabIndex = 3;
            this.ck_bx_voleybol.Text = "voleybol";
            this.ck_bx_voleybol.UseVisualStyleBackColor = true;
            this.ck_bx_voleybol.CheckedChanged += new System.EventHandler(this.checkBox_isChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(127, 44);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(40, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Sports:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(316, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 251);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.ck_bx_voleybol);
            this.Controls.Add(this.ck_bx_box);
            this.Controls.Add(this.ck_bx_basketbol);
            this.Controls.Add(this.ck_bx_futbol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ck_bx_futbol;
        private System.Windows.Forms.CheckBox ck_bx_basketbol;
        private System.Windows.Forms.CheckBox ck_bx_box;
        private System.Windows.Forms.CheckBox ck_bx_voleybol;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ListBox listBox1;
    }
}

