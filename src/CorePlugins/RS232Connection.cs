using System;
using System.Windows.Forms;
using System.IO.Ports;
using F_RS232Client.Plugins.Core.Controls;

namespace F_RS232Client.Plugins.Core
{
    public class RS232Connection : IDataConnectionPlugin
    {
        private SerialPort internalPort = new SerialPort();
        readonly RS232ConnectionControl control = new RS232ConnectionControl();

        public event EventHandler<ChangeStateEventArgs> ChangeConnectionState;


        protected virtual void OnDoEvent<T>(EventHandler<T> e, T args)
            where T : EventArgs
        {
            if (e != null)
                e(this, args);
        }

        public RS232Connection()
        {
            control.PortOpen += (sender, args) => OpenPort();
            control.PortClose += (sender, args) => ClosePort();
            ChangeConnectionState += (sender, args) => control.SetConnectionState(args.IsOpen);

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
            return control;
        }

        #endregion

        #region IWriteable implementation

        public void Write(byte[] bytes)
        {
            CheckPortOpen();
            internalPort.Write(bytes, 0, bytes.Length);
        }

        public void Write(byte b)
        {
            Write(new[] {b});
        }

        public void Write(string str)
        {
            CheckPortOpen();
            internalPort.Write(str);
        }

        #endregion

        public void OpenPort()
        {
            if (internalPort.IsOpen)
                return;

            CreateSerialPortFromControl();
            internalPort.Open();
            OnDoEvent(ChangeConnectionState, new ChangeStateEventArgs(true));
        }

        private void CreateSerialPortFromControl()
        {
            internalPort = new SerialPort(control.PortName,
                control.BaudRate, control.Parity, 
                control.DataBits, control.StopBits);
        }

        private void ClosePort()
        {
            if (!internalPort.IsOpen)
                return;

            internalPort.DiscardInBuffer();
            internalPort.DiscardOutBuffer();
            new System.Threading.Thread(() =>
                {
                    internalPort.Close();
                    OnDoEvent(ChangeConnectionState, new ChangeStateEventArgs(false));
                }).Start();
        }

        private void CheckPortOpen()
        {
            if (!internalPort.IsOpen)
                throw new Exception("Cannot send data: port is closed");
        }
    }

    public class ChangeStateEventArgs : EventArgs
    {
        public ChangeStateEventArgs(bool isOpen)
        {
            IsOpen = isOpen;
        }

        public bool IsOpen { get; private set; }
    }
}
