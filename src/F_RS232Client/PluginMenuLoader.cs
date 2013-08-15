using System.Linq;
using System.Windows.Forms;
using F_RS232Client.Plugins;

namespace F_RS232Client
{
    class PluginMenuLoader
    {
        private readonly ToolStripMenuItem baseMenuItem;
        private const int PositionOfUnknowPlugin = 2;
        #region constant menu items
        private ToolStripMenuItem connectionPlugins;
        private ToolStripMenuItem viewerPlugins;
        private ToolStripMenuItem writerPlugins;
        private ToolStripMenuItem baseViewerPlugins;
        private ToolStripMenuItem baseWriterPlugins;
        #endregion

        private readonly PluginService pluginService = new PluginService();

        public PluginMenuLoader(ToolStripMenuItem baseMenuItem)
        {
            this.baseMenuItem = baseMenuItem;
        }

        public void LoadMenu()
        {
            baseMenuItem.DropDownItems.Clear();

            BuildConstMenu();
            LoadItems();
            FillEmptyBranches();
        }

        private void FillEmptyBranches()
        {
            const string none = "(none)";

            if (baseWriterPlugins.DropDownItems.Count == 0)
                AddToMenu(none, baseWriterPlugins).Enabled = false;
            if (baseViewerPlugins.DropDownItems.Count == 0)
                AddToMenu(none, baseViewerPlugins).Enabled = false;
            if (connectionPlugins.DropDownItems.Count == 0)
                AddToMenu(none, connectionPlugins).Enabled = false;
        }

        private void BuildConstMenu()
        {
            connectionPlugins = AddToMenu("Connection Plugins");
            viewerPlugins = AddToMenu("Viewer Plugins");
            writerPlugins = AddToMenu("Writer Plugins");
            baseViewerPlugins = AddToMenu("Base Viewer Plugins", viewerPlugins);
            baseWriterPlugins = AddToMenu("Base Writer Plugins", writerPlugins);
            baseMenuItem.DropDownItems.Add(new ToolStripSeparator());
            AddToMenu("Reload plugins").Click += (sender, args) => LoadMenu();
        }

        private ToolStripMenuItem AddToMenu(string text, ToolStripMenuItem parent = null)
        {
            var item = new ToolStripMenuItem(text);
            (parent ?? baseMenuItem).DropDownItems.Add(item);

            return item;
        }

        private ToolStripMenuItem InsertUnknowPluginToMenu(string text)
        {
            var item = new ToolStripMenuItem(text);
            baseMenuItem.DropDownItems.Insert(baseMenuItem.DropDownItems.Count - PositionOfUnknowPlugin, item);

            return item;
        }

        private void LoadItems()
        {
            pluginService.FindPlugins();

            foreach (var plugin in from AvailablePlugin availablePlugin in pluginService.AvailablePlugins select availablePlugin.Instance)
            {
                ToolStripMenuItem item = InsertPluginToMenu(plugin);
                IPlugin pluginCopy = plugin;
                item.Click += (sender, e) => pluginCopy.Start();
            }
        }

        private ToolStripMenuItem InsertPluginToMenu(IPlugin plugin)
        {
            PluginType type = PluginService.GetPluginType(plugin);
            ToolStripMenuItem parent;

            switch (type)
            {
                case PluginType.BaseViewer:
                    parent = baseViewerPlugins;
                    break;
                case PluginType.BaseWriter:
                    parent = baseWriterPlugins;
                    break;
                case PluginType.Connection:
                    parent = connectionPlugins;
                    break;
                case PluginType.Viewer:
                    parent = viewerPlugins;
                    break;
                case PluginType.Writer:
                    parent = writerPlugins;
                    break;
                default:
                    return InsertUnknowPluginToMenu(plugin.Name);
                    break;
            }

            return AddToMenu(plugin.Name, parent);
        }
    }
}
