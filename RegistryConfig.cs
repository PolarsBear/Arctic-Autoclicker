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

        public static RegistryKey CreateIfDoesntExist()
        {
            if (Registry.CurrentUser.OpenSubKey(@"SOFTWARE\M4RQU1NH05") == null)
            {
                return Registry.CurrentUser.CreateSubKey(@"SOFTWARE\M4RQU1NH05");
            }
            else
            {
                return Registry.CurrentUser.OpenSubKey(@"SOFTWARE\M4RQU1NH05", true);
            }
        }

        public static Settings GetSettings()
        {
            if (Registry.CurrentUser.OpenSubKey(@"SOFTWARE\M4RQU1NH05") != null)
            {
                return new Settings(Registry.CurrentUser.OpenSubKey(@"SOFTWARE\M4RQU1NH05"));
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
