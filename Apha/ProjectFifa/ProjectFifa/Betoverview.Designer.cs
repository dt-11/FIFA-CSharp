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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.betOverviewToFormButton = new System.Windows.Forms.Button();
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
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 199);
            this.listBox1.TabIndex = 24;
            // 
            // betOverviewToFormButton
            // 
            this.betOverviewToFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.betOverviewToFormButton.Location = new System.Drawing.Point(16, 271);
            this.betOverviewToFormButton.Name = "betOverviewToFormButton";
            this.betOverviewToFormButton.Size = new System.Drawing.Size(75, 23);
            this.betOverviewToFormButton.TabIndex = 26;
            this.betOverviewToFormButton.Text = "Back";
            this.betOverviewToFormButton.UseVisualStyleBackColor = true;
            this.betOverviewToFormButton.Click += new System.EventHandler(this.betOverviewToFormButton_Click);
            // 
            // Betoverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 306);
            this.Controls.Add(this.betOverviewToFormButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poolButton);
            this.Controls.Add(this.selectPouleDomain);
            this.Name = "Betoverview";
            this.Text = "Gokoverzicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button poolButton;
        private System.Windows.Forms.DomainUpDown selectPouleDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button betOverviewToFormButton;
    }
}