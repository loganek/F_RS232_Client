using System.Windows.Forms;

namespace F_RS232Client
{
    public partial class MainWindow : Form
    {
        private readonly PluginMenuLoader pluginMenuLoader;

        public MainWindow()
        {
            InitializeComponent();
            pluginMenuLoader = new PluginMenuLoader(pluginsToolStripMenuItem, baseWriterPanel, null, null);
            pluginMenuLoader.LoadMenu();
        }
    }
}
