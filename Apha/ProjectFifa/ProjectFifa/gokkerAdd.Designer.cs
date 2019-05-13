namespace ProjectFifa
{
    partial class gokkerAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.gokkerNameTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aanmakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gokkerAanmakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gokkerAddButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gokker Naam:";
            // 
            // gokkerNameTextBox
            // 
            this.gokkerNameTextBox.Location = new System.Drawing.Point(12, 55);
            this.gokkerNameTextBox.Name = "gokkerNameTextBox";
            this.gokkerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.gokkerNameTextBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aanmakenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(207, 24);
            this.menuStrip1.TabIndex = 25;
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
            // aanmakenToolStripMenuItem
            // 
            this.aanmakenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gokkerAanmakenToolStripMenuItem});
            this.aanmakenToolStripMenuItem.Name = "aanmakenToolStripMenuItem";
            this.aanmakenToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.aanmakenToolStripMenuItem.Text = "Aanmaken";
            // 
            // gokkerAanmakenToolStripMenuItem
            // 
            this.gokkerAanmakenToolStripMenuItem.Name = "gokkerAanmakenToolStripMenuItem";
            this.gokkerAanmakenToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.gokkerAanmakenToolStripMenuItem.Text = "Gokker Aanmaken";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // gokkerAddButton
            // 
            this.gokkerAddButton.Location = new System.Drawing.Point(12, 81);
            this.gokkerAddButton.Name = "gokkerAddButton";
            this.gokkerAddButton.Size = new System.Drawing.Size(75, 23);
            this.gokkerAddButton.TabIndex = 26;
            this.gokkerAddButton.Text = "Create";
            this.gokkerAddButton.UseVisualStyleBackColor = true;
            this.gokkerAddButton.Click += new System.EventHandler(this.gokkerAddButton_Click);
            // 
            // gokkerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 450);
            this.Controls.Add(this.gokkerAddButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gokkerNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "gokkerAdd";
            this.Text = "gokkerAdd";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gokkerNameTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aanmakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gokkerAanmakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button gokkerAddButton;
    }
}