using ISP.Configs;
using ISP.Engine.Accounts;
using ISP.Misc;
using ISP.Objects.Targets;
using JCS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ISP.Forms.Dialogs {
    public partial class AutoTargetForm : Form {
        /// <summary>
        /// Объект DataGridView
        /// </summary>
        public DataGridView DataGridView;
        public AutoTargetForm() {
            InitializeComponent();
            BackColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorApplications);
            ForeColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb);

            try {
                SetForeColor(Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb));
            }
            catch { }
        }
        new void KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar))
                return;
            e.Handled = true;
        }
        /// <summary>
        /// Применяет указанный цвет к настройкам интерфейса
        /// </summary>
        /// <param name="col">Цвет, который нужно применить</param>
        public void SetForeColor(Color col) {
            Color colorForSwitches = col.ToArgb() == Color.Black.ToArgb() ? Color.Gray : col;

            var switchRenderer = new ToggleSwitchModernRenderer() {
                LeftSideBackColor1 = colorForSwitches,
                LeftSideBackColor2 = colorForSwitches,
                ArrowNormalColor = colorForSwitches,
                ArrowHoverColor = Color.White,
                ArrowPressedColor = Color.White
            };

            checkBox_appeal.SetRenderer(Cloner.Clone(switchRenderer));

            ConfigController.InterfaceConfig.ForColorAsArgb = col.ToArgb();
            ConfigController.InterfaceConfig.Save();
        }

        private void button_Apply_Click(object sender, EventArgs e) {
            try {
                var from = IsInteger(textBox_From.Text);
                var before = IsInteger(textBox_Before.Text);
                var appeal = DataGridView.CurrentRow.Cells[2].Value.ToString();

                AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.ClearTarget());
                DataGridView.Rows.Clear();

                for (int i = from; i <= before; i++) {
                    if (checkBox_appeal.Checked) {
                        DataGridView.Rows.Add($"im?sel=c{i}", comboBox_LocAppeal.Text, appeal, comboBox_Content.Text);
                        AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.AddNewTarget(new FlooderTarget() {
                            Link = $"im?sel=c{i}",
                            NamePlace = comboBox_LocAppeal.Text,
                            Name = appeal,
                            Contains = comboBox_Content.Text
                        }));
                    }
                    else {
                        DataGridView.Rows.Add($"im?sel=c{i}", "Начало", "", "Текст");
                        AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.AddNewTarget(new FlooderTarget() {
                            Link = $"im?sel=c{i}",
                            NamePlace = comboBox_LocAppeal.Text,
                            Name = appeal,
                            Contains = comboBox_Content.Text
                        }));
                    }
                }

                AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
            }
            catch {

            }
        }

        int IsInteger(string value) {
            var result = 0;
            return int.TryParse(value, out result) ? result > 0 ? result : 0 : 0;
        }
    }
}
