using System;

namespace F_RS232Client.Plugins
{
    public interface IDataConnectionPlugin : IWriteable, IPlugin
    {
        event EventHandler<ChangeStateEventArgs> ChangeConnectionState;
        event EventHandler<NewDataEventArgs> ReceiveNewData;
    }

    public class ChangeStateEventArgs : EventArgs
    {
        public ChangeStateEventArgs(bool isOpen)
        {
            IsOpen = isOpen;
        }

        public bool IsOpen { get; private set; }
    }

    public class NewDataEventArgs : EventArgs
    {
        public NewDataEventArgs(byte[] data)
        {
            Data = data;
        }

        public byte[] Data { get; private set; }
    }
}
