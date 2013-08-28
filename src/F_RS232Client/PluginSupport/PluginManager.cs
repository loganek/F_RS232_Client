using System.Collections.Generic;
using F_RS232Client.Plugins;

namespace F_RS232Client.PluginSupport
{
    class PluginManager
    {
        private readonly List<IPlugin> selectedPlugins = new List<IPlugin>();

        public void AddPlugin(IPlugin plugin)
        {
            selectedPlugins.Add(plugin);
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
    }
}
