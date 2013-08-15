using System.Linq;
using System.Windows.Forms;
using F_RS232Client.Plugins;
using F_RS232Client.Types;

namespace F_RS232Client
{
    public partial class MainWindow : Form
    {
        readonly PluginService pluginService = new PluginService();

        public MainWindow()
        {
            InitializeComponent();

            LoadPlugins();
        }

        private void LoadPlugins()
        {
            pluginService.FindPlugins();

            foreach (var plugin in from AvailablePlugin availablePlugin in pluginService.AvailablePlugins select availablePlugin.Instance)
            {
                ToolStripItem item = new ToolStripMenuItem(plugin.Name);
                IPlugin pluginCopy = plugin;
                item.Click += (sender, e) => pluginCopy.Start();
                pluginsToolStripMenuItem.DropDownItems.Insert(pluginsToolStripMenuItem.DropDownItems.Count - 2, item);
            }
        }
    }
}
