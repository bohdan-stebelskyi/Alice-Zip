namespace WindowsForms
{
    partial class MoveForm
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
            this.FromPathLabel = new System.Windows.Forms.Label();
            this.ToPathLabel = new System.Windows.Forms.Label();
            this.FromPathTextBox = new System.Windows.Forms.TextBox();
            this.ToPathTextBox = new System.Windows.Forms.TextBox();
            this.MoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromPathLabel
            // 
            this.FromPathLabel.AutoSize = true;
            this.FromPathLabel.Location = new System.Drawing.Point(15, 15);
            this.FromPathLabel.Name = "FromPathLabel";
            this.FromPathLabel.Size = new System.Drawing.Size(33, 13);
            this.FromPathLabel.TabIndex = 0;
            this.FromPathLabel.Text = "From:";
            // 
            // ToPathLabel
            // 
            this.ToPathLabel.AutoSize = true;
            this.ToPathLabel.Location = new System.Drawing.Point(25, 42);
            this.ToPathLabel.Name = "ToPathLabel";
            this.ToPathLabel.Size = new System.Drawing.Size(23, 13);
            this.ToPathLabel.TabIndex = 1;
            this.ToPathLabel.Text = "To:";
            // 
            // FromPathTextBox
            // 
            this.FromPathTextBox.Location = new System.Drawing.Point(61, 12);
            this.FromPathTextBox.Name = "FromPathTextBox";
            this.FromPathTextBox.Size = new System.Drawing.Size(196, 20);
            this.FromPathTextBox.TabIndex = 2;
            // 
            // ToPathTextBox
            // 
            this.ToPathTextBox.Location = new System.Drawing.Point(61, 39);
            this.ToPathTextBox.Name = "ToPathTextBox";
            this.ToPathTextBox.Size = new System.Drawing.Size(196, 20);
            this.ToPathTextBox.TabIndex = 3;
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(182, 71);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(75, 23);
            this.MoveButton.TabIndex = 4;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 103);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.ToPathTextBox);
            this.Controls.Add(this.FromPathTextBox);
            this.Controls.Add(this.ToPathLabel);
            this.Controls.Add(this.FromPathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Move";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromPathLabel;
        private System.Windows.Forms.Label ToPathLabel;
        private System.Windows.Forms.TextBox FromPathTextBox;
        private System.Windows.Forms.TextBox ToPathTextBox;
        private System.Windows.Forms.Button MoveButton;
    }
}