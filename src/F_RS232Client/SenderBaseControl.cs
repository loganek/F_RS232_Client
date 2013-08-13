using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F_RS232Client
{
    public partial class SenderBaseControl : UserControl
    {
        private IWriteable destination;

        public event EventHandler ErrorOccured;

        public SenderBaseControl(IWriteable destination)
        {
            InitializeComponent();

            this.destination = destination;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string dataToSend = dataToSendTextBox.Text;

            try
            {
                destination.Write(dataToSend);
                LogData(dataToSend);
            }
            catch (Exception exception)
            {
                LogMessage(exception);    
            }
        }

        private void LogMessage(Exception exception)
        {
            // TODO: implement message loggin

            // TODO: event arg with exception?
            OnErrorOccured(null);
        }

        private void LogData(string data)
        {
            sentDataRichTextBox.AppendText(data);
        }

        private void OnErrorOccured(EventArgs e)
        {
            if (ErrorOccured != null)
                ErrorOccured(this, e);
        }
    }
}
