using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DaWuffStash
{
	public partial class StylizedTextBox : UserControl
	{
        [Category("Appearance")]
		public override string Text
		{
			get
			{
				return TypingBox.Text;
			}
			set
			{
				TypingBox.Text = value;
			}
		}
		
		public override Color BackColor {
			get {
				return base.BackColor;
			}
			set {
				base.BackColor = value;
				TypingBox.BackColor = value;
				Border.BackColor = value;
			}
		}
		
		public override Color ForeColor {
			get {
				return base.ForeColor;
			}
			set {
				base.ForeColor = value;
				TypingBox.ForeColor = value;
				Border.ForeColor = value;
			}
		}

        [Category("Appearance")]
        public bool ReadOnly
        {
            get
            {
                return TypingBox.ReadOnly;
            }
            set
            {
                TypingBox.ReadOnly = value;
            }
        }
		
		public StylizedTextBox()
		{
			InitializeComponent();
			TypingBox.KeyDown += (ee, aa) => OnKeyDown(aa);
		}
		void BorderClick(object sender, EventArgs e)
		{
			TypingBox.Focus();
		}

        private void TypingBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }
    }
}
