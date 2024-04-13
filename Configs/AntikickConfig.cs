using ISP.Engine.Accounts;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ISP.Configs {
    internal class AntikickAccountData {
        /// <summary>
        /// Название чата
        /// </summary>
        public string Name;
        /// <summary>
        /// ID чата
        /// </summary>
        public long? ChatId;
        public AntikickAccountData(string name, long? chatId = null) {
            Name = name;
            ChatId = chatId;
        }
    }

    /// <summary>
    /// Класс AntikickTarget представляет цель для антикика, содержащую информацию о имени цели, аккаунтах и других параметрах.
    /// </summary>
    internal sealed class AntikickTarget {
        /// <summary>
        /// Имя цели
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Коллекция аккаунтов
        /// </summary>
        public readonly List<AntikickAccountData> Accounts;
        /// <summary>
        /// Индекс активного аккаунта
        /// </summary>
        public int IndexOfActiveAcc;
        /// <summary>
        /// Время для повторного вступления в чат
        /// </summary>
        [NonSerialized] public DateTime? WhenToRejoin;

        public AntikickTarget(string name) {
            IndexOfActiveAcc = 0;
            Name = name;
            Accounts = new List<AntikickAccountData>();
            WhenToRejoin = null;
        }
    }

    /// <summary>
    /// Класс AntikickConfig для работы с настройками антикика.
    /// </summary>
    internal class AntikickConfig : ISBConfig {
        /// <summary>
        /// Коллекция целей
        /// </summary>
        public readonly List<AntikickTarget> Targets;
        /// <summary>
        /// Задержка и задержка частичного повторного вступления
        /// </summary>
        public int Delay, PartialRejoinDelay;
        /// <summary>
        /// Словарь для хранения информации о целях
        /// </summary>
        [NonSerialized] public ConcurrentDictionary<string, List<ulong>> LeavedIntentionallyFrom;
        public AntikickConfig() {
            Targets = new List<AntikickTarget>();
            Delay = PartialRejoinDelay = 333;
        }
        /// <summary>
        /// Сохранение конфигурации антикика
        /// </summary>
        public void Save() {
            File.WriteAllText("Configs\\antikickConfig.json", JsonConvert.SerializeObject(this, Formatting.Indented));
        }
        /// <summary>
        /// Добавить новую цель
        /// </summary>
        /// <param name="atg">Объект целей</param>
        /// <returns></returns>
        public bool AddNewTarget(AntikickTarget atg) {
            lock (Targets) {
                if ((from x in Targets where x.Name == atg.Name select x).Any())
                    return false;
                Targets.Add(atg);
                return true;
            }
        }
        /// <summary>
        /// Загрузить чаты на аккаунте
        /// </summary>
        /// <param name="chats">Коллекция чатов</param>
        public void SetChatsList(IEnumerable<string> chats) {
            lock (Targets) {
                var inputNames = new HashSet<string>(chats);
                var existsingNames = new HashSet<string>(from t in Targets select t.Name);

                var toAdd = new HashSet<string>(inputNames);
                toAdd.ExceptWith(existsingNames);
                var toRemove = new HashSet<string>(existsingNames);
                toRemove.ExceptWith(inputNames);

                Targets.RemoveAll(x => toRemove.Contains(x.Name));
                foreach (var target in toAdd)
                    Targets.Add(new AntikickTarget(target));
            }
        }

        public void Validate() {
            lock (Targets) {
                foreach (var target in Targets)
                    target.Accounts.RemoveAll(x => !AccountsManager.GetAccountsList().Contains(x.Name));
            }
        }
    }
}