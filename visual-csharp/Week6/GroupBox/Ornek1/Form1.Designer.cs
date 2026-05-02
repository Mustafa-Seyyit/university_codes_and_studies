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
            this.rb_lolipop = new System.Windows.Forms.RadioButton();
            this.rb_stikır = new System.Windows.Forms.RadioButton();
            this.rb_laptop = new System.Windows.Forms.RadioButton();
            this.rb_tablet = new System.Windows.Forms.RadioButton();
            this.rb_phone = new System.Windows.Forms.RadioButton();
            this.rb_germany = new System.Windows.Forms.RadioButton();
            this.rb_spain = new System.Windows.Forms.RadioButton();
            this.rb_usa = new System.Windows.Forms.RadioButton();
            this.rb_england = new System.Windows.Forms.RadioButton();
            this.rb_turkey = new System.Windows.Forms.RadioButton();
            this.grp_bx_gift = new System.Windows.Forms.GroupBox();
            this.grp_bx_nation = new System.Windows.Forms.GroupBox();
            this.lbl_secilenler = new System.Windows.Forms.Label();
            this.grp_bx_gift.SuspendLayout();
            this.grp_bx_nation.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_lolipop
            // 
            this.rb_lolipop.AutoSize = true;
            this.rb_lolipop.Location = new System.Drawing.Point(8, 19);
            this.rb_lolipop.Name = "rb_lolipop";
            this.rb_lolipop.Size = new System.Drawing.Size(55, 17);
            this.rb_lolipop.TabIndex = 0;
            this.rb_lolipop.TabStop = true;
            this.rb_lolipop.Text = "lolipop";
            this.rb_lolipop.UseVisualStyleBackColor = true;
            this.rb_lolipop.CheckedChanged += new System.EventHandler(this.radioButtons_checkedChanged);
            // 
            // rb_stikır
            // 
            this.rb_stikır.AutoSize = true;
            this.rb_stikır.Location = new System.Drawing.Point(6, 44);
            this.rb_stikır.Name = "rb_stikır";
            this.rb_stikır.Size = new System.Drawing.Size(46, 17);
            this.rb_stikır.TabIndex = 1;
            this.rb_stikır.TabStop = true;
            this.rb_stikır.Text = "stikır";
            this.rb_stikır.UseVisualStyleBackColor = true;
            this.rb_stikır.CheckedChanged += new System.EventHandler(this.radioButtons_checkedChanged);
            // 
            // rb_laptop
            // 
            this.rb_laptop.AutoSize = true;
            this.rb_laptop.Location = new System.Drawing.Point(6, 83);
            this.rb_laptop.Name = "rb_laptop";
            this.rb_laptop.Size = new System.Drawing.Size(54, 17);
            this.rb_laptop.TabIndex = 2;
            this.rb_laptop.TabStop = true;
            this.rb_laptop.Text = "laptop";
            this.rb_laptop.UseVisualStyleBackColor = true;
            this.rb_laptop.CheckedChanged += new System.EventHandler(this.radioButtons_checkedChanged);
            // 
            // rb_tablet
            // 
            this.rb_tablet.AutoSize = true;
            this.rb_tablet.Location = new System.Drawing.Point(6, 128);
            this.rb_tablet.Name = "rb_tablet";
            this.rb_tablet.Size = new System.Drawing.Size(51, 17);
            this.rb_tablet.TabIndex = 3;
            this.rb_tablet.TabStop = true;
            this.rb_tablet.Text = "tablet";
            this.rb_tablet.UseVisualStyleBackColor = true;
            this.rb_tablet.CheckedChanged += new System.EventHandler(this.radioButtons_checkedChanged);
            // 
            // rb_phone
            // 
            this.rb_phone.AutoSize = true;
            this.rb_phone.Location = new System.Drawing.Point(6, 166);
            this.rb_phone.Name = "rb_phone";
            this.rb_phone.Size = new System.Drawing.Size(57, 17);
            this.rb_phone.TabIndex = 4;
            this.rb_phone.TabStop = true;
            this.rb_phone.Text = "telefon";
            this.rb_phone.UseVisualStyleBackColor = true;
            this.rb_phone.CheckedChanged += new System.EventHandler(this.radioButtons_checkedChanged);
            // 
            // rb_germany
            // 
            this.rb_germany.AutoSize = true;
            this.rb_germany.Location = new System.Drawing.Point(37, 177);
            this.rb_germany.Name = "rb_germany";
            this.rb_germany.Size = new System.Drawing.Size(65, 17);
            this.rb_germany.TabIndex = 9;
            this.rb_germany.TabStop = true;
            this.rb_germany.Text = "germany";
            this.rb_germany.UseVisualStyleBackColor = true;
            this.rb_germany.CheckedChanged += new System.EventHandler(this.radioButtons_checkedChanged);
            // 
            // rb_spain
            // 
            this.rb_spain.AutoSize = true;
            this.rb_spain.Location = new System.Drawing.Point(37, 143);
            this.rb_spain.Name = "rb_spain";
            this.rb_spain.Size = new System.Drawing.Size(50, 17);
            this.rb_spain.TabIndex = 8;
            this.rb_spain.TabStop = true;
            this.rb_spain.Text = "spain";
            this.rb_spain.UseVisualStyleBackColor = true;
            this.rb_spain.CheckedChanged += new System.EventHandler(this.radioButtons_checkedChanged);
            // 
            // rb_usa
            // 
            this.rb_usa.AutoSize = true;
            this.rb_usa.Location = new System.Drawing.Point(37, 105);
            this.rb_usa.Name = "rb_usa";
            this.rb_usa.Size = new System.Drawing.Size(42, 17);
            this.rb_usa.TabIndex = 7;
            this.rb_usa.TabStop = true;
            this.rb_usa.Text = "usa";
            this.rb_usa.UseVisualStyleBackColor = true;
            this.rb_usa.CheckedChanged += new System.EventHandler(this.radioButtons_checkedChanged);
            // 
            // rb_england
            // 
            this.rb_england.AutoSize = true;
            this.rb_england.Location = new System.Drawing.Point(37, 60);
            this.rb_england.Name = "rb_england";
            this.rb_england.Size = new System.Drawing.Size(63, 17);
            this.rb_england.TabIndex = 6;
            this.rb_england.TabStop = true;
            this.rb_england.Text = "england";
            this.rb_england.UseVisualStyleBackColor = true;
            this.rb_england.CheckedChanged += new System.EventHandler(this.radioButtons_checkedChanged);
            // 
            // rb_turkey
            // 
            this.rb_turkey.AutoSize = true;
            this.rb_turkey.Location = new System.Drawing.Point(37, 19);
            this.rb_turkey.Name = "rb_turkey";
            this.rb_turkey.Size = new System.Drawing.Size(54, 17);
            this.rb_turkey.TabIndex = 5;
            this.rb_turkey.TabStop = true;
            this.rb_turkey.Text = "turkey";
            this.rb_turkey.UseVisualStyleBackColor = true;
            this.rb_turkey.CheckedChanged += new System.EventHandler(this.radioButtons_checkedChanged);
            // 
            // grp_bx_gift
            // 
            this.grp_bx_gift.Controls.Add(this.rb_lolipop);
            this.grp_bx_gift.Controls.Add(this.rb_stikır);
            this.grp_bx_gift.Controls.Add(this.rb_laptop);
            this.grp_bx_gift.Controls.Add(this.rb_tablet);
            this.grp_bx_gift.Controls.Add(this.rb_phone);
            this.grp_bx_gift.Location = new System.Drawing.Point(96, 56);
            this.grp_bx_gift.Name = "grp_bx_gift";
            this.grp_bx_gift.Size = new System.Drawing.Size(200, 209);
            this.grp_bx_gift.TabIndex = 10;
            this.grp_bx_gift.TabStop = false;
            this.grp_bx_gift.Text = "Gifts";
            // 
            // grp_bx_nation
            // 
            this.grp_bx_nation.Controls.Add(this.rb_turkey);
            this.grp_bx_nation.Controls.Add(this.rb_england);
            this.grp_bx_nation.Controls.Add(this.rb_germany);
            this.grp_bx_nation.Controls.Add(this.rb_usa);
            this.grp_bx_nation.Controls.Add(this.rb_spain);
            this.grp_bx_nation.Location = new System.Drawing.Point(465, 56);
            this.grp_bx_nation.Name = "grp_bx_nation";
            this.grp_bx_nation.Size = new System.Drawing.Size(200, 200);
            this.grp_bx_nation.TabIndex = 11;
            this.grp_bx_nation.TabStop = false;
            this.grp_bx_nation.Text = "nation";
            // 
            // lbl_secilenler
            // 
            this.lbl_secilenler.AutoSize = true;
            this.lbl_secilenler.Location = new System.Drawing.Point(93, 324);
            this.lbl_secilenler.Name = "lbl_secilenler";
            this.lbl_secilenler.Size = new System.Drawing.Size(0, 13);
            this.lbl_secilenler.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_secilenler);
            this.Controls.Add(this.grp_bx_nation);
            this.Controls.Add(this.grp_bx_gift);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_bx_gift.ResumeLayout(false);
            this.grp_bx_gift.PerformLayout();
            this.grp_bx_nation.ResumeLayout(false);
            this.grp_bx_nation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_lolipop;
        private System.Windows.Forms.RadioButton rb_stikır;
        private System.Windows.Forms.RadioButton rb_laptop;
        private System.Windows.Forms.RadioButton rb_tablet;
        private System.Windows.Forms.RadioButton rb_phone;
        private System.Windows.Forms.RadioButton rb_germany;
        private System.Windows.Forms.RadioButton rb_spain;
        private System.Windows.Forms.RadioButton rb_usa;
        private System.Windows.Forms.RadioButton rb_england;
        private System.Windows.Forms.RadioButton rb_turkey;
        private System.Windows.Forms.GroupBox grp_bx_gift;
        private System.Windows.Forms.GroupBox grp_bx_nation;
        private System.Windows.Forms.Label lbl_secilenler;
    }
}

