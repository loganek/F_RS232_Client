using System;

namespace F_RS232Client.Plugins
{
    public interface IDataWriterPlugin : IPlugin
    {
        event EventHandler<NewDataEventArgs> SendData;
    }
}
