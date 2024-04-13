using ISP.Configs;
using ISP.Engine.Accounts;
using ISP.Misc;
using JCS;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ISP.Forms {
    internal partial class LogForm : CenteredForm {
        private static readonly LinkedList<string> Logs = new LinkedList<string>();
        public LogForm() {
            InitializeComponent();

            ForeColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb);
            BackColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorApplications);

            try {
                SetForeColor(Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb));
                checkBox_EnabledLogger.Checked = ConfigController.LoggerConfig.Enabled;

                LogUpdater_Tick(null, null);
            }
            catch {

            }
        }
        public void SetForeColor(Color col) {
            Color colorForSwitches = col.ToArgb() == Color.Black.ToArgb() ? Color.Gray : col;

            ToggleSwitchModernRenderer switchRenderer = new ToggleSwitchModernRenderer() {
                LeftSideBackColor1 = colorForSwitches,
                LeftSideBackColor2 = colorForSwitches,
                ArrowNormalColor = colorForSwitches,
                ArrowHoverColor = Color.White,
                ArrowPressedColor = Color.White
            };

            checkBox_EnabledLogger.SetRenderer(Cloner.Clone(switchRenderer));

            ConfigController.InterfaceConfig.ForColorAsArgb = col.ToArgb();
            ConfigController.InterfaceConfig.Save();
        }
        public static void PushToLog(string info) {
            PushToLog(null, info);
        }
        public static void PushToLog(Account acc, string info) {
            lock (Logs) {
                string from = "";
                if (acc != null)
                    from = " " + acc.Login;
                Logs.AddFirst($"[{DateTime.Now.ToShortTimeString()}{from}]: {info}");
            }
        }

        private void LogUpdater_Tick(object sender, EventArgs e) {
            if (ConfigController.LoggerConfig.Enabled)
                return;

            lock (Logs) {
                richTextBox_log.Clear();
                foreach (string entry in Logs) {
                    richTextBox_log.Text += entry + "\n";
                }

                if (Logs.Count > 100)
                    Logs.RemoveLast();
            }
        }

        private void checkBox_EnabledLogger_CheckedChanged(object sender, EventArgs e) {
            ConfigController.LoggerConfig.Enabled = checkBox_EnabledLogger.Checked;
            ConfigController.LoggerConfig.Save();

            Logs.Clear();
            richTextBox_log.Clear();
        }
    }
}
