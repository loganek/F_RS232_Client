using System.Collections.Generic;
using System.Linq;
using F_RS232Client.Plugins;

namespace F_RS232Client.PluginSupport
{
    class PluginManager
    {
        private readonly List<IPlugin> selectedPlugins = new List<IPlugin>();

        public void AddPlugin(IPlugin plugin)
        {
            selectedPlugins.Add(plugin);

            if (plugin is IDataWriterPlugin)
            {
                foreach (var p in selectedPlugins.OfType<IDataConnectionPlugin>())
                {
                    var p1 = p;
                    (plugin as IDataWriterPlugin).SendData += (sender, args) => WriteToDataConnection(p1, args.Data);
                }
            }

            plugin.Start();
        }

        public void RemovePlugin(IPlugin plugin)
        {
            plugin.Dispose();
            selectedPlugins.Remove(plugin);
        }

        public bool HasPlugin(IPlugin plugin)
        {
            return selectedPlugins.Contains(plugin);
        }

        private void WriteToDataConnection(IDataConnectionPlugin plugin, byte[] data)
        {
            plugin.Write(data);
        }
    }
}
