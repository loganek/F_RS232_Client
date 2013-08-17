namespace F_RS232Client.Plugins.Core
{
    public class BaseConnection : IDataConnectionPlugin
    {
        public BaseConnection()
        {
            Name = "Core RS232 Connection";
            Description = "Makes a connection via RS232";
            Author = "Marcin Kolny <marcin.kolny@gmail.com>";
            Version = "1.0";
        }

        #region DataConnectionPlugin implementation
        public IPluginHost Host { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }
        public string Version { get; private set; }
        public void Start()
        {
        }

        public void Initialize()
        {
        }

        public void Dispose()
        {
        }
        #endregion
    }
}
