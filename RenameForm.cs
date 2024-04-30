using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsForms
{
    public partial class RenameForm : Form
    {
        public static RenameForm instance;
        private string originalFilePath;
        private string fileName;
        public RenameForm()
        {
            InitializeComponent();
            instance = this;
            renameTextBox.Text = Path.GetFileName(MainForm.instance.currentPath);
            originalFilePath = MainForm.instance.currentPath;
            var selectedItems = MainForm.instance.selectedItems;
            try {
                if(selectedItems == null)
                {
                    throw new ArgumentNullException("You must select an item", nameof(selectedItems));
                }
                renameTextBox.Text = selectedItems[0].Text;
                fileName = selectedItems[0].Text;
            }catch (Exception) {
                MessageBox.Show("Error! You must select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                this.Dispose();
            }
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(renameTextBox.Text))
            {
                return;
            }

            try
            {
                File.Move(originalFilePath + @"\" + fileName, originalFilePath + @"\" + renameTextBox.Text);
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
