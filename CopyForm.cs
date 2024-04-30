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
    public partial class CopyForm : Form
    {
        public static CopyForm instance;
        private string originalFilePath;
        private string fileName;
        public CopyForm()
        {
            InitializeComponent();

            instance = this;
            FromPathTextBox.Text = Path.GetFileName(MainForm.instance.currentPath);
            originalFilePath = MainForm.instance.currentPath;
            var selectedItems = MainForm.instance.selectedItems;
            try
            {
                if (selectedItems == null)
                {
                    throw new ArgumentNullException("You must select an item.", nameof(selectedItems));
                }
                fileName = selectedItems[0].Text;
                FromPathTextBox.Text = fileName;
            }
            catch (Exception)
            {
                MessageBox.Show("Error! You must select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                this.Dispose();
            }

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ToPathTextBox.Text)) return;

            try
            {
                File.Copy(originalFilePath + @"\" + fileName, originalFilePath + @"\" + ToPathTextBox.Text);
                MainForm.instance.ChangeComboBoxText();
                MessageBox.Show("Operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error! " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
