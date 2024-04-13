using ISP.Engine.Accounts;
using ISP.Objects.Targets;
using ISP.Tasks.Settings;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ISP.Forms {
    internal partial class MainForm {
        private void LoadFlooderFormFromActive() {
            dataGridView_flooderEditable.Rows.Clear();
            dataGridView_flooderView.Rows.Clear();

            dataGridView_flooderEditable.Rows.Add("", "Начало", "", "Текст");

            foreach (var a in AccountsManager.ActiveAccount.FlooderTaskSettings.Targets) {
                dataGridView_flooderView.Rows.Add(a.Link, a.NamePlace, a.Name, a.Contains);
            }

            comboBox_flooderPhrasesSource.Text = AccountsManager.ActiveAccount.FlooderTaskSettings.PhrasesFile;
            comboBox_flooderPhrasesWithDotsSource.Text = AccountsManager.ActiveAccount.FlooderTaskSettings.PhrasesWithDotsFile;
            comboBox_flooderPictureSource.SelectedIndex = AccountsManager.ActiveAccount.FlooderTaskSettings.ImagesFromFolder ? 1 : 0;
            comboBox_flooderStickerFile.Text = AccountsManager.ActiveAccount.FlooderTaskSettings.StickersFile;
            selectionDelay.Text = AccountsManager.ActiveAccount.FlooderTaskSettings.SelectionDelay;
            if (!string.IsNullOrEmpty(comboBox_flooderStickerFile.Text)) {
                comboBox_flooderStickerId.Items.Clear();
                comboBox_flooderStickerId.Items.Add("По порядку");
                comboBox_flooderStickerId.Items.AddRange(File.ReadAllLines($"Txts\\Stickers\\{comboBox_flooderStickerFile.Text}",
                    Encoding.GetEncoding("windows-1251")));
            }
            comboBox_flooderStickerId.Text = AccountsManager.ActiveAccount.FlooderTaskSettings.StickerId;

            DataGridView_flooderView_SelectionChanged(null, null);
        }
        private void SelectionDelay_SelectedIndexChanged(object sender, EventArgs e) {
            if (selectionDelay.SelectedIndex == 0)
                numericUpDown_flooderDelayMax.Enabled = false;
            if (selectionDelay.SelectedIndex == 1)
                numericUpDown_flooderDelayMax.Enabled = true;
            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.SelectionDelay = selectionDelay.Text);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void ComboBox_flooderPictureSource_SelectedIndexChanged(object sender, EventArgs e) {
            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.ImagesFromFolder = comboBox_flooderPictureSource.SelectedIndex == 1);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void ComboBox_flooderPhrasesSource_SelectedIndexChanged(object sender, EventArgs e) {
            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.PhrasesFile = comboBox_flooderPhrasesSource.Text);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void ComboBox_flooderPhrasesWithDotsSource_SelectedIndexChanged(object sender, EventArgs e) {
            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.PhrasesWithDotsFile = comboBox_flooderPhrasesWithDotsSource.Text);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void Button_flooderAdd_Click(object sender, EventArgs e) {
            dataGridView_flooderView.Rows.Add(dataGridView_flooderEditable[0, 0].Value,
                dataGridView_flooderEditable[1, 0].Value,
                dataGridView_flooderEditable[2, 0].Value,
                dataGridView_flooderEditable[3, 0].Value);

            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.AddNewTarget(new FlooderTarget() {
                Link = (dataGridView_flooderEditable[0, 0].Value ?? "").ToString(),
                NamePlace = dataGridView_flooderEditable[1, 0].Value.ToString(),
                Name = (dataGridView_flooderEditable[2, 0].Value ?? "").ToString(),
                Contains = dataGridView_flooderEditable[3, 0].Value.ToString()
            }));
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void Button_flooderRemove_Click(object sender, EventArgs e) {
            int selRow = dataGridView_flooderView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selRow == -1)
                return;
            // dataGridView_flooderView.Rows.Remove(dataGridView_flooderView.Rows[selRow]);
            dataGridView_flooderView.Rows.Remove(dataGridView_flooderView.SelectedRows[0]);

            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.RemoveTarget(new FlooderTarget() {
                Link = (dataGridView_flooderEditable[0, 0].Value ?? "").ToString(),
                NamePlace = dataGridView_flooderEditable[1, 0].Value.ToString(),
                Name = (dataGridView_flooderEditable[2, 0].Value ?? "").ToString(),
                Contains = dataGridView_flooderEditable[3, 0].Value.ToString()
            }));
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void Button_flooderChange_Click(object sender, EventArgs e) {
            int selIndex = dataGridView_flooderView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selIndex == -1)
                return;
            var from = new FlooderTarget() {
                Link = (dataGridView_flooderView[0, selIndex].Value ?? "").ToString(),
                NamePlace = dataGridView_flooderView[1, selIndex].Value.ToString(),
                Name = (dataGridView_flooderView[2, selIndex].Value ?? "").ToString(),
                Contains = dataGridView_flooderView[3, selIndex].Value.ToString()
            };

            for (int i = 0; i < dataGridView_flooderView.Columns.Count; ++i)
                dataGridView_flooderView[i, selIndex].Value = dataGridView_flooderEditable[i, 0].Value;

            var to = new FlooderTarget() {
                Link = (dataGridView_flooderEditable[0, 0].Value ?? "").ToString(),
                NamePlace = dataGridView_flooderEditable[1, 0].Value.ToString(),
                Name = (dataGridView_flooderEditable[2, 0].Value ?? "").ToString(),
                Contains = dataGridView_flooderEditable[3, 0].Value.ToString()
            };

            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.ReplaceTarget(from, to));
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }
        private void DataGridView_flooderView_SelectionChanged(object sender, EventArgs e) {
            int selIndex = dataGridView_flooderView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selIndex == -1)
                return;
            for (int i = 0; i < dataGridView_flooderView.Columns.Count; ++i)
                dataGridView_flooderEditable[i, 0].Value = dataGridView_flooderView[i, selIndex].Value;
        }
        private void ComboBox_flooderStickerFile_SelectedIndexChanged(object sender, EventArgs e) {
            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.StickersFile = comboBox_flooderStickerFile.Text);
            comboBox_flooderStickerId.Items.Clear();
            if (!string.IsNullOrEmpty(comboBox_flooderStickerFile.Text)) {
                comboBox_flooderStickerId.Text = "";
                comboBox_flooderStickerId.Items.Add("По порядку");
                comboBox_flooderStickerId.Items.AddRange(File.ReadAllLines($"Txts\\Stickers\\{comboBox_flooderStickerFile.Text}", Encoding.GetEncoding("windows-1251")));
            }
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void ComboBox_flooderStickerId_SelectedIndexChanged(object sender, EventArgs e) {
            AccountsManager.ApplyToCurrent((a) => a.FlooderTaskSettings.StickerId = comboBox_flooderStickerId.Text);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }
    }
}
