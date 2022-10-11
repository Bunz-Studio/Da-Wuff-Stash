using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaWuffStash.Utils
{
    public partial class BetterMessageBox : Form
    {
        public Size defaultButtonSize = new Size(100, 28);
        public List<Label> buttons = new List<Label>();
        public BetterMessageBox()
        {
            InitializeComponent();
        }

        public static BetterMessageBox Show(string content, string title = null, params BetterButton[] buttons)
        {
            var box = new BetterMessageBox();
            box.warningLabel.Text = content;
            box.Text = string.IsNullOrWhiteSpace(title) ? Application.ProductName : title;
            if(buttons != null)
            {
                if (buttons.Length > 0)
                {
                    foreach(var but in buttons)
                    {
                        box.AddButton(but);
                        box.Select();
                        if(but.close)
                        {
                            but.onClick += () => box.Dispose();
                        }
                    }
                }
                else
                {
                    box.AddButton(new BetterButton("Ok", () => box.Dispose()));
                    box.Select();
                }
            }
            box.Show();
            return box;
        }

        public Label AddButton(BetterButton button)
        {
            var label = new Label();
            label.Text = button.text;
            label.MouseUp += (aa, ee) => button.onClick.TryInvoke();
            label.AddBorder();
            label.ModernifyInteraction();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Size = defaultButtonSize;
            buttonsLayoutPanel.Controls.Add(label);
            buttons.Add(label);
            return label;
        }

        public class BetterButton
        {
            public string text;
            public bool close;
            public Action onClick;

            public BetterButton(string text)
            {
                this.text = text;
                close = true;
            }

            public BetterButton(string text, Action onClick)
            {
                this.text = text;
                this.onClick = onClick;
                close = false;
            }

            public BetterButton(string text, bool close, Action onClick)
            {
                this.text = text;
                this.close = close;
                this.onClick = onClick;
            }
        }
    }
}
