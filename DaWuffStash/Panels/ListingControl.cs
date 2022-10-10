using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaWuffStash.Panels
{
    public partial class ListingControl : UserControl
    {
        public ListingControl()
        {
            InitializeComponent();

            MainForm.mainTheme.ApplyTo(this);

            this.AddBorder();
            listingSidePanel.AddBorder();
            layoutListPanel.AddBorder();

            searchButton.AddBorder();
            searchButton.ModernifyInteraction();
        }
    }
}
