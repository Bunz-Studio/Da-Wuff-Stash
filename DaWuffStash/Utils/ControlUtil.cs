using System;
using System.Drawing;
using System.Windows.Forms;

namespace DaWuffStash
{
    static class ControlUtil
    {
        public static DraggableControl AddDraggableHandle(Control interacter, IntPtr handle = default(IntPtr))
        {
            var d = new DraggableControl();
            if (handle == default(IntPtr))
                d.handle = interacter.Handle;
            else
                d.handle = handle;
            interacter.MouseDown += d.Drag_MouseDown;
            return d;
        }

        public static void ModernifyInteraction(this Control control, Color mainColor, Color onHoverColor, Color onClickColor)
        {
			control.MouseDown += (a, e) => control.BackColor = onClickColor;
			control.MouseUp += (a, e) => control.BackColor = onHoverColor;
			control.MouseEnter += (a, e) => control.BackColor = onHoverColor;
			control.MouseLeave += (a, e) => control.BackColor = mainColor;
            control.ForeColorChanged += (a, e) => control.ModernifyInteraction(mainColor, onHoverColor, onClickColor);
        }
        public static void ModernifyInteraction(this Control control, ColorDictionary dictionary)
        {
        	var d = dictionary;
            control.MouseDown += (a, e) => control.BackColor = d.click;
            control.MouseUp += (a, e) => control.BackColor = d.hover;
            control.MouseEnter += (a, e) => control.BackColor = d.hover;
            control.MouseLeave += (a, e) => control.BackColor = d.main;
            control.ForeColorChanged += (a, e) => control.ModernifyInteraction(dictionary);
        }
        public static ColorDictionary ModernifyInteraction(this Control control, int intensity = 1)
        {
        	var d = new ColorDictionary(control, intensity);
            control.MouseDown += (a, e) => control.BackColor = d.click;
            control.MouseUp += (a, e) => control.BackColor = d.hover;
            control.MouseEnter += (a, e) => control.BackColor = d.hover;
            control.MouseLeave += (a, e) => control.BackColor = d.main;
            control.ForeColorChanged += (a, e) => control.ModernifyInteraction(intensity);
            return d;
        }
        public static ColorDictionary ModernifyInteractioRedirect(this Control control, Control target, int intensity = 1)
        {
        	var d = new ColorDictionary(control, intensity);
            control.MouseDown += (a, e) => target.BackColor = d.click;
            control.MouseUp += (a, e) => target.BackColor = d.hover;
            control.MouseEnter += (a, e) => target.BackColor = d.hover;
            control.MouseLeave += (a, e) => target.BackColor = d.main;
            control.ForeColorChanged += (a, e) => control.ModernifyInteractioRedirect(target, intensity);
            return d;
        }
        
        public class ColorDictionary
        {
        	public Color main = Color.Black;
        	public Color hover = Color.DarkGray;
        	public Color click = Color.Gray;
        	
        	public ColorDictionary ()
        	{
        		
        	}
        	
        	public ColorDictionary (Control control)
        	{
        		main = control.BackColor;
        		hover = control.BackColor.Add(15);
        		click = control.BackColor.Add(45);
        	}
        	
        	public ColorDictionary (Control control, int intensity)
        	{
        		main = control.BackColor;
        		hover = control.BackColor.Add(15 * intensity);
        		click = control.BackColor.Add(45 * intensity);
        	}
        }

        public static void AddBorder(this Control control)
        {
            control.Paint += (a, e) =>
            {
                var point = new Point(control.DisplayRectangle.X, control.DisplayRectangle.Y);
                e.Graphics.DrawRectangle(new Pen(control.ForeColor), point.X, point.Y, control.Size.Width - 1, control.Size.Height - 1);
            };
            control.ForeColorChanged += (a, e) => control.Invalidate();
            control.Resize += (a, e) => control.Invalidate();
            control.Move += (a, e) => control.Invalidate();
        }

        public static void AddBorder(this Control control, Point point)
        {
            control.Paint += (a, e) =>
            e.Graphics.DrawRectangle(new Pen(control.ForeColor), point.X, point.Y, control.Size.Width - 1, control.Size.Height - 1);
            control.ForeColorChanged += (a, e) => control.Invalidate();
            control.Resize += (a, e) => control.Refresh();
            control.Resize += (a, e) => control.Invalidate();
            control.Move += (a, e) => control.Invalidate();
        }

        public static Point Add(this Point lhs, Point rhs)
        {
            return new Point(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }
		
        public static Color Add(this Color c, int val)
        {
        	return Color.FromArgb(c.A, Mathf.Clamp(c.R + val, 0, 255), Mathf.Clamp(c.G + val, 0, 255), Mathf.Clamp(c.B + val, 0, 255));
        }
        
        #region Insiders
        public class DraggableControl
        {
            public const int WM_NCLBUTTONDOWN = 0xA1;
            public const int HT_CAPTION = 0x2;
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern bool ReleaseCapture();
            public IntPtr handle;
            public void Drag_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
        #endregion
    }
}
