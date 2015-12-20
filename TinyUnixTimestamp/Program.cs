using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyUnixTimestamp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (NotifyIcon icon = new NotifyIcon())
            {
                icon.Icon = new Icon(Properties.Resources.TinyUnixTimestamp, SystemInformation.SmallIconSize);
                icon.Visible = true;
                icon.Text = "Click to copy the Unix timestamp to the clipboard.";

                icon.ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Exit", (s, e) => { Application.Exit(); }),
                });

                icon.Click += (s, e) =>
                {
                    Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                    Clipboard.SetText(unixTimestamp.ToString());
                };

                Application.Run();
            }
        }
    }
}
