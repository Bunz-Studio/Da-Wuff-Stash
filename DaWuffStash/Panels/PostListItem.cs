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
    public partial class PostListItem : UserControl
    {
        public string specials = "↑↓♥";
        public string ratings = "SQE";

        public PostListItem()
        {
            InitializeComponent();
            previewBox.AddBorder();
        }

        public void Initialize(eData.Post post)
        {
            previewBox.Image = null;
            loadProgressBar.Visible = true;
            loadProgressBar.Value = 0;
            ResizeWhenSize(new Size(post.preview.width, post.preview.height));
            var img = ImageCollectionCenter.GetImage(post, true);
            img.onSuccess += (ImageRequest.ImageResult val) => {
                post.previewImage = val.image;
                PostManager.RunOnUIThread(() => {
                    loadProgressBar.Visible = false;
                    previewBox.Image = val.image;
                    ResizeWhenSize(val.image.Size);
                });
            };
            img.onProgress += val =>
            {
                loadProgressBar.Value = val.ProgressPercentage;
            };
            img.onError += val =>
            {
                PostManager.RunOnUIThread(() =>
                {
                    loadProgressBar.Visible = false;
                });
                // MessageBox.Show(val.Message);
            };
            img.Start(post, true);

            var pType = typeof(PictureBox).GetProperty("ForeColor");
            if (post.rating == "s")
            {
                pType.SetValue(previewBox, Color.FromArgb(255, 0, 255, 0));
            }
            else if (post.rating == "q")
            {
                pType.SetValue(previewBox, Color.FromArgb(255, 255, 255, 0));
            }
            else
            {
                pType.SetValue(previewBox, Color.FromArgb(255, 255, 0, 0));
            }

            if(post.score.total > 0)
            {
                infoLabel.ForeColor = Color.FromArgb(255, 0, 255, 0);
            }
            else if (post.score.total < 0)
            {
                infoLabel.ForeColor = Color.FromArgb(255, 255, 0, 0);
            }
            else
            {
                if(post.fav_count > 0)
                {
                    infoLabel.ForeColor = Color.FromArgb(255, 0, 255, 255);
                }
                else
                {
                    infoLabel.ForeColor = MainForm.mainTheme.ForeColor;
                }
            }

            infoLabel.Text = (post.score.total >= 0) ? specials[0] + post.score.total.ToString() : specials[1] + post.score.total.ToString();
            infoLabel.Text += " " + specials[2] + post.fav_count.ToString();
            infoLabel.Text += " " + post.rating.ToUpper();
        }
        public void ResizeWhenSize(Size image)
        {
            var origin = previewBox.Size;
            var after = ResizeToWidth(origin.Width, image);
            var diff = after.Height - origin.Height;
            Size = new Size(Size.Width, Size.Height + diff);
        }

        public static Size ResizeToWidth(int width, Size image)
        {
            double canvasWidth = (double)width;
            double originalWidth = (double)image.Width;
            double originalHeight = (double)image.Height;

            double newWidth = canvasWidth;
            double newHeight = (canvasWidth / originalWidth) * originalHeight;

            return new Size(Convert.ToInt32(newWidth), Convert.ToInt32(newHeight));
        }

        private void previewBox_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
