using System.Linq;
using System.Windows.Forms;
using F_RS232Client.Plugins;

namespace F_RS232Client
{
    class PluginMenuLoader
    {
        private readonly ToolStripMenuItem baseMenuItem;
        private const int PositionOfUnknowPlugin = 2;

        #region Base panels

        private readonly Control baseWriter;
        private readonly Control baseViewer;
        private readonly Control baseConnection;

        #endregion

        #region constant menu items
        private ToolStripMenuItem connectionPlugins;
        private ToolStripMenuItem viewerPlugins;
        private ToolStripMenuItem writerPlugins;
        #endregion

        private readonly PluginService pluginService = new PluginService();

        public PluginMenuLoader(ToolStripMenuItem baseMenuItem, Control baseWriter, Control baseViewer, Control baseConnection)
        {
            this.baseWriter = baseWriter;
            this.baseViewer = baseViewer;
            this.baseConnection = baseConnection;
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

            if (writerPlugins.DropDownItems.Count == 0)
                AddToMenu(none, writerPlugins).Enabled = false;
            if (viewerPlugins.DropDownItems.Count == 0)
                AddToMenu(none, viewerPlugins).Enabled = false;
            if (connectionPlugins.DropDownItems.Count == 0)
                AddToMenu(none, connectionPlugins).Enabled = false;
        }

        private void BuildConstMenu()
        {
            connectionPlugins = AddToMenu("Connection Plugins");
            viewerPlugins = AddToMenu("Viewer Plugins");
            writerPlugins = AddToMenu("Writer Plugins");
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

                AppendClickMethodToBasePlugin(item, plugin);

                item.Click += (sender, e) => pluginCopy.Start();
            }
        }

        private void AppendClickMethodToBasePlugin(ToolStripItem item, IPlugin plugin)
        {
            Control parentControl = null;

            switch (PluginService.GetPluginType(plugin))
            {
                case PluginType.Viewer:
                    parentControl = baseViewer;
                    break;
                case PluginType.Writer:
                    parentControl = baseWriter;
                    break;
                case PluginType.Connection:
                    parentControl = baseConnection;
                    break;
            }

            item.Click += (sender, args) =>
                {
                    if (parentControl == null) return;
                    Control ctrl = plugin.GetControl();
                    parentControl.Controls.Add(ctrl);
                    ctrl.Dock = DockStyle.Fill;
                };
        }

        private ToolStripMenuItem InsertPluginToMenu(IPlugin plugin)
        {
            PluginType type = PluginService.GetPluginType(plugin);
            ToolStripMenuItem parent;

            switch (type)
            {
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
            }

            return AddToMenu(plugin.Name, parent);
        }
    }
}
