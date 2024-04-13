using ISP.Configs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ISP.Forms.Dialogs {
    internal sealed partial class TwoFactAsker : Form {
        /// <summary>
        /// Имя аккаунта
        /// </summary>
        public static string AccName = "";

        public TwoFactAsker() {
            InitializeComponent();
            try {
                BackColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorApplications);
            }
            catch {

            }

            Text = "2FA: " + AccName;
            textBox_Code.Focus();
        }

        public string GetCode() {
            return textBox_Code.Text;
        }

        private void button_Ok_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_Skip_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void textBox_Code_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                button_Ok.PerformClick();
        }
    }
}
