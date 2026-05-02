namespace LabSorusu
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
            this.tx_bx_Email = new System.Windows.Forms.TextBox();
            this.lbl_EMail = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tx_bx_Password = new System.Windows.Forms.TextBox();
            this.btn_signin = new System.Windows.Forms.Button();
            this.grp_bx_signin = new System.Windows.Forms.GroupBox();
            this.cmb_bx = new System.Windows.Forms.ComboBox();
            this.lst_bx = new System.Windows.Forms.ListBox();
            this.grp_bx_userlist = new System.Windows.Forms.GroupBox();
            this.grp_bx_signin.SuspendLayout();
            this.grp_bx_userlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_bx_Email
            // 
            this.tx_bx_Email.Location = new System.Drawing.Point(87, 29);
            this.tx_bx_Email.Name = "tx_bx_Email";
            this.tx_bx_Email.Size = new System.Drawing.Size(100, 20);
            this.tx_bx_Email.TabIndex = 0;
            // 
            // lbl_EMail
            // 
            this.lbl_EMail.AutoSize = true;
            this.lbl_EMail.Location = new System.Drawing.Point(33, 29);
            this.lbl_EMail.Name = "lbl_EMail";
            this.lbl_EMail.Size = new System.Drawing.Size(39, 13);
            this.lbl_EMail.TabIndex = 1;
            this.lbl_EMail.Text = "E-Mail:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(33, 70);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // tx_bx_Password
            // 
            this.tx_bx_Password.Location = new System.Drawing.Point(87, 70);
            this.tx_bx_Password.Name = "tx_bx_Password";
            this.tx_bx_Password.Size = new System.Drawing.Size(100, 20);
            this.tx_bx_Password.TabIndex = 2;
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(36, 118);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(151, 33);
            this.btn_signin.TabIndex = 4;
            this.btn_signin.Text = "Sign in";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // grp_bx_signin
            // 
            this.grp_bx_signin.Controls.Add(this.tx_bx_Password);
            this.grp_bx_signin.Controls.Add(this.btn_signin);
            this.grp_bx_signin.Controls.Add(this.tx_bx_Email);
            this.grp_bx_signin.Controls.Add(this.lbl_Password);
            this.grp_bx_signin.Controls.Add(this.lbl_EMail);
            this.grp_bx_signin.Location = new System.Drawing.Point(31, 48);
            this.grp_bx_signin.Name = "grp_bx_signin";
            this.grp_bx_signin.Size = new System.Drawing.Size(258, 214);
            this.grp_bx_signin.TabIndex = 5;
            this.grp_bx_signin.TabStop = false;
            this.grp_bx_signin.Text = "Sign in";
            // 
            // cmb_bx
            // 
            this.cmb_bx.FormattingEnabled = true;
            this.cmb_bx.Location = new System.Drawing.Point(10, 29);
            this.cmb_bx.Name = "cmb_bx";
            this.cmb_bx.Size = new System.Drawing.Size(121, 21);
            this.cmb_bx.TabIndex = 6;
            this.cmb_bx.SelectedIndexChanged += new System.EventHandler(this.cmb_bx_SelectedIndexChanged);
            // 
            // lst_bx
            // 
            this.lst_bx.FormattingEnabled = true;
            this.lst_bx.Location = new System.Drawing.Point(158, 29);
            this.lst_bx.Name = "lst_bx";
            this.lst_bx.Size = new System.Drawing.Size(173, 134);
            this.lst_bx.TabIndex = 7;
            // 
            // grp_bx_userlist
            // 
            this.grp_bx_userlist.Controls.Add(this.lst_bx);
            this.grp_bx_userlist.Controls.Add(this.cmb_bx);
            this.grp_bx_userlist.Location = new System.Drawing.Point(427, 48);
            this.grp_bx_userlist.Name = "grp_bx_userlist";
            this.grp_bx_userlist.Size = new System.Drawing.Size(337, 214);
            this.grp_bx_userlist.TabIndex = 8;
            this.grp_bx_userlist.TabStop = false;
            this.grp_bx_userlist.Text = "User list";
            this.grp_bx_userlist.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_bx_userlist);
            this.Controls.Add(this.grp_bx_signin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_bx_signin.ResumeLayout(false);
            this.grp_bx_signin.PerformLayout();
            this.grp_bx_userlist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tx_bx_Email;
        private System.Windows.Forms.Label lbl_EMail;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tx_bx_Password;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.GroupBox grp_bx_signin;
        private System.Windows.Forms.ComboBox cmb_bx;
        private System.Windows.Forms.ListBox lst_bx;
        private System.Windows.Forms.GroupBox grp_bx_userlist;
    }
}

