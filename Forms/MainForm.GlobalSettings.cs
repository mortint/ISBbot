using ISP.Engine.Accounts;
using System;
using System.IO;
using System.Text;

namespace ISP.Forms {
    internal partial class MainForm {
        private void LoadGlobalSettingsFormFromActive() {
            checkBox_flooderEnabled.Checked = AccountsManager.ActiveAccount.FlooderTaskSettings.Enabled;

            checkBox_chatsEnabled.Checked = AccountsManager.ActiveAccount.ChatsTaskSettings.Enabled;

            checkBox_inviterEnabled.Checked = AccountsManager.ActiveAccount.InviteTaskSettings.Enabled;
            checkBox_autoansEnabled.Checked = AccountsManager.ActiveAccount.AutoansTaskSettings.Enabled;

            numericUpDown_flooderDelay.Value = AccountsManager.ActiveAccount.FlooderTaskSettings.Delay;

            numericUpDown_chatsDelay.Value = AccountsManager.ActiveAccount.ChatsTaskSettings.Delay;

            numericUpDown_inviterDelay.Value = AccountsManager.ActiveAccount.InviteTaskSettings.Delay;
            numericUpDown_flooderDelayMax.Value = AccountsManager.ActiveAccount.FlooderTaskSettings.DelayMax;
            numericUpDown_autoansDelay.Value = AccountsManager.ActiveAccount.AutoansTaskSettings.Delay;
        }


        private void LoadAutoansFormFromActive() {
            dataGridView_autoansEditable.Rows.Clear();
            dataGridView_autoansView.Rows.Clear();

            dataGridView_autoansEditable.Rows.Add("", "Начало", "", "Текст");


            foreach (var a in AccountsManager.ActiveAccount.AutoansTaskSettings.Targets) {
                dataGridView_autoansView.Rows.Add(a.Link, a.NamePlace, a.Name, a.Contains);
            }

            comboBox_autoansPhrasesSource.Text = AccountsManager.ActiveAccount.AutoansTaskSettings.PhrasesFile;

            comboBox_autoansStickerFile.Text = AccountsManager.ActiveAccount.AutoansTaskSettings.StickersFile;

            if (!string.IsNullOrEmpty(comboBox_autoansStickerFile.Text)) {
                comboBox_autoansStickerId.Items.Clear();
                comboBox_autoansStickerId.Items.Add("По порядку");
                comboBox_autoansStickerId.Items.AddRange(File.ReadAllLines($"Txts\\Stickers\\{comboBox_autoansStickerFile.Text}",
                    Encoding.GetEncoding("windows-1251")));
            }
            comboBox_autoansStickerId.Text = AccountsManager.ActiveAccount.AutoansTaskSettings.StickerId;


            dataGridView_autoansView_SelectionChanged(null, null);
        }

        private void CheckBox_flooderEnabled_CheckedChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.Enabled = checkBox_flooderEnabled.Checked);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void CheckBox_autoansEnabled_CheckedChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.AutoansTaskSettings.Enabled = checkBox_autoansEnabled.Checked);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }
        private void NumericUpDown_flooderDelayMax_ValueChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.DelayMax = (int)numericUpDown_flooderDelayMax.Value);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }
        private void CheckBox_chatsEnabled_CheckedChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.ChatsTaskSettings.Enabled = checkBox_chatsEnabled.Checked);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void CheckBox_antikickEnabled_CheckedChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.InviteTaskSettings.Enabled = checkBox_inviterEnabled.Checked);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void CheckBox_remoteEnabled_CheckedChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
        }

        private void NumericUpDown_flooderDelay_ValueChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.Delay = (int)numericUpDown_flooderDelay.Value);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void NumericUpDown_autoansDelay_ValueChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.AutoansTaskSettings.Delay = (int)numericUpDown_autoansDelay.Value);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void NumericUpDown_chatsDelay_ValueChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.ChatsTaskSettings.Delay = (int)numericUpDown_chatsDelay.Value);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void NumericUpDown_smartautoDelay_ValueChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
        }

        private void NumericUpDown_antikickDelay_ValueChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.InviteTaskSettings.Delay = (int)numericUpDown_inviterDelay.Value);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void NumericUpDown_remoteDelay_ValueChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
        }

        private void Button_resetSettings_Click(object sender, EventArgs e) {
            LogForm.PushToLog("sdfsfd");
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.ResetSettings());
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
            ComboBox_accountsList_SelectedIndexChanged(null, null);
        }
    }
}
