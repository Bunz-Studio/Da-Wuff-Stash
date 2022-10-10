using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Timer = System.Windows.Forms.Timer;

namespace DaWuffStash
{
    public partial class MainForm : Form
    {
        // Naming Scheme
        /// PT : Panel Tab Navigation Buttons
        /// HC : Homepage Controls
        /// LC : List Controls
        /// SC : Settings Controls
        
        /// <summary> The main theme of the app</summary>
        public static Theme mainTheme = new Theme()
        {
            BackColor = Color.FromArgb(255, 1, 46, 86),
            ForeColor = Color.FromArgb(255, 180, 199, 217),
            BorderColor = Color.FromArgb(255, 31, 76, 117),
            MiddleColor = Color.FromArgb(255, 15, 59, 98)
        };
        public static SynchronizationContext syncContext;
        public static APICenter.HostType hostType = APICenter.HostType.SFW;
        bool ignoreChange;

        public Control[] panels = {};
        public List<Panels.PostListItem> controls = new List<Panels.PostListItem>();

        public MainForm()
        {
            InitializeComponent();
            panels = new Control[]{ homepageControl, listingControl, viewerControl };

            // Modernify
            ptHomepage.AddBorder();
            ptHomepage.ModernifyInteraction();
            ptListing.AddBorder();
            ptListing.ModernifyInteraction();
            ptViewer.AddBorder();
            ptViewer.ModernifyInteraction();
            // EndModernify

            mainTheme.ApplyTo(this);

            // Homepage
            homepageControl.SearchLButton.MouseUp += SearchLButton_MouseUp;
            homepageControl.hostDropdown.SelectedIndex = 0;
            homepageControl.hostDropdown.SelectedIndexChanged += HostDropdown_SelectedIndexChanged;
            homepageControl.searchBox.KeyDown += SearchBox_KeyDown;

            // Listing
            listingControl.searchButton.MouseUp += SearchButton_MouseUp;
            listingControl.searchBox.KeyDown += SearchBox_KeyDown1;

            // Viewer
            viewerControl.numericUpDown.ValueChanged += NumericUpDown_ValueChanged;
            syncContext = SynchronizationContext.Current;
        }

        private void SearchBox_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CommitSearch(listingControl.searchBox.Text, listingControl.pageNumericUD.Value.ToString(), null);
                homepageControl.searchBox.Text = listingControl.searchBox.Text;
            }
        }

        private void SearchButton_MouseUp(object sender, MouseEventArgs e)
        {
            CommitSearch(listingControl.searchBox.Text, listingControl.pageNumericUD.Value.ToString(), null);
            homepageControl.searchBox.Text = listingControl.searchBox.Text;
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CommitSearch(homepageControl.searchBox.Text, "1", null);
                listingControl.searchBox.Text = homepageControl.searchBox.Text;
            }
        }

        private void HostDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            hostType = homepageControl.hostDropdown.SelectedIndex == 0 ? APICenter.HostType.SFW : APICenter.HostType.NSFW;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PostManager.posts == null || ignoreChange) return;

            int index = (int)viewerControl.numericUpDown.Value;
            var p = PostManager.posts.posts[index];
            viewerControl.ThrowPost(p, p.previewImage);
        }
        public void CommitSearch(string tags, string page, string limit)
        {
            Console.WriteLine("Fetching posts");
            Enabled = false;
            var req = APICenter.GetPosts(hostType, tags, page, limit);
            req.onSuccess += val =>
            {
                Console.WriteLine("Post fetched, is posts null? " + (val == null));
                PostManager.posts = val;
                PostManager.RunOnUIThread(() =>
                {
                    Enabled = true;
                    int i = 0;
                    foreach (var post in val.posts)
                    {
                        if (i >= controls.Count)
                        {
                            var inst = new Panels.PostListItem();
                            listingControl.layoutListPanel.Controls.Add(inst);
                            inst.AddBorder();
                            inst.Initialize(post);
                            inst.Tag = new object[] { post, i };
                            inst.Click += delegate {
                                var d = (object[])inst.Tag;
                                viewerControl.ThrowPost((eData.Post)d[0], inst.previewBox.Image);
                                ignoreChange = true;
                                viewerControl.numericUpDown.Value = (int)d[1];
                                ignoreChange = false;
                                ChangeTab(2);
                            };
                            controls.Add(inst);
                        }
                        else
                        {
                            var inst = controls[i];
                            inst.Tag = new object[] { post, i };
                            inst.Initialize(post);
                        }
                        i++;
                    }

                    if (i < controls.Count)
                    {
                        for (int b = i + 1; b < controls.Count; b++)
                        {
                            controls[b].Dispose();
                        }
                    }
                    viewerControl.numericUpDown.Maximum = val.posts.Count - 1;
                    ChangeTab(1);
                });
            };
            req.onError += val =>
            {
                PostManager.RunOnUIThread(() =>
                {
                    Enabled = true;
                });
                Utils.BetterMessageBox.Show(val.Message + val.StackTrace);
            };
            req.Start(req.preparedUrl);
        }

        private void SearchLButton_MouseUp(object sender, MouseEventArgs e)
        {
            CommitSearch(homepageControl.searchBox.Text, "1", null);
            listingControl.searchBox.Text = homepageControl.searchBox.Text;
        }

        public void ChangeTab(int index)
        {
            for(int i = 0; i < panels.Length; i++)
            {
                panels[i].Visible = index == i;
            }
        }

        #region PT Area
        private void ptHomepage_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeTab(0);
        }

        private void ptListing_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeTab(1);
        }

        private void ptViewer_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeTab(2);
        }
        #endregion
    }

    public class Theme
    {
        public static List<Control> registeredControls = new List<Control>();

        public Color BackColor;
        public Color ForeColor;
        public Color BorderColor;
        public Color MiddleColor;

        public void ApplyTo(Control ctr)
        {
            if (!registeredControls.Contains(ctr))
            {
                registeredControls.Add(ctr);
            }
            var ctrls = ctr.GetControls();
            ctr.BackColor = BackColor;
            ctr.ForeColor = ForeColor;

            if (ctr is ContextMenuStrip)
            {
                var s = ((ContextMenuStrip)ctr).Items;
                foreach (ToolStripItem a in s)
                {
                    a.ForeColor = ForeColor;
                }
            }
            foreach (var c in ctrls)
            {
                c.BackColor = BackColor;
                c.ForeColor = ForeColor;
            }

            var rbs = ctr.GetControlsWithType<Button>();
            foreach (var a in rbs)
            {
                a.BackColor = MiddleColor;
                a.ForeColor = ForeColor;
            }

            var txt = ctr.GetControlsWithType<StylizedTextBox>();
            foreach (var t in txt)
            {
                t.BackColor = MiddleColor;
                t.ForeColor = ForeColor;
            }
        }
    }

    public static class PostManager
    {
        // Runtime
        public static Timer timer;
        public static List<RuntimeLoopBase> runtimeLoops = new List<RuntimeLoopBase>();

        // Posts
        public static eData.Posts posts;

        public static void Initialize()
        {
            // Timer
            timer = new Timer();
            timer.Tick += (aa, ee) => Update();
            timer.Interval = 100;
            timer.Start();
        }

        public static void Update()
        {
            // Runtime Loop
            var l = new List<RuntimeLoopBase>();
            foreach (var b in runtimeLoops) if (!b.Update()) l.Add(b);
            foreach (var b in l) runtimeLoops.Remove(b);
        }

        public static void RunOnUIThread(Action action)
        {
            MainForm.syncContext.Post(delegate { action.TryInvoke(); }, null);
        }
    }

    public class RuntimeForeach<T> : RuntimeLoopBase
    {
        public List<T> lists = new List<T>();
        public Action<T> onLoop;
        public int index;

        public RuntimeForeach() { }
        public RuntimeForeach(List<T> lists)
        {
            this.lists = lists;
        }

        public override bool Update()
        {
            if (index >= lists.Count) return false;
            if (onLoop != null) onLoop.Invoke(lists[index]);
            index++;
            return true;
        }
    }

    public class RuntimeFor : RuntimeLoopBase
    {
        public float c;
        public float l;
        public float a;
        public Action<float> onLoop;

        public RuntimeFor() { }
        public RuntimeFor(int start, int limit, int addition)
        {
            c = start;
            l = limit;
            a = addition;
        }

        public override bool Update()
        {
            if (a > 0)
            {
                if (c < a)
                {
                    onLoop.Invoke(c);
                    c += a;
                    return true;
                }
                return false;
            }
            else if (a < 0)
            {
                if (c > a)
                {
                    onLoop.Invoke(c);
                    c += a;
                    return true;
                }
                return false;
            }
            else return false;
        }
    }

    public class RuntimeLoopBase
    {
        public virtual bool Update()
        {
            return false;
        }
    }
}
