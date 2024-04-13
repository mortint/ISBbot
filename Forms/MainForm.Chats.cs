using ISP.Engine.Accounts;
using ISP.Objects.Targets;
using ISP.Tasks.Settings;
using System;
using System.Windows.Forms;

namespace ISP.Forms {
    internal partial class MainForm {
        private void LoadChatsFormFromActive() {
            dataGridView_chatsEditable.Rows.Clear();
            dataGridView_chatsView.Rows.Clear();

            dataGridView_chatsEditable.Rows.Add("", "Ничего не делать", "", "Ничего не делать", false);

            foreach (var a in AccountsManager.ActiveAccount.ChatsTaskSettings.Targets) {
                dataGridView_chatsView.Rows.Add(a.Link, a.TitleMode, a.Title, a.AvatarMode, a.FloodWithAvatar);
            }

            DataGridView_chatsView_SelectionChanged(null, null);
        }

        private void DataGridView_chatsView_SelectionChanged(object sender, EventArgs e) {
            int selIndex = dataGridView_chatsView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selIndex == -1)
                return;
            for (int i = 0; i < dataGridView_chatsView.Columns.Count; ++i)
                dataGridView_chatsEditable[i, 0].Value = dataGridView_chatsView[i, selIndex].Value;
        }

        private void Button_chatsAdd_Click(object sender, EventArgs e) {
            dataGridView_chatsView.Rows.Add(dataGridView_chatsEditable[0, 0].Value,
                dataGridView_chatsEditable[1, 0].Value,
                dataGridView_chatsEditable[2, 0].Value,
                dataGridView_chatsEditable[3, 0].Value,
                dataGridView_chatsEditable[4, 0].Value);

            AccountsManager.ApplyToCurrent((a) => a.ChatsTaskSettings.AddNewTarget(new ChatsTarget() {
                Link = (dataGridView_chatsEditable[0, 0].Value ?? "").ToString(),
                TitleMode = dataGridView_chatsEditable[1, 0].Value.ToString(),
                Title = (dataGridView_chatsEditable[2, 0].Value ?? "").ToString(),
                AvatarMode = dataGridView_chatsEditable[3, 0].Value.ToString(),
                FloodWithAvatar = (bool)dataGridView_chatsEditable[4, 0].Value
            }));
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void Button_chatsRemove_Click(object sender, EventArgs e) {
            int selRow = dataGridView_chatsView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selRow == -1)
                return;
            // dataGridView_chatsView.Rows.Remove(dataGridView_chatsView.Rows[selRow]);
            dataGridView_chatsView.Rows.Remove(dataGridView_chatsView.SelectedRows[0]);

            AccountsManager.ApplyToCurrent((a) => a.ChatsTaskSettings.RemoveTarget(new ChatsTarget() {
                Link = (dataGridView_chatsEditable[0, 0].Value ?? "").ToString(),
                TitleMode = dataGridView_chatsEditable[1, 0].Value.ToString(),
                Title = (dataGridView_chatsEditable[2, 0].Value ?? "").ToString(),
                AvatarMode = dataGridView_chatsEditable[3, 0].Value.ToString(),
                FloodWithAvatar = (bool)dataGridView_chatsEditable[4, 0].Value
            }));
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void Button_chatsChange_Click(object sender, EventArgs e) {
            int selIndex = dataGridView_chatsView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selIndex == -1)
                return;
            var from = new ChatsTarget() {
                Link = (dataGridView_chatsView[0, selIndex].Value ?? "").ToString(),
                TitleMode = dataGridView_chatsView[1, selIndex].Value.ToString(),
                Title = (dataGridView_chatsView[2, selIndex].Value ?? "").ToString(),
                AvatarMode = dataGridView_chatsView[3, selIndex].Value.ToString(),
                FloodWithAvatar = (bool)dataGridView_chatsView[4, 0].Value
            };

            for (int i = 0; i < dataGridView_chatsView.Columns.Count; ++i)
                dataGridView_chatsView[i, selIndex].Value = dataGridView_chatsEditable[i, 0].Value;

            var to = new ChatsTarget() {
                Link = (dataGridView_chatsEditable[0, 0].Value ?? "").ToString(),
                TitleMode = dataGridView_chatsEditable[1, 0].Value.ToString(),
                Title = (dataGridView_chatsEditable[2, 0].Value ?? "").ToString(),
                AvatarMode = dataGridView_chatsEditable[3, 0].Value.ToString(),
                FloodWithAvatar = (bool)dataGridView_chatsEditable[4, 0].Value
            };

            AccountsManager.ApplyToCurrent((a) => a.ChatsTaskSettings.ReplaceTarget(from, to));
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }
    }
}
