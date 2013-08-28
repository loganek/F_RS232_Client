using System;
using System.Linq;
using System.Windows.Forms;
using F_RS232Client.Plugins;

namespace F_RS232Client.PluginSupport
{
    class PluginMenuLoader
    {
        private readonly ToolStripMenuItem baseMenuItem;
        private const int PositionOfUnknowPlugin = 2;
        private PluginManager manager = new PluginManager();

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

                item.Click += (sender, e) =>
                    {
                        if (manager.HasPlugin(pluginCopy))
                        {
                            manager.RemovePlugin(pluginCopy);
                            RemovePluginParent(pluginCopy);
                            item.Checked = false;
                        }
                        else
                        {
                            manager.AddPlugin(pluginCopy);
                            SetPluginParent(pluginCopy);
                            item.Checked = true;
                        }
                    };
            }
        }

        private void RemovePluginParent(IPlugin plugin)
        {
            Control parentControl = GetPluginParent(plugin);

            if (parentControl == null) return;
            parentControl.Controls.Clear();
        }

        private void SetPluginParent(IPlugin plugin)
        {
            Control parentControl = GetPluginParent(plugin);

            if (parentControl == null) return;
            Control ctrl = plugin.GetControl();
            parentControl.Controls.Add(ctrl);
            ctrl.Dock = DockStyle.Fill;
        }

        private Control GetPluginParent(IPlugin plugin)
        {
            switch (PluginService.GetPluginType(plugin))
            {
                case PluginType.Viewer:
                    return baseViewer;
                case PluginType.Writer:
                    return baseWriter;
                case PluginType.Connection:
                    return baseConnection;
            }

            throw new Exception("Unknow plugin parent");
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
