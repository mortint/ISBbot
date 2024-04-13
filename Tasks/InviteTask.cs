using ISP.Engine.Accounts;
using ISP.Forms;
using ISP.Misc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VkNet.Model;

namespace ISP.Tasks {
    internal class InviteTask : ISBTask {
        private void AsyncWorker(Account acc) {
            var api = acc.VkApi;
            var its = acc.InviteTaskSettings;
            //var targets = its.Targets;

            List<long> chatIds = new List<long>();
            ulong offset = 0;
            LogForm.PushToLog(acc, "[Инвайтер]: Получение списка чатов...");

            while (true) {
                var resp = api.Messages.GetConversations(new GetConversationsParams { Count = 200, Offset = offset });
                if (resp.Items.Count == 0)
                    break;

                var found = from msg in resp.Items
                            where msg.Conversation.Peer.LocalId != 0 && msg.Conversation.ChatSettings.ActiveIds.Any()
                            select (long)msg.Conversation.Peer.LocalId;

                chatIds.AddRange(found);

                offset += 200;
            }

            LogForm.PushToLog(acc, $"[Инвайтер]: Найдено {chatIds.Count} чатов");

            int currChatId = 0;
            void DoInvite() {
                if (!its.Enabled) {
                    PeriodicTimer?.Dispose();
                    PeriodicTimer = null;
                    return;
                }

                // Поиск новых чатов
                offset = 0;
                while (true) {
                    var resp = api.Messages.GetConversations(new GetConversationsParams { Count = 200, Offset = offset });
                    if (resp.Items.Count == 0)
                        break;

                    var found = (from msg in resp.Items
                                 where msg.Conversation.Peer.LocalId != 0 && msg.Conversation.ChatSettings.ActiveIds.Any() && !chatIds.Contains((long)msg.Conversation.Peer.LocalId)
                                 select (long)msg.Conversation.Peer.LocalId).ToList();
                    if (!found.Any())
                        break;
                    chatIds.AddRange(found);

                    offset += 200;
                }

                if (!chatIds.Any())
                    return;

                //todo: получение информации о чатах, сравнение с целями
                var usersInTheChat = new HashSet<long>(api.Messages.GetChat(chatIds[currChatId]).Users);
                var accsList = new HashSet<long>(from accstr in AccountsManager.GetAccountsList()
                                                 let id = AccountsManager.GetAccount(accstr).Myself.Id
                                                 select id);
                var idsToRejoin = accsList.Except(usersInTheChat).ToList();

                if (idsToRejoin.Any()) {
                    string requestBody =
                        idsToRejoin.Aggregate("return [",
                            (current, toRej) => current +
                                                $"API.messages.addChatUser({{\"chat_id\":{chatIds[currChatId]},\"user_id\":{toRej}}}),") +
                        "];"; //todo: 25+
                    api.Execute.Execute(requestBody);
                }
                currChatId = (currChatId + 1) % chatIds.Count;
            }

            PeriodicTimer = new SingleSimrunTimer(DoInvite, its.Delay);
        }

        public override void LaunchTask(Account acc) {
            if (!acc.InviteTaskSettings.Enabled)
                return;

            new Task(() => AsyncWorker(acc)).Start();
        }

        public override void StopTask() {
            PeriodicTimer?.Dispose();
            PeriodicTimer = null;
        }
    }
}