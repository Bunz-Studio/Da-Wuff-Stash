namespace DaWuffStash
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ptHomepage = new System.Windows.Forms.Label();
            this.ptListing = new System.Windows.Forms.Label();
            this.contentPlacementPanel = new System.Windows.Forms.Panel();
            this.settingsControl = new System.Windows.Forms.Panel();
            this.Sets_HideTrayBox = new System.Windows.Forms.CheckBox();
            this.Sets_ResetButtonLB = new System.Windows.Forms.Label();
            this.Sets_ImageViewDropdown = new System.Windows.Forms.ComboBox();
            this.Sets_ImageViewLabel = new System.Windows.Forms.Label();
            this.Sets_OpenSavePathLB = new System.Windows.Forms.Label();
            this.Sets_SavePathBox = new DaWuffStash.StylizedTextBox();
            this.Sets_SavePath = new System.Windows.Forms.Label();
            this.Sets_StorageHeader = new System.Windows.Forms.Label();
            this.Sets_HostDropdown = new System.Windows.Forms.ComboBox();
            this.Sets_GeneralHeader = new System.Windows.Forms.Label();
            this.Sets_HostLabel = new System.Windows.Forms.Label();
            this.Sets_HideToTrayLabel = new System.Windows.Forms.Label();
            this.homepageControl = new DaWuffStash.Panels.HomepageControl();
            this.listingControl = new DaWuffStash.Panels.ListingControl();
            this.viewerControl = new DaWuffStash.Panels.ViewerControl();
            this.ptViewer = new System.Windows.Forms.Label();
            this.ptSettings = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentPlacementPanel.SuspendLayout();
            this.settingsControl.SuspendLayout();
            this.trayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptHomepage
            // 
            this.ptHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.ptHomepage.Location = new System.Drawing.Point(5, 5);
            this.ptHomepage.Name = "ptHomepage";
            this.ptHomepage.Size = new System.Drawing.Size(86, 27);
            this.ptHomepage.TabIndex = 0;
            this.ptHomepage.Text = "Homepage";
            this.ptHomepage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ptHomepage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptHomepage_MouseUp);
            // 
            // ptListing
            // 
            this.ptListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.ptListing.Location = new System.Drawing.Point(95, 5);
            this.ptListing.Name = "ptListing";
            this.ptListing.Size = new System.Drawing.Size(85, 27);
            this.ptListing.TabIndex = 1;
            this.ptListing.Text = "Listing";
            this.ptListing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ptListing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptListing_MouseUp);
            // 
            // contentPlacementPanel
            // 
            this.contentPlacementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPlacementPanel.Controls.Add(this.settingsControl);
            this.contentPlacementPanel.Controls.Add(this.homepageControl);
            this.contentPlacementPanel.Controls.Add(this.listingControl);
            this.contentPlacementPanel.Controls.Add(this.viewerControl);
            this.contentPlacementPanel.Location = new System.Drawing.Point(5, 35);
            this.contentPlacementPanel.Name = "contentPlacementPanel";
            this.contentPlacementPanel.Size = new System.Drawing.Size(931, 457);
            this.contentPlacementPanel.TabIndex = 2;
            // 
            // settingsControl
            // 
            this.settingsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsControl.Controls.Add(this.Sets_HideTrayBox);
            this.settingsControl.Controls.Add(this.Sets_ResetButtonLB);
            this.settingsControl.Controls.Add(this.Sets_ImageViewDropdown);
            this.settingsControl.Controls.Add(this.Sets_ImageViewLabel);
            this.settingsControl.Controls.Add(this.Sets_OpenSavePathLB);
            this.settingsControl.Controls.Add(this.Sets_SavePathBox);
            this.settingsControl.Controls.Add(this.Sets_SavePath);
            this.settingsControl.Controls.Add(this.Sets_StorageHeader);
            this.settingsControl.Controls.Add(this.Sets_HostDropdown);
            this.settingsControl.Controls.Add(this.Sets_GeneralHeader);
            this.settingsControl.Controls.Add(this.Sets_HostLabel);
            this.settingsControl.Controls.Add(this.Sets_HideToTrayLabel);
            this.settingsControl.Location = new System.Drawing.Point(0, 0);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(931, 457);
            this.settingsControl.TabIndex = 3;
            // 
            // Sets_HideTrayBox
            // 
            this.Sets_HideTrayBox.AutoSize = true;
            this.Sets_HideTrayBox.Location = new System.Drawing.Point(109, 99);
            this.Sets_HideTrayBox.Name = "Sets_HideTrayBox";
            this.Sets_HideTrayBox.Size = new System.Drawing.Size(15, 14);
            this.Sets_HideTrayBox.TabIndex = 10;
            this.Sets_HideTrayBox.UseVisualStyleBackColor = true;
            this.Sets_HideTrayBox.CheckedChanged += new System.EventHandler(this.Sets_HideTrayBox_CheckedChanged);
            // 
            // Sets_ResetButtonLB
            // 
            this.Sets_ResetButtonLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(61)))), ((int)(((byte)(101)))));
            this.Sets_ResetButtonLB.Location = new System.Drawing.Point(528, 47);
            this.Sets_ResetButtonLB.Name = "Sets_ResetButtonLB";
            this.Sets_ResetButtonLB.Size = new System.Drawing.Size(53, 23);
            this.Sets_ResetButtonLB.TabIndex = 9;
            this.Sets_ResetButtonLB.Text = "Reset";
            this.Sets_ResetButtonLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sets_ResetButtonLB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sets_ResetButtonLB_MouseUp);
            // 
            // Sets_ImageViewDropdown
            // 
            this.Sets_ImageViewDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sets_ImageViewDropdown.FormattingEnabled = true;
            this.Sets_ImageViewDropdown.Items.AddRange(new object[] {
            "Native Picture Box",
            "Embedded Web Browser"});
            this.Sets_ImageViewDropdown.Location = new System.Drawing.Point(109, 73);
            this.Sets_ImageViewDropdown.Name = "Sets_ImageViewDropdown";
            this.Sets_ImageViewDropdown.Size = new System.Drawing.Size(130, 21);
            this.Sets_ImageViewDropdown.TabIndex = 8;
            // 
            // Sets_ImageViewLabel
            // 
            this.Sets_ImageViewLabel.Location = new System.Drawing.Point(18, 70);
            this.Sets_ImageViewLabel.Name = "Sets_ImageViewLabel";
            this.Sets_ImageViewLabel.Size = new System.Drawing.Size(100, 23);
            this.Sets_ImageViewLabel.TabIndex = 7;
            this.Sets_ImageViewLabel.Text = "Image View";
            this.Sets_ImageViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sets_OpenSavePathLB
            // 
            this.Sets_OpenSavePathLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(61)))), ((int)(((byte)(101)))));
            this.Sets_OpenSavePathLB.Location = new System.Drawing.Point(583, 47);
            this.Sets_OpenSavePathLB.Name = "Sets_OpenSavePathLB";
            this.Sets_OpenSavePathLB.Size = new System.Drawing.Size(45, 23);
            this.Sets_OpenSavePathLB.TabIndex = 6;
            this.Sets_OpenSavePathLB.Text = "Open";
            this.Sets_OpenSavePathLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sets_OpenSavePathLB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sets_OpenSavePathLB_MouseUp);
            // 
            // Sets_SavePathBox
            // 
            this.Sets_SavePathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Sets_SavePathBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Sets_SavePathBox.Location = new System.Drawing.Point(352, 47);
            this.Sets_SavePathBox.Name = "Sets_SavePathBox";
            this.Sets_SavePathBox.ReadOnly = false;
            this.Sets_SavePathBox.Size = new System.Drawing.Size(174, 22);
            this.Sets_SavePathBox.TabIndex = 5;
            // 
            // Sets_SavePath
            // 
            this.Sets_SavePath.Location = new System.Drawing.Point(246, 47);
            this.Sets_SavePath.Name = "Sets_SavePath";
            this.Sets_SavePath.Size = new System.Drawing.Size(100, 23);
            this.Sets_SavePath.TabIndex = 4;
            this.Sets_SavePath.Text = "Save Path";
            this.Sets_SavePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sets_StorageHeader
            // 
            this.Sets_StorageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(57)))), ((int)(((byte)(97)))));
            this.Sets_StorageHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Sets_StorageHeader.Location = new System.Drawing.Point(245, 15);
            this.Sets_StorageHeader.Name = "Sets_StorageHeader";
            this.Sets_StorageHeader.Size = new System.Drawing.Size(383, 29);
            this.Sets_StorageHeader.TabIndex = 3;
            this.Sets_StorageHeader.Text = "Storage";
            this.Sets_StorageHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sets_HostDropdown
            // 
            this.Sets_HostDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sets_HostDropdown.FormattingEnabled = true;
            this.Sets_HostDropdown.Items.AddRange(new object[] {
            "e926 (SFW)",
            "e621 (NSFW)"});
            this.Sets_HostDropdown.Location = new System.Drawing.Point(109, 49);
            this.Sets_HostDropdown.Name = "Sets_HostDropdown";
            this.Sets_HostDropdown.Size = new System.Drawing.Size(130, 21);
            this.Sets_HostDropdown.TabIndex = 1;
            // 
            // Sets_GeneralHeader
            // 
            this.Sets_GeneralHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(57)))), ((int)(((byte)(97)))));
            this.Sets_GeneralHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Sets_GeneralHeader.Location = new System.Drawing.Point(17, 15);
            this.Sets_GeneralHeader.Name = "Sets_GeneralHeader";
            this.Sets_GeneralHeader.Size = new System.Drawing.Size(222, 29);
            this.Sets_GeneralHeader.TabIndex = 0;
            this.Sets_GeneralHeader.Text = "General";
            this.Sets_GeneralHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sets_HostLabel
            // 
            this.Sets_HostLabel.Location = new System.Drawing.Point(18, 47);
            this.Sets_HostLabel.Name = "Sets_HostLabel";
            this.Sets_HostLabel.Size = new System.Drawing.Size(100, 23);
            this.Sets_HostLabel.TabIndex = 2;
            this.Sets_HostLabel.Text = "Host";
            this.Sets_HostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sets_HideToTrayLabel
            // 
            this.Sets_HideToTrayLabel.Location = new System.Drawing.Point(18, 94);
            this.Sets_HideToTrayLabel.Name = "Sets_HideToTrayLabel";
            this.Sets_HideToTrayLabel.Size = new System.Drawing.Size(100, 23);
            this.Sets_HideToTrayLabel.TabIndex = 11;
            this.Sets_HideToTrayLabel.Text = "Hide to tray";
            this.Sets_HideToTrayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // homepageControl
            // 
            this.homepageControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homepageControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.homepageControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.homepageControl.Location = new System.Drawing.Point(0, 0);
            this.homepageControl.Name = "homepageControl";
            this.homepageControl.Size = new System.Drawing.Size(931, 457);
            this.homepageControl.TabIndex = 0;
            // 
            // listingControl
            // 
            this.listingControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listingControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.listingControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.listingControl.Location = new System.Drawing.Point(0, 0);
            this.listingControl.Name = "listingControl";
            this.listingControl.Size = new System.Drawing.Size(931, 457);
            this.listingControl.TabIndex = 1;
            // 
            // viewerControl
            // 
            this.viewerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewerControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.viewerControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.viewerControl.Location = new System.Drawing.Point(0, 0);
            this.viewerControl.Name = "viewerControl";
            this.viewerControl.Size = new System.Drawing.Size(931, 457);
            this.viewerControl.TabIndex = 2;
            // 
            // ptViewer
            // 
            this.ptViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.ptViewer.Location = new System.Drawing.Point(184, 5);
            this.ptViewer.Name = "ptViewer";
            this.ptViewer.Size = new System.Drawing.Size(85, 27);
            this.ptViewer.TabIndex = 3;
            this.ptViewer.Text = "Viewer";
            this.ptViewer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ptViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptViewer_MouseUp);
            // 
            // ptSettings
            // 
            this.ptSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.ptSettings.Location = new System.Drawing.Point(271, 5);
            this.ptSettings.Name = "ptSettings";
            this.ptSettings.Size = new System.Drawing.Size(85, 27);
            this.ptSettings.TabIndex = 4;
            this.ptSettings.Text = "Settings";
            this.ptSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ptSettings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptSettings_MouseUp);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipText = "I\'m hiding here!";
            this.trayIcon.BalloonTipTitle = "Notice me! uwu";
            this.trayIcon.ContextMenuStrip = this.trayContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Da Wuff Stash";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(161, 79);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.ptSettings);
            this.Controls.Add(this.ptViewer);
            this.Controls.Add(this.contentPlacementPanel);
            this.Controls.Add(this.ptListing);
            this.Controls.Add(this.ptHomepage);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Da Wuff Stash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contentPlacementPanel.ResumeLayout(false);
            this.settingsControl.ResumeLayout(false);
            this.settingsControl.PerformLayout();
            this.trayContextMenu.ResumeLayout(false);
            this.trayContextMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ptHomepage;
        private System.Windows.Forms.Label ptListing;
        private System.Windows.Forms.Panel contentPlacementPanel;
        private Panels.HomepageControl homepageControl;
        private Panels.ListingControl listingControl;
        private System.Windows.Forms.Label ptViewer;
        private Panels.ViewerControl viewerControl;
        private System.Windows.Forms.Panel settingsControl;
        private System.Windows.Forms.Label Sets_GeneralHeader;
        private System.Windows.Forms.Label Sets_HostLabel;
        private System.Windows.Forms.ComboBox Sets_HostDropdown;
        private System.Windows.Forms.Label Sets_StorageHeader;
        private System.Windows.Forms.Label Sets_SavePath;
        private StylizedTextBox Sets_SavePathBox;
        private System.Windows.Forms.Label Sets_OpenSavePathLB;
        private System.Windows.Forms.ComboBox Sets_ImageViewDropdown;
        private System.Windows.Forms.Label Sets_ImageViewLabel;
        private System.Windows.Forms.Label ptSettings;
        private System.Windows.Forms.Label Sets_ResetButtonLB;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox Sets_HideTrayBox;
        private System.Windows.Forms.Label Sets_HideToTrayLabel;
    }
}

