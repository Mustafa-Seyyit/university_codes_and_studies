namespace WindowsFormsApp4
{
    partial class FormZarOyunu
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
            this.pbDice1 = new System.Windows.Forms.PictureBox();
            this.lblPlayerStatus = new System.Windows.Forms.Label();
            this.lblP2TotalScore = new System.Windows.Forms.Label();
            this.lblP1TotalScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pbDice2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnP2Roll = new System.Windows.Forms.Button();
            this.lblP2Score = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerDice = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblP2Dice2 = new System.Windows.Forms.Label();
            this.lblP2Dice1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnP1Roll = new System.Windows.Forms.Button();
            this.lblP1Score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblP1Dice2 = new System.Windows.Forms.Label();
            this.lblP1Dice1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDice1
            // 
            this.pbDice1.Image = global::WindowsFormsApp4.Properties.Resources.dice1;
            this.pbDice1.Location = new System.Drawing.Point(574, 73);
            this.pbDice1.Name = "pbDice1";
            this.pbDice1.Size = new System.Drawing.Size(146, 123);
            this.pbDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDice1.TabIndex = 5;
            this.pbDice1.TabStop = false;
            // 
            // lblPlayerStatus
            // 
            this.lblPlayerStatus.AutoSize = true;
            this.lblPlayerStatus.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayerStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lblPlayerStatus.Location = new System.Drawing.Point(21, 597);
            this.lblPlayerStatus.Name = "lblPlayerStatus";
            this.lblPlayerStatus.Size = new System.Drawing.Size(99, 28);
            this.lblPlayerStatus.TabIndex = 6;
            this.lblPlayerStatus.Text = "Player-1";
            // 
            // lblP2TotalScore
            // 
            this.lblP2TotalScore.AutoSize = true;
            this.lblP2TotalScore.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblP2TotalScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblP2TotalScore.Location = new System.Drawing.Point(131, 134);
            this.lblP2TotalScore.Name = "lblP2TotalScore";
            this.lblP2TotalScore.Size = new System.Drawing.Size(24, 26);
            this.lblP2TotalScore.TabIndex = 0;
            this.lblP2TotalScore.Text = "0";
            // 
            // lblP1TotalScore
            // 
            this.lblP1TotalScore.AutoSize = true;
            this.lblP1TotalScore.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblP1TotalScore.ForeColor = System.Drawing.Color.White;
            this.lblP1TotalScore.Location = new System.Drawing.Point(131, 82);
            this.lblP1TotalScore.Name = "lblP1TotalScore";
            this.lblP1TotalScore.Size = new System.Drawing.Size(24, 26);
            this.lblP1TotalScore.TabIndex = 0;
            this.lblP1TotalScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(17, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Player-2 : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(17, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Player-1 : ";
            // 
            // pbDice2
            // 
            this.pbDice2.Image = global::WindowsFormsApp4.Properties.Resources.dice2;
            this.pbDice2.Location = new System.Drawing.Point(750, 73);
            this.pbDice2.Name = "pbDice2";
            this.pbDice2.Size = new System.Drawing.Size(146, 123);
            this.pbDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDice2.TabIndex = 7;
            this.pbDice2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.lblP2TotalScore);
            this.groupBox3.Controls.Add(this.lblP1TotalScore);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(574, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 263);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Score Ranking";
            // 
            // btnP2Roll
            // 
            this.btnP2Roll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnP2Roll.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnP2Roll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnP2Roll.Location = new System.Drawing.Point(21, 176);
            this.btnP2Roll.Name = "btnP2Roll";
            this.btnP2Roll.Size = new System.Drawing.Size(310, 68);
            this.btnP2Roll.TabIndex = 2;
            this.btnP2Roll.Text = "Roll The Dice";
            this.btnP2Roll.UseVisualStyleBackColor = false;
            this.btnP2Roll.Click += new System.EventHandler(this.btnP2Roll_Click);
            // 
            // lblP2Score
            // 
            this.lblP2Score.AutoSize = true;
            this.lblP2Score.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblP2Score.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblP2Score.Location = new System.Drawing.Point(179, 120);
            this.lblP2Score.Name = "lblP2Score";
            this.lblP2Score.Size = new System.Drawing.Size(25, 28);
            this.lblP2Score.TabIndex = 1;
            this.lblP2Score.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(15, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Score: ";
            // 
            // timerDice
            // 
            this.timerDice.Tick += new System.EventHandler(this.timerDice_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dice-1: ";
            // 
            // lblP2Dice2
            // 
            this.lblP2Dice2.AutoSize = true;
            this.lblP2Dice2.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblP2Dice2.ForeColor = System.Drawing.Color.Red;
            this.lblP2Dice2.Location = new System.Drawing.Point(237, 51);
            this.lblP2Dice2.Name = "lblP2Dice2";
            this.lblP2Dice2.Size = new System.Drawing.Size(17, 24);
            this.lblP2Dice2.TabIndex = 0;
            this.lblP2Dice2.Text = "-";
            // 
            // lblP2Dice1
            // 
            this.lblP2Dice1.AutoSize = true;
            this.lblP2Dice1.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblP2Dice1.ForeColor = System.Drawing.Color.Red;
            this.lblP2Dice1.Location = new System.Drawing.Point(96, 51);
            this.lblP2Dice1.Name = "lblP2Dice1";
            this.lblP2Dice1.Size = new System.Drawing.Size(17, 24);
            this.lblP2Dice1.TabIndex = 0;
            this.lblP2Dice1.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(158, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dice-2: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Dice-1: ";
            // 
            // btnP1Roll
            // 
            this.btnP1Roll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnP1Roll.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnP1Roll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnP1Roll.Location = new System.Drawing.Point(21, 176);
            this.btnP1Roll.Name = "btnP1Roll";
            this.btnP1Roll.Size = new System.Drawing.Size(310, 68);
            this.btnP1Roll.TabIndex = 2;
            this.btnP1Roll.Text = "Roll The Dice";
            this.btnP1Roll.UseVisualStyleBackColor = false;
            this.btnP1Roll.Click += new System.EventHandler(this.btnP1Roll_Click);
            // 
            // lblP1Score
            // 
            this.lblP1Score.AutoSize = true;
            this.lblP1Score.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblP1Score.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblP1Score.Location = new System.Drawing.Point(179, 120);
            this.lblP1Score.Name = "lblP1Score";
            this.lblP1Score.Size = new System.Drawing.Size(25, 28);
            this.lblP1Score.TabIndex = 1;
            this.lblP1Score.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total Score  :";
            // 
            // lblP1Dice2
            // 
            this.lblP1Dice2.AutoSize = true;
            this.lblP1Dice2.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblP1Dice2.ForeColor = System.Drawing.Color.Red;
            this.lblP1Dice2.Location = new System.Drawing.Point(237, 51);
            this.lblP1Dice2.Name = "lblP1Dice2";
            this.lblP1Dice2.Size = new System.Drawing.Size(17, 24);
            this.lblP1Dice2.TabIndex = 0;
            this.lblP1Dice2.Text = "-";
            // 
            // lblP1Dice1
            // 
            this.lblP1Dice1.AutoSize = true;
            this.lblP1Dice1.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblP1Dice1.ForeColor = System.Drawing.Color.Red;
            this.lblP1Dice1.Location = new System.Drawing.Point(96, 51);
            this.lblP1Dice1.Name = "lblP1Dice1";
            this.lblP1Dice1.Size = new System.Drawing.Size(17, 24);
            this.lblP1Dice1.TabIndex = 0;
            this.lblP1Dice1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(158, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dice-2: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Green;
            this.groupBox2.Controls.Add(this.btnP2Roll);
            this.groupBox2.Controls.Add(this.lblP2Score);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblP2Dice2);
            this.groupBox2.Controls.Add(this.lblP2Dice1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(26, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 263);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player-2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnP1Roll);
            this.groupBox1.Controls.Add(this.lblP1Score);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblP1Dice2);
            this.groupBox1.Controls.Add(this.lblP1Dice1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 263);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player-1";
            // 
            // FormZarOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(935, 653);
            this.Controls.Add(this.pbDice1);
            this.Controls.Add(this.lblPlayerStatus);
            this.Controls.Add(this.pbDice2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormZarOyunu";
            this.Text = "FormZarOyunu";
            this.Load += new System.EventHandler(this.FormZarOyunu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbDice1;
        private System.Windows.Forms.Label lblPlayerStatus;
        private System.Windows.Forms.Label lblP2TotalScore;
        private System.Windows.Forms.Label lblP1TotalScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbDice2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblP2Score;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerDice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblP2Dice2;
        private System.Windows.Forms.Label lblP2Dice1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnP1Roll;
        private System.Windows.Forms.Label lblP1Score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblP1Dice2;
        private System.Windows.Forms.Label lblP1Dice1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnP2Roll;
    }
}