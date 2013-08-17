using System.Windows.Forms;

namespace F_RS232Client.Plugins
{
    public interface IPlugin
    {
        IPluginHost Host { get; set; }

        #region Plugin info
        string Name { get; }
        string Description { get; }
        string Author { get; }
        string Version { get; }
        #endregion

        void Start();
        void Initialize();
        void Dispose();
    }

    public interface IBasePlugin
    {
        Control GetControl();
    }

    public interface IPluginHost
    {
        void Feedback(string feSedback, IPlugin pluginn);
    }
}
