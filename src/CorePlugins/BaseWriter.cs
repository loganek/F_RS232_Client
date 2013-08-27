using System.Windows.Forms;
using F_RS232Client.Plugins.Core.Controls;

namespace F_RS232Client.Plugins.Core
{
    public class BaseWriter : IDataWriterPlugin
    {
        public BaseWriter()
        {
            Name = "Core Base Writer";
            Description = "Writes data to an element";
            Author = "Marcin Kolny <marcin.kolny@gmail.com>";
            Version = "1.0";
        }

        #region IBaseDataWriterPlugin implementation
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
            return new BaseWriterControl();
        }

        #endregion
    }
}
