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
        #region Variables
        public static MainForm self;
        // Naming Scheme
        /// PT : Panel Tab Navigation Buttons
        /// Sets : Settings Controls

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
        public bool forceClose;
        #endregion

        #region Initialization
        public MainForm()
        {
            self = this;
            InitializeComponent();
            panels = new Control[]{ homepageControl, listingControl, viewerControl, settingsControl };

            // Modernify
            ptHomepage.AddBorder();
            ptHomepage.ModernifyInteraction();
            ptListing.AddBorder();
            ptListing.ModernifyInteraction();
            ptViewer.AddBorder();
            ptViewer.ModernifyInteraction();
            ptSettings.AddBorder();
            ptSettings.ModernifyInteraction();
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

            // Settings
            settingsControl.AddBorder();
            Sets_GeneralHeader.AddBorder();
            Sets_StorageHeader.AddBorder();
            Sets_HostDropdown.SelectedIndexChanged += Sets_HostDropdown_SelectedIndexChanged;
            Sets_ImageViewDropdown.SelectedIndexChanged += Sets_ImageViewDropdown_SelectedIndexChanged;
            Sets_SavePathBox.TypingBox.TextChanged += TypingBox_TextChanged;
            Sets_OpenSavePathLB.AddBorder();
            Sets_OpenSavePathLB.ModernifyInteraction();
            Sets_ResetButtonLB.AddBorder();
            Sets_ResetButtonLB.ModernifyInteraction();

            // Save Files
            var pref = Settings.preferences;
            SetHostType(pref.hostType, false);
            ignoreChange = true;
            Sets_SavePathBox.Text = pref.savePath;
            ignoreChange = false;
            Sets_ImageViewDropdown.SelectedIndex = pref.imageViewType;
            Sets_HideTrayBox.Checked = pref.hideToTray;

            var history = Settings.history;
            if(history.postsData != null)
            {
                LoadPosts(history.postsData);
            }
            homepageControl.searchBox.Text = history.searchTag;
            listingControl.searchBox.Text = history.searchTag;
            listingControl.pageNumericUD.Value = history.page;

            ChangeTab(0);
        }

        public void AddToCurrentSearch(string tag)
        {
            homepageControl.searchBox.Text = homepageControl.searchBox.Text + " " + tag;
            listingControl.searchBox.Text = homepageControl.searchBox.Text;
        }

        public void SetCurrentSearch(string tag)
        {
            homepageControl.searchBox.Text = tag;
            listingControl.searchBox.Text = tag;
        }

        public void SearchBasedOnHomepage()
        {
            CommitSearch(homepageControl.searchBox.Text, "1", null);
        }
        #endregion

        #region Hosts
        public void SetHostType(int index, bool overrideSettings = true)
        {
            hostPreventChange = true;
            hostType = index == 0 ? APICenter.HostType.SFW : APICenter.HostType.NSFW;
            Sets_HostDropdown.SelectedIndex = index;
            homepageControl.hostDropdown.SelectedIndex = index;
            if (overrideSettings)
            {
                Settings.preferences.hostType = Sets_HostDropdown.SelectedIndex;
                Settings.ForceSave();
            }
            hostPreventChange = false;
        }

        bool hostPreventChange;
        private void Sets_HostDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hostPreventChange) return;
            SetHostType(Sets_HostDropdown.SelectedIndex);
        }

        private void HostDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hostPreventChange) return;
            SetHostType(homepageControl.hostDropdown.SelectedIndex);
        }
        #endregion

        #region Search
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

        public void CommitSearch(string tags, string page, string limit)
        {
            Console.WriteLine("Fetching posts");
            Enabled = false;
            var req = APICenter.GetPosts(hostType, tags, page, limit);
            req.onSuccess += val =>
            {
                PostManager.posts = val;
                Settings.history.postsData = val;
                int i = 1;
                int.TryParse(page, out i);
                Settings.history.page = i;
                Settings.history.searchTag = tags;
                Settings.history.searchedTags.Add(tags);
                Settings.HistorySave();
                LoadPosts(val);
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

        public void LoadPosts(eData.Posts posts)
        {
            var val = posts;
            Console.WriteLine("Post fetched, is posts null? " + (val == null));
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
                        inst.Click += delegate
                        {
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
        }

        private void SearchLButton_MouseUp(object sender, MouseEventArgs e)
        {
            CommitSearch(homepageControl.searchBox.Text, "1", null);
            listingControl.searchBox.Text = homepageControl.searchBox.Text;
        }
        #endregion

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

        private void ptSettings_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeTab(3);
        }

        public void ChangeTab(int index)
        {
            for (int i = 0; i < panels.Length; i++)
            {
                panels[i].Visible = index == i;
            }
        }
        #endregion

        #region Uncategorized
        private void Sets_OpenSavePathLB_MouseUp(object sender, MouseEventArgs e)
        {
            if (System.IO.Directory.Exists(Sets_SavePathBox.Text))
                System.Diagnostics.Process.Start(Sets_SavePathBox.Text);
            else
                Utils.BetterMessageBox.Show("The save path folder doesn't exist!");
        }

        private void Sets_ResetButtonLB_MouseUp(object sender, MouseEventArgs e)
        {
            Settings.preferences.nativePath = true;
            Settings.preferences.savePath = System.IO.Path.GetFullPath("Posts");
            Sets_SavePathBox.Text = Settings.preferences.savePath;
            Settings.ForceSave();
        }

        private void Sets_ImageViewDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.preferences.imageViewType = Sets_ImageViewDropdown.SelectedIndex;
            Settings.ForceSave();
        }

        private void TypingBox_TextChanged(object sender, EventArgs e)
        {
            if (ignoreChange) return;
            Settings.preferences.nativePath = false;
            Settings.preferences.savePath = Sets_SavePathBox.Text;
            Settings.ForceSave();
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PostManager.posts == null || ignoreChange) return;

            int index = (int)viewerControl.numericUpDown.Value;
            var p = PostManager.posts.posts[index];
            viewerControl.ThrowPost(p, p.previewImage);
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Show();
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CommitSearch(toolStripTextBox1.Text, "1", null);
                Show();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trayIcon.Dispose();
            forceClose = true;
            Application.Exit();
        }

        private void Sets_HideTrayBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.preferences.hideToTray = Sets_HideTrayBox.Checked;
            Settings.ForceSave();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!forceClose && Settings.preferences.hideToTray)
            {
                e.Cancel = true;
                Hide();

                if(!Settings.history.bubbleShowed)
                {
                    trayIcon.ShowBalloonTip(4);
                    Settings.history.bubbleShowed = true;
                    Settings.HistorySave();
                }
            }
        }
        #endregion
    }

    #region Tool Classes
    public class Theme
    {
        public static List<Control> registeredControls = new List<Control>();

        public Color BackColor;
        public Color ForeColor;
        public Color BorderColor;
        public Color MiddleColor;

        public void ApplyTo(Control ctr)
        {
            if (ctr.Name.Contains("Header")) return;

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
    #endregion
}
