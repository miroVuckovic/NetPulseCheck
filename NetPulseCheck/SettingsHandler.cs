using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPulseCheck
{
    public class SettingsHandler
    {

        public SettingsHandler()
        {
        }

        public void SaveSetting(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }

            try
            {
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show("Error writing app settings\n\n" + ex.Message,Application.ProductName +" - Error");
            }
        }

        public string ReadSetting(string key)
        {
            string result = string.Empty;

            var appSettings = ConfigurationManager.AppSettings;

            try
            {            
                result = appSettings[key];
            }
            catch (ConfigurationErrorsException)
            {
                result = "false";
            }

            return result;
        }
    }
}
