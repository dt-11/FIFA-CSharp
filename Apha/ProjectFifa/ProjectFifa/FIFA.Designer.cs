namespace ProjectFifa
{
    partial class FIFA
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gokkerOverzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aanmakenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gokkerAanmakenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.weddenschapAanmakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Poule";
            // 
            // poolButton
            // 
            this.poolButton.BackColor = System.Drawing.Color.White;
            this.poolButton.Location = new System.Drawing.Point(160, 96);
            this.poolButton.Name = "poolButton";
            this.poolButton.Size = new System.Drawing.Size(55, 23);
            this.poolButton.TabIndex = 17;
            this.poolButton.Text = "Go";
            this.poolButton.UseVisualStyleBackColor = false;
            // 
            // selectPouleDomain
            // 
            this.selectPouleDomain.BackColor = System.Drawing.Color.White;
            this.selectPouleDomain.Location = new System.Drawing.Point(17, 99);
            this.selectPouleDomain.Name = "selectPouleDomain";
            this.selectPouleDomain.Size = new System.Drawing.Size(137, 20);
            this.selectPouleDomain.TabIndex = 16;
            this.selectPouleDomain.Text = "domainUpDown1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "FIFA";
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
            this.menuStrip1.Size = new System.Drawing.Size(240, 24);
            this.menuStrip1.TabIndex = 37;
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
            this.teamOverviewToolStripMenuItem,
            this.gokkerOverzichtToolStripMenuItem});
            this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            this.overviewToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.overviewToolStripMenuItem.Text = "Overzichten";
            // 
            // betOverviewToolStripMenuItem
            // 
            this.betOverviewToolStripMenuItem.Name = "betOverviewToolStripMenuItem";
            this.betOverviewToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.betOverviewToolStripMenuItem.Text = "Weddenschap Overzicht";
            this.betOverviewToolStripMenuItem.Click += new System.EventHandler(this.betOverviewToolStripMenuItem_Click);
            // 
            // teamOverviewToolStripMenuItem
            // 
            this.teamOverviewToolStripMenuItem.Name = "teamOverviewToolStripMenuItem";
            this.teamOverviewToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.teamOverviewToolStripMenuItem.Text = "Team Overzicht";
            this.teamOverviewToolStripMenuItem.Click += new System.EventHandler(this.teamOverviewToolStripMenuItem_Click);
            // 
            // gokkerOverzichtToolStripMenuItem
            // 
            this.gokkerOverzichtToolStripMenuItem.Name = "gokkerOverzichtToolStripMenuItem";
            this.gokkerOverzichtToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.gokkerOverzichtToolStripMenuItem.Text = "Gokker Overzicht";
            this.gokkerOverzichtToolStripMenuItem.Click += new System.EventHandler(this.gokkerOverzichtToolStripMenuItem_Click);
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
            this.gokkerAanmakenToolStripMenuItem1.Click += new System.EventHandler(this.gokkerAanmakenToolStripMenuItem1_Click_1);
            // 
            // weddenschapAanmakenToolStripMenuItem
            // 
            this.weddenschapAanmakenToolStripMenuItem.Name = "weddenschapAanmakenToolStripMenuItem";
            this.weddenschapAanmakenToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.weddenschapAanmakenToolStripMenuItem.Text = "Weddenschap Aanmaken";
            this.weddenschapAanmakenToolStripMenuItem.Click += new System.EventHandler(this.weddenschapAanmakenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // matchListBox
            // 
            this.matchListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.matchListBox.FormattingEnabled = true;
            this.matchListBox.Location = new System.Drawing.Point(17, 125);
            this.matchListBox.Name = "matchListBox";
            this.matchListBox.Size = new System.Drawing.Size(198, 264);
            this.matchListBox.TabIndex = 38;
            // 
            // FIFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 411);
            this.Controls.Add(this.matchListBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poolButton);
            this.Controls.Add(this.selectPouleDomain);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FIFA";
            this.Text = "FIFA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button poolButton;
        private System.Windows.Forms.DomainUpDown selectPouleDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gokkerOverzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aanmakenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gokkerAanmakenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem weddenschapAanmakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox matchListBox;
    }
}

