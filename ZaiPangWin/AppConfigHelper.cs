using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZaiPangWin
{
    public class AppConfigHelper
    {
        public static void Save(string Name, string value)
        {
            ConfigurationManager.AppSettings.Set(Name, value);
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings[Name].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            config = null;
        }

        public static string Get(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}
