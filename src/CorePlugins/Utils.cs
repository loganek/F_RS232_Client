using System;
using System.Windows.Forms;

namespace F_RS232Client.Plugins.Core
{
    internal class Utils
    {
        internal static void DoInvoke(Control control, Action action)
        {
            if (control.InvokeRequired)
                control.Invoke(action);
            else
                action();
        }
    }
}
