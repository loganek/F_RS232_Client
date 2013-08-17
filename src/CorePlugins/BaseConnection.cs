using System.Windows.Forms;
using System.IO.Ports;
using F_RS232Client.Plugins.Controls;

namespace F_RS232Client.Plugins.Core
{
    public class BaseConnection : IDataConnectionPlugin
    {
        private SerialPort internalPort;

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

        #region IBasePlugin implementation
        
        public Control GetControl()
        {
            return new RS232ConnectionControl();
        }

        #endregion

        #region IWriteable implementation

        public void Write(byte[] bytes)
        {
            throw new System.NotImplementedException();
        }

        public void Write(byte b)
        {
            throw new System.NotImplementedException();
        }

        public void Write(string str)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
