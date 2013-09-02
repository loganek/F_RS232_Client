using System.Windows.Forms;
using F_RS232Client.PluginSupport;

namespace F_RS232Client
{
    public partial class MainWindow : Form
    {
        private readonly PluginMenuLoader pluginMenuLoader;

        public MainWindow()
        {
            InitializeComponent();
            pluginMenuLoader = new PluginMenuLoader(pluginsToolStripMenuItem, baseWriterPanel, baseViewerPanel, connectionPanel);
            pluginMenuLoader.LoadMenu();
        }
    }
}
