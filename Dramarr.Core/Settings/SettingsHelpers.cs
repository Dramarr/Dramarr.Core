using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Dramarr.Core.Settings
{
    public class SettingsHelpers
    {
        #region Properties

        public string Filename { get; set; }
        private Dictionary<string, string> _settings
        {
            get
            {
                if (Settings == null)
                {
                    Settings = LoadSettings();
                }

                return Settings;
            }
        }

        #endregion

        #region Constructors
        public SettingsHelpers(string filename)
        {
            Filename = filename;
        }

        public SettingsHelpers()
        {
        }

        #endregion

        #region Private methods

        private static Dictionary<string, string> Settings = new Dictionary<string, string>();

        private Dictionary<string, string> LoadSettings()
        {
            using (StreamReader reader = new StreamReader(this.Filename ??= "settings.json"))
            {
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Gets settings
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public string GetSetting(string key, string defaultValue = null)
        {
            try
            {
                return _settings[key];
            }
            catch (Exception)
            {
                return defaultValue;
            }

        }

        #endregion
    }
}
