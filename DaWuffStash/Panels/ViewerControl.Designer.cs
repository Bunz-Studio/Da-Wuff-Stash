namespace DaWuffStash.Panels
{
    partial class ViewerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerControl));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.openFileButton = new System.Windows.Forms.Label();
            this.sizeBox = new DaWuffStash.StylizedTextBox();
            this.heightBox = new DaWuffStash.StylizedTextBox();
            this.widthBox = new DaWuffStash.StylizedTextBox();
            this.idBox = new DaWuffStash.StylizedTextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sourcesList = new System.Windows.Forms.ListBox();
            this.tagsList = new System.Windows.Forms.ListBox();
            this.artistsList = new System.Windows.Forms.ListBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.OpenLinkButton = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.vlcControl = new Vlc.DotNet.Forms.VlcControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.vlcMediaControls = new System.Windows.Forms.Panel();
            this.CT_TrackBar = new System.Windows.Forms.TrackBar();
            this.CT_PlayLB = new System.Windows.Forms.Label();
            this.CT_PauseLB = new System.Windows.Forms.Label();
            this.CT_StopLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bottomConsole = new System.Windows.Forms.Panel();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.vlcMediaControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_TrackBar)).BeginInit();
            this.bottomConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(713, 457);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Visible = false;
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.Controls.Add(this.openFileButton);
            this.sidePanel.Controls.Add(this.sizeBox);
            this.sidePanel.Controls.Add(this.heightBox);
            this.sidePanel.Controls.Add(this.widthBox);
            this.sidePanel.Controls.Add(this.idBox);
            this.sidePanel.Controls.Add(this.numericUpDown);
            this.sidePanel.Controls.Add(this.sourcesList);
            this.sidePanel.Controls.Add(this.tagsList);
            this.sidePanel.Controls.Add(this.artistsList);
            this.sidePanel.Controls.Add(this.descriptionTextBox);
            this.sidePanel.Controls.Add(this.OpenLinkButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(214, 457);
            this.sidePanel.TabIndex = 1;
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileButton.Location = new System.Drawing.Point(151, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(59, 26);
            this.openFileButton.TabIndex = 10;
            this.openFileButton.Text = "Open File";
            this.openFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openFileButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openFileButton_MouseUp);
            // 
            // sizeBox
            // 
            this.sizeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sizeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sizeBox.Location = new System.Drawing.Point(116, 31);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.ReadOnly = true;
            this.sizeBox.Size = new System.Drawing.Size(54, 22);
            this.sizeBox.TabIndex = 9;
            // 
            // heightBox
            // 
            this.heightBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.heightBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.heightBox.Location = new System.Drawing.Point(61, 31);
            this.heightBox.Name = "heightBox";
            this.heightBox.ReadOnly = true;
            this.heightBox.Size = new System.Drawing.Size(54, 22);
            this.heightBox.TabIndex = 8;
            // 
            // widthBox
            // 
            this.widthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.widthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.widthBox.Location = new System.Drawing.Point(6, 31);
            this.widthBox.Name = "widthBox";
            this.widthBox.ReadOnly = true;
            this.widthBox.Size = new System.Drawing.Size(54, 22);
            this.widthBox.TabIndex = 7;
            // 
            // idBox
            // 
            this.idBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.idBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.idBox.Location = new System.Drawing.Point(6, 7);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(75, 22);
            this.idBox.TabIndex = 6;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown.Location = new System.Drawing.Point(171, 33);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown.TabIndex = 5;
            // 
            // sourcesList
            // 
            this.sourcesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourcesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourcesList.FormattingEnabled = true;
            this.sourcesList.Location = new System.Drawing.Point(6, 382);
            this.sourcesList.Name = "sourcesList";
            this.sourcesList.Size = new System.Drawing.Size(205, 67);
            this.sourcesList.TabIndex = 4;
            this.sourcesList.DoubleClick += new System.EventHandler(this.sourcesList_DoubleClick);
            // 
            // tagsList
            // 
            this.tagsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagsList.FormattingEnabled = true;
            this.tagsList.Location = new System.Drawing.Point(6, 242);
            this.tagsList.Name = "tagsList";
            this.tagsList.Size = new System.Drawing.Size(205, 119);
            this.tagsList.TabIndex = 3;
            this.tagsList.DoubleClick += new System.EventHandler(this.tagsList_DoubleClick);
            // 
            // artistsList
            // 
            this.artistsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artistsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.artistsList.FormattingEnabled = true;
            this.artistsList.Location = new System.Drawing.Point(6, 167);
            this.artistsList.Name = "artistsList";
            this.artistsList.Size = new System.Drawing.Size(205, 67);
            this.artistsList.TabIndex = 2;
            this.artistsList.DoubleClick += new System.EventHandler(this.artistsList_DoubleClick);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 59);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(205, 102);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.Text = "";
            // 
            // OpenLinkButton
            // 
            this.OpenLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenLinkButton.Location = new System.Drawing.Point(83, 3);
            this.OpenLinkButton.Name = "OpenLinkButton";
            this.OpenLinkButton.Size = new System.Drawing.Size(65, 26);
            this.OpenLinkButton.TabIndex = 0;
            this.OpenLinkButton.Text = "Open Link";
            this.OpenLinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenLinkButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OpenLinkButton_MouseUp);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(713, 457);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // loadingPanel
            // 
            this.loadingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingPanel.Controls.Add(this.loadingProgressBar);
            this.loadingPanel.Controls.Add(this.loadingLabel);
            this.loadingPanel.Location = new System.Drawing.Point(0, 409);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(713, 48);
            this.loadingPanel.TabIndex = 3;
            this.loadingPanel.Visible = false;
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingProgressBar.Location = new System.Drawing.Point(12, 25);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.Size = new System.Drawing.Size(688, 11);
            this.loadingProgressBar.TabIndex = 1;
            // 
            // loadingLabel
            // 
            this.loadingLabel.Location = new System.Drawing.Point(9, 7);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(100, 17);
            this.loadingLabel.TabIndex = 0;
            this.loadingLabel.Text = "Loading...";
            this.loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vlcControl
            // 
            this.vlcControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vlcControl.BackColor = System.Drawing.Color.Black;
            this.vlcControl.Location = new System.Drawing.Point(0, 0);
            this.vlcControl.Name = "vlcControl";
            this.vlcControl.Size = new System.Drawing.Size(713, 413);
            this.vlcControl.Spu = -1;
            this.vlcControl.TabIndex = 4;
            this.vlcControl.Text = "vlcControl1";
            this.vlcControl.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl.VlcLibDirectory")));
            this.vlcControl.VlcMediaplayerOptions = null;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.vlcMediaControls);
            this.splitContainer1.Panel1.Controls.Add(this.bottomConsole);
            this.splitContainer1.Panel1.Controls.Add(this.loadingPanel);
            this.splitContainer1.Panel1.Controls.Add(this.vlcControl);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.webBrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.sidePanel);
            this.splitContainer1.Size = new System.Drawing.Size(931, 457);
            this.splitContainer1.SplitterDistance = 713;
            this.splitContainer1.TabIndex = 5;
            // 
            // vlcMediaControls
            // 
            this.vlcMediaControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vlcMediaControls.Controls.Add(this.CT_TrackBar);
            this.vlcMediaControls.Controls.Add(this.CT_PlayLB);
            this.vlcMediaControls.Controls.Add(this.CT_PauseLB);
            this.vlcMediaControls.Controls.Add(this.CT_StopLB);
            this.vlcMediaControls.Controls.Add(this.label1);
            this.vlcMediaControls.Location = new System.Drawing.Point(0, 419);
            this.vlcMediaControls.Name = "vlcMediaControls";
            this.vlcMediaControls.Size = new System.Drawing.Size(713, 38);
            this.vlcMediaControls.TabIndex = 6;
            this.vlcMediaControls.Visible = false;
            // 
            // CT_TrackBar
            // 
            this.CT_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CT_TrackBar.AutoSize = false;
            this.CT_TrackBar.Location = new System.Drawing.Point(3, 7);
            this.CT_TrackBar.Name = "CT_TrackBar";
            this.CT_TrackBar.Size = new System.Drawing.Size(521, 23);
            this.CT_TrackBar.TabIndex = 4;
            // 
            // CT_PlayLB
            // 
            this.CT_PlayLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CT_PlayLB.Location = new System.Drawing.Point(530, 8);
            this.CT_PlayLB.Name = "CT_PlayLB";
            this.CT_PlayLB.Size = new System.Drawing.Size(56, 23);
            this.CT_PlayLB.TabIndex = 3;
            this.CT_PlayLB.Text = "Play";
            this.CT_PlayLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CT_PauseLB
            // 
            this.CT_PauseLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CT_PauseLB.Location = new System.Drawing.Point(592, 7);
            this.CT_PauseLB.Name = "CT_PauseLB";
            this.CT_PauseLB.Size = new System.Drawing.Size(56, 23);
            this.CT_PauseLB.TabIndex = 2;
            this.CT_PauseLB.Text = "Pause";
            this.CT_PauseLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CT_StopLB
            // 
            this.CT_StopLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CT_StopLB.Location = new System.Drawing.Point(654, 7);
            this.CT_StopLB.Name = "CT_StopLB";
            this.CT_StopLB.Size = new System.Drawing.Size(56, 23);
            this.CT_StopLB.TabIndex = 1;
            this.CT_StopLB.Text = "Stop";
            this.CT_StopLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // bottomConsole
            // 
            this.bottomConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomConsole.Controls.Add(this.consoleLabel);
            this.bottomConsole.Location = new System.Drawing.Point(0, 419);
            this.bottomConsole.Name = "bottomConsole";
            this.bottomConsole.Size = new System.Drawing.Size(713, 38);
            this.bottomConsole.TabIndex = 5;
            this.bottomConsole.Visible = false;
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Location = new System.Drawing.Point(9, 13);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(0, 13);
            this.consoleLabel.TabIndex = 0;
            // 
            // ViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Name = "ViewerControl";
            this.Size = new System.Drawing.Size(931, 457);
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.loadingPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.vlcMediaControls.ResumeLayout(false);
            this.vlcMediaControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CT_TrackBar)).EndInit();
            this.bottomConsole.ResumeLayout(false);
            this.bottomConsole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.ProgressBar loadingProgressBar;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Label OpenLinkButton;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.ListBox sourcesList;
        private System.Windows.Forms.ListBox tagsList;
        private System.Windows.Forms.ListBox artistsList;
        public System.Windows.Forms.NumericUpDown numericUpDown;
        private Vlc.DotNet.Forms.VlcControl vlcControl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private StylizedTextBox idBox;
        private StylizedTextBox sizeBox;
        private StylizedTextBox heightBox;
        private StylizedTextBox widthBox;
        private System.Windows.Forms.Label openFileButton;
        private System.Windows.Forms.Panel bottomConsole;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.Panel vlcMediaControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CT_StopLB;
        private System.Windows.Forms.Label CT_PlayLB;
        private System.Windows.Forms.Label CT_PauseLB;
        private System.Windows.Forms.TrackBar CT_TrackBar;
    }
}
