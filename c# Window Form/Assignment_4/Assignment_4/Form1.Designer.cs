
namespace Assignment_4
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
            this.grpHand = new System.Windows.Forms.GroupBox();
            this.lbl_NumberofCards = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblSuit = new System.Windows.Forms.Label();
            this.cmbSuit = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.cmbValue = new System.Windows.Forms.ComboBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpHand
            // 
            this.grpHand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHand.Location = new System.Drawing.Point(193, 12);
            this.grpHand.Name = "grpHand";
            this.grpHand.Size = new System.Drawing.Size(414, 328);
            this.grpHand.TabIndex = 0;
            this.grpHand.TabStop = false;
            this.grpHand.Text = "Hand";
            // 
            // lbl_NumberofCards
            // 
            this.lbl_NumberofCards.AutoSize = true;
            this.lbl_NumberofCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_NumberofCards.Location = new System.Drawing.Point(12, 50);
            this.lbl_NumberofCards.Name = "lbl_NumberofCards";
            this.lbl_NumberofCards.Size = new System.Drawing.Size(103, 13);
            this.lbl_NumberofCards.TabIndex = 1;
            this.lbl_NumberofCards.Text = "Number Of Cards";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(12, 66);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(169, 20);
            this.txtCount.TabIndex = 2;
            // 
            // lblSuit
            // 
            this.lblSuit.AutoSize = true;
            this.lblSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblSuit.Location = new System.Drawing.Point(12, 110);
            this.lblSuit.Name = "lblSuit";
            this.lblSuit.Size = new System.Drawing.Size(29, 13);
            this.lblSuit.TabIndex = 3;
            this.lblSuit.Text = "Suit";
            // 
            // cmbSuit
            // 
            this.cmbSuit.FormattingEnabled = true;
            this.cmbSuit.Location = new System.Drawing.Point(12, 126);
            this.cmbSuit.Name = "cmbSuit";
            this.cmbSuit.Size = new System.Drawing.Size(169, 21);
            this.cmbSuit.TabIndex = 4;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblValue.Location = new System.Drawing.Point(12, 176);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(39, 13);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Value";
            // 
            // cmbValue
            // 
            this.cmbValue.FormattingEnabled = true;
            this.cmbValue.Location = new System.Drawing.Point(12, 192);
            this.cmbValue.Name = "cmbValue";
            this.cmbValue.Size = new System.Drawing.Size(169, 21);
            this.cmbValue.TabIndex = 6;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 290);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 50);
            this.btnDraw.TabIndex = 7;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 352);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.cmbValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.cmbSuit);
            this.Controls.Add(this.lblSuit);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lbl_NumberofCards);
            this.Controls.Add(this.grpHand);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGuessingGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHand;
        private System.Windows.Forms.Label lbl_NumberofCards;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblSuit;
        private System.Windows.Forms.ComboBox cmbSuit;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ComboBox cmbValue;
        private System.Windows.Forms.Button btnDraw;
    }
}

