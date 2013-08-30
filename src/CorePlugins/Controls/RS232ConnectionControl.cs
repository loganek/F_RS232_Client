using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace F_RS232Client.Plugins.Core.Controls
{
    public partial class RS232ConnectionControl : UserControl
    {
        private bool connectionState;
        private int rxIndicateCounter;

        public RS232ConnectionControl()
        {
            InitializeComponent();

            InitComponentValues();
        }

        internal event EventHandler PortOpen;
        internal event EventHandler PortClose;

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
            get { return Convert.ToInt32(baudRateComboBox.Text); }
        }

        public Parity Parity
        {
            get
            {
                var parities = new[] {Parity.None, Parity.Odd, Parity.Even, Parity.Mark, Parity.Space};
                return parities[parityComboBox.SelectedIndex];
            }
        }

        public int DataBits
        {
            get { return Convert.ToInt32(dataBitsComboBox.Text); }
        }

        public StopBits StopBits
        {
            get
            {
                var stopBits = new[] {StopBits.None, StopBits.One, StopBits.OnePointFive, StopBits.Two};
                return stopBits[stopBitsComboBox.SelectedIndex];
            }
        }

        #endregion

        public void SetConnectionState(bool state)
        {
            connectionState = state;
            DoInvoke(connectButton, () =>
                                    connectButton.Text = connectionState ? "Disconnect" : "Connect");
        }

        public void DataReceived(object sender, NewDataEventArgs e)
        {
            dataReceivedIndicatorButton.BackColor = Color.Green;
            Interlocked.Increment(ref rxIndicateCounter);
            new Thread(() =>
                {
                    Thread.Sleep(1000);
                    DoInvoke(dataReceivedIndicatorButton, () =>
                        {
                            Interlocked.Decrement(ref rxIndicateCounter);

                            if (rxIndicateCounter == 0)
                                dataReceivedIndicatorButton.BackColor = SystemColors.Control;
                        });
                }).Start();
        }

        private void InitComponentValues()
        {
            ScanPorts();

            parityComboBox.SelectedIndex = 0;
            dataBitsComboBox.SelectedIndex = 1;
            stopBitsComboBox.SelectedIndex = 1;
        }

        private void ScanPorts()
        {
            availablePortsComboBox.DataSource = SerialPort.GetPortNames();

            if (availablePortsComboBox.Items.Count > 0)
            {
                availablePortsComboBox.SelectedIndex = 0;
                connectButton.Enabled = true;
            }
            else
                connectButton.Enabled = false | connectionState;
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

        private void rescanPortsButton_Click(object sender, EventArgs e)
        {
            ScanPorts();
        }
    }
}
