namespace WindowsForms
{
    partial class CopyForm
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
            this.CopyButton = new System.Windows.Forms.Button();
            this.ToPathTextBox = new System.Windows.Forms.TextBox();
            this.FromPathTextBox = new System.Windows.Forms.TextBox();
            this.ToPathLabel = new System.Windows.Forms.Label();
            this.FromPathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(180, 68);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 9;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // ToPathTextBox
            // 
            this.ToPathTextBox.Location = new System.Drawing.Point(59, 36);
            this.ToPathTextBox.Name = "ToPathTextBox";
            this.ToPathTextBox.Size = new System.Drawing.Size(196, 20);
            this.ToPathTextBox.TabIndex = 8;
            // 
            // FromPathTextBox
            // 
            this.FromPathTextBox.Location = new System.Drawing.Point(59, 9);
            this.FromPathTextBox.Name = "FromPathTextBox";
            this.FromPathTextBox.Size = new System.Drawing.Size(196, 20);
            this.FromPathTextBox.TabIndex = 7;
            // 
            // ToPathLabel
            // 
            this.ToPathLabel.AutoSize = true;
            this.ToPathLabel.Location = new System.Drawing.Point(23, 39);
            this.ToPathLabel.Name = "ToPathLabel";
            this.ToPathLabel.Size = new System.Drawing.Size(23, 13);
            this.ToPathLabel.TabIndex = 6;
            this.ToPathLabel.Text = "To:";
            // 
            // FromPathLabel
            // 
            this.FromPathLabel.AutoSize = true;
            this.FromPathLabel.Location = new System.Drawing.Point(13, 12);
            this.FromPathLabel.Name = "FromPathLabel";
            this.FromPathLabel.Size = new System.Drawing.Size(33, 13);
            this.FromPathLabel.TabIndex = 5;
            this.FromPathLabel.Text = "From:";
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 100);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ToPathTextBox);
            this.Controls.Add(this.FromPathTextBox);
            this.Controls.Add(this.ToPathLabel);
            this.Controls.Add(this.FromPathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CopyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Copy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.TextBox ToPathTextBox;
        private System.Windows.Forms.TextBox FromPathTextBox;
        private System.Windows.Forms.Label ToPathLabel;
        private System.Windows.Forms.Label FromPathLabel;
    }
}