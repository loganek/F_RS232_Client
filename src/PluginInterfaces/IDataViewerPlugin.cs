namespace F_RS232Client.Plugins
{
    public interface IDataViewerPlugin : IPlugin
    {
        void AppendData(byte[] data);
    }
}
