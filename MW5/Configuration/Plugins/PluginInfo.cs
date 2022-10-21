using System;
using System.ComponentModel;
using MW5.Plugins.Concrete;

namespace MW5.Configuration.Plugins
{
    public class PluginInfo
    {
        private readonly BasePlugin _plugin;

        public PluginInfo(BasePlugin plugin, bool selected)
        {
            if (plugin == null) throw new ArgumentNullException("plugin");
            _plugin = plugin;
            Selected = selected;
        }


        [DisplayName("选择")]
        public bool Selected { get; set; }

        [DisplayName("名称")]
        public string Name
        {
            get { return _plugin.Identity.Name; }
        }

        [DisplayName("作者")]
        public string Author
        {
            get { return _plugin.Identity.Author; }
        }

        [DisplayName("启动时加载")]
        public bool LoadOnStartup
        {
            get { return _plugin.Identity.LoadOnStartup; }
        }

        internal BasePlugin BasePlugin
        {
            get { return _plugin; }
        }
    }
}
