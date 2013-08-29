using System;

namespace F_RS232Client.Plugins
{
    public interface IDataConnectionPlugin : IWriteable, IPlugin
    {
        event EventHandler<ChangeStateEventArgs> ChangeConnectionState;
    }

    public class ChangeStateEventArgs : EventArgs
    {
        public ChangeStateEventArgs(bool isOpen)
        {
            IsOpen = isOpen;
        }

        public bool IsOpen { get; private set; }
    }
}
