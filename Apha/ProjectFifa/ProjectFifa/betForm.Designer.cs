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
            this.betButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.betScoreAmount = new System.Windows.Forms.Label();
            this.teamBetLabel = new System.Windows.Forms.Label();
            this.teamBetDomain = new System.Windows.Forms.DomainUpDown();
            this.betScoreTextBox = new System.Windows.Forms.TextBox();
            this.betMatchLabel = new System.Windows.Forms.Label();
            this.betsOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.betScoreAmount);
            this.groupBox1.Controls.Add(this.teamBetLabel);
            this.groupBox1.Controls.Add(this.teamBetDomain);
            this.groupBox1.Controls.Add(this.betScoreTextBox);
            this.groupBox1.Controls.Add(this.betMatchLabel);
            this.groupBox1.Controls.Add(this.betsOn);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 258);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(10, 215);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 9;
            this.betButton.Text = "Enter";
            this.betButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wat is de eindscoren van de wedstrijd?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wie wint de wedstrijd?";
            // 
            // betScoreAmount
            // 
            this.betScoreAmount.AutoSize = true;
            this.betScoreAmount.Location = new System.Drawing.Point(9, 171);
            this.betScoreAmount.Name = "betScoreAmount";
            this.betScoreAmount.Size = new System.Drawing.Size(85, 13);
            this.betScoreAmount.TabIndex = 6;
            this.betScoreAmount.Text = "Gok eindscoren:";
            // 
            // teamBetLabel
            // 
            this.teamBetLabel.AutoSize = true;
            this.teamBetLabel.Location = new System.Drawing.Point(9, 97);
            this.teamBetLabel.Name = "teamBetLabel";
            this.teamBetLabel.Size = new System.Drawing.Size(37, 13);
            this.teamBetLabel.TabIndex = 5;
            this.teamBetLabel.Text = "Team:";
            // 
            // teamBetDomain
            // 
            this.teamBetDomain.Location = new System.Drawing.Point(53, 95);
            this.teamBetDomain.Name = "teamBetDomain";
            this.teamBetDomain.Size = new System.Drawing.Size(120, 20);
            this.teamBetDomain.TabIndex = 4;
            this.teamBetDomain.Text = "domainUpDown1";
            // 
            // betScoreTextBox
            // 
            this.betScoreTextBox.Location = new System.Drawing.Point(101, 168);
            this.betScoreTextBox.Name = "betScoreTextBox";
            this.betScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.betScoreTextBox.TabIndex = 3;
            // 
            // betMatchLabel
            // 
            this.betMatchLabel.AutoSize = true;
            this.betMatchLabel.Location = new System.Drawing.Point(70, 27);
            this.betMatchLabel.Name = "betMatchLabel";
            this.betMatchLabel.Size = new System.Drawing.Size(88, 13);
            this.betMatchLabel.TabIndex = 2;
            this.betMatchLabel.Text = "variabelen match";
            // 
            // betsOn
            // 
            this.betsOn.AutoSize = true;
            this.betsOn.Location = new System.Drawing.Point(7, 27);
            this.betsOn.Name = "betsOn";
            this.betsOn.Size = new System.Drawing.Size(57, 13);
            this.betsOn.TabIndex = 1;
            this.betsOn.Text = "U gokt op:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gokken";
            // 
            // betForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "betForm";
            this.Text = "betForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label betScoreAmount;
        private System.Windows.Forms.Label teamBetLabel;
        private System.Windows.Forms.DomainUpDown teamBetDomain;
        private System.Windows.Forms.TextBox betScoreTextBox;
        private System.Windows.Forms.Label betMatchLabel;
        private System.Windows.Forms.Label betsOn;
        private System.Windows.Forms.Label label1;
    }
}