using System.Windows.Forms;
using MetroFramework.Forms;

namespace ArcticAutoclicker
{
    partial class AutoclickerGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoclickerGUI));
            this.onBtn = new MetroFramework.Controls.MetroButton();
            this.offBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.interval = new MetroFramework.Controls.MetroTextBox();
            this.keybind = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lightDarkSwitch = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.VersionText = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // onBtn
            // 
            this.onBtn.Location = new System.Drawing.Point(12, 306);
            this.onBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.onBtn.Name = "onBtn";
            this.onBtn.Size = new System.Drawing.Size(92, 50);
            this.onBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.onBtn.TabIndex = 1;
            this.onBtn.Text = "Ligar";
            this.onBtn.Click += new System.EventHandler(this.onBtn_Click);
            // 
            // offBtn
            // 
            this.offBtn.Enabled = false;
            this.offBtn.Location = new System.Drawing.Point(110, 306);
            this.offBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.offBtn.Name = "offBtn";
            this.offBtn.Size = new System.Drawing.Size(92, 50);
            this.offBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.offBtn.TabIndex = 2;
            this.offBtn.Text = "Desligar";
            this.offBtn.Click += new System.EventHandler(this.offBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Intervalo (ms)";
            this.metroLabel1.UseStyleColors = true;
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(24, 106);
            this.interval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(88, 22);
            this.interval.Style = MetroFramework.MetroColorStyle.Blue;
            this.interval.TabIndex = 5;
            this.interval.Text = "100";
            this.interval.UseStyleColors = true;
            this.interval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.interval_KeyPress);
            this.interval.Validated += new System.EventHandler(this.interval_Validated);
            // 
            // keybind
            // 
            this.keybind.Location = new System.Drawing.Point(24, 167);
            this.keybind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keybind.Name = "keybind";
            this.keybind.Size = new System.Drawing.Size(50, 22);
            this.keybind.Style = MetroFramework.MetroColorStyle.Blue;
            this.keybind.TabIndex = 7;
            this.keybind.Text = "F6";
            this.keybind.UseStyleColors = true;
            this.keybind.Click += new System.EventHandler(this.keybind_Click);
            this.keybind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keybind_KeyDown);
            this.keybind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keybind_KeyPress);
            this.keybind.Leave += new System.EventHandler(this.keybind_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Hotkey";
            this.metroLabel2.UseStyleColors = true;
            // 
            // lightDarkSwitch
            // 
            this.lightDarkSwitch.AutoSize = true;
            this.lightDarkSwitch.DisplayStatus = false;
            this.lightDarkSwitch.Location = new System.Drawing.Point(220, 329);
            this.lightDarkSwitch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lightDarkSwitch.Name = "lightDarkSwitch";
            this.lightDarkSwitch.Size = new System.Drawing.Size(50, 17);
            this.lightDarkSwitch.Style = MetroFramework.MetroColorStyle.Blue;
            this.lightDarkSwitch.TabIndex = 8;
            this.lightDarkSwitch.Text = "Off";
            this.lightDarkSwitch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lightDarkSwitch.UseStyleColors = true;
            this.lightDarkSwitch.UseVisualStyleBackColor = true;
            this.lightDarkSwitch.CheckedChanged += new System.EventHandler(this.lightDarkSwitch_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(212, 306);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Light/Dark";
            this.metroLabel3.UseStyleColors = true;
            // 
            // VersionText
            // 
            this.VersionText.AutoSize = true;
            this.VersionText.Location = new System.Drawing.Point(212, 50);
            this.VersionText.Name = "VersionText";
            this.VersionText.Size = new System.Drawing.Size(32, 19);
            this.VersionText.TabIndex = 10;
            this.VersionText.Text = "V1.2";
            // 
            // AutoclickerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 370);
            this.Controls.Add(this.VersionText);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lightDarkSwitch);
            this.Controls.Add(this.keybind);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.offBtn);
            this.Controls.Add(this.onBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AutoclickerGUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "   Arctic Autoclicker";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoclickerGUI_FormClosing);
            this.Shown += new System.EventHandler(this.AutoclickerGUI_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton onBtn;
        private MetroFramework.Controls.MetroButton offBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox interval;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox keybind;
        private MetroFramework.Controls.MetroToggle lightDarkSwitch;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel VersionText;
    }
}

