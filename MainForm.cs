using Checksum.Sha256;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public string currentPath;
        public System.Windows.Forms.ListView.SelectedListViewItemCollection selectedItems;

        public MainForm()
        {
            InitializeComponent();

            instance = this;
            selectedItems = FolderListView.SelectedItems;
            currentPath = PathComboBox.Text;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FolderListView = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRC32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRC64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.BackButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MoveToButton = new System.Windows.Forms.Button();
            this.ExtractFromArchiveButton = new System.Windows.Forms.Button();
            this.AddToArchiveButton = new System.Windows.Forms.Button();
            this.CopyToButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderListView
            // 
            this.FolderListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSize,
            this.columnHeaderModified,
            this.columnHeaderCreated});
            this.FolderListView.HideSelection = false;
            this.FolderListView.LabelEdit = true;
            this.FolderListView.Location = new System.Drawing.Point(13, 119);
            this.FolderListView.Name = "FolderListView";
            this.FolderListView.Size = new System.Drawing.Size(820, 296);
            this.FolderListView.TabIndex = 0;
            this.FolderListView.UseCompatibleStateImageBehavior = false;
            this.FolderListView.View = System.Windows.Forms.View.Details;
            this.FolderListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.FolderListView_ColumnClick);
            this.FolderListView.ItemActivate += new System.EventHandler(this.FolderListView_ItemActivate);
            this.FolderListView.SelectedIndexChanged += new System.EventHandler(this.FolderListView_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 200;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            this.columnHeaderSize.Width = 200;
            // 
            // columnHeaderModified
            // 
            this.columnHeaderModified.Text = "Modified";
            this.columnHeaderModified.Width = 200;
            // 
            // columnHeaderCreated
            // 
            this.columnHeaderCreated.Text = "Created";
            this.columnHeaderCreated.Width = 200;
            // 
            // PathComboBox
            // 
            this.PathComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PathComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.PathComboBox.FormattingEnabled = true;
            this.PathComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.PathComboBox.Location = new System.Drawing.Point(43, 84);
            this.PathComboBox.Name = "PathComboBox";
            this.PathComboBox.Size = new System.Drawing.Size(790, 21);
            this.PathComboBox.TabIndex = 1;
            this.PathComboBox.TextChanged += new System.EventHandler(this.PathComboBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(757, 45);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 28);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.viewToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.toolStripSeparator1,
            this.renameToolStripMenuItem,
            this.copyToToolStripMenuItem,
            this.moveToToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.propertiesToolStripMenuItem,
            this.cRCToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.toolStripMenuItem1.Text = "Files";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.viewToolStripMenuItem1.Text = "View";
            this.viewToolStripMenuItem1.Click += new System.EventHandler(this.viewToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // copyToToolStripMenuItem
            // 
            this.copyToToolStripMenuItem.Name = "copyToToolStripMenuItem";
            this.copyToToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.copyToToolStripMenuItem.Text = "Copy To...";
            this.copyToToolStripMenuItem.Click += new System.EventHandler(this.copyToToolStripMenuItem_Click);
            // 
            // moveToToolStripMenuItem
            // 
            this.moveToToolStripMenuItem.Name = "moveToToolStripMenuItem";
            this.moveToToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.moveToToolStripMenuItem.Text = "Move To...";
            this.moveToToolStripMenuItem.Click += new System.EventHandler(this.moveToToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // cRCToolStripMenuItem
            // 
            this.cRCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRC32ToolStripMenuItem,
            this.cRC64ToolStripMenuItem,
            this.sHA1ToolStripMenuItem,
            this.sHA256ToolStripMenuItem,
            this.aDlerToolStripMenuItem});
            this.cRCToolStripMenuItem.Name = "cRCToolStripMenuItem";
            this.cRCToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.cRCToolStripMenuItem.Text = "CRC";
            // 
            // cRC32ToolStripMenuItem
            // 
            this.cRC32ToolStripMenuItem.Name = "cRC32ToolStripMenuItem";
            this.cRC32ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cRC32ToolStripMenuItem.Text = "CRC-32";
            this.cRC32ToolStripMenuItem.Click += new System.EventHandler(this.cRC32ToolStripMenuItem_Click);
            // 
            // cRC64ToolStripMenuItem
            // 
            this.cRC64ToolStripMenuItem.Name = "cRC64ToolStripMenuItem";
            this.cRC64ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cRC64ToolStripMenuItem.Text = "CRC-64";
            this.cRC64ToolStripMenuItem.Click += new System.EventHandler(this.cRC64ToolStripMenuItem_Click);
            // 
            // sHA1ToolStripMenuItem
            // 
            this.sHA1ToolStripMenuItem.Name = "sHA1ToolStripMenuItem";
            this.sHA1ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sHA1ToolStripMenuItem.Text = "SHA-1";
            this.sHA1ToolStripMenuItem.Click += new System.EventHandler(this.sHA1ToolStripMenuItem_Click);
            // 
            // sHA256ToolStripMenuItem
            // 
            this.sHA256ToolStripMenuItem.Name = "sHA256ToolStripMenuItem";
            this.sHA256ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sHA256ToolStripMenuItem.Text = "SHA-256";
            this.sHA256ToolStripMenuItem.Click += new System.EventHandler(this.sHA256ToolStripMenuItem_Click);
            // 
            // aDlerToolStripMenuItem
            // 
            this.aDlerToolStripMenuItem.Name = "aDlerToolStripMenuItem";
            this.aDlerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aDlerToolStripMenuItem.Text = "Adler32";
            this.aDlerToolStripMenuItem.Click += new System.EventHandler(this.aDlerToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(125, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem,
            this.invertSectionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.deselectAllToolStripMenuItem.Text = "Deselect All";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // invertSectionToolStripMenuItem
            // 
            this.invertSectionToolStripMenuItem.Name = "invertSectionToolStripMenuItem";
            this.invertSectionToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.invertSectionToolStripMenuItem.Text = "Invert Section";
            this.invertSectionToolStripMenuItem.Click += new System.EventHandler(this.invertSectionToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.listToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.toolStripSeparator6,
            this.nameToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.sizeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // largeIconsToolStripMenuItem
            // 
            this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
            this.largeIconsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.largeIconsToolStripMenuItem.Text = "Large Icons";
            this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.largeIconsToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.smallIconsToolStripMenuItem.Text = "Small Icons";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(131, 6);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.typeToolStripMenuItem.Text = "Type";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(844, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 84);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(24, 21);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "..";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoButton.Location = new System.Drawing.Point(327, 35);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(57, 38);
            this.InfoButton.TabIndex = 10;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(264, 35);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(57, 38);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MoveToButton
            // 
            this.MoveToButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveToButton.FlatAppearance.BorderSize = 0;
            this.MoveToButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MoveToButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveToButton.Location = new System.Drawing.Point(201, 35);
            this.MoveToButton.Name = "MoveToButton";
            this.MoveToButton.Size = new System.Drawing.Size(57, 38);
            this.MoveToButton.TabIndex = 8;
            this.MoveToButton.Text = "Move";
            this.MoveToButton.UseVisualStyleBackColor = true;
            this.MoveToButton.Click += new System.EventHandler(this.MoveToButton_Click);
            // 
            // ExtractFromArchiveButton
            // 
            this.ExtractFromArchiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExtractFromArchiveButton.FlatAppearance.BorderSize = 0;
            this.ExtractFromArchiveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExtractFromArchiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtractFromArchiveButton.Location = new System.Drawing.Point(75, 35);
            this.ExtractFromArchiveButton.Name = "ExtractFromArchiveButton";
            this.ExtractFromArchiveButton.Size = new System.Drawing.Size(57, 38);
            this.ExtractFromArchiveButton.TabIndex = 5;
            this.ExtractFromArchiveButton.Text = "Extract";
            this.ExtractFromArchiveButton.UseVisualStyleBackColor = true;
            this.ExtractFromArchiveButton.Click += new System.EventHandler(this.ExtractFromArchiveButton_Click);
            // 
            // AddToArchiveButton
            // 
            this.AddToArchiveButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddToArchiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddToArchiveButton.FlatAppearance.BorderSize = 0;
            this.AddToArchiveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddToArchiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToArchiveButton.Location = new System.Drawing.Point(12, 35);
            this.AddToArchiveButton.Name = "AddToArchiveButton";
            this.AddToArchiveButton.Size = new System.Drawing.Size(57, 38);
            this.AddToArchiveButton.TabIndex = 4;
            this.AddToArchiveButton.Text = "Add";
            this.AddToArchiveButton.UseVisualStyleBackColor = false;
            this.AddToArchiveButton.Click += new System.EventHandler(this.AddToArchiveButton_Click);
            // 
            // CopyToButton
            // 
            this.CopyToButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CopyToButton.FlatAppearance.BorderSize = 0;
            this.CopyToButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CopyToButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyToButton.Location = new System.Drawing.Point(138, 35);
            this.CopyToButton.Name = "CopyToButton";
            this.CopyToButton.Size = new System.Drawing.Size(57, 38);
            this.CopyToButton.TabIndex = 7;
            this.CopyToButton.Text = "Copy";
            this.CopyToButton.UseVisualStyleBackColor = true;
            this.CopyToButton.Click += new System.EventHandler(this.CopyToButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(844, 441);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.MoveToButton);
            this.Controls.Add(this.CopyToButton);
            this.Controls.Add(this.ExtractFromArchiveButton);
            this.Controls.Add(this.AddToArchiveButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PathComboBox);
            this.Controls.Add(this.FolderListView);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(860, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AliceZip";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private int AddIconToListView(Icon icon, ImageList imageList)
        {
            try
            {
                imageList.Images.Add(icon.ToBitmap());
            }
            catch
            {
                MessageBox.Show(@"Error!", @"Couldn't load icon of the file!", MessageBoxButtons.OK);
            }

            return imageList.Images.Count - 1;
        }

        private void AddToArchiveButton_Click(object sender, EventArgs e)
        {
            var addToArchiveForm = new AddToArchiveForm();
            addToArchiveForm.ShowDialog();
        }

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e){
            FolderListView.View = View.LargeIcon;
            largeIconsToolStripMenuItem.Checked = true;
            smallIconsToolStripMenuItem.Checked = false;
            listToolStripMenuItem.Checked = false;
            detailsToolStripMenuItem.Checked = false;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderListView.View = View.SmallIcon;
            smallIconsToolStripMenuItem.Checked = true;
            largeIconsToolStripMenuItem.Checked = false;
            listToolStripMenuItem.Checked = false;
            detailsToolStripMenuItem.Checked = false;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e) 
        { 
            FolderListView.View = View.List;
            listToolStripMenuItem.Checked = true;
            smallIconsToolStripMenuItem.Checked = false;
            largeIconsToolStripMenuItem.Checked = false;
            detailsToolStripMenuItem.Checked = false;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderListView.View = View.Details;
            detailsToolStripMenuItem.Checked = true;
            smallIconsToolStripMenuItem.Checked = false;
            largeIconsToolStripMenuItem.Checked = false;
            listToolStripMenuItem.Checked = false;
        }

        private void OpenRenameForm()
        {
            try
            {
                var renameForm = new RenameForm();
                renameForm.Show();
            }
            catch { }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRenameForm();
        }

        private void ShowProperties() {
            if (selectedItems == null || selectedItems.Count == 0)
            {
                MessageBox.Show("Error! You must select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RetrieveProperties.ShowFileProperties(selectedItems[0].Text);
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            ShowProperties();
        }

        public void ChangeComboBoxText()
        {
            if (string.IsNullOrEmpty(PathComboBox.Text))
            {
                return;
            }

            if (!File.Exists(PathComboBox.Text) && !Directory.Exists(PathComboBox.Text))
            {
                return;
            }

            FolderListView.Items.Clear();

            var imageList = new ImageList();
            FolderListView.SmallImageList = imageList;

            string[] fileEntries;
            string[] directoryEntries;

            try
            {
                fileEntries = Directory.GetFiles(PathComboBox.Text);
                directoryEntries = Directory.GetDirectories(PathComboBox.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Error! " + exception.Message, @"Error!", MessageBoxButtons.OK);
                PathComboBox.Text = string.Concat(Directory.GetParent(PathComboBox.Text)?.FullName, @"\");
                return;
            }

            var directoryIcon = IconExtractor.FolderLarge;
            var directoryIconIndex = AddIconToListView(directoryIcon, imageList);

            foreach (var directory in directoryEntries)
            {
                if (string.IsNullOrEmpty(directory))
                {
                    continue;
                }

                var directoryInfo = new DirectoryInfo(directory);

                var item = new ListViewItem(Path.GetFileName(directory), directoryIconIndex);

                item.SubItems.Add("");
                item.SubItems.Add(directoryInfo.LastWriteTimeUtc.ToString(CultureInfo.CurrentCulture));
                item.SubItems.Add(directoryInfo.CreationTimeUtc.ToString(CultureInfo.CurrentCulture));

                FolderListView.Items.Add(item);
            }

            foreach (var file in fileEntries)
            {
                if (string.IsNullOrEmpty(file))
                {
                    continue;
                }

                var fileInfo = new FileInfo(file);

                var fileIcon = Icon.ExtractAssociatedIcon(file);

                var iconIndex = AddIconToListView(fileIcon, imageList);

                var item = new ListViewItem(Path.GetFileName(fileInfo.Name), iconIndex);

                item.SubItems.Add(fileInfo.Length.ToString());
                item.SubItems.Add(fileInfo.LastWriteTimeUtc.ToString(CultureInfo.CurrentCulture));
                item.SubItems.Add(fileInfo.CreationTimeUtc.ToString(CultureInfo.CurrentCulture));


                FolderListView.Items.Add(item);
            }

            if (!PathComboBox.Items.Contains(PathComboBox.Text))
            {
                PathComboBox.Items.Add(PathComboBox.Text);
            }

            currentPath = PathComboBox.Text;
        }

        private void PathComboBox_TextChanged(object sender, EventArgs e)
        {
            ChangeComboBoxText();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PathComboBox.Text))
            {
                return;
            }

            string levelHigherPath = Directory.GetParent(PathComboBox.Text)?.FullName;

            if (string.IsNullOrEmpty(levelHigherPath))
            {
                return;
            }

            PathComboBox.Text = levelHigherPath;
        }

        private void FolderListView_ItemActivate(object sender, EventArgs e)
        {
            var selectedItem = FolderListView.SelectedItems[0];

            var newPath = Path.Combine(PathComboBox.Text, selectedItem.SubItems[0].Text);

            var attributes = File.GetAttributes(newPath);

            if ((attributes & FileAttributes.Directory) == FileAttributes.Directory) {
                PathComboBox.Text = newPath;
                return;
            }

            try
            {
                Process.Start(newPath);
            }catch(System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("No application is associated with the specified file!", "Error!", MessageBoxButtons.OK);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FolderListView == null || FolderListView.SelectedItems.Count == 0)
            {
                return;
            }

            var selectedItem = FolderListView.SelectedItems[0];

            var newPath = Path.Combine(PathComboBox.Text, selectedItem.SubItems[0].Text);

            var attributes = File.GetAttributes(newPath);

            if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                return;
            }

            try
            {
                Process.Start(newPath);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("No application is associated with the specified file!", "Error!", MessageBoxButtons.OK);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FolderListView == null || FolderListView.SelectedItems.Count == 0)
            {
                return;
            }

            var selectedItem = FolderListView.SelectedItems[0];

            var newPath = Path.Combine(PathComboBox.Text, selectedItem.SubItems[0].Text);

            var attributes = File.GetAttributes(newPath);

            if ((attributes & FileAttributes.Directory) != FileAttributes.Directory)
            {
                return;
            }

            PathComboBox.Text = newPath;
        }

        private void FolderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItems = FolderListView.SelectedItems;
        }

        private void copyToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var copyForm = new CopyForm();
            try
            {
                copyForm.ShowDialog();
            }
            catch { }
        }

        private void cRC32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(selectedItems == null || selectedItems.Count == 0)
            {
                return;
            }

            var checksumInformation = new ChecksumInformationForm("crc32", PathComboBox.Text + @"\" + Path.GetFileName(selectedItems[0].Text));

            if (checksumInformation == null)
            {
                return;
            }

            if (!checksumInformation.IsDisposed)
            {
                checksumInformation.Show();
            }
        }

        private void cRC64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedItems == null || selectedItems.Count == 0)
            {
                return;
            }

            var checksumInformation = new ChecksumInformationForm("crc64", PathComboBox.Text + @"\" + Path.GetFileName(selectedItems[0].Text));

            if (checksumInformation == null)
            {
                return;
            }

            if (!checksumInformation.IsDisposed)
            {
                checksumInformation.Show();
            }
        }

        private void sHA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedItems == null || selectedItems.Count == 0)
            {
                return;
            }

            var checksumInformation = new ChecksumInformationForm("sha1", PathComboBox.Text + @"\" + Path.GetFileName(selectedItems[0].Text));

            if (checksumInformation == null)
            {
                return;
            }

            if (!checksumInformation.IsDisposed)
            {
                checksumInformation.Show();
            }
        }

        private void sHA256ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedItems == null || selectedItems.Count == 0)
            {
                return;
            }

            var checksumInformation = new ChecksumInformationForm("sha256", PathComboBox.Text + @"\" + Path.GetFileName(selectedItems[0].Text));

            if (checksumInformation == null)
            {
                return;
            }

            if (!checksumInformation.IsDisposed)
            {
                checksumInformation.Show();
            }
        }

        private void ExtractFromArchiveButton_Click(object sender, EventArgs e)
        {
            var extractFromArchiveForm = new ExtractFromArchiveForm();
            extractFromArchiveForm.ShowDialog();
        }

        private void MoveToButton_Click(object sender, EventArgs e)
        {
            var moveForm = new MoveForm();
            try
            {
                moveForm.ShowDialog();
            }
            catch { }
        }

        private void DeleteFile()
        {
            if (selectedItems == null || selectedItems.Count == 0)
            {
                MessageBox.Show("Error! You must select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                foreach (ListViewItem item in selectedItems)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.Delete(PathComboBox.Text + @"\" + item.Text);
                    }
                }

                MainForm.instance.ChangeComboBoxText();
                MessageBox.Show("Operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error! " + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void CopyToButton_Click(object sender, EventArgs e)
        {
            var copyForm = new CopyForm();
            try
            {
                copyForm.ShowDialog();
            }
            catch { }
        }

        private void aDlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedItems == null || selectedItems.Count == 0)
            {
                return;
            }

            var checksumInformation = new ChecksumInformationForm("adler32", PathComboBox.Text + @"\" + Path.GetFileName(selectedItems[0].Text));

            if (checksumInformation == null)
            {
                return;
            }

            if (!checksumInformation.IsDisposed)
            {
                checksumInformation.Show();
            }
        }

        private void createFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(FolderListView == null || FolderListView.SelectedItems.Count == 0)
            {
                return;
            }

            var selectedItem = FolderListView.SelectedItems[0];

            var newPath = Path.Combine(PathComboBox.Text, selectedItem.SubItems[0].Text);

            var attributes = File.GetAttributes(newPath);

            if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                return;
            }

            try
            {
                Process.Start("notepad.exe", newPath);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("No application is associated with the specified file!", "Error!", MessageBoxButtons.OK);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProperties();
        }

        private void moveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var moveForm = new MoveForm();
            try
            {
                moveForm.ShowDialog();
            }
            catch { }
        }

        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PathComboBox.Text))
            {
                return;
            }

            if (!File.Exists(PathComboBox.Text) && !Directory.Exists(PathComboBox.Text))
            {
                return;
            }

            FolderListView.Items.Clear();

            ImageList imageList = new();
            FolderListView.SmallImageList = imageList;

            var directoryEntries = Directory.GetDirectories(PathComboBox.Text);

            foreach (var directory in directoryEntries)
            {
                if (string.IsNullOrEmpty(directory))
                {
                    continue;
                }

                var directoryInfo = new DirectoryInfo(directory);

                var directoryIcon = IconExtractor.FolderLarge;

                var iconIndex = AddIconToListView(directoryIcon, imageList);

                var item = new ListViewItem(Path.GetFileName(directory), iconIndex);

                item.SubItems.Add("");
                item.SubItems.Add(directoryInfo.LastWriteTimeUtc.ToString(CultureInfo.CurrentCulture));
                item.SubItems.Add(directoryInfo.CreationTimeUtc.ToString(CultureInfo.CurrentCulture));

                FolderListView.Items.Add(item);
            }

            var fileEntries = Directory.GetFiles(PathComboBox.Text);

            foreach (var file in fileEntries)
            {
                if (string.IsNullOrEmpty(file)) continue;

                var fileInfo = new FileInfo(file);

                var fileIcon = Icon.ExtractAssociatedIcon(file);

                var iconIndex = AddIconToListView(fileIcon, imageList);

                var item = new ListViewItem(Path.GetFileName(fileInfo.Name), iconIndex);

                item.SubItems.Add(fileInfo.Length.ToString());
                item.SubItems.Add(fileInfo.LastWriteTimeUtc.ToString(CultureInfo.CurrentCulture));
                item.SubItems.Add(fileInfo.CreationTimeUtc.ToString(CultureInfo.CurrentCulture));

                FolderListView.Items.Add(item);
            }
        }

        enum SortingCriteria
        {
            None = -1, Name = 0, Type = 1, Date = 2, Size = 3
        }
        private List<ListViewItem> SortListViewItems(System.Windows.Forms.ListView listView, SortingCriteria sortingCriteria)
        {
            List<ListViewItem> sortedItems = new List<ListViewItem>();

            switch (sortingCriteria)
            {
                case SortingCriteria.Name:
                    sortedItems = listView.Items.Cast<ListViewItem>().OrderBy(item => item.Text).ToList();
                    break;
                case SortingCriteria.Type:
                    sortedItems = listView.Items.Cast<ListViewItem>().OrderBy(item => item.SubItems[1].Text).ToList();
                    break;
                case SortingCriteria.Date:
                    sortedItems = listView.Items.Cast<ListViewItem>().OrderBy(item => DateTime.Parse(item.SubItems[2].Text)).ToList();
                    break;
                case SortingCriteria.Size:
                    sortedItems = listView.Items
                        .Cast<ListViewItem>()
                        .OrderBy(item =>
                        {
                            string sizeString = item.SubItems[3].Text;
                            long size;
                            if (long.TryParse(new string(sizeString.Where(char.IsDigit).ToArray()), out size))
                            {
                                return size;
                            }
                            else
                            {
                                return long.MinValue;
                            }
                        })
                        .ToList();
                    break;
                default:
                    sortedItems = listView.Items.Cast<ListViewItem>().ToList();
                    break;
            }

            return sortedItems;
        }
        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ListViewItem> sortedItems = SortListViewItems(FolderListView, SortingCriteria.Name);

            FolderListView.Items.Clear();

            foreach (var item in sortedItems)
            {
                FolderListView.Items.Add(item);
            }
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ListViewItem> sortedItems = SortListViewItems(FolderListView, SortingCriteria.Type);

            FolderListView.Items.Clear();

            foreach (var item in sortedItems)
            {
                FolderListView.Items.Add(item);
            }
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ListViewItem> sortedItems = SortListViewItems(FolderListView, SortingCriteria.Date);

            FolderListView.Items.Clear();

            foreach (var item in sortedItems)
            {
                FolderListView.Items.Add(item);
            }
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ListViewItem> sortedItems = SortListViewItems(FolderListView, SortingCriteria.Size);

            FolderListView.Items.Clear();

            foreach (var item in sortedItems)
            {
                FolderListView.Items.Add(item);
            }
        }

        private void FolderListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            List<ListViewItem> sortedItems;
            switch (e.Column)
            {
                case 0:
                    {
                        sortedItems = SortListViewItems(FolderListView, SortingCriteria.Name);
                        break;
                    }
                case 1:
                    {
                        sortedItems = SortListViewItems(FolderListView, SortingCriteria.Size);
                        break;
                    }
                case 2:
                    {
                        sortedItems = SortListViewItems(FolderListView, SortingCriteria.Date);
                        break;
                    }
                case 3:
                    {
                        sortedItems = SortListViewItems(FolderListView, SortingCriteria.Date);
                        break;
                    }
                default:
                    {
                        sortedItems = SortListViewItems(FolderListView, SortingCriteria.None);
                        break;
                    }
            }

            FolderListView.Items.Clear();

            foreach (var item in sortedItems)
            {
                FolderListView.Items.Add(item);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderListView.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Selected = true);
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderListView.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Selected = false);
        }

        private void invertSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderListView.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Selected = !item.Selected);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm preLoaderForm = new();
            preLoaderForm.ShowDialog();
        }
    }
}
