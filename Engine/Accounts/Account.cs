using ISP.Captcha;
using ISP.Forms;
using ISP.Forms.Dialogs;
using ISP.Tasks.Settings;
using Newtonsoft.Json;
using System;
using System.IO;
using VkNet;
using VkNet.Model;

namespace ISP.Engine.Accounts {
    internal sealed class Account {
        /// <summary>
        /// Объект VkApi для работы с vk.com
        /// </summary>
        public VkApi VkApi { get; private set; }
        /// <summary>
        /// Объект настроек флудера
        /// </summary>
        public FlooderTaskSettings FlooderTaskSettings;
        /// <summary>
        /// Объект настроек с чатами
        /// </summary>
        public ChatsTaskSettings ChatsTaskSettings;
        /// <summary>
        /// Объект настроек с голосовыми сообщениями
        /// </summary>
        public VoiceTaskSettings VoiceTaskSettings;
        /// <summary>
        /// Объект настроек инвайтера
        /// </summary>
        public InviteTaskSettings InviteTaskSettings;
        /// <summary>
        /// Объект настроек автоответчика
        /// </summary>
        public AutoansTaskSettings AutoansTaskSettings;
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Объект User для работы с пользователем
        /// </summary>
        public User Myself { get; set; }
        /// <summary>
        /// Токен
        /// </summary>
        public string Token { get; set; }

        private enum AuthResult {
            /// <summary>
            /// Успешно
            /// </summary>
            Ok,
            /// <summary>
            /// Неверный логин или пароль (ошибка)
            /// </summary>
            InvalidCred,
            /// <summary>
            /// Неизвестная ошибка
            /// </summary>
            Other
        };

        public Account() {
            FlooderTaskSettings = new FlooderTaskSettings();
            VoiceTaskSettings = new VoiceTaskSettings();
            ChatsTaskSettings = new ChatsTaskSettings();
            InviteTaskSettings = new InviteTaskSettings();
            AutoansTaskSettings = new AutoansTaskSettings();
        }

        public void ValidateSettings() {
            if (FlooderTaskSettings == null)
                FlooderTaskSettings = new FlooderTaskSettings();
            if (VoiceTaskSettings == null)
                VoiceTaskSettings = new VoiceTaskSettings();
            if (ChatsTaskSettings == null)
                ChatsTaskSettings = new ChatsTaskSettings();
            if (InviteTaskSettings == null)
                InviteTaskSettings = new InviteTaskSettings();
            if (AutoansTaskSettings == null)
                AutoansTaskSettings = new AutoansTaskSettings();
            AutoansTaskSettings.Validate();
            FlooderTaskSettings.Validate();
            ChatsTaskSettings.Validate();
            VoiceTaskSettings.Validate();
            InviteTaskSettings.Validate();
        }

        public void Reauth(CaptchaSolver solver) {
            VkApi = new VkApi(null, solver);
            ApiAuthParams aup = new ApiAuthParams() {
                AccessToken = Token
            };

            VkApi.Authorize(aup);
        }
        /// <summary>
        /// Авторизация аккаунтов
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <param name="solver">Объект CaptchaSolver для работы с капчей</param>
        /// <param name="twoFactHandler">Двухфакторная авторизация</param>
        /// <param name="appId">ID приложения для авторизации</param>
        /// <returns></returns>
        private AuthResult Auth(string login, string password, CaptchaSolver solver, Func<string> twoFactHandler, ulong appId) {
            VkApi = new VkApi(null, solver);

            ApiAuthParams aup;

            if (password.Contains("vk1")) {
                aup = new ApiAuthParams {
                    AccessToken = password,
                    Settings = VkNet.Enums.Filters.Settings.All | VkNet.Enums.Filters.Settings.Offline,
                };
            }
            else {
                aup = new ApiAuthParams() {
                    ApplicationId = appId,
                    Login = login,
                    Password = password,
                    Settings = VkNet.Enums.Filters.Settings.All | VkNet.Enums.Filters.Settings.Offline,
                    TwoFactorAuthorization = twoFactHandler,
                    TwoFactorSupported = true
                };
            }

            try {
                VkApi.Authorize(aup);
                Token = VkApi.Token;
                return AuthResult.Ok;
            }
            catch (Exception ex) {
                VkApi = null;
                if (ex.Message.Contains("Invalid authorization"))
                    return AuthResult.InvalidCred;
                else
                    return AuthResult.Other;
            }
        }

        public void Auth(string login, string password, CaptchaSolver solver, Func<string> twoFactHandler) {
            Login = login;
            VkApi = null;

            try {
                switch (Auth(login, password, solver, null, 2685278)) {
                    case AuthResult.InvalidCred:
                        LogForm.PushToLog(this, "Ошибка авторизации. Включена двуфакторная авторизация?");
                        TwoFactAsker.AccName = login;
                        Auth(login, password, solver, twoFactHandler, 2685278);
                        break;
                    case AuthResult.Other:
                        LogForm.PushToLog(this, "Неизвестная ошибка, попытка авторизоваться через другое приложение");
                        if (Auth(login, password, solver, null, 2685278) == AuthResult.InvalidCred)
                            Auth(login, password, solver, twoFactHandler, 2685278);
                        break;
                }

                if (VkApi != null) {
                    LogForm.PushToLog(this, "Успешно авторизован");
                    SaveToDisk();
                }
                else
                    LogForm.PushToLog(this, "Ошибка авторзиации");
            }
            catch (Exception ex) {
                LogForm.PushToLog(this, "Ошибка авторзиации: " + ex.Message);
                VkApi = null;
            }
        }
        /// <summary>
        /// Сбросить настройки всех функций
        /// </summary>
        public void ResetSettings() {
            FlooderTaskSettings = new FlooderTaskSettings();
            VoiceTaskSettings = new VoiceTaskSettings();
            ChatsTaskSettings = new ChatsTaskSettings();
            InviteTaskSettings = new InviteTaskSettings();
            AutoansTaskSettings = new AutoansTaskSettings();
            //TODO: Вставлять сюда новые
        }

        public void SaveToDisk() {
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText($"Accounts\\{Login}.json", json);
        }
    }
}
