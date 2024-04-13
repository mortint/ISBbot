using ISP.Engine.Accounts;
using ISP.Tasks;
using System;

namespace ISP.Forms {
    internal partial class MainForm {
        private void LoadVoiceFormFromActive() {
            comboBox_voiceVO.Text = AccountsManager.ActiveAccount.VoiceTaskSettings.Voice;
            comboBox_emotionVO.Text = AccountsManager.ActiveAccount.VoiceTaskSettings.Emotion;
            numericUpDown_speedVO.Value = AccountsManager.ActiveAccount.VoiceTaskSettings.Speed;
            textBox_yandexKeyVO.Text = AccountsManager.ActiveAccount.VoiceTaskSettings.Yandexapi;
            checkBox_enabledToCustomAudio.Checked = AccountsManager.ActiveAccount.VoiceTaskSettings.SendCustomAudio;
        }

        private void ComboBox_voiceVO_SelectedIndexChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.VoiceTaskSettings.Voice = comboBox_voiceVO.Items[comboBox_voiceVO.SelectedIndex].ToString());
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void ComboBox_emotionVO_SelectedIndexChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.VoiceTaskSettings.Emotion = comboBox_emotionVO.Items[comboBox_emotionVO.SelectedIndex].ToString());
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void NumericUpDown_speedVO_ValueChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.VoiceTaskSettings.Speed = (int)numericUpDown_speedVO.Value);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void TextBox_yandexKeyVO_TextChanged(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.VoiceTaskSettings.Yandexapi = textBox_yandexKeyVO.Text);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void Button_sendVO_Click(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            AccountsManager.ApplyToCurrent((a) => a.VoiceTaskSettings.Message = richTextBox_messageVO.Text);
            AccountsManager.ApplyToCurrent((a) => a.VoiceTaskSettings.Target = textBox_targetVO.Text);
            AccountsManager.ApplyToCurrent((a) => new VoiceTask().LaunchTask(a));
        }
    }
}
