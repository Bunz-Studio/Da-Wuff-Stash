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
        }

        public void Initialize(eData.Post post)
        {
            ResizeWhenSize(new Size(post.preview.width, post.preview.height));
            var img = ImageCollectionCenter.GetImage(post, true);
            img.onSuccess += (ImageRequest.ImageResult val) => {
                post.previewImage = val.image;
                PostManager.RunOnUIThread(() => {
                    previewBox.Image = val.image;
                    ResizeWhenSize(val.image.Size);
                });
            };
            img.onError += val =>
            {
                // MessageBox.Show(val.Message);
            };
            img.Start(post, true);

            infoLabel.Text = (post.score.total >= 0) ? specials[0] + post.score.total.ToString() : specials[1] + post.score.total.ToString();
            infoLabel.Text += " " + specials[2] + post.fav_count.ToString();
            infoLabel.Text += " " + post.rating;
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
