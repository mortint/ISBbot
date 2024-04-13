using ISP.Configs;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ISP.Forms {
    internal sealed partial class DesignForm : CenteredForm {
        public static MainForm FormMainForm;

        public DesignForm() {
            InitializeComponent();
            ForeColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb);
            BackColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorApplications);
            textBox_general.Text = ConfigController.InterfaceConfig.PathToBackgroundImgGeneral;
            textBox_tabs.Text = ConfigController.InterfaceConfig.PathToBackgroundImgTabs;
            pictureBox.BackColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb);
            pictureBox_ColorApp.BackColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorApplications);
        }

        private void button_fileFind_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            FormMainForm.SetBackPicture(openFileDialog.FileName);
            textBox_general.Text = openFileDialog.FileName;
        }

        private void button_fileFindTabs_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            FormMainForm.SetTabsBackPicture(openFileDialog.FileName);
            textBox_tabs.Text = openFileDialog.FileName;
        }

        private void button_selectColor_Click(object sender, EventArgs e) {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;
            FormMainForm.SetForeColor(colorDialog.Color);
            pictureBox.BackColor = colorDialog.Color;
        }

        private void button_resetImgGeneral_Click(object sender, EventArgs e) {
            FormMainForm.SetBackPicture(null);
            textBox_general.Text = "";
        }

        private void button_resetImgTabs_Click(object sender, EventArgs e) {
            FormMainForm.SetTabsBackPicture(null);
            textBox_tabs.Text = "";
        }

        private void button_resetColor_Click(object sender, EventArgs e) {
            FormMainForm.SetForeColor(Color.Black);
            pictureBox.BackColor = Color.Black;
        }

        private void button_selecColorApp_Click(object sender, EventArgs e) {
            if (colorDialog.ShowDialog() != DialogResult.OK)
                return;
            FormMainForm.SetApplicationColor(colorDialog.Color);
            pictureBox_ColorApp.BackColor = colorDialog.Color;
            BackColor = colorDialog.Color;
        }

        private void button_resetColorApp_Click(object sender, EventArgs e) {
            FormMainForm.SetApplicationColor(Color.FromArgb(100, 100, 100));
            pictureBox_ColorApp.BackColor = Color.FromArgb(100, 100, 100);
            BackColor = Color.FromArgb(100, 100, 100);
        }
    }
}
