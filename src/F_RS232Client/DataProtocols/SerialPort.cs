using F_RS232Client.Plugins;

namespace F_RS232Client.DataProtocols
{
    public class SerialPort : DataProtocol, IWriteable
    {
        private readonly System.IO.Ports.SerialPort internalPort;

        public SerialPort(string portName)
        {
            internalPort = new System.IO.Ports.SerialPort(portName);
        }

        #region DataProtocol implementation
        override public void Open()
        {
            if (IsOpen)
                return;
            
            internalPort.Open();
        }

        override public bool IsOpen
        {
            get
            {
                return internalPort.IsOpen;
            }
        }

        override public void Close()
        {
            internalPort.Close();
        }
        #endregion

        #region IWriteable implementation
        public void Write(byte b)
        {
            internalPort.Write(new[] { b }, 0, 1);
        }

        public void Write(byte[] bytes)
        {
            internalPort.Write(bytes, 0, bytes.Length);
        }

        public void Write(string str)
        {
            internalPort.Write(str);
        }
        #endregion

        public static string[] AvailablePorts
        {
            get
            {
                return System.IO.Ports.SerialPort.GetPortNames();
            }
        }
    }
}
