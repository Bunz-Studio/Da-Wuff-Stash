namespace DaWuffStash
{
    partial class TagInfoDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagInfoDialog));
            this.tagLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.addTSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tagLabel
            // 
            this.tagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tagLabel.Location = new System.Drawing.Point(12, 9);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(262, 39);
            this.tagLabel.TabIndex = 0;
            this.tagLabel.Text = "Tag";
            this.tagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(15, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(259, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addTSearchButton
            // 
            this.addTSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTSearchButton.Location = new System.Drawing.Point(15, 80);
            this.addTSearchButton.Name = "addTSearchButton";
            this.addTSearchButton.Size = new System.Drawing.Size(259, 23);
            this.addTSearchButton.TabIndex = 2;
            this.addTSearchButton.Text = "Add to current search";
            this.addTSearchButton.UseVisualStyleBackColor = true;
            this.addTSearchButton.Click += new System.EventHandler(this.addTSearchButton_Click);
            // 
            // TagInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 115);
            this.Controls.Add(this.addTSearchButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.tagLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TagInfoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tag Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tagLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addTSearchButton;
    }
}