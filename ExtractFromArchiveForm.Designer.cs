namespace WindowsForms
{
    partial class ExtractFromArchiveForm
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
            this.BrowseInPathButton = new System.Windows.Forms.Button();
            this.InPathComboBox = new System.Windows.Forms.ComboBox();
            this.InPathLabel = new System.Windows.Forms.Label();
            this.BrowseOutPathButton = new System.Windows.Forms.Button();
            this.OutPathComboBox = new System.Windows.Forms.ComboBox();
            this.OutPathLabel = new System.Windows.Forms.Label();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.TogglePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BrowseInPathButton
            // 
            this.BrowseInPathButton.Location = new System.Drawing.Point(488, 12);
            this.BrowseInPathButton.Name = "BrowseInPathButton";
            this.BrowseInPathButton.Size = new System.Drawing.Size(37, 21);
            this.BrowseInPathButton.TabIndex = 21;
            this.BrowseInPathButton.Text = "...";
            this.BrowseInPathButton.UseVisualStyleBackColor = true;
            this.BrowseInPathButton.Click += new System.EventHandler(this.BrowseInPathButton_Click);
            // 
            // InPathComboBox
            // 
            this.InPathComboBox.FormattingEnabled = true;
            this.InPathComboBox.Location = new System.Drawing.Point(112, 12);
            this.InPathComboBox.Name = "InPathComboBox";
            this.InPathComboBox.Size = new System.Drawing.Size(370, 21);
            this.InPathComboBox.TabIndex = 20;
            this.InPathComboBox.TextChanged += new System.EventHandler(this.InPathComboBox_TextChanged);
            // 
            // InPathLabel
            // 
            this.InPathLabel.AutoSize = true;
            this.InPathLabel.Location = new System.Drawing.Point(12, 15);
            this.InPathLabel.Name = "InPathLabel";
            this.InPathLabel.Size = new System.Drawing.Size(91, 13);
            this.InPathLabel.TabIndex = 19;
            this.InPathLabel.Text = "Input Folder Path:";
            // 
            // BrowseOutPathButton
            // 
            this.BrowseOutPathButton.Location = new System.Drawing.Point(488, 39);
            this.BrowseOutPathButton.Name = "BrowseOutPathButton";
            this.BrowseOutPathButton.Size = new System.Drawing.Size(37, 21);
            this.BrowseOutPathButton.TabIndex = 18;
            this.BrowseOutPathButton.Text = "...";
            this.BrowseOutPathButton.UseVisualStyleBackColor = true;
            this.BrowseOutPathButton.Click += new System.EventHandler(this.BrowseOutPathButton_Click);
            // 
            // OutPathComboBox
            // 
            this.OutPathComboBox.FormattingEnabled = true;
            this.OutPathComboBox.Location = new System.Drawing.Point(112, 39);
            this.OutPathComboBox.Name = "OutPathComboBox";
            this.OutPathComboBox.Size = new System.Drawing.Size(370, 21);
            this.OutPathComboBox.TabIndex = 17;
            this.OutPathComboBox.TextChanged += new System.EventHandler(this.OutPathComboBox_TextChanged);
            // 
            // OutPathLabel
            // 
            this.OutPathLabel.AutoSize = true;
            this.OutPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutPathLabel.Location = new System.Drawing.Point(7, 43);
            this.OutPathLabel.Name = "OutPathLabel";
            this.OutPathLabel.Size = new System.Drawing.Size(99, 13);
            this.OutPathLabel.TabIndex = 16;
            this.OutPathLabel.Text = "Output Folder Path:";
            // 
            // ExtractButton
            // 
            this.ExtractButton.Location = new System.Drawing.Point(450, 114);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractButton.TabIndex = 22;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(15, 114);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(429, 23);
            this.ProgressBar.TabIndex = 23;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 83);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(59, 13);
            this.PasswordLabel.TabIndex = 24;
            this.PasswordLabel.Text = "Password: ";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(77, 80);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 25;
            // 
            // TogglePasswordCheckBox
            // 
            this.TogglePasswordCheckBox.AutoSize = true;
            this.TogglePasswordCheckBox.Location = new System.Drawing.Point(184, 83);
            this.TogglePasswordCheckBox.Name = "TogglePasswordCheckBox";
            this.TogglePasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.TogglePasswordCheckBox.TabIndex = 26;
            this.TogglePasswordCheckBox.Text = "Show Password";
            this.TogglePasswordCheckBox.UseVisualStyleBackColor = true;
            this.TogglePasswordCheckBox.CheckedChanged += new System.EventHandler(this.TogglePasswordCheckBox_CheckedChanged);
            // 
            // ExtractFromArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 149);
            this.Controls.Add(this.TogglePasswordCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.BrowseInPathButton);
            this.Controls.Add(this.InPathComboBox);
            this.Controls.Add(this.InPathLabel);
            this.Controls.Add(this.BrowseOutPathButton);
            this.Controls.Add(this.OutPathComboBox);
            this.Controls.Add(this.OutPathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtractFromArchiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Extract From Archive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseInPathButton;
        private System.Windows.Forms.ComboBox InPathComboBox;
        private System.Windows.Forms.Label InPathLabel;
        private System.Windows.Forms.Button BrowseOutPathButton;
        private System.Windows.Forms.ComboBox OutPathComboBox;
        private System.Windows.Forms.Label OutPathLabel;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox TogglePasswordCheckBox;
    }
}