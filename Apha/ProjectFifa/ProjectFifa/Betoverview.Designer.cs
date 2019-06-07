namespace ProjectFifa
{
    partial class Betoverview
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
            this.label3 = new System.Windows.Forms.Label();
            this.poolButton = new System.Windows.Forms.Button();
            this.selectPouleDomain = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.betsListBox = new System.Windows.Forms.ListBox();
            this.betButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(169, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Poule";
            // 
            // poolButton
            // 
            this.poolButton.BackColor = System.Drawing.Color.White;
            this.poolButton.Location = new System.Drawing.Point(238, 23);
            this.poolButton.Name = "poolButton";
            this.poolButton.Size = new System.Drawing.Size(55, 23);
            this.poolButton.TabIndex = 21;
            this.poolButton.Text = "Go";
            this.poolButton.UseVisualStyleBackColor = false;
            // 
            // selectPouleDomain
            // 
            this.selectPouleDomain.BackColor = System.Drawing.Color.White;
            this.selectPouleDomain.Location = new System.Drawing.Point(172, 26);
            this.selectPouleDomain.Name = "selectPouleDomain";
            this.selectPouleDomain.Size = new System.Drawing.Size(60, 20);
            this.selectPouleDomain.TabIndex = 20;
            this.selectPouleDomain.Text = "domainUpDown1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Gok Overzicht";
            // 
            // betsListBox
            // 
            this.betsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.betsListBox.FormattingEnabled = true;
            this.betsListBox.Location = new System.Drawing.Point(12, 52);
            this.betsListBox.Name = "betsListBox";
            this.betsListBox.Size = new System.Drawing.Size(288, 225);
            this.betsListBox.TabIndex = 24;
            // 
            // betButton
            // 
            this.betButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.betButton.Location = new System.Drawing.Point(12, 286);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 27;
            this.betButton.Text = "Bet Start";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // Betoverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 321);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.betsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poolButton);
            this.Controls.Add(this.selectPouleDomain);
            this.Name = "Betoverview";
            this.Text = "FIFA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button poolButton;
        private System.Windows.Forms.DomainUpDown selectPouleDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox betsListBox;
        private System.Windows.Forms.Button betButton;
    }
}