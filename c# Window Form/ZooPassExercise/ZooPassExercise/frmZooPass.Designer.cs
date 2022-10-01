namespace ZooPassExercise
{
    partial class frmZooPass
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddPass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemovePass = new System.Windows.Forms.Button();
            this.lblNumPasses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPasses = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoAdult = new System.Windows.Forms.RadioButton();
            this.rdoChild = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMonkeyShow = new System.Windows.Forms.CheckBox();
            this.chkTrainor = new System.Windows.Forms.CheckBox();
            this.chkVip = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPassLength = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(204, 451);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 27);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddPass
            // 
            this.btnAddPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPass.Location = new System.Drawing.Point(382, 107);
            this.btnAddPass.Name = "btnAddPass";
            this.btnAddPass.Size = new System.Drawing.Size(86, 27);
            this.btnAddPass.TabIndex = 28;
            this.btnAddPass.Text = "Add";
            this.btnAddPass.UseVisualStyleBackColor = true;
            this.btnAddPass.Click += new System.EventHandler(this.btnAddPass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pass Length";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(142, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 27);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRemovePass
            // 
            this.btnRemovePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePass.Location = new System.Drawing.Point(50, 373);
            this.btnRemovePass.Name = "btnRemovePass";
            this.btnRemovePass.Size = new System.Drawing.Size(86, 27);
            this.btnRemovePass.TabIndex = 25;
            this.btnRemovePass.Text = "Remove";
            this.btnRemovePass.UseVisualStyleBackColor = true;
            this.btnRemovePass.Click += new System.EventHandler(this.Item_Remove);
            // 
            // lblNumPasses
            // 
            this.lblNumPasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumPasses.Location = new System.Drawing.Point(382, 379);
            this.lblNumPasses.Name = "lblNumPasses";
            this.lblNumPasses.Size = new System.Drawing.Size(66, 23);
            this.lblNumPasses.TabIndex = 23;
            this.lblNumPasses.Text = "0";
            this.lblNumPasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Passes";
            // 
            // lstPasses
            // 
            this.lstPasses.FormattingEnabled = true;
            this.lstPasses.Location = new System.Drawing.Point(50, 252);
            this.lstPasses.Name = "lstPasses";
            this.lstPasses.Size = new System.Drawing.Size(398, 108);
            this.lstPasses.TabIndex = 20;
            this.lstPasses.DoubleClick += new System.EventHandler(this.Item_Remove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoAdult);
            this.groupBox2.Controls.Add(this.rdoChild);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(55, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 96);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Checked = true;
            this.rdoAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdult.Location = new System.Drawing.Point(24, 60);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(58, 21);
            this.rdoAdult.TabIndex = 1;
            this.rdoAdult.TabStop = true;
            this.rdoAdult.Text = "Adult";
            this.rdoAdult.UseVisualStyleBackColor = true;
            // 
            // rdoChild
            // 
            this.rdoChild.AutoSize = true;
            this.rdoChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChild.Location = new System.Drawing.Point(24, 27);
            this.rdoChild.Name = "rdoChild";
            this.rdoChild.Size = new System.Drawing.Size(57, 21);
            this.rdoChild.TabIndex = 0;
            this.rdoChild.Text = "Child";
            this.rdoChild.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMonkeyShow);
            this.groupBox1.Controls.Add(this.chkTrainor);
            this.groupBox1.Controls.Add(this.chkVip);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(183, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 126);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkMonkeyShow
            // 
            this.chkMonkeyShow.AutoSize = true;
            this.chkMonkeyShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonkeyShow.Location = new System.Drawing.Point(21, 86);
            this.chkMonkeyShow.Name = "chkMonkeyShow";
            this.chkMonkeyShow.Size = new System.Drawing.Size(114, 21);
            this.chkMonkeyShow.TabIndex = 2;
            this.chkMonkeyShow.Text = "Monkey Show";
            this.chkMonkeyShow.UseVisualStyleBackColor = true;
            // 
            // chkTrainor
            // 
            this.chkTrainor.AutoSize = true;
            this.chkTrainor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrainor.Location = new System.Drawing.Point(21, 57);
            this.chkTrainor.Name = "chkTrainor";
            this.chkTrainor.Size = new System.Drawing.Size(132, 21);
            this.chkTrainor.TabIndex = 1;
            this.chkTrainor.Text = "Meet the Trainor";
            this.chkTrainor.UseVisualStyleBackColor = true;
            // 
            // chkVip
            // 
            this.chkVip.AutoSize = true;
            this.chkVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVip.Location = new System.Drawing.Point(21, 31);
            this.chkVip.Name = "chkVip";
            this.chkVip.Size = new System.Drawing.Size(48, 21);
            this.chkVip.TabIndex = 0;
            this.chkVip.Text = "VIP";
            this.chkVip.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "# of Passes:";
            // 
            // cboPassLength
            // 
            this.cboPassLength.FormattingEnabled = true;
            this.cboPassLength.Location = new System.Drawing.Point(50, 97);
            this.cboPassLength.Name = "cboPassLength";
            this.cboPassLength.Size = new System.Drawing.Size(121, 21);
            this.cboPassLength.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Zoo Pass Purchase";
            // 
            // frmZooPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 507);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRemovePass);
            this.Controls.Add(this.lblNumPasses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPasses);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPassLength);
            this.Controls.Add(this.label1);
            this.Name = "frmZooPass";
            this.Text = "Zoo Pass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmZooPass_FormClosing);
            this.Load += new System.EventHandler(this.frmZooPass_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRemovePass;
        private System.Windows.Forms.Label lblNumPasses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPasses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.RadioButton rdoChild;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMonkeyShow;
        private System.Windows.Forms.CheckBox chkTrainor;
        private System.Windows.Forms.CheckBox chkVip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPassLength;
        private System.Windows.Forms.Label label1;
    }
}

