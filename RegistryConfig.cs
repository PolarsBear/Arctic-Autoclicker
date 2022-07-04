using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcticAutoclicker
{
    class RegistryConfig
    {
        public struct Settings
        {
            public int interval;
            public int keybind;
            public bool darkMode;

            public Settings(RegistryKey key)
            {
                interval = (int)key.GetValue("Interval", 100);
                keybind = (int)key.GetValue("Keybind", (int)Keys.F6);
                darkMode = bool.Parse((string)key.GetValue("DarkMode", "False"));
            }

            public Settings(bool d)
            {
                interval = 100;
                keybind = (int)Keys.F6;
                darkMode = false;
            }
        }

        public static string path = @"SOFTWARE\PolarsBear\ArcticAutoclicker";

        public static RegistryKey CreateIfDoesntExist()
        {
            if (Registry.CurrentUser.OpenSubKey(path) == null)
            {
                return Registry.CurrentUser.CreateSubKey(path);
            }
            else
            {
                return Registry.CurrentUser.OpenSubKey(path, true);
            }
        }

        public static Settings GetSettings()
        {
            if (Registry.CurrentUser.OpenSubKey(path) != null)
            {
                return new Settings(Registry.CurrentUser.OpenSubKey(path));
            }

            return new Settings(true);
        }

        public static void SaveSettings(Settings settings)
        {
            RegistryKey key = CreateIfDoesntExist();

            key.SetValue("Interval", settings.interval);
            key.SetValue("Keybind", settings.keybind);
            key.SetValue("DarkMode", settings.darkMode);
        }
    }
}
