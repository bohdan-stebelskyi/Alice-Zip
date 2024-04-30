namespace WindowsForms
{
    partial class ChecksumInformationForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.ChecksumListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(673, 414);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(115, 32);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ChecksumListView
            // 
            this.ChecksumListView.HideSelection = false;
            this.ChecksumListView.Location = new System.Drawing.Point(12, 12);
            this.ChecksumListView.Name = "ChecksumListView";
            this.ChecksumListView.Size = new System.Drawing.Size(776, 388);
            this.ChecksumListView.TabIndex = 0;
            this.ChecksumListView.UseCompatibleStateImageBehavior = false;
            this.ChecksumListView.View = System.Windows.Forms.View.Details;
            // 
            // ChecksumInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ChecksumListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChecksumInformationForm";
            this.ShowIcon = false;
            this.Text = "Checksum information";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ListView ChecksumListView;
    }
}