using Archiver;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ExtractFromArchiveForm : Form
    {
        private string inPath;
        private string outPath;
        public ExtractFromArchiveForm()
        {
            InitializeComponent();

            PasswordTextBox.PasswordChar = '\u25CF';
            InPathComboBox.Text = MainForm.instance.currentPath;
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                var archiverType = Path.GetExtension(InPathComboBox.Text);

                if(TogglePasswordCheckBox.Checked && String.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    throw new ArgumentNullException(nameof(PasswordTextBox.Text));
                }

                var password = PasswordTextBox.Text.Trim();

                IArchiver arch;

                switch (archiverType)
                {
                    case ".zip":
                        {
                            Archiver.Zip.Zip archiver = new()
                            {
                                Password = password
                            };
                            archiver.Password = password;
                            arch = archiver;
                            break;
                        }
                    case ".tar":
                        {
                            Archiver.Tar.Tar archiver = new();
                            arch = archiver;
                            break;
                        }
                    case ".bzip2":
                        {
                            Archiver.BZip2.BZip2 archiver = new();
                            arch = archiver;
                            break;
                        }
                    case ".gzip":
                        {
                            Archiver.GZip.GZip archiver = new();
                            arch = archiver;
                            break;
                        }
                    case ".lz":
                        {
                            Archiver.Lz.Lz archiver = new();
                            arch = archiver;
                            break;
                        }
                    case ".lzma":
                        {
                            Archiver.Lzma.Lzma archiver = new();
                            arch = archiver;
                            break;
                        }
                    case ".rar":
                        {
                            Archiver.Rar.Rar archiver = new();
                            arch = archiver;
                            break;
                        }
                    case ".7zip":
                        {
                            Archiver.SevenZip.SevenZip archiver = new();
                            arch = archiver;
                            break;
                        }
                    default:
                        {
                            Archiver.Zip.Zip archiver = new();
                            arch = archiver;
                            break;
                        }
                }

                arch.Unarchive(inPath, outPath);
                MessageBox.Show("Operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProgressBar.Value = 100;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Error! Password can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProgressBar.Value = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error! " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProgressBar.Value = 0;
            }
        }

        private void BrowseInPathButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();

            openFileDialog.Filter = "Archived Files (*.zip;*.rar;*.7z;*.tar;*.gz;*.bz2;*.lz;*.lzma)|*.zip;*.rar;*.7z;*.tar;*.gz;*.bz2;*.lz;*.lzma|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string selectedDirectory = Path.GetDirectoryName(selectedFilePath);


                inPath = selectedFilePath;
                InPathComboBox.Text = inPath;
            }
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

        private void InPathComboBox_TextChanged(object sender, EventArgs e)
        {
            inPath = InPathComboBox.Text;
        }

        private void OutPathComboBox_TextChanged(object sender, EventArgs e)
        {
            outPath = OutPathComboBox.Text;
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
