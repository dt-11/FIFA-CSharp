﻿namespace ProjectFifa
{
    partial class Teamoverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teamoverview));
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teamOverviewToFormButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aanmakenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gokkerAanmakenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.weddenschapAanmakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamListBox
            // 
            this.teamListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(12, 61);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(184, 199);
            this.teamListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Overview";
            // 
            // teamOverviewToFormButton
            // 
            this.teamOverviewToFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.teamOverviewToFormButton.Location = new System.Drawing.Point(12, 278);
            this.teamOverviewToFormButton.Name = "teamOverviewToFormButton";
            this.teamOverviewToFormButton.Size = new System.Drawing.Size(75, 23);
            this.teamOverviewToFormButton.TabIndex = 2;
            this.teamOverviewToFormButton.Text = "Back";
            this.teamOverviewToFormButton.UseVisualStyleBackColor = true;
            this.teamOverviewToFormButton.Click += new System.EventHandler(this.overviewToFormButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.overviewToolStripMenuItem,
            this.aanmakenToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // overviewToolStripMenuItem
            // 
            this.overviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.betOverviewToolStripMenuItem,
            this.teamOverviewToolStripMenuItem});
            this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            this.overviewToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.overviewToolStripMenuItem.Text = "Overzichten";
            // 
            // betOverviewToolStripMenuItem
            // 
            this.betOverviewToolStripMenuItem.Name = "betOverviewToolStripMenuItem";
            this.betOverviewToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.betOverviewToolStripMenuItem.Text = "Gok Overzicht";
            // 
            // teamOverviewToolStripMenuItem
            // 
            this.teamOverviewToolStripMenuItem.Name = "teamOverviewToolStripMenuItem";
            this.teamOverviewToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.teamOverviewToolStripMenuItem.Text = "Team Overzicht";
            // 
            // aanmakenToolStripMenuItem1
            // 
            this.aanmakenToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gokkerAanmakenToolStripMenuItem1,
            this.weddenschapAanmakenToolStripMenuItem});
            this.aanmakenToolStripMenuItem1.Name = "aanmakenToolStripMenuItem1";
            this.aanmakenToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.aanmakenToolStripMenuItem1.Text = "Aanmaken";
            // 
            // gokkerAanmakenToolStripMenuItem1
            // 
            this.gokkerAanmakenToolStripMenuItem1.Name = "gokkerAanmakenToolStripMenuItem1";
            this.gokkerAanmakenToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.gokkerAanmakenToolStripMenuItem1.Text = "Gokker Aanmaken";
            // 
            // weddenschapAanmakenToolStripMenuItem
            // 
            this.weddenschapAanmakenToolStripMenuItem.Name = "weddenschapAanmakenToolStripMenuItem";
            this.weddenschapAanmakenToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.weddenschapAanmakenToolStripMenuItem.Text = "Weddenschap Aanmaken";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Teamoverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(314, 313);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.teamOverviewToFormButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamListBox);
            this.Name = "Teamoverview";
            this.Text = "overviewForm";
            this.Load += new System.EventHandler(this.overviewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button teamOverviewToFormButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aanmakenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gokkerAanmakenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem weddenschapAanmakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}