using ISP.Configs;
using ISP.Engine.Network;
using System.Drawing;

namespace ISP.Forms {
    internal sealed partial class AnticapSettingsForm : CenteredForm {
        public AnticapSettingsForm() {
            InitializeComponent();
            BackColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorApplications);
            ForeColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb);
            textBox_rucapKey.Text = ConfigController.AnticapConfig.RucaptchaKey;
            textBox_anticapKey.Text = ConfigController.AnticapConfig.AnticaptchaKey;
            textBox_keyISbgpt.Text = ConfigController.AnticapConfig.ISBGptKey;
        }

        private void textBox_rucapKey_TextChanged(object sender, System.EventArgs e) {
            ConfigController.AnticapConfig.RucaptchaKey = textBox_rucapKey.Text;
            ConfigController.AnticapConfig.Save();
        }

        private void textBox_anticapKey_TextChanged(object sender, System.EventArgs e) {
            ConfigController.AnticapConfig.AnticaptchaKey = textBox_anticapKey.Text;
            ConfigController.AnticapConfig.Save();
        }

        private void button_rucaptchaBalance_Click(object sender, System.EventArgs e) {
            button_rucaptchaBalance.Text = Network.GET($"https://rucaptcha.com/res.php?key={textBox_rucapKey.Text}&action=getbalance") + "₽";
        }

        private void button_anticaptchaBalance_Click(object sender, System.EventArgs e) {
            button_anticaptchaBalance.Text = Network.GET($"https://anti-captcha.com/res.php?key={textBox_anticapKey.Text}&action=getbalance") + "₽";
        }

        private void textBox_keyISbgpt_TextChanged(object sender, System.EventArgs e) {
            ConfigController.AnticapConfig.ISBGptKey = textBox_keyISbgpt.Text;
            ConfigController.AnticapConfig.Save();
        }

        private void button_getBalanceISBgpt_Click(object sender, System.EventArgs e) {
            if (string.IsNullOrEmpty(textBox_keyISbgpt.Text))
                return;

            button_getBalanceISBgpt.Text = "99999999₽";
        }
    }
}
