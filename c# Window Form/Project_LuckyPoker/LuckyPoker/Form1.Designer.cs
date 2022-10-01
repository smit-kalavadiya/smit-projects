
namespace LuckyPoker
{
    partial class Form1
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
            this.grpPlayerOne = new System.Windows.Forms.GroupBox();
            this.picDeckOne = new System.Windows.Forms.PictureBox();
            this.grpPlayerTwo = new System.Windows.Forms.GroupBox();
            this.picDeckTwo = new System.Windows.Forms.PictureBox();
            this.lblCardsLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeftCardsOne = new System.Windows.Forms.TextBox();
            this.txtLeftCardsTwo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOnePoints = new System.Windows.Forms.Label();
            this.lblTwoPoints = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPlayerOneBalance = new System.Windows.Forms.Label();
            this.lblPlayerTwoBalance = new System.Windows.Forms.Label();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDeckOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeckTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPlayerOne
            // 
            this.grpPlayerOne.BackColor = System.Drawing.Color.LimeGreen;
            this.grpPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayerOne.ForeColor = System.Drawing.Color.Black;
            this.grpPlayerOne.Location = new System.Drawing.Point(12, 129);
            this.grpPlayerOne.Name = "grpPlayerOne";
            this.grpPlayerOne.Size = new System.Drawing.Size(396, 480);
            this.grpPlayerOne.TabIndex = 0;
            this.grpPlayerOne.TabStop = false;
            this.grpPlayerOne.Text = "Player 1";
            this.grpPlayerOne.DragDrop += new System.Windows.Forms.DragEventHandler(this.grpPlayerOne_DragDrop);
            this.grpPlayerOne.DragEnter += new System.Windows.Forms.DragEventHandler(this.grpPlayerOne_DragEnter);
            // 
            // picDeckOne
            // 
            this.picDeckOne.Location = new System.Drawing.Point(414, 144);
            this.picDeckOne.Name = "picDeckOne";
            this.picDeckOne.Size = new System.Drawing.Size(83, 111);
            this.picDeckOne.TabIndex = 12;
            this.picDeckOne.TabStop = false;
            this.picDeckOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDeck_MouseDown);
            // 
            // grpPlayerTwo
            // 
            this.grpPlayerTwo.BackColor = System.Drawing.Color.LimeGreen;
            this.grpPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayerTwo.ForeColor = System.Drawing.Color.Black;
            this.grpPlayerTwo.Location = new System.Drawing.Point(592, 125);
            this.grpPlayerTwo.Name = "grpPlayerTwo";
            this.grpPlayerTwo.Size = new System.Drawing.Size(396, 484);
            this.grpPlayerTwo.TabIndex = 1;
            this.grpPlayerTwo.TabStop = false;
            this.grpPlayerTwo.Text = "Player 2";
            this.grpPlayerTwo.DragDrop += new System.Windows.Forms.DragEventHandler(this.grpPlayerTwo_DragDrop);
            this.grpPlayerTwo.DragEnter += new System.Windows.Forms.DragEventHandler(this.grpPlayerTwo_DragEnter);
            // 
            // picDeckTwo
            // 
            this.picDeckTwo.Location = new System.Drawing.Point(503, 144);
            this.picDeckTwo.Name = "picDeckTwo";
            this.picDeckTwo.Size = new System.Drawing.Size(83, 111);
            this.picDeckTwo.TabIndex = 13;
            this.picDeckTwo.TabStop = false;
            this.picDeckTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDeckTwo_MouseDown);
            // 
            // lblCardsLeft
            // 
            this.lblCardsLeft.AutoSize = true;
            this.lblCardsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblCardsLeft.ForeColor = System.Drawing.Color.White;
            this.lblCardsLeft.Location = new System.Drawing.Point(135, 110);
            this.lblCardsLeft.Name = "lblCardsLeft";
            this.lblCardsLeft.Size = new System.Drawing.Size(69, 13);
            this.lblCardsLeft.TabIndex = 4;
            this.lblCardsLeft.Text = "Cards Left:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(745, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cards Left:";
            // 
            // txtLeftCardsOne
            // 
            this.txtLeftCardsOne.Location = new System.Drawing.Point(211, 106);
            this.txtLeftCardsOne.Name = "txtLeftCardsOne";
            this.txtLeftCardsOne.ReadOnly = true;
            this.txtLeftCardsOne.Size = new System.Drawing.Size(57, 20);
            this.txtLeftCardsOne.TabIndex = 6;
            this.txtLeftCardsOne.TabStop = false;
            this.txtLeftCardsOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLeftCardsTwo
            // 
            this.txtLeftCardsTwo.Location = new System.Drawing.Point(820, 103);
            this.txtLeftCardsTwo.Name = "txtLeftCardsTwo";
            this.txtLeftCardsTwo.ReadOnly = true;
            this.txtLeftCardsTwo.Size = new System.Drawing.Size(57, 20);
            this.txtLeftCardsTwo.TabIndex = 7;
            this.txtLeftCardsTwo.TabStop = false;
            this.txtLeftCardsTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Points";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(777, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Points";
            // 
            // lblOnePoints
            // 
            this.lblOnePoints.AutoSize = true;
            this.lblOnePoints.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnePoints.ForeColor = System.Drawing.Color.White;
            this.lblOnePoints.Location = new System.Drawing.Point(194, 31);
            this.lblOnePoints.Name = "lblOnePoints";
            this.lblOnePoints.Size = new System.Drawing.Size(0, 21);
            this.lblOnePoints.TabIndex = 10;
            // 
            // lblTwoPoints
            // 
            this.lblTwoPoints.AutoSize = true;
            this.lblTwoPoints.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoPoints.ForeColor = System.Drawing.Color.White;
            this.lblTwoPoints.Location = new System.Drawing.Point(815, 31);
            this.lblTwoPoints.Name = "lblTwoPoints";
            this.lblTwoPoints.Size = new System.Drawing.Size(0, 21);
            this.lblTwoPoints.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(135, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(744, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Balance:";
            // 
            // lblPlayerOneBalance
            // 
            this.lblPlayerOneBalance.AutoSize = true;
            this.lblPlayerOneBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneBalance.ForeColor = System.Drawing.Color.White;
            this.lblPlayerOneBalance.Location = new System.Drawing.Point(209, 78);
            this.lblPlayerOneBalance.Name = "lblPlayerOneBalance";
            this.lblPlayerOneBalance.Size = new System.Drawing.Size(0, 16);
            this.lblPlayerOneBalance.TabIndex = 14;
            // 
            // lblPlayerTwoBalance
            // 
            this.lblPlayerTwoBalance.AutoSize = true;
            this.lblPlayerTwoBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoBalance.ForeColor = System.Drawing.Color.White;
            this.lblPlayerTwoBalance.Location = new System.Drawing.Point(818, 78);
            this.lblPlayerTwoBalance.Name = "lblPlayerTwoBalance";
            this.lblPlayerTwoBalance.Size = new System.Drawing.Size(0, 16);
            this.lblPlayerTwoBalance.TabIndex = 15;
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtBetAmount.Location = new System.Drawing.Point(447, 31);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBetAmount.TabIndex = 16;
            this.txtBetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(449, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bet Amount";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(460, 57);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 27);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestart.Location = new System.Drawing.Point(460, 389);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 34);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShuffle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnShuffle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShuffle.Location = new System.Drawing.Point(460, 314);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 34);
            this.btnShuffle.TabIndex = 20;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1005, 667);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.picDeckTwo);
            this.Controls.Add(this.picDeckOne);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBetAmount);
            this.Controls.Add(this.lblPlayerTwoBalance);
            this.Controls.Add(this.lblPlayerOneBalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTwoPoints);
            this.Controls.Add(this.lblOnePoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLeftCardsTwo);
            this.Controls.Add(this.txtLeftCardsOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCardsLeft);
            this.Controls.Add(this.grpPlayerTwo);
            this.Controls.Add(this.grpPlayerOne);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Poker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDeckOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeckTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlayerOne;
        private System.Windows.Forms.GroupBox grpPlayerTwo;
        private System.Windows.Forms.Label lblCardsLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeftCardsOne;
        private System.Windows.Forms.TextBox txtLeftCardsTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOnePoints;
        private System.Windows.Forms.Label lblTwoPoints;
        private System.Windows.Forms.PictureBox picDeckOne;
        private System.Windows.Forms.PictureBox picDeckTwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPlayerOneBalance;
        private System.Windows.Forms.Label lblPlayerTwoBalance;
        private System.Windows.Forms.TextBox txtBetAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnShuffle;
    }
}

