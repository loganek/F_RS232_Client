using System;
using System.IO;
using System.Linq;
using System.Reflection;
using F_RS232Client.Plugins;

namespace F_RS232Client
{
    class PluginService : IPluginHost
    {
        private Types.AvailablePlugins colAvailablePlugins = new Types.AvailablePlugins();

        public Types.AvailablePlugins AvailablePlugins
        {
            get { return colAvailablePlugins; }
            set { colAvailablePlugins = value; }
        }

        public void FindPlugins()
        {
            FindPlugins(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins"));
        }
       
        public void FindPlugins(string path)
        {
            colAvailablePlugins.Clear();

            foreach (var fileOn in from fileOn in Directory.GetFiles(path) let file = new FileInfo(fileOn) where file.Extension.Equals(".dll") select fileOn)
            {
                AddPlugin(fileOn);
            }
        }

        public void ClosePlugins()
        {
            foreach (Types.AvailablePlugin pluginOn in colAvailablePlugins)
            {
                if (pluginOn.Instance != null) pluginOn.Instance.Dispose();
                pluginOn.Instance = null;
            }

            colAvailablePlugins.Clear();
        }

        private void AddPlugin(string fileName)
        {
            Assembly pluginAssembly = Assembly.LoadFrom(fileName);

            foreach (var newPlugin in from pluginType in pluginAssembly.GetTypes() where pluginType.IsPublic && !pluginType.IsAbstract let typeInterface = pluginType.GetInterface("F_RS232Client.Plugins.IPlugin", true) where typeInterface != null select new Types.AvailablePlugin
                {
                    AssemblyPath = fileName,
                    Instance = (IPlugin) Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()))
                })
            {
                newPlugin.Instance.Host = this;
                newPlugin.Instance.Initialize();
                colAvailablePlugins.Add(newPlugin);
            }
        }

        public void Feedback(string feedback, IPlugin plugin)
        {
            
        }
    }
    namespace Types
    {
        public class AvailablePlugins : System.Collections.CollectionBase
        {
            public void Add(AvailablePlugin pluginToAdd)
            {
                List.Add(pluginToAdd);
            }

            public void Remove(AvailablePlugin pluginToRemove)
            {
                List.Remove(pluginToRemove);
            }

            public AvailablePlugin Find(string pluginNameOrPath)
            {
                return List.Cast<AvailablePlugin>().FirstOrDefault(pluginOn => (pluginOn.Instance.Name.Equals(pluginNameOrPath)) || pluginOn.AssemblyPath.Equals(pluginNameOrPath));
            }
        }

        public class AvailablePlugin
        {
            public IPlugin Instance { get; set; }
            public string AssemblyPath { get; set; }
        }
    }
}
