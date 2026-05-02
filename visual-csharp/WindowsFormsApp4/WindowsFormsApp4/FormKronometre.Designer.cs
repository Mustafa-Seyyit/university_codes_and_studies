namespace WindowsFormsApp4
{
    partial class FormKronometre
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKronometre));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lstSureler = new System.Windows.Forms.ListBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSalise = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.timerKronometre = new System.Windows.Forms.Timer(this.components);
            this.lblAnikTarih = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.lblAnlikSaat = new System.Windows.Forms.Label();
            this.timerTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 343);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblBaslik);
            this.tabPage2.Controls.Add(this.lstSureler);
            this.tabPage2.Controls.Add(this.btnTransfer);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.btnPause);
            this.tabPage2.Controls.Add(this.btnBasla);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblSalise);
            this.tabPage2.Controls.Add(this.lblSaniye);
            this.tabPage2.Controls.Add(this.lblDakika);
            this.tabPage2.Controls.Add(this.lblSaat);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kronometre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(21, 212);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(262, 25);
            this.lblBaslik.TabIndex = 17;
            this.lblBaslik.Text = "Kronometre Uygulaması";
            // 
            // lstSureler
            // 
            this.lstSureler.FormattingEnabled = true;
            this.lstSureler.Location = new System.Drawing.Point(427, 22);
            this.lstSureler.Name = "lstSureler";
            this.lstSureler.Size = new System.Drawing.Size(177, 199);
            this.lstSureler.TabIndex = 16;
            // 
            // btnTransfer
            // 
            this.btnTransfer.ImageKey = "Icojam-Blue-Bits-Arrow-right.256.png";
            this.btnTransfer.ImageList = this.ımageList1;
            this.btnTransfer.Location = new System.Drawing.Point(347, 22);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(50, 50);
            this.btnTransfer.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnTransfer, "Skor Al");
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Button-Play-icon.png");
            this.ımageList1.Images.SetKeyName(1, "Custom-Icon-Design-Pretty-Office-8-Stop.256.png");
            this.ımageList1.Images.SetKeyName(2, "Hopstarter-Button-Button-Pause.256.png");
            this.ımageList1.Images.SetKeyName(3, "Icojam-Blue-Bits-Arrow-right.256.png");
            this.ımageList1.Images.SetKeyName(4, "replay-icon.png");
            this.ımageList1.Images.SetKeyName(5, "Save-as-icon.png");
            this.ımageList1.Images.SetKeyName(6, "Hopstarter-Sleek-Xp-Software-Windows-Close-Program.256.png");
            // 
            // btnSave
            // 
            this.btnSave.ImageKey = "Save-as-icon.png";
            this.btnSave.ImageList = this.ımageList1;
            this.btnSave.Location = new System.Drawing.Point(211, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnSave, "Kaydet");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.ImageKey = "replay-icon.png";
            this.btnReset.ImageList = this.ımageList1;
            this.btnReset.Location = new System.Drawing.Point(142, 118);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 50);
            this.btnReset.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnReset, "Sıfırla");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.ImageKey = "Custom-Icon-Design-Pretty-Office-8-Stop.256.png";
            this.btnPause.ImageList = this.ımageList1;
            this.btnPause.Location = new System.Drawing.Point(75, 118);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 50);
            this.btnPause.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnPause, "Duraklat");
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.ImageKey = "Button-Play-icon.png";
            this.btnBasla.ImageList = this.ımageList1;
            this.btnBasla.Location = new System.Drawing.Point(7, 118);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(50, 50);
            this.btnBasla.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnBasla, "Başla");
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(160, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(100, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(46, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // lblSalise
            // 
            this.lblSalise.AutoSize = true;
            this.lblSalise.Location = new System.Drawing.Point(186, 68);
            this.lblSalise.Name = "lblSalise";
            this.lblSalise.Size = new System.Drawing.Size(19, 13);
            this.lblSalise.TabIndex = 7;
            this.lblSalise.Text = "00";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Location = new System.Drawing.Point(133, 67);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(19, 13);
            this.lblSaniye.TabIndex = 6;
            this.lblSaniye.Text = "00";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Location = new System.Drawing.Point(72, 67);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(19, 13);
            this.lblDakika.TabIndex = 5;
            this.lblDakika.Text = "00";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(21, 67);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(19, 13);
            this.lblSaat.TabIndex = 4;
            this.lblSaat.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(180, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(124, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saniye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dakika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saat";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 317);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "GeriSayım";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // timerKronometre
            // 
            this.timerKronometre.Interval = 1;
            this.timerKronometre.Tick += new System.EventHandler(this.timerKronometre_Tick);
            // 
            // lblAnikTarih
            // 
            this.lblAnikTarih.AutoSize = true;
            this.lblAnikTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnikTarih.Location = new System.Drawing.Point(23, 403);
            this.lblAnikTarih.Name = "lblAnikTarih";
            this.lblAnikTarih.Size = new System.Drawing.Size(47, 16);
            this.lblAnikTarih.TabIndex = 9;
            this.lblAnikTarih.Text = "Tarih:";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.ImageKey = "Hopstarter-Sleek-Xp-Software-Windows-Close-Program.256.png";
            this.buttonExit.ImageList = this.ımageList1;
            this.buttonExit.Location = new System.Drawing.Point(601, 384);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 50);
            this.buttonExit.TabIndex = 11;
            this.toolTip1.SetToolTip(this.buttonExit, "Çıkış");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // lblAnlikSaat
            // 
            this.lblAnlikSaat.AutoSize = true;
            this.lblAnlikSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnlikSaat.Location = new System.Drawing.Point(339, 400);
            this.lblAnlikSaat.Name = "lblAnlikSaat";
            this.lblAnlikSaat.Size = new System.Drawing.Size(43, 16);
            this.lblAnlikSaat.TabIndex = 10;
            this.lblAnlikSaat.Text = "Saat:";
            // 
            // timerTarihSaat
            // 
            this.timerTarihSaat.Interval = 10;
            this.timerTarihSaat.Tick += new System.EventHandler(this.timerTarihSaat_Tick);
            // 
            // FormKronometre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 425);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblAnikTarih);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.lblAnlikSaat);
            this.Name = "FormKronometre";
            this.Text = "FormKronometre";
            this.Load += new System.EventHandler(this.FormKronometre_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.ListBox lstSureler;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSalise;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Timer timerKronometre;
        private System.Windows.Forms.Label lblAnikTarih;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label lblAnlikSaat;
        private System.Windows.Forms.Timer timerTarihSaat;
    }
}