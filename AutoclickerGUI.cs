using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Input;
using System.Text.RegularExpressions;


namespace ArcticAutoclicker
{
    public partial class AutoclickerGUI : MetroForm
    {
        
        struct Version
        {
            public int major;
            public int minor;

            public Version(int major, int minor)
            {
                this.major = major;
                this.minor = minor;
            }
        }

        bool choosingKeybind = false;
        Keys currentKeybind = Keys.F6;
        KeysConverter keyConverter = new KeysConverter();

        Version v = new Version(1,3);


        bool _active;
        bool active { 
            get
            {
                return _active;
            }
            set
            {
                _active = value;
                onBtn.Enabled = !_active;
                offBtn.Enabled = _active;

                if (_active)
                {
                    clickerT = new Thread(AutoclickerThread);
                    clickerT.Start();
                }
                else
                {
                    if (clickerT != null)
                    {
                        clickerT.Abort();
                        clickerT = null;
                    }
                }
            }
        }
        int intervalTime = 100;
        bool _darkTheme = false;
        bool darkTheme
        {
            get
            {
                return _darkTheme;
            }
            set
            {
                _darkTheme = value;
                foreach (MetroFramework.Interfaces.IMetroStyledComponent i in Controls)
                {
                    i.InternalStyleManager.Theme = _darkTheme ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
                }
                Theme = _darkTheme ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
            }
        }

        void AutoclickerThread()
        {
            while (active)
            {
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
                MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
                Thread.Sleep(intervalTime);
            }
        }
        bool pressed = false;
        void KeybindThread()
        {
            while (true)
            {
                if (Keyboard.IsKeyDown(currentKeybind))
                {
                    if (!(pressed || choosingKeybind))
                    {
                        active = !active;
                        pressed = true;
                    }
                }
                else
                {
                    pressed = false;
                }
                Thread.Sleep(5);
            }
        }

        Thread clickerT;
        Thread keybindT;

        RegistryConfig.Settings settings;

        public AutoclickerGUI()
        {
            InitializeComponent();
            keybindT = new Thread(KeybindThread);

            
            keybindT.Start();

            settings = RegistryConfig.GetSettings();
            intervalTime = settings.interval;
            currentKeybind = (Keys)settings.keybind;

            interval.Text = intervalTime.ToString();
            keybind.Text = keyConverter.ConvertToString(currentKeybind);

            VersionText.Text = $"V{v.major}.{v.minor}";
        }

        private void AutoclickerGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clickerT != null)
            {
                clickerT.Abort();
            }
            keybindT.Abort();


            settings.interval = intervalTime;
            settings.keybind = (int)currentKeybind;
            settings.darkMode = darkTheme;

            RegistryConfig.SaveSettings(settings);
        }

        private void onBtn_Click(object sender, EventArgs e)
        {
            active = true;
        }

        private void offBtn_Click(object sender, EventArgs e)
        {
            active = false;
        }

        private void interval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void keybind_KeyDown(object sender, KeyEventArgs e)
        {
            if (!choosingKeybind)
                e.Handled = true;

            pressed = true;
            keybind.Text = keyConverter.ConvertToString(e.KeyCode);
            choosingKeybind = false;
            currentKeybind = e.KeyCode;
            e.Handled = true;

            onBtn.Focus();
        }

        private void keybind_Click(object sender, EventArgs e)
        {
            keybind.Text = "...";
            choosingKeybind = true;
        }

        private void keybind_Leave(object sender, EventArgs e)
        {
            choosingKeybind = false;
            keybind.Text = keyConverter.ConvertToString(currentKeybind);
        }

        private void keybind_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void interval_Validated(object sender, EventArgs e)
        {
            intervalTime = int.Parse(interval.Text);
        }

        

        private void lightDarkSwitch_CheckedChanged(object sender, EventArgs e)
        {
            darkTheme = lightDarkSwitch.Checked;
        }

        private void AutoclickerGUI_Shown(object sender, EventArgs e)
        {
            darkTheme = settings.darkMode;
            lightDarkSwitch.Checked = darkTheme;

            foreach (MetroFramework.Interfaces.IMetroStyledComponent i in Controls)
            {
                i.InternalStyleManager.Style = Style;
            }

            Tooltips.SetToolTip(keybind, "Click to change keybind");
            Tooltips.SetToolTip(lightDarkSwitch, "Toggle between light and dark themes");
        }
    }
}
