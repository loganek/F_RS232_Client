using System.Windows.Forms;
using F_RS232Client.Plugins.Core.Controls;

namespace F_RS232Client.Plugins.Core
{
    public class CoreViewer : IDataViewerPlugin
    {
        readonly CoreViewerControl control = new CoreViewerControl();

        public CoreViewer()
        {
            Name = "Core Base Viewer";
            Description = "Shows data on an element";
            Author = "Marcin Kolny <marcin.kolny@gmail.com>";
            Version = "1.0";
        }

        #region IPlugin implementation
        public IPluginHost Host { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }
        public string Version { get; private set; }

        public Control GetControl()
        {
            return control;
        }

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

        #region IDataViewerPlugin implementation
        public void AppendData(byte[] data)
        {
            control.AppendData(data);
        }
        #endregion
    }
}
