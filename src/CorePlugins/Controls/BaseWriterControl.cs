using System;
using System.Windows.Forms;

namespace F_RS232Client.Plugins.Core.Controls
{
    public partial class BaseWriterControl : UserControl
    {
        private readonly BaseWriter writer;

        public BaseWriterControl(BaseWriter writer)
        {
            InitializeComponent();

            this.writer = writer;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            AppendToRichTextBox(Send());
            ClearTextBox();
        }

        private string Send()
        {
            var strConverter = new StrToBytesConverter(dataToSendTextBox.Text);
            var byteConverter = new BytesToStrConverter(strConverter.GetBytes(), GetSelectedDisplayMode());
            writer.Write(strConverter.GetBytes());
            
            return byteConverter.GetString();
        }

        private void AppendToRichTextBox(string sentString)
        {
            sentDataRichTextBox.AppendText(sentString);
            sentDataRichTextBox.SelectionStart = sentDataRichTextBox.Text.Length;
            sentDataRichTextBox.ScrollToCaret();
        }

        private void ClearTextBox()
        {
            if (clearAfterSendingCheckBox.Checked)
                dataToSendTextBox.Clear();
        }

        private DisplayMode GetSelectedDisplayMode()
        {
            if(asciiDMRadioButton.Checked)
                return DisplayMode.Ascii;
            if(octDMRadioButton.Checked)
                return DisplayMode.Oct;
            
            return decDMRadioButton.Checked ? DisplayMode.Dec : DisplayMode.Hex;
        }

        private void dataToSendTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                AppendToRichTextBox(Send());
                ClearTextBox();
            }
        }

        private void startStopCSButton_Click(object sender, EventArgs e)
        {
            if (circularSendingTimer.Enabled)
            {
                startStopCSButton.Text = "Start";
                circularSendingTimer.Stop();
                dataToSendTextBox.Enabled = true;
                sendButton.Enabled = true;
            }
            else
            {
                circularSendingTimer.Interval = Convert.ToInt32(intervalCSTextBox.Text);
                circularSendingTimer.Start();
                startStopCSButton.Text = "Stop";
                dataToSendTextBox.Enabled = false;
                sendButton.Enabled = false;
            }
        }

        private void circularSendingTimer_Tick(object sender, EventArgs e)
        {
            AppendToRichTextBox(Send());
        }
    }
}
