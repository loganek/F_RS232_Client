using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace F_RS232Client.Plugins.Core.Controls
{
    public partial class RS232ConnectionControl : UserControl
    {
        private bool connectionState = false;

        public RS232ConnectionControl()
        {
            InitializeComponent();
            availablePortsComboBox.DataSource = SerialPort.GetPortNames();
        }

        public event EventHandler PortOpen;
        public event EventHandler PortClose;

        protected virtual void OnDoEvent(EventHandler e, EventArgs args = null)
        {
            args = args ?? EventArgs.Empty;

            if (e != null)
                e(this, args);
        }

        #region public getters

        public string PortName
        {
            get { return availablePortsComboBox.Text; }
        }

        public int BaudRate
        {
            get { return 9600; }
        }

        public Parity Parity
        {
            get { return Parity.None; }
        }

        public int DataBits
        {
            get { return 8; }
        }

        public StopBits StopBits
        {
            get { return StopBits.One; }
        }

        #endregion

        public void SetConnectionState(bool state)
        {
            connectionState = state;
            DoInvoke(connectButton, () =>
                                    connectButton.Text = connectionState ? "Disconnect" : "Connect");
        }

        private void DoInvoke(Control control, Action action)
        {
            if (control.InvokeRequired)
                control.Invoke(action);
            else
                action();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            OnDoEvent(connectionState ? PortClose : PortOpen);
        }
    }
}
