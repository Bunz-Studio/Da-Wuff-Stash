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
    public partial class HomepageControl : UserControl
    {
        public MascotInfo[] mascotInfos = {
            new MascotInfo(Properties.Resources.esix1, "Keishinkae", "http://www.furaffinity.net/user/keishinkae"),
            new MascotInfo(Properties.Resources.esix2, "Keishinkae", "http://www.furaffinity.net/user/keishinkae"),
            new MascotInfo(Properties.Resources.raptor1, "darkdoomer", "http://nowhereincoming.net/"),
            new MascotInfo(Properties.Resources.hexerade, "chizi", "http://www.furaffinity.net/user/chizi"),
            new MascotInfo(Properties.Resources.wiredhooves, "wiredhooves", "http://www.furaffinity.net/user/wiredhooves"),
            new MascotInfo(Properties.Resources.ecmajor, "ecmajor", "http://www.horsecore.org/"),
            new MascotInfo(Properties.Resources.evalionfix, "evalion", "http://www.furaffinity.net/user/evalion"),
            new MascotInfo(Properties.Resources.peacock, "Ratte", "http://www.furaffinity.net/user/ratte"),
        };
        public int currMascot = 1;

        public HomepageControl()
        {
            InitializeComponent();

            MainForm.mainTheme.ApplyTo(this);
            this.AddBorder();
            homeSidePanel.AddBorder();
            SearchLButton.ModernifyInteraction();
            SearchLButton.AddBorder();

            changeMascotLB.AddBorder();
            changeMascotLB.ModernifyInteraction();

            creditLinkLabel.Links.Clear();
            creditLinkLabel.Text = "Drawn by Keinshinkae";
            creditLinkLabel.Tag = "http://www.furaffinity.net/user/keishinkae";
            creditLinkLabel.Links.Add(9, creditLinkLabel.Text.Length - 1, new Uri("http://www.furaffinity.net/user/keishinkae"));
        }

        private void creditLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)creditLinkLabel.Tag);
        }

        private void changeMascotLB_MouseUp(object sender, MouseEventArgs e)
        {
            currMascot++;
            if (currMascot >= mascotInfos.Length) currMascot = 0;

            var inf = mascotInfos[currMascot];
            mascotPreviewBox.Image = inf.resource;
            creditLinkLabel.Links.Clear();
            creditLinkLabel.Text = "Drawn by " + inf.artist;
            creditLinkLabel.Tag = inf.link;
            creditLinkLabel.Links.Add(9, creditLinkLabel.Text.Length - 1, new Uri(inf.link));
        }
    }

    public class MascotInfo
    {
        public string link;
        public string artist;
        public Image resource;

        public MascotInfo(Image res, string artist, string link)
        {
            resource = res;
            this.artist = artist;
            this.link = link;
        }
    }
}
