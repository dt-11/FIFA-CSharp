﻿namespace ProjectFifa
{
    partial class bettorOverview
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
            this.betOverviewToFormButton = new System.Windows.Forms.Button();
            this.gokkerListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // betOverviewToFormButton
            // 
            this.betOverviewToFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.betOverviewToFormButton.Location = new System.Drawing.Point(12, 213);
            this.betOverviewToFormButton.Name = "betOverviewToFormButton";
            this.betOverviewToFormButton.Size = new System.Drawing.Size(75, 23);
            this.betOverviewToFormButton.TabIndex = 35;
            this.betOverviewToFormButton.Text = "Back";
            this.betOverviewToFormButton.UseVisualStyleBackColor = true;
            // 
            // gokkerListBox
            // 
            this.gokkerListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gokkerListBox.FormattingEnabled = true;
            this.gokkerListBox.Location = new System.Drawing.Point(12, 51);
            this.gokkerListBox.Name = "gokkerListBox";
            this.gokkerListBox.Size = new System.Drawing.Size(288, 147);
            this.gokkerListBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Gokker Overzicht";
            // 
            // bettorOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 248);
            this.Controls.Add(this.betOverviewToFormButton);
            this.Controls.Add(this.gokkerListBox);
            this.Controls.Add(this.label1);
            this.Name = "bettorOverview";
            this.Text = "bettorOverview";
            this.Load += new System.EventHandler(this.bettorOverview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button betOverviewToFormButton;
        private System.Windows.Forms.ListBox gokkerListBox;
        private System.Windows.Forms.Label label1;
    }
}