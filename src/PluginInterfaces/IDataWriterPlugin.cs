namespace F_RS232Client.Plugins
{
    public interface IDataWriterPlugin : IPlugin
    {
    }

    public interface IBaseDataWriterPlugin : IDataWriterPlugin, IBasePlugin
    {
    }
}
