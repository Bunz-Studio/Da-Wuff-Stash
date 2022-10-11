using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace DaWuffStash
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var cProc = Process.GetCurrentProcess();
            var matchName = cProc.ProcessName;
            var processes = Process.GetProcesses();
            Process proc = null;
            foreach(var procc in processes)
            {
                if (procc.ProcessName == matchName && procc.Id != cProc.Id) proc = procc;
            }

            if (proc != null)
            {
                Utils.BetterMessageBox.Show("Another instance of Da Wuff Stash is already running (check system tray), do you want to open another one?", "Da Wuff Stash Duplication Protection", 
                    new Utils.BetterMessageBox.BetterButton("No", true, () => Application.Exit()),
                    new Utils.BetterMessageBox.BetterButton("Yes", true, () => {
                        var mainForm = new MainForm();
                        mainForm.FormClosed += MainForm_FormClosed;
                        mainForm.Show();
                    })
                    );
                Application.Run();
            }
            else
            {
                Application.Run(new MainForm());
            }
        }

        private static void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    public static class Utility
    {
        public static Control[] GetControls(this Control control, bool deep = true)
        {
            List<Control> list = new List<Control>();
            foreach (Control item in control.Controls)
            {
                list.Add(item);
            }
            if (deep)
            {
                foreach (Control control2 in control.Controls)
                {
                    Control[] controls = control2.GetControls(true);
                    Control[] array = controls;
                    for (int i = 0; i < array.Length; i++)
                    {
                        Control item2 = array[i];
                        list.Add(item2);
                    }
                }
            }
            return list.ToArray();
        }

        public static T[] GetControlsWithType<T>(this Control control)
        {
            List<T> list = new List<T>();
            foreach (object current in control.Controls)
            {
                string a = current.GetType().ToString();
                string b = typeof(T).ToString();
                if (a == b)
                {
                    list.Add((T)((object)current));
                }
            }
            foreach (Control control2 in control.Controls)
            {
                T[] controlsWithType = control2.GetControlsWithType<T>();
                T[] array = controlsWithType;
                for (int i = 0; i < array.Length; i++)
                {
                    object obj = array[i];
                    list.Add((T)((object)obj));
                }
            }
            return list.ToArray();
        }

        public static void TryInvoke(this Action action)
        {
            if (action != null) action.Invoke();
        }

        public static void TryInvoke<T>(this Action<T> action, T obj)
        {
            if (action != null) action.Invoke(obj);
        }
    }
}
