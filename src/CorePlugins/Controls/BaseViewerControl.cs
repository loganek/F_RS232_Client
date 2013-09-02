using System;
using System.Windows.Forms;

namespace F_RS232Client.Plugins.Core.Controls
{
    public partial class BaseViewerControl : UserControl
    {
        public BaseViewerControl()
        {
            InitializeComponent();
        }

        public void AppendData(byte[] data)
        {
            string text = new BytesToStrConverter(data, DisplayMode.Ascii).GetString();
            Utils.DoInvoke(mainRichTextBox, () => mainRichTextBox.AppendText(text));
        }
    }
}
