namespace ProjectFifa
{
    partial class betForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bettorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inzetNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.betsOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.matchComboBox = new System.Windows.Forms.ComboBox();
            this.betterBalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inzetNumbericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.betterBalLabel);
            this.groupBox1.Controls.Add(this.matchComboBox);
            this.groupBox1.Controls.Add(this.bettorComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.teamComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inzetNumbericUpDown);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.betsOn);
            this.groupBox1.Location = new System.Drawing.Point(16, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 205);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // bettorComboBox
            // 
            this.bettorComboBox.FormattingEnabled = true;
            this.bettorComboBox.Location = new System.Drawing.Point(73, 19);
            this.bettorComboBox.Name = "bettorComboBox";
            this.bettorComboBox.Size = new System.Drawing.Size(203, 21);
            this.bettorComboBox.TabIndex = 11;
            this.bettorComboBox.SelectedIndexChanged += new System.EventHandler(this.bettorComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gokker:";
            // 
            // teamComboBox
            // 
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(96, 77);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(180, 21);
            this.teamComboBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hoeveel geld wilt u inzetten?";
            // 
            // inzetNumbericUpDown
            // 
            this.inzetNumbericUpDown.Location = new System.Drawing.Point(6, 136);
            this.inzetNumbericUpDown.Name = "inzetNumbericUpDown";
            this.inzetNumbericUpDown.Size = new System.Drawing.Size(89, 20);
            this.inzetNumbericUpDown.TabIndex = 12;
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(6, 162);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 9;
            this.betButton.Text = "Enter";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gok wie er wint.";
            // 
            // betsOn
            // 
            this.betsOn.AutoSize = true;
            this.betsOn.Location = new System.Drawing.Point(10, 50);
            this.betsOn.Name = "betsOn";
            this.betsOn.Size = new System.Drawing.Size(57, 13);
            this.betsOn.TabIndex = 1;
            this.betsOn.Text = "U gokt op:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gokken";
            // 
            // matchComboBox
            // 
            this.matchComboBox.FormattingEnabled = true;
            this.matchComboBox.Location = new System.Drawing.Point(73, 50);
            this.matchComboBox.Name = "matchComboBox";
            this.matchComboBox.Size = new System.Drawing.Size(203, 21);
            this.matchComboBox.TabIndex = 16;
            this.matchComboBox.SelectedIndexChanged += new System.EventHandler(this.matchComboBox_SelectedIndexChanged);
            // 
            // betterBalLabel
            // 
            this.betterBalLabel.AutoSize = true;
            this.betterBalLabel.Location = new System.Drawing.Point(201, 162);
            this.betterBalLabel.Name = "betterBalLabel";
            this.betterBalLabel.Size = new System.Drawing.Size(10, 13);
            this.betterBalLabel.TabIndex = 17;
            this.betterBalLabel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(195, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "My Balance:";
            // 
            // betForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 251);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "betForm";
            this.Text = "betForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inzetNumbericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label betsOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inzetNumbericUpDown;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.ComboBox bettorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox matchComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label betterBalLabel;
    }
}