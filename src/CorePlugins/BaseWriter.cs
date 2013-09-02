using System;
using System.Windows.Forms;
using F_RS232Client.Plugins.Core.Controls;

namespace F_RS232Client.Plugins.Core
{
    public class BaseWriter : IDataWriterPlugin
    {
        private readonly BaseWriterControl control;

        public BaseWriter()
        {
            control = new BaseWriterControl(this);
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

        #region DataWriterPlugin implementation

        public event EventHandler<NewDataEventArgs> SendData;

        #endregion

        protected virtual void OnSendData(NewDataEventArgs e)
        {
            if (SendData != null) 
                SendData(this, e);
        }

        public void Write(string text)
        {
            var converter = new StrToBytesConverter(text);
            OnSendData(new NewDataEventArgs(converter.GetBytes()));
        }
    }
}
