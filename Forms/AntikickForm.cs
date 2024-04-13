using ISP.Configs;
using ISP.Engine.Accounts;
using ISP.Engine.Helpers;
using ISP.Enums.Parser;
using ISP.Misc;
using ISP.Objects.Targets;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISP.Forms {
    internal sealed partial class AntikickForm : CenteredForm {
        /// <summary>
        /// Объект таймера
        /// </summary>
        private static SingleSimrunTimer _periodicTimer;

        public AntikickForm() {
            InitializeComponent();
            BackColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorApplications);
            ForeColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb);
            MaximizeBox = false;
        }
        /// <summary>
        /// Обработка чатов
        /// </summary>
        private static void ProcessChat(AntikickTarget at) {
            if (at.Accounts.Count == 0)
                return;

            if (at.IndexOfActiveAcc >= at.Accounts.Count)
                at.IndexOfActiveAcc = 0;
            Account acc = AccountsManager.GetAccount(at.Accounts[at.IndexOfActiveAcc].Name);

            long? chatId;
            {
                TargetData searchResult = LinkParser.Parse(acc, "chatname=" + at.Name);
                if (searchResult.Type == TypeOfTarget.Chat)
                    chatId = searchResult.Id1;
                else
                    return;
            }

            TargetData GetChatId(Account currAcc, AntikickAccountData aad) {
                if (aad.ChatId != null)
                    return new TargetData(TypeOfTarget.Chat, aad.ChatId.ToString(), "0");
                return LinkParser.Parse(currAcc, "chatname=" + at.Name);
            }

            List<long> idsToRejoin = (from account in at.Accounts
                                      let currAcc = AccountsManager.GetAccount(account.Name)
                                      where currAcc != acc
                                      let searchResult = GetChatId(currAcc, account)
                                      where searchResult.Type == TypeOfTarget.Chat
                                            && currAcc.VkApi.Messages.GetChat((long)searchResult.Id1).Kicked
                                      select currAcc.Myself.Id).ToList();

            if (idsToRejoin.Count > 0 && at.WhenToRejoin == null) {
                at.WhenToRejoin = DateTime.Now + new TimeSpan(0, 0, 0, 0, ConfigController.AntikickConfig.PartialRejoinDelay);
            }

            if (idsToRejoin.Count == at.Accounts.Count - 1 || (at.WhenToRejoin != null && at.WhenToRejoin <= DateTime.Now)) {
                at.WhenToRejoin = null;
                var requestBody = idsToRejoin.Aggregate("", (current, kicked) => 
                        current + $"API.messages.addChatUser({{\"chat_id\":{chatId},\"user_id\":{kicked}}}),");

                if (ConfigController.AntikickConfig.LeavedIntentionallyFrom.ContainsKey(acc.Login))
                    ConfigController.AntikickConfig.LeavedIntentionallyFrom[acc.Login].Remove((ulong)chatId);
                requestBody = $"return [API.messages.addChatUser({{\"chat_id\":{chatId},\"user_id\":{acc.Myself.Id}}})," + requestBody;
                requestBody += "];";
                var response = acc.VkApi.Execute.Execute(requestBody);

                if (at.Accounts.Count == 0)
                    return;

                at.IndexOfActiveAcc = (at.IndexOfActiveAcc + 1) % at.Accounts.Count;

                acc = AccountsManager.GetAccount(at.Accounts[at.IndexOfActiveAcc].Name);
            }

            try {
                ulong leavingChatId = (ulong)LinkParser.Parse(acc, "chatname=" + at.Name).Id1;
                acc.VkApi.Messages.RemoveChatUser(leavingChatId, acc.Myself.Id);
                if (!ConfigController.AntikickConfig.LeavedIntentionallyFrom.ContainsKey(acc.Login))
                    ConfigController.AntikickConfig.LeavedIntentionallyFrom.TryAdd(acc.Login, new List<ulong>());
                ConfigController.AntikickConfig.LeavedIntentionallyFrom[acc.Login].Add(leavingChatId);
            }
            catch {
            }
        }

        private static void AsyncWorker() {
            var akc = ConfigController.AntikickConfig;
            var targets = akc.Targets;

            int targetIter = -1;

            void DoAntikick() {
                lock (targets) {
                    targetIter = (targetIter + 1) % targets.Count;
                    try {
                        AntikickTarget atg = targets[targetIter];
                        ProcessChat(atg);
                    }
                    catch (Exception ex) {
                        LogForm.PushToLog("[Антикик]: " + ex.Message);
                    }
                }
            }

            _periodicTimer = new SingleSimrunTimer(DoAntikick, akc.Delay);
        }

        private void ListBox_chatsList_SelectedIndexChanged(object sender, EventArgs e) {
            int selIndex = listBox_chatsList.SelectedIndex;
            if (selIndex == -1)
                return;

            dataGridView_accountsToDefendInChat.Rows.Clear();

            textBox_chatName.Text = listBox_chatsList.Items[selIndex].ToString();

            dataGridView_accountsToDefendInChat.Tag = ConfigController.AntikickConfig.Targets[selIndex].Accounts;

            foreach (var a in ConfigController.AntikickConfig.Targets[selIndex].Accounts) {
                dataGridView_accountsToDefendInChat.Rows.Add(a.Name, a.ChatId);
            }
        }

        private void Button_addChatName_Click(object sender, EventArgs e) {
            if (!ConfigController.AntikickConfig.AddNewTarget(new AntikickTarget(textBox_chatName.Text)))
                return;
            listBox_chatsList.Items.Add(textBox_chatName.Text);
            listBox_chatsList.SelectedIndex = listBox_chatsList.Items.Count - 1;
            ConfigController.AntikickConfig.Save();
        }

        private void Button_changeChatName_Click(object sender, EventArgs e) {
            int selIndex = listBox_chatsList.SelectedIndex;
            if (selIndex == -1)
                return;

            listBox_chatsList.Items[selIndex] = textBox_chatName.Text;

            ConfigController.AntikickConfig.SetChatsList(listBox_chatsList.Items.Cast<string>());
            ConfigController.AntikickConfig.Save();
        }

        private void Button_deleteChatName_Click(object sender, EventArgs e) {
            int selIndex = listBox_chatsList.SelectedIndex;
            if (selIndex == -1)
                return;

            listBox_chatsList.Items.RemoveAt(selIndex);
            listBox_chatsList.SelectedIndex = listBox_chatsList.Items.Count == 0 ? -1
                : Math.Max(0, selIndex - 1);

            if (listBox_chatsList.Items.Count == 0) {
                dataGridView_accountsToDefendInChat.Rows.Clear();
                dataGridView_accountsToDefendInChat.Tag = null;
            }

            ConfigController.AntikickConfig.SetChatsList(listBox_chatsList.Items.Cast<string>());
            ConfigController.AntikickConfig.Save();
        }

        private void Button_addAccountDef_Click(object sender, EventArgs e) {
            string toAdd = comboBox_accDefChats.Text;

            var targets = (List<AntikickAccountData>)dataGridView_accountsToDefendInChat.Tag;
            if (targets == null)
                return;
            lock (targets) {
                if (targets.Count > 20 || (from target in targets where target.Name == toAdd select target).Any())
                    return;
                targets.Add(new AntikickAccountData(toAdd, null));
                dataGridView_accountsToDefendInChat.Rows.Add(comboBox_accDefChats.Text, null);

                ConfigController.AntikickConfig.Save();
            }
        }

        private void Button_changeAccountDef_Click(object sender, EventArgs e) {
            int selIndex = dataGridView_accountsToDefendInChat.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selIndex == -1)
                return;

            var targets = (List<AntikickAccountData>)dataGridView_accountsToDefendInChat.Tag;
            if (targets == null)
                return;
            lock (targets) {
                targets[selIndex].Name = comboBox_accDefChats.Text;
                dataGridView_accountsToDefendInChat.Rows[selIndex].Cells[0].Value = comboBox_accDefChats.Text;

                ConfigController.AntikickConfig.Save();
            }
        }

        private void Button_deleteAccountDef_Click(object sender, EventArgs e) {
            int selIndex = dataGridView_accountsToDefendInChat.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selIndex == -1)
                return;

            var targets = (List<AntikickAccountData>)dataGridView_accountsToDefendInChat.Tag;
            if (targets == null)
                return;
            lock (targets) {
                targets.RemoveAt(selIndex);
                dataGridView_accountsToDefendInChat.Rows.RemoveAt(selIndex);

                dataGridView_accountsToDefendInChat.ClearSelection();

                int toSelect = dataGridView_accountsToDefendInChat.Rows.Count == 0
                    ? -1
                    : Math.Max(0, selIndex - 1);

                if (toSelect != -1)
                    dataGridView_accountsToDefendInChat.Rows[toSelect].Selected = true;

                ConfigController.AntikickConfig.Save();
            }
        }

        private void Button_startStop_Click(object sender, EventArgs e) {
            ConfigController.AntikickConfig.LeavedIntentionallyFrom = new ConcurrentDictionary<string, List<ulong>>();
            if (_periodicTimer != null) {
                _periodicTimer.Dispose();
                button_startStop.Text = "Старт";
                _periodicTimer = null;
            }
            else {
                if (ConfigController.AntikickConfig.Targets.Count == 0) {
                    LogForm.PushToLog("[Антикик]: ошибка запуска - отсутствуют цели");
                    return;
                }
                button_startStop.Text = "Стоп";
                new Task(AsyncWorker).Start();
            }
        }

        private void NumericUpDown_antikickDelay_ValueChanged(object sender, EventArgs e) {
            ConfigController.AntikickConfig.Delay = (int)numericUpDown_antikickDelay.Value;
            ConfigController.AntikickConfig.Save();
        }

        private void AntikickForm_Shown(object sender, EventArgs e) {
            ConfigController.AntikickConfig.Validate();

            listBox_chatsList.Items.Clear();
            dataGridView_accountsToDefendInChat.Rows.Clear();

            comboBox_accDefChats.Items.Clear();
            comboBox_accDefChats.Items.AddRange(AccountsManager.GetAccountsList().ToArray<object>());
            if (comboBox_accDefChats.Items.Count != 0)
                comboBox_accDefChats.SelectedIndex = 0;

            foreach (AntikickTarget a in ConfigController.AntikickConfig.Targets) {
                listBox_chatsList.Items.Add(a.Name);
            }

            if (listBox_chatsList.Items.Count != 0)
                listBox_chatsList.SelectedIndex = 0;

            numericUpDown_antikickDelay.Value = ConfigController.AntikickConfig.Delay;
            numericUpDown_partialRejoinDelay.Value = ConfigController.AntikickConfig.PartialRejoinDelay;
        }

        private void AntikickForm_FormClosed(object sender, FormClosedEventArgs e) {
            _periodicTimer?.Dispose();
        }

        private void DataGridView_accountsToDefendInChat_SelectionChanged(object sender, EventArgs e) {
            int selIndex = dataGridView_accountsToDefendInChat.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selIndex == -1)
                return;

            comboBox_accDefChats.Text = dataGridView_accountsToDefendInChat.Rows[selIndex].Cells[0].Value.ToString();
        }

        private void DataGridView_accountsToDefendInChat_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            int chatSelIndex = listBox_chatsList.SelectedIndex;
            if (chatSelIndex == -1)
                return;

            int ri = e.RowIndex;
            if (dataGridView_accountsToDefendInChat.Rows[ri].Cells[1].Value != null)
                return;

            var accName = dataGridView_accountsToDefendInChat.Rows[ri].Cells[0].Value as string;
            var currAcc = AccountsManager.GetAccount(accName);

            string chatName = ConfigController.AntikickConfig.Targets[chatSelIndex].Name;
            var searchResult = LinkParser.Parse(currAcc, "chatname=" + chatName);

            if (searchResult.Type == TypeOfTarget.Chat) {
                dataGridView_accountsToDefendInChat.Rows[ri].Cells[1].Value = searchResult.Id1;

                var targets = (List<AntikickAccountData>)dataGridView_accountsToDefendInChat.Tag;
                targets[ri].ChatId = searchResult.Id1;
                ConfigController.AntikickConfig.Save();
            }
        }

        private void DataGridView_accountsToDefendInChat_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var targets = (List<AntikickAccountData>)dataGridView_accountsToDefendInChat.Tag;
            if (targets == null)
                return;

            targets[e.RowIndex].ChatId = dataGridView_accountsToDefendInChat.Rows[e.RowIndex].Cells[1].Value as int?;
            ConfigController.AntikickConfig.Save();
        }

        private void NumericUpDown_partialRejoinDelay_ValueChanged(object sender, EventArgs e) {
            ConfigController.AntikickConfig.PartialRejoinDelay = (int)numericUpDown_partialRejoinDelay.Value;
            ConfigController.AntikickConfig.Save();
        }
    }
}
