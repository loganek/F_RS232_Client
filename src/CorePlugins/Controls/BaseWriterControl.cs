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

        private void sendButton_Click(object sender, System.EventArgs e)
        {
            Send();
        }

        private void Send()
        {
            var strConverter = new StrToBytesConverter(dataToSendTextBox.Text);
            var byteConverter = new BytesToStrConverter(strConverter.GetBytes(), GetSelectedDisplayMode());
            writer.Write(strConverter.GetBytes());
            
            sentDataRichTextBox.AppendText(byteConverter.GetString());
            sentDataRichTextBox.SelectionStart = sentDataRichTextBox.Text.Length;
            sentDataRichTextBox.ScrollToCaret();
        }

        private DisplayMode GetSelectedDisplayMode()
        {
            if(asciiDMRadioButton.Checked)
                return DisplayMode.Ascii;
            if(octDMRadioButton.Checked)
                return DisplayMode.Oct;
            
            return decDMRadioButton.Checked ? DisplayMode.Dec : DisplayMode.Hex;
        }
    }
}
