namespace DaWuffStash.Panels
{
    partial class ListingControl
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
            this.listingSidePanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Label();
            this.pageNumericUD = new System.Windows.Forms.NumericUpDown();
            this.searchBox = new DaWuffStash.StylizedTextBox();
            this.layoutListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.listingSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // listingSidePanel
            // 
            this.listingSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listingSidePanel.Controls.Add(this.searchButton);
            this.listingSidePanel.Controls.Add(this.pageNumericUD);
            this.listingSidePanel.Controls.Add(this.searchBox);
            this.listingSidePanel.Location = new System.Drawing.Point(3, 3);
            this.listingSidePanel.Name = "listingSidePanel";
            this.listingSidePanel.Size = new System.Drawing.Size(156, 451);
            this.listingSidePanel.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(45, 31);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(106, 22);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageNumericUD
            // 
            this.pageNumericUD.Location = new System.Drawing.Point(3, 31);
            this.pageNumericUD.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.pageNumericUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNumericUD.Name = "pageNumericUD";
            this.pageNumericUD.Size = new System.Drawing.Size(38, 20);
            this.pageNumericUD.TabIndex = 1;
            this.pageNumericUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.searchBox.Location = new System.Drawing.Point(3, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(150, 22);
            this.searchBox.TabIndex = 0;
            // 
            // layoutListPanel
            // 
            this.layoutListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutListPanel.AutoScroll = true;
            this.layoutListPanel.Location = new System.Drawing.Point(163, 3);
            this.layoutListPanel.Name = "layoutListPanel";
            this.layoutListPanel.Size = new System.Drawing.Size(765, 451);
            this.layoutListPanel.TabIndex = 1;
            // 
            // ListingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.layoutListPanel);
            this.Controls.Add(this.listingSidePanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(199)))), ((int)(((byte)(217)))));
            this.Name = "ListingControl";
            this.Size = new System.Drawing.Size(931, 457);
            this.listingSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageNumericUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listingSidePanel;
        public System.Windows.Forms.Label searchButton;
        public StylizedTextBox searchBox;
        public System.Windows.Forms.NumericUpDown pageNumericUD;
        public System.Windows.Forms.FlowLayoutPanel layoutListPanel;
    }
}
