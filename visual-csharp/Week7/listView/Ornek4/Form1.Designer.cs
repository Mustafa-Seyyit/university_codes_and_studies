namespace Ornek4
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
            this.tx_bx_id = new System.Windows.Forms.TextBox();
            this.tx_bx_firstname = new System.Windows.Forms.TextBox();
            this.tx_be_lastname = new System.Windows.Forms.TextBox();
            this.tx_bx_age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.btn_removeuser = new System.Windows.Forms.Button();
            this.btn_loaduser = new System.Windows.Forms.Button();
            this.btn_saveUAF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_bx_id
            // 
            this.tx_bx_id.Location = new System.Drawing.Point(109, 12);
            this.tx_bx_id.Name = "tx_bx_id";
            this.tx_bx_id.Size = new System.Drawing.Size(100, 20);
            this.tx_bx_id.TabIndex = 0;
            // 
            // tx_bx_firstname
            // 
            this.tx_bx_firstname.Location = new System.Drawing.Point(109, 47);
            this.tx_bx_firstname.Name = "tx_bx_firstname";
            this.tx_bx_firstname.Size = new System.Drawing.Size(100, 20);
            this.tx_bx_firstname.TabIndex = 1;
            // 
            // tx_be_lastname
            // 
            this.tx_be_lastname.Location = new System.Drawing.Point(109, 83);
            this.tx_be_lastname.Name = "tx_be_lastname";
            this.tx_be_lastname.Size = new System.Drawing.Size(100, 20);
            this.tx_be_lastname.TabIndex = 2;
            // 
            // tx_bx_age
            // 
            this.tx_bx_age.Location = new System.Drawing.Point(109, 119);
            this.tx_bx_age.Name = "tx_bx_age";
            this.tx_bx_age.Size = new System.Drawing.Size(100, 20);
            this.tx_bx_age.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 192);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(773, 246);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_adduser
            // 
            this.btn_adduser.Location = new System.Drawing.Point(15, 145);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(181, 41);
            this.btn_adduser.TabIndex = 9;
            this.btn_adduser.Text = "Add User";
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // btn_removeuser
            // 
            this.btn_removeuser.Location = new System.Drawing.Point(202, 145);
            this.btn_removeuser.Name = "btn_removeuser";
            this.btn_removeuser.Size = new System.Drawing.Size(181, 41);
            this.btn_removeuser.TabIndex = 10;
            this.btn_removeuser.Text = "Remove User";
            this.btn_removeuser.UseVisualStyleBackColor = true;
            this.btn_removeuser.Click += new System.EventHandler(this.btn_removeuser_Click);
            // 
            // btn_loaduser
            // 
            this.btn_loaduser.Location = new System.Drawing.Point(607, 145);
            this.btn_loaduser.Name = "btn_loaduser";
            this.btn_loaduser.Size = new System.Drawing.Size(181, 41);
            this.btn_loaduser.TabIndex = 11;
            this.btn_loaduser.Text = "Load User";
            this.btn_loaduser.UseVisualStyleBackColor = true;
            this.btn_loaduser.Click += new System.EventHandler(this.btn_loaduser_Click);
            // 
            // btn_saveUAF
            // 
            this.btn_saveUAF.Location = new System.Drawing.Point(420, 145);
            this.btn_saveUAF.Name = "btn_saveUAF";
            this.btn_saveUAF.Size = new System.Drawing.Size(181, 41);
            this.btn_saveUAF.TabIndex = 12;
            this.btn_saveUAF.Text = "Save User As File";
            this.btn_saveUAF.UseVisualStyleBackColor = true;
            this.btn_saveUAF.Click += new System.EventHandler(this.btn_saveUAF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_saveUAF);
            this.Controls.Add(this.btn_loaduser);
            this.Controls.Add(this.btn_removeuser);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_bx_age);
            this.Controls.Add(this.tx_be_lastname);
            this.Controls.Add(this.tx_bx_firstname);
            this.Controls.Add(this.tx_bx_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_bx_id;
        private System.Windows.Forms.TextBox tx_bx_firstname;
        private System.Windows.Forms.TextBox tx_be_lastname;
        private System.Windows.Forms.TextBox tx_bx_age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.Button btn_removeuser;
        private System.Windows.Forms.Button btn_loaduser;
        private System.Windows.Forms.Button btn_saveUAF;
    }
}

