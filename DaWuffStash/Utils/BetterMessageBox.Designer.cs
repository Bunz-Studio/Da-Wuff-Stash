namespace DaWuffStash.Utils
{
    partial class BetterMessageBox
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
            this.warningLabel = new System.Windows.Forms.Label();
            this.buttonsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // warningLabel
            // 
            this.warningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warningLabel.Location = new System.Drawing.Point(12, 9);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(382, 93);
            this.warningLabel.TabIndex = 0;
            // 
            // buttonsLayoutPanel
            // 
            this.buttonsLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonsLayoutPanel.Location = new System.Drawing.Point(12, 105);
            this.buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            this.buttonsLayoutPanel.Size = new System.Drawing.Size(382, 28);
            this.buttonsLayoutPanel.TabIndex = 1;
            // 
            // BetterMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 143);
            this.Controls.Add(this.buttonsLayoutPanel);
            this.Controls.Add(this.warningLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BetterMessageBox";
            this.Text = "Da Wuff Stash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.FlowLayoutPanel buttonsLayoutPanel;
    }
}