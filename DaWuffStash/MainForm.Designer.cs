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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ptHomepage = new System.Windows.Forms.Label();
            this.ptListing = new System.Windows.Forms.Label();
            this.contentPlacementPanel = new System.Windows.Forms.Panel();
            this.homepageControl = new DaWuffStash.Panels.HomepageControl();
            this.listingControl = new DaWuffStash.Panels.ListingControl();
            this.viewerControl = new DaWuffStash.Panels.ViewerControl();
            this.ptViewer = new System.Windows.Forms.Label();
            this.contentPlacementPanel.SuspendLayout();
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
            this.contentPlacementPanel.Controls.Add(this.homepageControl);
            this.contentPlacementPanel.Controls.Add(this.listingControl);
            this.contentPlacementPanel.Controls.Add(this.viewerControl);
            this.contentPlacementPanel.Location = new System.Drawing.Point(5, 35);
            this.contentPlacementPanel.Name = "contentPlacementPanel";
            this.contentPlacementPanel.Size = new System.Drawing.Size(931, 457);
            this.contentPlacementPanel.TabIndex = 2;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.ptViewer);
            this.Controls.Add(this.contentPlacementPanel);
            this.Controls.Add(this.ptListing);
            this.Controls.Add(this.ptHomepage);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Da Wuff Stash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.contentPlacementPanel.ResumeLayout(false);
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
    }
}

