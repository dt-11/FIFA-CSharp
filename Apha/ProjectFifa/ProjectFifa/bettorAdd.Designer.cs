namespace ProjectFifa
{
    partial class bettorAdd
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
            this.gokkerAddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gokker Naam:";
            // 
            // gokkerNameTextBox
            // 
            this.gokkerNameTextBox.Location = new System.Drawing.Point(12, 72);
            this.gokkerNameTextBox.Name = "gokkerNameTextBox";
            this.gokkerNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.gokkerNameTextBox.TabIndex = 1;
            // 
            // gokkerAddButton
            // 
            this.gokkerAddButton.Location = new System.Drawing.Point(12, 98);
            this.gokkerAddButton.Name = "gokkerAddButton";
            this.gokkerAddButton.Size = new System.Drawing.Size(76, 23);
            this.gokkerAddButton.TabIndex = 26;
            this.gokkerAddButton.Text = "Create";
            this.gokkerAddButton.UseVisualStyleBackColor = true;
            this.gokkerAddButton.Click += new System.EventHandler(this.gokkerAddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Gokker Aanmaken.";
            // 
            // bettorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 134);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gokkerAddButton);
            this.Controls.Add(this.gokkerNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "bettorAdd";
            this.Text = "FIFA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gokkerNameTextBox;
        private System.Windows.Forms.Button gokkerAddButton;
        private System.Windows.Forms.Label label2;
    }
}