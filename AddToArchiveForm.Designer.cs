namespace WindowsForms
{
    partial class AddToArchiveForm
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
            this.OutPathLabel = new System.Windows.Forms.Label();
            this.ArchiveFormatLabel = new System.Windows.Forms.Label();
            this.CompressionLevelLabel = new System.Windows.Forms.Label();
            this.BufferSizeLabel = new System.Windows.Forms.Label();
            this.BrowseOutPathButton = new System.Windows.Forms.Button();
            this.ArchiveFormatComboBox = new System.Windows.Forms.ComboBox();
            this.CompressionLevelComboBox = new System.Windows.Forms.ComboBox();
            this.InPathLabel = new System.Windows.Forms.Label();
            this.OutPathComboBox = new System.Windows.Forms.ComboBox();
            this.InPathComboBox = new System.Windows.Forms.ComboBox();
            this.BrowseInPathButton = new System.Windows.Forms.Button();
            this.CreateArchiveButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Zip64Checkbox = new System.Windows.Forms.CheckBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.EncodingLabel = new System.Windows.Forms.Label();
            this.EncodingComboBox = new System.Windows.Forms.ComboBox();
            this.BufferSizeTextBox = new System.Windows.Forms.TextBox();
            this.StreamOwnerCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchPatternTextBox = new System.Windows.Forms.TextBox();
            this.SearchPatternLabel = new System.Windows.Forms.Label();
            this.SearchOptionComboBox = new System.Windows.Forms.ComboBox();
            this.SearchOptionLabel = new System.Windows.Forms.Label();
            this.UserInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.GroupNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.GroupIdTextBox = new System.Windows.Forms.TextBox();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.GroupNameLabel = new System.Windows.Forms.Label();
            this.GroupIdLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.KeepOldFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.AsciiTranslateCheckBox = new System.Windows.Forms.CheckBox();
            this.TogglePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.UserInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutPathLabel
            // 
            this.OutPathLabel.AutoSize = true;
            this.OutPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutPathLabel.Location = new System.Drawing.Point(7, 45);
            this.OutPathLabel.Name = "OutPathLabel";
            this.OutPathLabel.Size = new System.Drawing.Size(99, 13);
            this.OutPathLabel.TabIndex = 0;
            this.OutPathLabel.Text = "Output Folder Path:";
            // 
            // ArchiveFormatLabel
            // 
            this.ArchiveFormatLabel.AutoSize = true;
            this.ArchiveFormatLabel.Location = new System.Drawing.Point(30, 111);
            this.ArchiveFormatLabel.Name = "ArchiveFormatLabel";
            this.ArchiveFormatLabel.Size = new System.Drawing.Size(78, 13);
            this.ArchiveFormatLabel.TabIndex = 1;
            this.ArchiveFormatLabel.Text = "Archive format:";
            // 
            // CompressionLevelLabel
            // 
            this.CompressionLevelLabel.AutoSize = true;
            this.CompressionLevelLabel.Location = new System.Drawing.Point(13, 140);
            this.CompressionLevelLabel.Name = "CompressionLevelLabel";
            this.CompressionLevelLabel.Size = new System.Drawing.Size(95, 13);
            this.CompressionLevelLabel.TabIndex = 2;
            this.CompressionLevelLabel.Text = "Compression level:";
            // 
            // BufferSizeLabel
            // 
            this.BufferSizeLabel.AutoSize = true;
            this.BufferSizeLabel.Location = new System.Drawing.Point(47, 165);
            this.BufferSizeLabel.Name = "BufferSizeLabel";
            this.BufferSizeLabel.Size = new System.Drawing.Size(59, 13);
            this.BufferSizeLabel.TabIndex = 3;
            this.BufferSizeLabel.Text = "Buffer size:";
            // 
            // BrowseOutPathButton
            // 
            this.BrowseOutPathButton.Location = new System.Drawing.Point(488, 41);
            this.BrowseOutPathButton.Name = "BrowseOutPathButton";
            this.BrowseOutPathButton.Size = new System.Drawing.Size(37, 21);
            this.BrowseOutPathButton.TabIndex = 7;
            this.BrowseOutPathButton.Text = "...";
            this.BrowseOutPathButton.UseVisualStyleBackColor = true;
            this.BrowseOutPathButton.Click += new System.EventHandler(this.BrowseOutPathButton_Click);
            // 
            // ArchiveFormatComboBox
            // 
            this.ArchiveFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArchiveFormatComboBox.FormattingEnabled = true;
            this.ArchiveFormatComboBox.Items.AddRange(new object[] {
            "zip",
            "tar",
            "bzip2",
            "gzip",
            "lz",
            "lzma",
            "7zip"});
            this.ArchiveFormatComboBox.Location = new System.Drawing.Point(112, 108);
            this.ArchiveFormatComboBox.Name = "ArchiveFormatComboBox";
            this.ArchiveFormatComboBox.Size = new System.Drawing.Size(121, 21);
            this.ArchiveFormatComboBox.TabIndex = 9;
            this.ArchiveFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.ArchiveFormatComboBox_SelectedIndexChanged);
            // 
            // CompressionLevelComboBox
            // 
            this.CompressionLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompressionLevelComboBox.FormattingEnabled = true;
            this.CompressionLevelComboBox.Items.AddRange(new object[] {
            "1 (Light)",
            "2",
            "3 (Low)",
            "4",
            "5 (Middle)",
            "6",
            "7 (High)",
            "8",
            "9 (Ultra)"});
            this.CompressionLevelComboBox.Location = new System.Drawing.Point(112, 135);
            this.CompressionLevelComboBox.Name = "CompressionLevelComboBox";
            this.CompressionLevelComboBox.Size = new System.Drawing.Size(121, 21);
            this.CompressionLevelComboBox.TabIndex = 10;
            // 
            // InPathLabel
            // 
            this.InPathLabel.AutoSize = true;
            this.InPathLabel.Location = new System.Drawing.Point(12, 17);
            this.InPathLabel.Name = "InPathLabel";
            this.InPathLabel.Size = new System.Drawing.Size(91, 13);
            this.InPathLabel.TabIndex = 13;
            this.InPathLabel.Text = "Input Folder Path:";
            // 
            // OutPathComboBox
            // 
            this.OutPathComboBox.FormattingEnabled = true;
            this.OutPathComboBox.Location = new System.Drawing.Point(112, 41);
            this.OutPathComboBox.Name = "OutPathComboBox";
            this.OutPathComboBox.Size = new System.Drawing.Size(370, 21);
            this.OutPathComboBox.TabIndex = 5;
            this.OutPathComboBox.TextChanged += new System.EventHandler(this.OutPathComboBox_TextChanged);
            // 
            // InPathComboBox
            // 
            this.InPathComboBox.FormattingEnabled = true;
            this.InPathComboBox.Location = new System.Drawing.Point(112, 14);
            this.InPathComboBox.Name = "InPathComboBox";
            this.InPathComboBox.Size = new System.Drawing.Size(370, 21);
            this.InPathComboBox.TabIndex = 14;
            this.InPathComboBox.TextChanged += new System.EventHandler(this.InPathComboBox_TextChanged);
            // 
            // BrowseInPathButton
            // 
            this.BrowseInPathButton.Location = new System.Drawing.Point(488, 14);
            this.BrowseInPathButton.Name = "BrowseInPathButton";
            this.BrowseInPathButton.Size = new System.Drawing.Size(37, 21);
            this.BrowseInPathButton.TabIndex = 15;
            this.BrowseInPathButton.Text = "...";
            this.BrowseInPathButton.UseVisualStyleBackColor = true;
            this.BrowseInPathButton.Click += new System.EventHandler(this.BrowseInPathButton_Click);
            // 
            // CreateArchiveButton
            // 
            this.CreateArchiveButton.Location = new System.Drawing.Point(412, 344);
            this.CreateArchiveButton.Name = "CreateArchiveButton";
            this.CreateArchiveButton.Size = new System.Drawing.Size(109, 25);
            this.CreateArchiveButton.TabIndex = 16;
            this.CreateArchiveButton.Text = "Create";
            this.CreateArchiveButton.UseVisualStyleBackColor = true;
            this.CreateArchiveButton.Click += new System.EventHandler(this.CreateArchiveButton_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(49, 71);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FileNameLabel.TabIndex = 17;
            this.FileNameLabel.Text = "File Name:";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(112, 68);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FileNameTextBox.TabIndex = 18;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(301, 272);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 19;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(239, 275);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 20;
            this.PasswordLabel.Text = "Password:";
            // 
            // Zip64Checkbox
            // 
            this.Zip64Checkbox.AutoSize = true;
            this.Zip64Checkbox.Location = new System.Drawing.Point(348, 212);
            this.Zip64Checkbox.Name = "Zip64Checkbox";
            this.Zip64Checkbox.Size = new System.Drawing.Size(58, 17);
            this.Zip64Checkbox.TabIndex = 22;
            this.Zip64Checkbox.Text = "ZIP 64";
            this.Zip64Checkbox.UseVisualStyleBackColor = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(242, 306);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(279, 23);
            this.ProgressBar.TabIndex = 23;
            // 
            // EncodingLabel
            // 
            this.EncodingLabel.AutoSize = true;
            this.EncodingLabel.Location = new System.Drawing.Point(272, 111);
            this.EncodingLabel.Name = "EncodingLabel";
            this.EncodingLabel.Size = new System.Drawing.Size(58, 13);
            this.EncodingLabel.TabIndex = 24;
            this.EncodingLabel.Text = "Encoding: ";
            // 
            // EncodingComboBox
            // 
            this.EncodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingComboBox.FormattingEnabled = true;
            this.EncodingComboBox.Items.AddRange(new object[] {
            "UTF-8",
            "Unicode",
            "ASCII"});
            this.EncodingComboBox.Location = new System.Drawing.Point(336, 108);
            this.EncodingComboBox.Name = "EncodingComboBox";
            this.EncodingComboBox.Size = new System.Drawing.Size(121, 21);
            this.EncodingComboBox.TabIndex = 25;
            // 
            // BufferSizeTextBox
            // 
            this.BufferSizeTextBox.Location = new System.Drawing.Point(112, 162);
            this.BufferSizeTextBox.Name = "BufferSizeTextBox";
            this.BufferSizeTextBox.Size = new System.Drawing.Size(121, 20);
            this.BufferSizeTextBox.TabIndex = 26;
            this.BufferSizeTextBox.Text = "81920";
            // 
            // StreamOwnerCheckBox
            // 
            this.StreamOwnerCheckBox.AutoSize = true;
            this.StreamOwnerCheckBox.Location = new System.Drawing.Point(412, 212);
            this.StreamOwnerCheckBox.Name = "StreamOwnerCheckBox";
            this.StreamOwnerCheckBox.Size = new System.Drawing.Size(93, 17);
            this.StreamOwnerCheckBox.TabIndex = 27;
            this.StreamOwnerCheckBox.Text = "Stream Owner";
            this.StreamOwnerCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchPatternTextBox
            // 
            this.SearchPatternTextBox.Location = new System.Drawing.Point(336, 135);
            this.SearchPatternTextBox.Name = "SearchPatternTextBox";
            this.SearchPatternTextBox.Size = new System.Drawing.Size(121, 20);
            this.SearchPatternTextBox.TabIndex = 28;
            // 
            // SearchPatternLabel
            // 
            this.SearchPatternLabel.AutoSize = true;
            this.SearchPatternLabel.Location = new System.Drawing.Point(249, 138);
            this.SearchPatternLabel.Name = "SearchPatternLabel";
            this.SearchPatternLabel.Size = new System.Drawing.Size(81, 13);
            this.SearchPatternLabel.TabIndex = 29;
            this.SearchPatternLabel.Text = "Search Pattern:";
            // 
            // SearchOptionComboBox
            // 
            this.SearchOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchOptionComboBox.FormattingEnabled = true;
            this.SearchOptionComboBox.Items.AddRange(new object[] {
            "All Directories",
            "Top Directory Only"});
            this.SearchOptionComboBox.Location = new System.Drawing.Point(336, 161);
            this.SearchOptionComboBox.Name = "SearchOptionComboBox";
            this.SearchOptionComboBox.Size = new System.Drawing.Size(121, 21);
            this.SearchOptionComboBox.TabIndex = 30;
            // 
            // SearchOptionLabel
            // 
            this.SearchOptionLabel.AutoSize = true;
            this.SearchOptionLabel.Location = new System.Drawing.Point(252, 165);
            this.SearchOptionLabel.Name = "SearchOptionLabel";
            this.SearchOptionLabel.Size = new System.Drawing.Size(78, 13);
            this.SearchOptionLabel.TabIndex = 31;
            this.SearchOptionLabel.Text = "Search Option:";
            // 
            // UserInfoGroupBox
            // 
            this.UserInfoGroupBox.Controls.Add(this.GroupNameTextBox);
            this.UserInfoGroupBox.Controls.Add(this.UserNameTextBox);
            this.UserInfoGroupBox.Controls.Add(this.GroupIdTextBox);
            this.UserInfoGroupBox.Controls.Add(this.UserIdTextBox);
            this.UserInfoGroupBox.Controls.Add(this.GroupNameLabel);
            this.UserInfoGroupBox.Controls.Add(this.GroupIdLabel);
            this.UserInfoGroupBox.Controls.Add(this.UserNameLabel);
            this.UserInfoGroupBox.Controls.Add(this.UserIdLabel);
            this.UserInfoGroupBox.Location = new System.Drawing.Point(33, 201);
            this.UserInfoGroupBox.Name = "UserInfoGroupBox";
            this.UserInfoGroupBox.Size = new System.Drawing.Size(200, 136);
            this.UserInfoGroupBox.TabIndex = 32;
            this.UserInfoGroupBox.TabStop = false;
            this.UserInfoGroupBox.Text = "User Info:";
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.Location = new System.Drawing.Point(85, 102);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.GroupNameTextBox.TabIndex = 34;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(85, 50);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameTextBox.TabIndex = 33;
            // 
            // GroupIdTextBox
            // 
            this.GroupIdTextBox.Location = new System.Drawing.Point(85, 76);
            this.GroupIdTextBox.Name = "GroupIdTextBox";
            this.GroupIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.GroupIdTextBox.TabIndex = 33;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(85, 24);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserIdTextBox.TabIndex = 33;
            // 
            // GroupNameLabel
            // 
            this.GroupNameLabel.AutoSize = true;
            this.GroupNameLabel.Location = new System.Drawing.Point(11, 105);
            this.GroupNameLabel.Name = "GroupNameLabel";
            this.GroupNameLabel.Size = new System.Drawing.Size(70, 13);
            this.GroupNameLabel.TabIndex = 36;
            this.GroupNameLabel.Text = "Group Name:";
            // 
            // GroupIdLabel
            // 
            this.GroupIdLabel.AutoSize = true;
            this.GroupIdLabel.Location = new System.Drawing.Point(26, 79);
            this.GroupIdLabel.Name = "GroupIdLabel";
            this.GroupIdLabel.Size = new System.Drawing.Size(53, 13);
            this.GroupIdLabel.TabIndex = 35;
            this.GroupIdLabel.Text = "Group ID:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(18, 53);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 13);
            this.UserNameLabel.TabIndex = 34;
            this.UserNameLabel.Text = "User Name:";
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(33, 27);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(46, 13);
            this.UserIdLabel.TabIndex = 33;
            this.UserIdLabel.Text = "User ID:";
            // 
            // KeepOldFilesCheckBox
            // 
            this.KeepOldFilesCheckBox.AutoSize = true;
            this.KeepOldFilesCheckBox.Location = new System.Drawing.Point(239, 212);
            this.KeepOldFilesCheckBox.Name = "KeepOldFilesCheckBox";
            this.KeepOldFilesCheckBox.Size = new System.Drawing.Size(94, 17);
            this.KeepOldFilesCheckBox.TabIndex = 33;
            this.KeepOldFilesCheckBox.Text = "Keep Old Files";
            this.KeepOldFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // AsciiTranslateCheckBox
            // 
            this.AsciiTranslateCheckBox.AutoSize = true;
            this.AsciiTranslateCheckBox.Location = new System.Drawing.Point(239, 238);
            this.AsciiTranslateCheckBox.Name = "AsciiTranslateCheckBox";
            this.AsciiTranslateCheckBox.Size = new System.Drawing.Size(100, 17);
            this.AsciiTranslateCheckBox.TabIndex = 34;
            this.AsciiTranslateCheckBox.Text = "ASCII Translate";
            this.AsciiTranslateCheckBox.UseVisualStyleBackColor = true;
            // 
            // TogglePasswordCheckBox
            // 
            this.TogglePasswordCheckBox.AutoSize = true;
            this.TogglePasswordCheckBox.Location = new System.Drawing.Point(412, 272);
            this.TogglePasswordCheckBox.Name = "TogglePasswordCheckBox";
            this.TogglePasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.TogglePasswordCheckBox.TabIndex = 35;
            this.TogglePasswordCheckBox.Text = "Show Password";
            this.TogglePasswordCheckBox.UseVisualStyleBackColor = true;
            this.TogglePasswordCheckBox.CheckedChanged += new System.EventHandler(this.TogglePasswordCheckBox_CheckedChanged);
            // 
            // AddToArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 382);
            this.Controls.Add(this.TogglePasswordCheckBox);
            this.Controls.Add(this.AsciiTranslateCheckBox);
            this.Controls.Add(this.KeepOldFilesCheckBox);
            this.Controls.Add(this.UserInfoGroupBox);
            this.Controls.Add(this.SearchOptionLabel);
            this.Controls.Add(this.SearchOptionComboBox);
            this.Controls.Add(this.SearchPatternLabel);
            this.Controls.Add(this.SearchPatternTextBox);
            this.Controls.Add(this.StreamOwnerCheckBox);
            this.Controls.Add(this.BufferSizeTextBox);
            this.Controls.Add(this.EncodingComboBox);
            this.Controls.Add(this.EncodingLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Zip64Checkbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.CreateArchiveButton);
            this.Controls.Add(this.BrowseInPathButton);
            this.Controls.Add(this.InPathComboBox);
            this.Controls.Add(this.InPathLabel);
            this.Controls.Add(this.CompressionLevelComboBox);
            this.Controls.Add(this.ArchiveFormatComboBox);
            this.Controls.Add(this.BrowseOutPathButton);
            this.Controls.Add(this.OutPathComboBox);
            this.Controls.Add(this.BufferSizeLabel);
            this.Controls.Add(this.CompressionLevelLabel);
            this.Controls.Add(this.ArchiveFormatLabel);
            this.Controls.Add(this.OutPathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddToArchiveForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add To Archive";
            this.UserInfoGroupBox.ResumeLayout(false);
            this.UserInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutPathLabel;
        private System.Windows.Forms.Label ArchiveFormatLabel;
        private System.Windows.Forms.Label CompressionLevelLabel;
        private System.Windows.Forms.Label BufferSizeLabel;
        private System.Windows.Forms.Button BrowseOutPathButton;
        private System.Windows.Forms.ComboBox ArchiveFormatComboBox;
        private System.Windows.Forms.ComboBox CompressionLevelComboBox;
        private System.Windows.Forms.Label InPathLabel;
        private System.Windows.Forms.ComboBox OutPathComboBox;
        private System.Windows.Forms.ComboBox InPathComboBox;
        private System.Windows.Forms.Button BrowseInPathButton;
        private System.Windows.Forms.Button CreateArchiveButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox Zip64Checkbox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label EncodingLabel;
        private System.Windows.Forms.ComboBox EncodingComboBox;
        private System.Windows.Forms.TextBox BufferSizeTextBox;
        private System.Windows.Forms.CheckBox StreamOwnerCheckBox;
        private System.Windows.Forms.TextBox SearchPatternTextBox;
        private System.Windows.Forms.Label SearchPatternLabel;
        private System.Windows.Forms.ComboBox SearchOptionComboBox;
        private System.Windows.Forms.Label SearchOptionLabel;
        private System.Windows.Forms.GroupBox UserInfoGroupBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label GroupNameLabel;
        private System.Windows.Forms.Label GroupIdLabel;
        private System.Windows.Forms.TextBox GroupNameTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox GroupIdTextBox;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.CheckBox KeepOldFilesCheckBox;
        private System.Windows.Forms.CheckBox AsciiTranslateCheckBox;
        private System.Windows.Forms.CheckBox TogglePasswordCheckBox;
    }
}