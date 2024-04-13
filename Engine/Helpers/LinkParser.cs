using ISP.Engine.Accounts;
using ISP.Enums.Parser;
using ISP.Forms;
using ISP.Objects.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using VkNet.Model;

namespace ISP.Engine.Helpers {

    internal static class LinkParser {
        /// <summary>
        /// Словарь для хранения информации о чате и пользователе
        /// </summary>
        private static readonly Dictionary<Account, Dictionary<string, long?>> ChatFromName, UserFromName;

        static LinkParser() {
            ChatFromName = new Dictionary<Account, Dictionary<string, long?>>();
            UserFromName = new Dictionary<Account, Dictionary<string, long?>>();
        }
        /// <summary>
        /// Очистить словарь
        /// </summary>
        public static void ClearCache() {
            ChatFromName.Clear();
            UserFromName.Clear();
        }

        public static TargetData Parse(Account acc, string link) {
            var api = acc.VkApi;

            var patternChat = new Regex("im\\?sel=c([0-9]+)").Match(link);
            var patternPm = new Regex("im\\?sel=([0-9]+)").Match(link);
            var patternWall = new Regex("wall([0-9]+)_([0-9]+)").Match(link);
            var patternPhoto = new Regex("photo([0-9]+)_([0-9]+)").Match(link);
            var patternVideo = new Regex("video([0-9]+)_([0-9]+)").Match(link);
            var patternTopic = new Regex("topic([0-9]+)_([0-9]+)").Match(link);
            var patternChatname = new Regex("chatname=(.+)").Match(link);
            var patternUsername = new Regex("username=(.+)").Match(link);

            if (patternChat.Success) {
                return new TargetData(TypeOfTarget.Chat, patternChat.Groups[1].Value, "0");
            }
            if (patternPm.Success) {
                return new TargetData(TypeOfTarget.PersonalMessage, patternPm.Groups[1].Value, "0");
            }
            if (patternWall.Success) {
                return new TargetData(TypeOfTarget.Wall, patternWall.Groups[1].Value, patternWall.Groups[2].Value);
            }
            if (patternPhoto.Success) {
                return new TargetData(TypeOfTarget.Photo, patternPhoto.Groups[1].Value, patternPhoto.Groups[2].Value);
            }
            if (patternVideo.Success) {
                return new TargetData(TypeOfTarget.Video, patternVideo.Groups[1].Value, patternVideo.Groups[2].Value);
            }
            if (patternTopic.Success) {
                return new TargetData(TypeOfTarget.Topic, patternTopic.Groups[1].Value, patternTopic.Groups[2].Value);
            }

            if (patternChatname.Success) {
                var nameToSearch = patternChatname.Groups[1].Value.ToLower();
                long? targetId = null;
                if (!ChatFromName.Keys.Contains(acc))
                    ChatFromName[acc] = new Dictionary<string, long?>();
                if (ChatFromName[acc].Keys.Contains(nameToSearch))
                    targetId = ChatFromName[acc][nameToSearch];
                else {
                    LogForm.PushToLog(acc, $"Поиск беседы: {nameToSearch}...");

                    ulong offset = 0;
                    while (targetId == null) {
                        var resp = api.Messages.GetConversations(new GetConversationsParams { Count = 200, Offset = offset });
                        if (resp.Items.Count == 0)
                            break;

                        var found = from msg in resp.Items
                                    where msg.Conversation.ChatSettings.Title.ToLower() == nameToSearch
                                    select msg.Conversation.Peer.LocalId;

                        targetId = found.FirstOrDefault();

                        offset += 200;
                    }

                    ChatFromName[acc][nameToSearch] = targetId;
                }

                if (targetId == null) {
                    LogForm.PushToLog(acc, $"Название беседы не найдено: {nameToSearch}");
                    return new TargetData(TypeOfTarget.NotFound);
                }

                return new TargetData(TypeOfTarget.Chat, targetId.ToString(), "0");
            }

            if (patternUsername.Success) {
                string nameToSearch = patternUsername.Groups[1].Value.ToLower();
                long? targetId = null;
                if (!UserFromName.Keys.Contains(acc))
                    UserFromName[acc] = new Dictionary<string, long?>();
                if (UserFromName[acc].Keys.Contains(nameToSearch))
                    targetId = UserFromName[acc][nameToSearch];
                else {
                    LogForm.PushToLog(acc, $"Поиск пользователя: {nameToSearch}...");

                    ulong offset = 0;

                    while (targetId == null) {
                        var resp = api.Messages.GetConversations(new GetConversationsParams { Count = 200, Offset = offset });
                        if (resp.Items.Count == 0)
                            break;

                        var found = from msg in resp.Profiles
                                    where msg.Id != 0
                                    && new Func<string>(() => {
                                        var info = api.Users.Get(new[] { msg.Id }).FirstOrDefault();
                                        return info.FirstName + " " + info.LastName;
                                    }).Invoke().ToLower() == nameToSearch
                                    select msg.Id;

                        targetId = found.FirstOrDefault();

                        offset += 200;
                    }

                    UserFromName[acc][nameToSearch] = targetId;
                }

                if (targetId == null) {
                    LogForm.PushToLog(acc, $"Пользователь не найден: {nameToSearch}");
                    return new TargetData(TypeOfTarget.NotFound);
                }

                return new TargetData(TypeOfTarget.PersonalMessage, targetId.ToString(), "0");
            }

            return new TargetData(TypeOfTarget.Unknown);
        }
    }
}
