using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaWuffStash
{
    public partial class TagInfoDialog : Form
    {
        public string tag;
        public TagInfoDialog()
        {
            InitializeComponent();
            MainForm.mainTheme.ApplyTo(this);
        }

        public void Initialize(string tag)
        {
            this.tag = tag;
            tagLabel.Text = tag;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MainForm.self.SetCurrentSearch(tag);
            MainForm.self.SearchBasedOnHomepage();
            Dispose();
        }

        private void addTSearchButton_Click(object sender, EventArgs e)
        {
            MainForm.self.AddToCurrentSearch(tag);
            Dispose();
        }


        public static TagInfoDialog Show(string tag)
        {
            var dialog = new TagInfoDialog();
            dialog.Show();
            dialog.Initialize(tag);
            return dialog;
        }
    }
}
