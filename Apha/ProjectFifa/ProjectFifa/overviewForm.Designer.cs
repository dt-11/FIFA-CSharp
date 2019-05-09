namespace ProjectFifa
{
    partial class overviewForm
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
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.overviewToFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamListBox
            // 
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(12, 51);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(184, 199);
            this.teamListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Overview";
            // 
            // overviewToFormButton
            // 
            this.overviewToFormButton.Location = new System.Drawing.Point(12, 266);
            this.overviewToFormButton.Name = "overviewToFormButton";
            this.overviewToFormButton.Size = new System.Drawing.Size(75, 23);
            this.overviewToFormButton.TabIndex = 2;
            this.overviewToFormButton.Text = "Back";
            this.overviewToFormButton.UseVisualStyleBackColor = true;
            this.overviewToFormButton.Click += new System.EventHandler(this.overviewToFormButton_Click);
            // 
            // overviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 301);
            this.Controls.Add(this.overviewToFormButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamListBox);
            this.Name = "overviewForm";
            this.Text = "overviewForm";
            this.Load += new System.EventHandler(this.overviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button overviewToFormButton;
    }
}