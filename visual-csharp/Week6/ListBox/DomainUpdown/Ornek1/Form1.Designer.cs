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
            this.dud_1 = new System.Windows.Forms.DomainUpDown();
            this.nup1 = new System.Windows.Forms.NumericUpDown();
            this.nup2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.lbl_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup2)).BeginInit();
            this.SuspendLayout();
            // 
            // dud_1
            // 
            this.dud_1.Location = new System.Drawing.Point(287, 91);
            this.dud_1.Name = "dud_1";
            this.dud_1.Size = new System.Drawing.Size(97, 20);
            this.dud_1.TabIndex = 0;
            this.dud_1.Text = "domainUpDown1";
            // 
            // nup1
            // 
            this.nup1.Location = new System.Drawing.Point(236, 91);
            this.nup1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nup1.Name = "nup1";
            this.nup1.Size = new System.Drawing.Size(45, 20);
            this.nup1.TabIndex = 1;
            // 
            // nup2
            // 
            this.nup2.Location = new System.Drawing.Point(399, 91);
            this.nup2.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nup2.Name = "nup2";
            this.nup2.Size = new System.Drawing.Size(62, 20);
            this.nup2.TabIndex = 2;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(173, 91);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(57, 13);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "Birth Date:";
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(176, 127);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(285, 47);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "doğum gününü getir";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(173, 208);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(57, 13);
            this.lbl_2.TabIndex = 5;
            this.lbl_2.Text = "Birth Date:";
            this.lbl_2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.nup2);
            this.Controls.Add(this.nup1);
            this.Controls.Add(this.dud_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dud_1;
        private System.Windows.Forms.NumericUpDown nup1;
        private System.Windows.Forms.NumericUpDown nup2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label lbl_2;
    }
}

