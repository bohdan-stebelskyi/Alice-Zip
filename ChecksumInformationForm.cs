using Checksum;
using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ChecksumInformationForm : Form
    {
        public ChecksumInformationForm(string checksumName, string path)
        {
            InitializeComponent();

            try
            {
                ChecksumListView.Columns.Add(checksumName, -2, HorizontalAlignment.Left);
                var checksum = ChecksumFactory.CreateChecksum(checksumName);
                ChecksumListView.Items.Add(checksum.CalculateChecksum(path));
            }
            catch {
                this.Close();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
