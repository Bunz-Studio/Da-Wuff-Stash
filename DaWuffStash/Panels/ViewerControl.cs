using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DaWuffStash.Utils;

namespace DaWuffStash.Panels
{
    public partial class ViewerControl : UserControl
    {
        public string htmlCode = 
            "<video width=\"{width}\" height=\"{height}\" autoplay muted>\n" +
            "<source src = \"{filePath}\" type=\"video/{extension}\">\n" + 
            "Your browser does not support the video tag.\n" +
            "</video>";

        public string imageHtmlCode =
            " <img src=\"{path}\" alt=\"{altText}\">";

        public eData.Post postInfo;
        public bool isDownloaded;
        public string path;
        bool vlcInitialized;

        public ViewerControl()
        {
            InitializeComponent();

            MainForm.mainTheme.ApplyTo(this);

            var libDirectory = new DirectoryInfo(Path.GetFullPath("libvlc"));
            libDirectory = new System.IO.DirectoryInfo(System.IO.Path.GetFullPath("libvlc"));
            this.AddBorder();
            sidePanel.AddBorder();
            loadingPanel.AddBorder();

            OpenLinkButton.AddBorder();
            OpenLinkButton.ModernifyInteraction();
            openFileButton.AddBorder();
            openFileButton.ModernifyInteraction();
        }

        public void ThrowPost(eData.Post post, Image preview = null)
        {
            webBrowser.Visible = false;
            pictureBox.Visible = true;
            bottomConsole.Visible = false;
            pictureBox.Image = preview;
            isDownloaded = false;
            path = null;
            postInfo = post;
            descriptionTextBox.Text = post.description;
            widthBox.Text = post.file.width.ToString();
            heightBox.Text = post.file.height.ToString();
            sizeBox.Text = GetReadableString(post.file.size);
            idBox.Text = post.id.ToString();
            artistsList.Items.Clear();
            foreach(var a in post.tags.artist)
            {
                artistsList.Items.Add(a);
            }
            tagsList.Items.Clear();
            tagsList.Items.Add("---- GENERAL ----");
            foreach(var a in post.tags.general)
            {
                tagsList.Items.Add(a);
            }
            tagsList.Items.Add("---- CHARACTERS ----");
            foreach (var a in post.tags.character)
            {
                tagsList.Items.Add(a);
            }
            tagsList.Items.Add("---- SPECIES ----");
            foreach (var a in post.tags.species)
            {
                tagsList.Items.Add(a);
            }
            sourcesList.Items.Clear();
            foreach(var a in post.sources)
            {
                sourcesList.Items.Add(a);
            }
            var img = ImageCollectionCenter.GetImage(post, false);
            img.onSuccess += (ImageRequest.ImageResult val) => {
                bottomConsole.Visible = false;
                isDownloaded = true;
                path = val.path;
                if (val.isVideo)
                {
                    if (Directory.Exists("libvlc"))
                    {
                        if(!vlcInitialized)
                        {
                            FinalizeVLC();
                            vlcInitialized = true;
                        }
                        vlcControl.Visible = true;
                        webBrowser.Visible = false;
                        pictureBox.Visible = false;
                        vlcControl.Play(new FileInfo(Path.GetFullPath(val.path)), "input-repeat=65535");
                    }
                    else
                    {
                        BetterMessageBox.Show(
                            "You don't have the VLC Library installed, do you want to open the video file?", 
                            "Da Wuff Stash" , 
                            new BetterMessageBox.BetterButton("Yes", true, () => {
                                System.Diagnostics.Process.Start(val.path);
                            }),
                            new BetterMessageBox.BetterButton("No")
                        );
                    }
                }
                else
                {
                    bool isWebPreferred = false;
                    vlcControl.Visible = false;
                    webBrowser.Visible = isWebPreferred;
                    pictureBox.Visible = !isWebPreferred;
                    if (isWebPreferred)
                    {
                        webBrowser.DocumentText = null;
                        webBrowser.Navigate(new Uri("file://" + Path.GetFullPath(val.path)));
                    }
                    else
                    {
                        pictureBox.Image = val.image;
                    }
                }

                numericUpDown.Select();
                loadingPanel.Visible = false;
            };
            img.onError += val =>
            {
                loadingPanel.Visible = false;
                bottomConsole.Visible = true;
                consoleLabel.Text = val.Message;
                // BetterMessageBox.Show(val.Message);
            };
            img.onProgress += (System.Net.DownloadProgressChangedEventArgs val) =>
            {
                loadingProgressBar.Value = val.ProgressPercentage;
            };
            loadingPanel.Visible = true;
            loadingProgressBar.Value = 0;
            img.Start(post, false);
            numericUpDown.Select();
        }

        public void FinalizeVLC()
        {
            var libDirectory = new DirectoryInfo(Path.GetFullPath("libvlc"));
            vlcControl.VlcLibDirectory = libDirectory;
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).EndInit();
        }

        public static string GetReadableString(double length)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = length;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }
        private void OpenLinkButton_MouseUp(object sender, MouseEventArgs e)
        {
            if(postInfo != null)
            {
                var host = MainForm.hostType == APICenter.HostType.SFW ? "https://e926.net/" : "https://e621.net/";
                System.Diagnostics.Process.Start(host + "posts/" + postInfo.id + "/");
            }
        }

        private void openFileButton_MouseUp(object sender, MouseEventArgs e)
        {
            if(isDownloaded)
            {
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
