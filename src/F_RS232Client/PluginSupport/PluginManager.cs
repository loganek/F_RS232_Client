using System;
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
                (plugin as IDataWriterPlugin).SendData += WriteToDataConnection;
            }
            else if(plugin is IDataConnectionPlugin)
            {
                (plugin as IDataConnectionPlugin).ReceiveNewData += OnReceiveNewData;
            }

            plugin.Start();
        }

        private void OnReceiveNewData(object sender, NewDataEventArgs e)
        {
            foreach (var plugin in selectedPlugins.OfType<IDataViewerPlugin>())
            {
                plugin.AppendData(e.Data);
            }
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

        private void WriteToDataConnection(object sender, NewDataEventArgs e)
        {
            foreach (var connectionPlugin in selectedPlugins.OfType<IDataConnectionPlugin>())
            {
                connectionPlugin.Write(e.Data);
            }
        }
    }
}
