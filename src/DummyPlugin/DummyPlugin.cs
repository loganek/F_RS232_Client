using System.Windows.Forms;
using F_RS232Client.Plugins;

namespace DummyPlugin
{
    public class DummyPlugin : IPlugin
    {
        public DummyPlugin()
        {
            Name = "Simple Dummy Plugin";
            Description = "Do Nothing (or maybe says 'Hello World')";
            Author = "Marcin Kolny <marcin.kolny@gmail.com>";
            Version = "1.0";
        }

        #region IPlugin implementation
        public IPluginHost Host { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }
        public string Version { get; private set; }

        public void Initialize()
        {
        }

        public void Dispose()
        {
        }

        public void Start()
        {
            MessageBox.Show("Hello World");
        }

        public Control GetControl()
        {
            return new Label
                {
                    Text = "This is dummy plugin"
                };
        }

        #endregion
    }
}
