using ISP.Configs;
using ISP.Engine.Helpers;
using ISP.Engine.Network;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISP.Forms.JsonDecode;

namespace ISP.Forms {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();

            try {
                ConfigController.Load();

                textBox_password.Text = ConfigController.LoginConfig.Password;

                var encode = JsonConvert.DeserializeObject<ConfigAmount>(Network.HttpRequest(Links.Configs));

                label_hwid.Text = Server.GetHWID() + $" (стоимость бота: {encode.Amount}₽)";
            }
            catch {

            }
        }
        private void button_copyHwid_Click(object sender, EventArgs e)
            => Clipboard.SetText(Server.GetHWID());

        private void Login() {
            try {
                var response =
                    Network.HttpRequest(Links.Index + $"?password={textBox_password.Text}&hwid={Server.GetHWID()}");

                var encode = JsonConvert.DeserializeObject<JsonDecode>(response);

                if (!string.IsNullOrEmpty(encode.Error)) {
                    MessageBox.Show("Неверный пароль.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                switch (encode.Response) {
                    case "ok":
                        var banned = int.Parse(encode.User.IsBanned);
                        var warn = encode.User.Warn;

                        if (banned == 1) {
                            MessageBox.Show($"Вы были забанены в системе.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (warn > 0) {
                            MessageBox.Show($"У вас {warn} предупреждений за нарушения Пользовательского соглашения.\n\nЕсли Вы будете забанены - разбан не осуществляется за нарушения.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }



                        var instance = Assembly.GetExecutingAssembly()
                            .CreateInstance("ISP.Forms.MainForm") as MainForm;

                        instance.UserName = Environment.UserName;
                        instance.Show();
                        Hide();
                        break;
                    default:
                        MessageBox.Show("Неизвестная ошибка входа. Обратитесь к администраторам", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Неизвестная ошибка входа. Обратитесь к администраторам\n\nТекст ошибки: {ex.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_Enter_Click(object sender, EventArgs e) {
            new Task(() => Invoke(new Action(() => Login()))).Start();
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                button_Enter_Click(null, null);
        }

        private void LoginForm_Shown(object sender, EventArgs e) {
            if (!Directory.Exists("DLL")) {
                MessageBox.Show("Отсутствует папка \"DLL\"", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e) {
            try {
                ConfigController.LoginConfig.Password = textBox_password.Text;
                ConfigController.LoginConfig.Save();
            }
            catch {

            }
        }
    }

    internal class JsonDecode {
        internal class Users {
            /// <summary>
            /// Предупреждение
            /// </summary>
            [JsonProperty("warn")] public int Warn { get; set; }
            /// <summary>
            /// Статус забанненого пользователя
            /// </summary>
            [JsonProperty("is_banned")] public string IsBanned { get; set; }

        }
        /// <summary>
        /// Массив пользователя
        /// </summary>
        [JsonProperty("user")] public Users User { get; set; }
        /// <summary>
        /// Возврат успешного выполнения запроса на стороне сервера
        /// </summary>
        [JsonProperty("response")] public string Response { get; set; }

        /// <summary>
        /// Текст ошибки
        /// </summary>
        [JsonProperty("error")] public string Error { get; set; }

        internal class ConfigAmount {
            /// <summary>
            /// Стоимость
            /// </summary>
            [JsonProperty("sum")] public string Amount { get; set; }
        }
    }
}
