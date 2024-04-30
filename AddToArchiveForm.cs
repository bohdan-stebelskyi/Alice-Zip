using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archiver;
using ICSharpCode.SharpZipLib.Zip;

namespace WindowsForms
{
    public partial class AddToArchiveForm : Form
    {
        private string inPath;
        private string outPath;
        public AddToArchiveForm()
        {
            InitializeComponent();

            InPathComboBox.Text = MainForm.instance.currentPath;

            PasswordTextBox.PasswordChar = '\u25CF';

            ArchiveFormatComboBox.SelectedIndex = 0;
            
        }

        private void BrowseOutPathButton_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderBrowserDialog = new();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outPath = folderBrowserDialog.SelectedPath;

                OutPathComboBox.Text = outPath;
            }
        }

        private void BrowseInPathButton_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderBrowserDialog = new();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                inPath = folderBrowserDialog.SelectedPath;

                InPathComboBox.Text = inPath;
            }

        }

        private void CreateArchiveButton_Click(object sender, EventArgs e)
        {
            var archiverType = ArchiveFormatComboBox.Text;

            int bufferSize = 81920;

            if (BufferSizeTextBox.Enabled)
            {
                bool success = Int32.TryParse(BufferSizeTextBox.Text, out bufferSize);

                if (!success)
                {
                    MessageBox.Show("Error! Incorrect buffer size.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                IArchiver arch;

                switch (archiverType)
                {
                    case "zip":
                        {
                            Archiver.Zip.Zip archiver = new()
                            {
                                CompressionLevel = CompressionLevelComboBox.SelectedIndex + 1,
                                SearchPattern = SearchPatternTextBox.Text,
                                Password = PasswordTextBox.Text.Trim(),
                                UseZip64 = Zip64Checkbox.Checked ? UseZip64.On : UseZip64.Off,
                                BufferSize = bufferSize,
                            };
                            switch (EncodingComboBox.Text) {
                                case "UTF8":    archiver.Encoding = Encoding.UTF8;    break;
                                case "Unicode": archiver.Encoding = Encoding.Unicode; break;
                                case "ASCII":   archiver.Encoding = Encoding.ASCII;   break;
                            }
                            switch (SearchOptionComboBox.Text)
                            {
                                case "AllDirectories":    archiver.SearchOption = SearchOption.AllDirectories;    break;
                                case "TopDirectoryOnly":  archiver.SearchOption = SearchOption.AllDirectories;    break;
                            }
                            arch = archiver;
                            break;
                        }
                    case "tar":
                        {
                            Archiver.Tar.Tar archiver = new()
                            {
                                SearchPattern = SearchPatternTextBox.Text,
                                AsciiTranslate = AsciiTranslateCheckBox.Checked,
                                KeepOldFiles = KeepOldFilesCheckBox.Checked,
                                UserId = Int32.Parse(UserIdTextBox.Text),
                                UserName = UserNameTextBox.Text,
                                GroupId = Int32.Parse(GroupIdTextBox.Text),
                                GroupName = GroupNameTextBox.Text
                            };
                            switch (EncodingComboBox.Text)
                            {
                                case "UTF8": archiver.Encoding = Encoding.UTF8; break;
                                case "Unicode": archiver.Encoding = Encoding.Unicode; break;
                                case "ASCII": archiver.Encoding = Encoding.ASCII; break;
                            }
                            switch (SearchOptionComboBox.Text)
                            {
                                case "AllDirectories": archiver.SearchOption = SearchOption.AllDirectories; break;
                                case "TopDirectoryOnly": archiver.SearchOption = SearchOption.AllDirectories; break;
                            }
                            arch = archiver;
                            break;
                        }
                    case "bzip2":
                        {
                            Archiver.BZip2.BZip2 archiver = new()
                            {
                                CompressionLevel = CompressionLevelComboBox.SelectedIndex + 1,
                                IsStreamOwner = StreamOwnerCheckBox.Checked
                            };
                            arch = archiver;
                            break;
                        }
                    case "gzip":
                        {
                            Archiver.GZip.GZip archiver = new()
                            {
                                BufferSize = bufferSize,
                                CompressionLevel = CompressionLevelComboBox.SelectedIndex + 1,
                                IsStreamOwner = StreamOwnerCheckBox.Checked
                            };
                            arch = archiver;
                            break;
                        }
                    case "lz":
                        {
                            Archiver.Lz.Lz archiver = new();
                            arch = archiver;
                            break;
                        }
                    case "lzma":
                        {
                            Archiver.Lzma.Lzma archiver = new();
                            arch = archiver;
                            break;
                        }
                    case "7zip":
                        {
                            Archiver.SevenZip.SevenZip archiver = new();
                            arch = archiver;
                            break;
                        }
                    default:
                        {
                            Archiver.Zip.Zip archiver = new()
                            {
                                CompressionLevel = CompressionLevelComboBox.SelectedIndex + 1,
                                SearchPattern = SearchPatternTextBox.Text,
                                Password = PasswordTextBox.Text,
                                UseZip64 = Zip64Checkbox.Checked ? UseZip64.On : UseZip64.Off
                            };
                            switch (EncodingComboBox.Text)
                            {
                                case "UTF8": archiver.Encoding = Encoding.UTF8; break;
                                case "Unicode": archiver.Encoding = Encoding.Unicode; break;
                                case "ASCII": archiver.Encoding = Encoding.ASCII; break;
                            }
                            switch (SearchOptionComboBox.Text)
                            {
                                case "AllDirectories": archiver.SearchOption = SearchOption.AllDirectories; break;
                                case "TopDirectoryOnly": archiver.SearchOption = SearchOption.AllDirectories; break;
                            }
                            arch = archiver;
                            break;  
                        }
                }
                
                arch.Archive(inPath, outPath + @"\" + FileNameTextBox.Text);
                MessageBox.Show("Operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProgressBar.Value = 100;
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error! " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProgressBar.Value = 0;
            }

        }

        private void OutPathComboBox_TextChanged(object sender, EventArgs e)
        {
            outPath = OutPathComboBox.Text;
        }

        private void InPathComboBox_TextChanged(object sender, EventArgs e)
        {
            inPath = InPathComboBox.Text;
        }

        private void ArchiveFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ArchiveFormatComboBox.SelectedIndex)
            {
                case 0:
                    {
                        PasswordTextBox.Text = "";
                        PasswordTextBox.Enabled = true;
                        CompressionLevelComboBox.Enabled = true;
                        CompressionLevelComboBox.SelectedIndex = 4;
                        EncodingComboBox.SelectedIndex = 0;
                        EncodingComboBox.Enabled = true;
                        SearchPatternTextBox.Enabled = true;
                        SearchPatternTextBox.Text = "*";
                        SearchOptionComboBox.Enabled = true;
                        SearchOptionComboBox.SelectedIndex = 0;
                        Zip64Checkbox.Enabled = true;
                        UserInfoGroupBox.Enabled = false;
                        KeepOldFilesCheckBox.Enabled = false;
                        AsciiTranslateCheckBox.Enabled = false;
                        StreamOwnerCheckBox.Enabled = false;
                        BufferSizeTextBox.Enabled = true;
                        BufferSizeTextBox.Text = "81920";
                        break;
                    } // zip
                case 1:
                    {
                        PasswordTextBox.Text = "";
                        PasswordTextBox.Enabled = false;
                        CompressionLevelComboBox.Enabled = false;
                        CompressionLevelComboBox.SelectedIndex = -1;
                        EncodingComboBox.SelectedIndex = 0;
                        EncodingComboBox.Enabled = true;
                        SearchPatternTextBox.Enabled = true;
                        SearchPatternTextBox.Text = "*";
                        SearchOptionComboBox.Enabled = true;
                        SearchOptionComboBox.SelectedIndex = 0;
                        Zip64Checkbox.Enabled = false;
                        UserInfoGroupBox.Enabled = true;
                        KeepOldFilesCheckBox.Enabled = true;
                        AsciiTranslateCheckBox.Enabled = true;
                        StreamOwnerCheckBox.Enabled = false;
                        BufferSizeTextBox.Enabled = false;
                        BufferSizeTextBox.Text = "";
                        break;
                    } // tar
                case 2:
                    {
                        PasswordTextBox.Text = "";
                        PasswordTextBox.Enabled = false;
                        CompressionLevelComboBox.Enabled = true;
                        CompressionLevelComboBox.SelectedIndex = 4;
                        EncodingComboBox.SelectedIndex = -1;
                        EncodingComboBox.Enabled = false;
                        SearchPatternTextBox.Enabled = false;
                        SearchPatternTextBox.Text = "";
                        SearchOptionComboBox.Enabled = false;
                        SearchOptionComboBox.SelectedIndex = -1;
                        Zip64Checkbox.Enabled = false;
                        UserInfoGroupBox.Enabled = false;
                        KeepOldFilesCheckBox.Enabled = false;
                        AsciiTranslateCheckBox.Enabled = false;
                        StreamOwnerCheckBox.Enabled = true;
                        BufferSizeTextBox.Enabled = false;
                        BufferSizeTextBox.Text = "";
                        break;
                    } // bzip2
                case 3:
                    {
                        PasswordTextBox.Text = "";
                        PasswordTextBox.Enabled = false;
                        CompressionLevelComboBox.Enabled = true;
                        CompressionLevelComboBox.SelectedIndex = 4;
                        EncodingComboBox.SelectedIndex = -1;
                        EncodingComboBox.Enabled = false;
                        SearchPatternTextBox.Enabled = false;
                        SearchPatternTextBox.Text = "";
                        SearchOptionComboBox.Enabled = false;
                        SearchOptionComboBox.SelectedIndex = -1;
                        Zip64Checkbox.Enabled = false;
                        UserInfoGroupBox.Enabled = false;
                        KeepOldFilesCheckBox.Enabled = false;
                        AsciiTranslateCheckBox.Enabled = false;
                        StreamOwnerCheckBox.Enabled = true;
                        BufferSizeTextBox.Enabled = true;
                        BufferSizeTextBox.Text = "81920";
                        break;
                    } // gzip
                case 4:
                    {
                        PasswordTextBox.Text = "";
                        PasswordTextBox.Enabled = false;
                        CompressionLevelComboBox.Enabled = false;
                        CompressionLevelComboBox.SelectedIndex = -1;
                        EncodingComboBox.SelectedIndex = -1;
                        EncodingComboBox.Enabled = false;
                        SearchPatternTextBox.Enabled = false;
                        SearchPatternTextBox.Text = "";
                        SearchOptionComboBox.Enabled = false;
                        SearchOptionComboBox.SelectedIndex = -1;
                        Zip64Checkbox.Enabled = false;
                        UserInfoGroupBox.Enabled = false;
                        KeepOldFilesCheckBox.Enabled = false;
                        AsciiTranslateCheckBox.Enabled = false;
                        StreamOwnerCheckBox.Enabled = false;
                        BufferSizeTextBox.Enabled = false;
                        BufferSizeTextBox.Text = "";
                        break;
                    } // lz
                case 5:
                    {
                        PasswordTextBox.Text = "";
                        PasswordTextBox.Enabled = false;
                        CompressionLevelComboBox.Enabled = false;
                        CompressionLevelComboBox.SelectedIndex = -1;
                        EncodingComboBox.SelectedIndex = -1;
                        EncodingComboBox.Enabled = false;
                        SearchPatternTextBox.Enabled = false;
                        SearchPatternTextBox.Text = "";
                        SearchOptionComboBox.Enabled = false;
                        SearchOptionComboBox.SelectedIndex = -1;
                        Zip64Checkbox.Enabled = false;
                        UserInfoGroupBox.Enabled = false;
                        KeepOldFilesCheckBox.Enabled = false;
                        AsciiTranslateCheckBox.Enabled = false;
                        StreamOwnerCheckBox.Enabled = false;
                        BufferSizeTextBox.Enabled = false;
                        BufferSizeTextBox.Text = "";
                        break;
                    } // lzma
                case 6:
                    {
                        PasswordTextBox.Text = "";
                        PasswordTextBox.Enabled = false;
                        CompressionLevelComboBox.Enabled = false;
                        CompressionLevelComboBox.SelectedIndex = -1;
                        EncodingComboBox.SelectedIndex = -1;
                        EncodingComboBox.Enabled = false;
                        SearchPatternTextBox.Enabled = false;
                        SearchPatternTextBox.Text = "";
                        SearchOptionComboBox.Enabled = false;
                        SearchOptionComboBox.SelectedIndex = -1;
                        Zip64Checkbox.Enabled = false;
                        UserInfoGroupBox.Enabled = false;
                        KeepOldFilesCheckBox.Enabled = false;
                        AsciiTranslateCheckBox.Enabled = false;
                        StreamOwnerCheckBox.Enabled = false;
                        BufferSizeTextBox.Enabled = false;
                        BufferSizeTextBox.Text = "";
                        break;
                    } // 7zip
                default:
                    {
                        PasswordTextBox.Text = "";
                        PasswordTextBox.Enabled = false;
                        CompressionLevelComboBox.Enabled = false;
                        CompressionLevelComboBox.SelectedIndex = -1;
                        EncodingComboBox.SelectedIndex = -1;
                        EncodingComboBox.Enabled = false;
                        SearchPatternTextBox.Enabled = false;
                        SearchPatternTextBox.Text = "";
                        SearchOptionComboBox.Enabled = false;
                        SearchOptionComboBox.SelectedIndex = -1;
                        Zip64Checkbox.Enabled = false;
                        UserInfoGroupBox.Enabled = false;
                        KeepOldFilesCheckBox.Enabled = false;
                        AsciiTranslateCheckBox.Enabled = false;
                        StreamOwnerCheckBox.Enabled = false;
                        BufferSizeTextBox.Enabled = false;
                        BufferSizeTextBox.Text = "";
                        break;
                    }
            }
        }

        private void TogglePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TogglePasswordCheckBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
                TogglePasswordCheckBox.Text = "Hide Password";
                return;
            }
            PasswordTextBox.PasswordChar = '\u25CF';
            TogglePasswordCheckBox.Text = "Show Password";
        }
    }
}
