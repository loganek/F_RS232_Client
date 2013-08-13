using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F_RS232Client
{
    public partial class MainWindow : Form
    {
        SenderBaseControl senderControl;
        DataProtocols.SerialPort serialPort;

        public MainWindow()
        {
            InitializeComponent();
            InitCustomControls();
            serialPort.Open();
        }

        private void InitCustomControls()
        {
            serialPort = new DataProtocols.SerialPort("COM1");
            senderControl = new SenderBaseControl(serialPort);
            senderControlPanel.Dock = DockStyle.Fill;
            senderControlPanel.Controls.Add(senderControl);
        }
    }
}
