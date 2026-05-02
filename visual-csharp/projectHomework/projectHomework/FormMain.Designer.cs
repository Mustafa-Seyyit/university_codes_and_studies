namespace ProjeOdev
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuIslemler = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOgrenci = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGrafik = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOgrenciGrafik = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.loglarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logKayıtlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuIslemler,
            this.menuGrafik,
            this.loglarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuIslemler
            // 
            this.menuIslemler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOgrenci});
            this.menuIslemler.Name = "menuIslemler";
            this.menuIslemler.Size = new System.Drawing.Size(60, 20);
            this.menuIslemler.Text = "İşlemler";
            // 
            // menuOgrenci
            // 
            this.menuOgrenci.Name = "menuOgrenci";
            this.menuOgrenci.Size = new System.Drawing.Size(180, 22);
            this.menuOgrenci.Text = "öğrenci işlemleri";
            this.menuOgrenci.Click += new System.EventHandler(this.menuOgrenci_Click);
            // 
            // menuGrafik
            // 
            this.menuGrafik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOgrenciGrafik});
            this.menuGrafik.Name = "menuGrafik";
            this.menuGrafik.Size = new System.Drawing.Size(63, 20);
            this.menuGrafik.Text = "Grafikler";
            // 
            // menuOgrenciGrafik
            // 
            this.menuOgrenciGrafik.Name = "menuOgrenciGrafik";
            this.menuOgrenciGrafik.Size = new System.Drawing.Size(180, 22);
            this.menuOgrenciGrafik.Text = "Öğrenci grafiği";
            this.menuOgrenciGrafik.Click += new System.EventHandler(this.menuOgrenciGrafik_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCikis});
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.Size = new System.Drawing.Size(180, 22);
            this.menuCikis.Text = "Çıkış Yap";
            this.menuCikis.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // loglarToolStripMenuItem
            // 
            this.loglarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logKayıtlarıToolStripMenuItem});
            this.loglarToolStripMenuItem.Name = "loglarToolStripMenuItem";
            this.loglarToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.loglarToolStripMenuItem.Text = "Loglar";
            // 
            // logKayıtlarıToolStripMenuItem
            // 
            this.logKayıtlarıToolStripMenuItem.Name = "logKayıtlarıToolStripMenuItem";
            this.logKayıtlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logKayıtlarıToolStripMenuItem.Text = "Log Kayıtları";
            this.logKayıtlarıToolStripMenuItem.Click += new System.EventHandler(this.logKayıtlarıToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuIslemler;
        private System.Windows.Forms.ToolStripMenuItem menuOgrenci;
        private System.Windows.Forms.ToolStripMenuItem menuGrafik;
        private System.Windows.Forms.ToolStripMenuItem menuOgrenciGrafik;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.ToolStripMenuItem loglarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logKayıtlarıToolStripMenuItem;
    }
}