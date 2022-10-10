namespace DaWuffStash.Panels
{
    partial class HomepageControl
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
            this.mascotPreviewBox = new System.Windows.Forms.PictureBox();
            this.homeSidePanel = new System.Windows.Forms.Panel();
            this.changeMascotLB = new System.Windows.Forms.Label();
            this.creditLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SearchLButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.hostDropdown = new System.Windows.Forms.ComboBox();
            this.searchBox = new DaWuffStash.StylizedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mascotPreviewBox)).BeginInit();
            this.homeSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mascotPreviewBox
            // 
            this.mascotPreviewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mascotPreviewBox.Image = global::DaWuffStash.Properties.Resources.esix2;
            this.mascotPreviewBox.Location = new System.Drawing.Point(13, 14);
            this.mascotPreviewBox.Name = "mascotPreviewBox";
            this.mascotPreviewBox.Size = new System.Drawing.Size(675, 425);
            this.mascotPreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mascotPreviewBox.TabIndex = 0;
            this.mascotPreviewBox.TabStop = false;
            // 
            // homeSidePanel
            // 
            this.homeSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeSidePanel.Controls.Add(this.hostDropdown);
            this.homeSidePanel.Controls.Add(this.changeMascotLB);
            this.homeSidePanel.Controls.Add(this.creditLinkLabel);
            this.homeSidePanel.Controls.Add(this.SearchLButton);
            this.homeSidePanel.Controls.Add(this.label1);
            this.homeSidePanel.Controls.Add(this.appTitle);
            this.homeSidePanel.Controls.Add(this.searchBox);
            this.homeSidePanel.Location = new System.Drawing.Point(694, 14);
            this.homeSidePanel.Name = "homeSidePanel";
            this.homeSidePanel.Size = new System.Drawing.Size(220, 425);
            this.homeSidePanel.TabIndex = 1;
            // 
            // changeMascotLB
            // 
            this.changeMascotLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeMascotLB.Location = new System.Drawing.Point(6, 131);
            this.changeMascotLB.Name = "changeMascotLB";
            this.changeMascotLB.Size = new System.Drawing.Size(209, 23);
            this.changeMascotLB.TabIndex = 5;
            this.changeMascotLB.Text = "Change Mascot";
            this.changeMascotLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changeMascotLB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.changeMascotLB_MouseUp);
            // 
            // creditLinkLabel
            // 
            this.creditLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(9, 19);
            this.creditLinkLabel.LinkColor = System.Drawing.Color.Cyan;
            this.creditLinkLabel.Location = new System.Drawing.Point(10, 157);
            this.creditLinkLabel.Name = "creditLinkLabel";
            this.creditLinkLabel.Size = new System.Drawing.Size(205, 23);
            this.creditLinkLabel.TabIndex = 4;
            this.creditLinkLabel.TabStop = true;
            this.creditLinkLabel.Text = "Drawn by Keishinkae";
            this.creditLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.creditLinkLabel.UseCompatibleTextRendering = true;
            this.creditLinkLabel.VisitedLinkColor = System.Drawing.Color.Magenta;
            this.creditLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditLinkLabel_LinkClicked);
            // 
            // SearchLButton
            // 
            this.SearchLButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchLButton.Location = new System.Drawing.Point(6, 106);
            this.SearchLButton.Name = "SearchLButton";
            this.SearchLButton.Size = new System.Drawing.Size(209, 23);
            this.SearchLButton.TabIndex = 3;
            this.SearchLButton.Text = "Search";
            this.SearchLButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(3, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "e926/e621 explorer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appTitle
            // 
            this.appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.appTitle.Location = new System.Drawing.Point(3, 20);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(214, 38);
            this.appTitle.TabIndex = 1;
            this.appTitle.Text = "Da Wuff Stash";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hostDropdown
            // 
            this.hostDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hostDropdown.FormattingEnabled = true;
            this.hostDropdown.Items.AddRange(new object[] {
            "e926 (SFW)",
            "e621 (NSFW)"});
            this.hostDropdown.Location = new System.Drawing.Point(3, 401);
            this.hostDropdown.Name = "hostDropdown";
            this.hostDropdown.Size = new System.Drawing.Size(214, 21);
            this.hostDropdown.TabIndex = 6;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.searchBox.Location = new System.Drawing.Point(6, 80);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(209, 22);
            this.searchBox.TabIndex = 0;
            // 
            // HomepageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.homeSidePanel);
            this.Controls.Add(this.mascotPreviewBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Name = "HomepageControl";
            this.Size = new System.Drawing.Size(931, 457);
            ((System.ComponentModel.ISupportInitialize)(this.mascotPreviewBox)).EndInit();
            this.homeSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mascotPreviewBox;
        private System.Windows.Forms.Panel homeSidePanel;
        public StylizedTextBox searchBox;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label SearchLButton;
        public System.Windows.Forms.Label changeMascotLB;
        private System.Windows.Forms.LinkLabel creditLinkLabel;
        public System.Windows.Forms.ComboBox hostDropdown;
    }
}
