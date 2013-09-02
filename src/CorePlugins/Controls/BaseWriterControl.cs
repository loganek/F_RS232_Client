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
            writer.Write(dataToSendTextBox.Text);
        }
    }
}
