using ISP.Engine.Helpers;
using ISP.Forms;
using ISP.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VkNet.Model;

namespace ISP.Engine.Accounts {
    internal static class AccountsManager {
        /// <summary>
        /// Список загруженных аккаунтов
        /// </summary>
        private static readonly Dictionary<string, Account> Accounts;
        /// <summary>
        /// Активный аккаунт
        /// </summary>
        private static string _activeAccount;
        /// <summary>
        /// Коллекция запущенных задач
        /// </summary>
        private static readonly List<ISBTask> AccsTasks;
        /// <summary>
        /// Флаг применить для всех аккаунтов
        /// </summary>
        private static bool _toAll;

        static AccountsManager() {
            Accounts = new Dictionary<string, Account>();
            AccsTasks = new List<ISBTask>();
            _activeAccount = null;
            _toAll = false;
        }
        /// <summary>
        /// Применить настройки для всех аккаунтов
        /// </summary>
        /// <returns></returns>
        public static bool ToggleToAll() {
            _toAll = !_toAll;
            return _toAll;
        }
        /// <summary>
        /// Загрузка всех аккаунтов
        /// </summary>
        /// <param name="twoFactHandler">2FA авторизация</param>
        public static void LoadAndPrepareAccounts(Func<string> twoFactHandler) {
            var data = File.ReadAllLines("Txts\\accounts.txt", Encoding.UTF8);
            Captcha.CaptchaSolver solver = new Captcha.CaptchaSolver();

            foreach (var cred in data) {
                try {
                    var logandpass = cred.Split(':');
                    if (logandpass.Length != 2)
                        continue;

                    Account currAcc;

                    try {
                        currAcc = JsonConvert.DeserializeObject<Account>(File.ReadAllText($"Accounts\\{logandpass[0]}.json"));
                    }
                    catch {
                        currAcc = new Account();
                    }

                    var relogin = false;

                    try {
                        if (currAcc.Token == null)
                            relogin = true;
                        else {
                            currAcc.Reauth(solver);
                            var rawUser = currAcc.VkApi.Call("users.get", VkNet.Utils.VkParameters.Empty)[0];
                            currAcc.Myself = new User() { FirstName = rawUser["first_name"], LastName = rawUser["last_name"], Id = rawUser["id"] };
                        }
                    }
                    catch {
                        relogin = true;
                    }

                    if (relogin) {
                        currAcc.Auth(logandpass[0], logandpass[1], solver, twoFactHandler);
                        var rawUser = currAcc.VkApi.Call("users.get", VkNet.Utils.VkParameters.Empty)[0];
                        currAcc.Myself = new User() { FirstName = rawUser["first_name"], LastName = rawUser["last_name"], Id = rawUser["id"] };
                        currAcc.SaveToDisk();
                    }

                    Accounts.Add(logandpass[0], currAcc);
                    if (Accounts.Last().Value.VkApi != null && _activeAccount == null)
                        _activeAccount = Accounts.Last().Key;
                }
                catch (Exception ex) {
                    LogForm.PushToLog($"Ошибка при загрузке одного из аккаунтов: {ex.Message}");
                }
            }

            Accounts.ToList().ForEach(x => x.Value.ValidateSettings());
        }
        /// <summary>
        /// Получить список загруженных аккаунтов
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAccountsList() {
            return (from acc in Accounts
                    where acc.Value.VkApi != null
                    select acc.Key + $" ({acc.Value.Myself.FirstName} {acc.Value.Myself.LastName})"
                    ).ToList();
        }
        /// <summary>
        /// Устанавливает активный аккаунт на основе имени аккаунта
        /// </summary>
        /// <param name="accWithName">Имя аккаунта</param>
        public static void SetActiveAccount(string accWithName) {
            _activeAccount = accWithName.Split(' ')[0];
        }
        /// <summary>
        /// Активный аккаунт
        /// </summary>
        public static Account ActiveAccount => Accounts[_activeAccount];
        /// <summary>
        /// Получить текущий аккаунта
        /// </summary>
        /// <param name="acc">Строка, содержащая информацию об аккаунте в ComboBox</param>
        /// <returns></returns>
        public static Account GetAccount(string acc) {
            return Accounts[acc.Split(' ')[0]];
        }
        /// <summary>
        /// Применяет действие к текущему аккаунту или ко всем аккаунтам.
        /// </summary>
        public static void ApplyToCurrent(Action<Account> func) {
            if (_toAll)
                Accounts.Values.ToList().ForEach(func);
            else
                func(ActiveAccount);
        }
        /// <summary>
        /// Запустить активные задачи
        /// </summary>
        public static void StartAllTasks() {
            LinkParser.ClearCache();
            AccsTasks.Clear();
            foreach (var acc in Accounts.Values) {
                void AddTask(ISBTask task) {
                    AccsTasks.Add(task);
                    task.LaunchTask(acc);
                }

                AddTask(new FlooderTask());
                AddTask(new ChatsTask());
                AddTask(new InviteTask());
                AddTask(new AutoansTask());
            }
        }
        /// <summary>
        /// Остановить активные задачи
        /// </summary>
        public static void StopAllTasks() {
            foreach (ISBTask task in AccsTasks)
                task.StopTask();
        }
    }
}
