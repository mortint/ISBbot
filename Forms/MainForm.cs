using ISP.Captcha;
using ISP.Configs;
using ISP.Configs.Optimizater;
using ISP.Engine.Accounts;
using ISP.Engine.Helpers;
using ISP.Forms.Dialogs;
using ISP.Misc;
using ISP.Objects.Targets;
using ISP.Properties;
using ISP.Tasks;
using ISP.Tasks.Settings;
using JCS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.StringEnums;
using VkNet.Model;

namespace ISP.Forms {
    internal sealed partial class MainForm : Form {
        /// <summary>
        /// ID капчи
        /// </summary>
        private string _currManualCaptId;
        /// <summary>
        /// Объект таймера
        /// </summary>
        System.Timers.Timer t;
        int h, m, s;
        /// <summary>
        /// Объект формы антикапчи
        /// </summary>
        private AnticapSettingsForm _formAnticapSettingsForm;
        /// <summary>
        /// Объект формы Дизайн
        /// </summary>
        private DesignForm _formDesignForm;
        /// <summary>
        /// Объект формы Справка
        /// </summary>
        private HelpForm _formHelpForm;
        /// <summary>
        /// Объект формы лога
        /// </summary>
        private LogForm _formLogForm;
        /// <summary>
        /// Объект формы тайпера
        /// </summary>
        private TyperForm _formTyperForm;
        /// <summary>
        /// Объект формы файлового менеджера
        /// </summary>
        private TxtManagerForm _formTxtManagerForm;
        /// <summary>
        /// Объект формы антикик
        /// </summary>
        private AntikickForm _formAntikickForm;
        /// <summary>
        /// Объект формы автоцели
        /// </summary>
        private AutoTargetForm _autoTargetForm;
        /// <summary>
        /// Флаг запущен ли бот
        /// </summary>
        private bool _accountsWorking;

        private static NotifyIcon _ni;

        private bool _notUserTriggeredChange = false;

        public string UserName = null;
        /// <summary>
        /// Демо-режим
        /// </summary>
        public string Demo { get; set; }

        public MainForm() {
            InitializeComponent();

            linkLabel1.Links.Add(new LinkLabel.Link() { LinkData = "https://tech.yandex.ru/speechkit/cloud/" });

            DesignForm.FormMainForm = this;
            notifyIcon.Icon = Icon;
            _ni = notifyIcon;

            _accountsWorking = false;

            Directory.CreateDirectory("Txts");
            Directory.CreateDirectory("Txts\\Attachments");
            Directory.CreateDirectory("Txts\\Phrases");
            Directory.CreateDirectory("Txts\\Stickers");
            Directory.CreateDirectory("Txts\\Phrases\\Simple");
            Directory.CreateDirectory("Txts\\Phrases\\Dots");

            Directory.CreateDirectory("Txts\\Phrases\\Autoans");

            Directory.CreateDirectory("Accounts");
            Directory.CreateDirectory("Configs");
            Directory.CreateDirectory("Tmp");
            Directory.CreateDirectory("Upload");
            Directory.CreateDirectory("Upload\\Documents");
            Directory.CreateDirectory("Upload\\Images");
            Directory.CreateDirectory("Upload\\Avatars");
            foreach (string tmp in Directory.GetFiles("Tmp"))
                File.Delete(tmp);
            CreateIfNotExists("Txts\\accounts.txt");
            CreateIfNotExists("Txts\\typerTexts.txt");
            CreateIfNotExists("Txts\\titles.txt");
            CreateIfNotExists("Txts\\Attachments\\audios.txt");
            CreateIfNotExists("Txts\\Attachments\\images.txt");
            CreateIfNotExists("Txts\\Attachments\\videos.txt");

            ConfigController.Load();

            try {
                SetApplicationColor(Color.FromArgb(ConfigController.InterfaceConfig.ForColorApplications));
            }
            catch {
            }

            try {
                SetTabsBackPicture(ConfigController.InterfaceConfig.PathToBackgroundImgTabs);
            }
            catch {
            }
            try {
                SetBackPicture(ConfigController.InterfaceConfig.PathToBackgroundImgGeneral);
            }
            catch {
            }
            try {
                SetForeColor(Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb));
            }
            catch {
            }

            try {
                checkBox_closedProfile.Checked = ConfigController.PrivaceConfig.ClosedProfile;
            }
            catch {

            }

            switch (ConfigController.AnticapConfig.SelectedMode) {
                case SelectedMode.Anticaptcha:
                    radioButton_captchaAnticap.Checked = true;
                    break;
                case SelectedMode.Rucaptcha:
                    radioButton_captchaRucap.Checked = true;
                    break;
                case SelectedMode.Manual:
                    radioButton_captchaManual.Checked = true;
                    break;
                case SelectedMode.IsbGPT:
                    radioButton_isbGpt.Checked = true;
                    break;
            }

            ReloadFileLists();
            dataGridView_autoansEditable.Rows.Add("", "Начало", "", "Текст");
        }
        /// <summary>
        /// Загрузить данные из файлов и .txt
        /// </summary>
        private void ReloadFileLists() {
            var autoans = new List<string>(Directory.GetFiles("Txts\\Phrases\\Autoans"));
            autoans = autoans.ConvertAll(Path.GetFileName);
            var txtss = new List<string>(Directory.GetFiles("Txts\\Phrases\\Simple"));
            txtss = txtss.ConvertAll(Path.GetFileName);
            var txtsd = new List<string>(Directory.GetFiles("Txts\\Phrases\\Dots"));
            txtsd = txtsd.ConvertAll(Path.GetFileName);
            var stks = new List<string>(Directory.GetFiles("Txts\\Stickers"));
            stks = stks.ConvertAll(Path.GetFileName);
            var avs = new List<string>(Directory.GetFiles("Upload\\Avatars"));
            avs = avs.ConvertAll(Path.GetFileName);
            comboBox_autoansPhrasesSource.Items.Clear();
            comboBox_autoansPhrasesSource.Items.AddRange(autoans.ToArray());
            comboBox_flooderPhrasesSource.Items.Clear();
            comboBox_flooderPhrasesSource.Items.AddRange(txtss.ToArray());
            comboBox_flooderPhrasesWithDotsSource.Items.Clear();
            comboBox_flooderPhrasesWithDotsSource.Items.AddRange(txtsd.ToArray());
            comboBox_flooderStickerFile.Items.Clear();
            comboBox_flooderStickerFile.Items.AddRange(stks.ToArray());
            comboBox_autoansStickerFile.Items.Clear();
            comboBox_autoansStickerFile.Items.AddRange(stks.ToArray());
            var comboBoxChatsEditable = (DataGridViewComboBoxColumn)dataGridView_chatsEditable.Columns[3];
            comboBoxChatsEditable.Items.Clear();
            comboBoxChatsEditable.Items.Add("Ничего не делать");
            comboBoxChatsEditable.Items.Add("Удалять");
            foreach (string av in avs) {
                comboBoxChatsEditable.Items.Add(av);
            }
        }

        public static void NotifyInTray(string msg) {
            Console.Beep();
            _ni.BalloonTipText = msg;
            _ni.ShowBalloonTip(5000);
        }

        /// <summary>
        /// Устанавливает задний фон вкладок и сохраняет путь к изображению в настройках
        /// </summary>
        /// <param name="img">Путь к изображению для заднего фона вкладок</param>
        public void SetTabsBackPicture(string img) {
            foreach (Control tabPage in tabControl.TabPages)
                tabPage.BackgroundImage = img == null ? null : System.Drawing.Image.FromFile(img);

            ConfigController.InterfaceConfig.PathToBackgroundImgTabs = img;
            ConfigController.InterfaceConfig.Save();
        }

        /// <summary>
        /// Устанавливает задний фон и сохраняет путь к изображению в настройках
        /// </summary>
        /// <param name="img">Путь к изображению для заднего фона</param>
        public void SetBackPicture(string img) {
            BackgroundImage = img == null ? null : System.Drawing.Image.FromFile(img);
            ConfigController.InterfaceConfig.PathToBackgroundImgGeneral = img;
            ConfigController.InterfaceConfig.Save();
        }

        /// <summary>
        /// Устанавливает цвет приложения и применяет его ко всем элементам интерфейса
        /// </summary>
        /// <param name="col">Цвет, который нужно установить</param>
        public void SetApplicationColor(Color col) {
            BackColor = col;
            foreach (Control tabPage in tabControl.TabPages)
                tabPage.BackColor = col;
            ConfigController.InterfaceConfig.ForColorApplications = col.ToArgb();
            ConfigController.InterfaceConfig.Save();
        }

        /// <summary>
        /// Устанавливает цвет текста и визуальные параметры для переключателей
        /// </summary>
        /// <param name="col">Цвет текста</param>
        public void SetForeColor(Color col) {
            Color colorForSwitches = col.ToArgb() == Color.Black.ToArgb() ? Color.Gray : col;

            ToggleSwitchModernRenderer switchRenderer = new ToggleSwitchModernRenderer() {
                LeftSideBackColor1 = colorForSwitches,
                LeftSideBackColor2 = colorForSwitches,
                ArrowNormalColor = colorForSwitches,
                ArrowHoverColor = Color.White,
                ArrowPressedColor = Color.White
            };

            checkBox_inviterEnabled.SetRenderer(Cloner.Clone(switchRenderer));

            ForeColor = col;
            menuStrip1.ForeColor = col;
            foreach (Control tabPage in tabControl.TabPages)
                tabPage.ForeColor = col;

            ConfigController.InterfaceConfig.ForColorAsArgb = col.ToArgb();
            ConfigController.InterfaceConfig.Save();
        }

        /// <summary>
        /// Обработчик двухфакторной аутентификации. Отображает диалоговое окно для ввода кода
        /// </summary>
        /// <returns>Код двухфакторной аутентификации или null, если ввод отменен</returns>
        private string TwoFactHandler() {
            return (string)Invoke(new Func<string>(() => {
                using (TwoFactAsker tfa = new TwoFactAsker()) {
                    if (tfa.ShowDialog(this) == DialogResult.OK) {
                        return tfa.GetCode();
                    }
                    else {
                        return null;
                    }
                }
            }));
        }

        /// <summary>
        /// Создать файл
        /// </summary>
        /// <param name="name">Имя файла</param>
        private static void CreateIfNotExists(string name) {
            if (!File.Exists(name))
                File.WriteAllText(name, "");
        }


        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        /// <summary>
        /// Запуск таймера
        /// </summary>

        private void OnTimeEvent(object sender, ElapsedEventArgs e) {
            Invoke(new Action(() => {
                s += 1;
                if (s == 60) {
                    s = 0;
                    m += 1;

                }

                if (m == 60) {
                    m = 0;
                    h += 1;
                }

                label_workbot.Text = "Время работы приложения: " + string.Format($"{h.ToString().PadLeft(2, '0')}:{m.ToString().PadLeft(2, '0')}:{s.ToString().PadLeft(2, '0')}");
            }));
        }
        private void MainForm_Shown(object sender, EventArgs e) {
            MaximizeBox = false;

            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;

            LogForm.PushToLog("Авторизация аккаунтов...");

            new Task(() => {
                AccountsManager.LoadAndPrepareAccounts(TwoFactHandler);
                comboBox_accountsList.Invoke(new Action(() => {
                    foreach (string acc in AccountsManager.GetAccountsList())
                        comboBox_accountsList.Items.Add(acc);
                    if (comboBox_accountsList.Items.Count != 0) {
                        comboBox_accountsList.SelectedIndex = 0;

                        tabControl.Enabled = true;

                        toolStripMenuItem_antikickBot.Enabled = true;
                        button_startStop.Enabled = true;
                    }
                    else
                        comboBox_accountsList.Text = "Не было загружено ни одного аккаунта";
                    LogForm.PushToLog("Авторизация завершена");
                }));
            }).Start();
        }

        private void ToolStripMenuItem_log_Click(object sender, EventArgs e) {
            _formLogForm?.Close();
            _formLogForm = new LogForm();
            _formLogForm.Show(this);
        }

        private void ToolStripMenuItem_help_Click(object sender, EventArgs e) {
            _formHelpForm?.Close();
            _formHelpForm = new HelpForm();
            _formHelpForm.Show(this);
        }

        private void ToolStripMenuItem_manager_Click(object sender, EventArgs e) {
            _formTxtManagerForm?.Close();
            _formTxtManagerForm = new TxtManagerForm();
            _formTxtManagerForm.Show(this);
        }

        private void Button_anticaptchaKeys_Click(object sender, EventArgs e) {
            _formAnticapSettingsForm?.Close();
            _formAnticapSettingsForm = new AnticapSettingsForm();
            _formAnticapSettingsForm.Show(this);
        }

        private void Button_anticaptchaDesign_Click(object sender, EventArgs e) {
            _formDesignForm?.Close();
            _formDesignForm = new DesignForm();
            _formDesignForm.Show(this);
        }

        private void Button_otherBots_Click(object sender, EventArgs e) {
            menuStrip1.Show(MousePosition);
        }

        private void Button_interfaceMouseEnter(object sender, EventArgs e) {
            ((ButtonBase)sender).UseVisualStyleBackColor = false;
            ((Control)sender).BackColor = Color.Silver;
        }

        private void Button_interfaceMouseLeave(object sender, EventArgs e) {
            ((ButtonBase)sender).UseVisualStyleBackColor = true;
            ((Control)sender).BackColor = Color.Transparent;
        }

        private int _changeDisablersRunning = 0;
        private void RunChangeEventDisabler() {
            _changeDisablersRunning++;
            new Task(() => {
                _notUserTriggeredChange = true;
                Thread.Sleep(100);
                _changeDisablersRunning--;
                if (_changeDisablersRunning == 0)
                    _notUserTriggeredChange = false;
            }).Start();
        }

        private void ComboBox_accountsList_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox_accountsList.SelectedIndex == -1)
                return;

            AccountsManager.SetActiveAccount(comboBox_accountsList.Items[comboBox_accountsList.SelectedIndex].ToString());

            RunChangeEventDisabler();
            LoadGlobalSettingsFormFromActive();
            LoadFlooderFormFromActive();
            LoadChatsFormFromActive();
            LoadVoiceFormFromActive();
            LoadInviterFormFromActive();
            LoadAutoansFormFromActive();
        }

        private void RadioButton_captchaManual_CheckedChanged(object sender, EventArgs e) {
            ConfigController.AnticapConfig.SelectedMode = SelectedMode.Manual;
            ConfigController.AnticapConfig.Save();
        }

        private void RadioButton_captchaRucap_CheckedChanged(object sender, EventArgs e) {
            ConfigController.AnticapConfig.SelectedMode = SelectedMode.Rucaptcha;
            ConfigController.AnticapConfig.Save();
        }

        private void RadioButton_captchaAnticap_CheckedChanged(object sender, EventArgs e) {
            ConfigController.AnticapConfig.SelectedMode = SelectedMode.Anticaptcha;
            ConfigController.AnticapConfig.Save();
        }

        private void Timer_manualCaptcha_Tick(object sender, EventArgs e) {
            if (pictureBox_captPic.BackgroundImage == null && ManualCaptchaService.CaptchaManualIdsToSolve.Count != 0) {
                _currManualCaptId = ManualCaptchaService.CaptchaManualIdsToSolve.Dequeue();
                FileStream fs = new FileStream($"tmp\\{_currManualCaptId}.png", FileMode.Open);
                pictureBox_captPic.BackgroundImage = System.Drawing.Image.FromStream(fs);
                fs.Close();
                File.Delete(_currManualCaptId + ".png");
            }
        }

        private void TextBox_manualCaptchaAnswer_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter || textBox_manualCaptchaAnswer.Text == "" || _currManualCaptId == null)
                return;

            ManualCaptchaService.CaptchaManualAnswers.Add(_currManualCaptId, textBox_manualCaptchaAnswer.Text);
            pictureBox_captPic.BackgroundImage.Dispose();
            pictureBox_captPic.BackgroundImage = null;
            _currManualCaptId = null;
            textBox_manualCaptchaAnswer.Clear();
        }

        private void Button_startStop_Click(object sender, EventArgs e) {
            if (!_accountsWorking) {
                LogForm.PushToLog("Бот запущен");
                toolStripMenuItem_reload.Enabled = false;
                button_startStop.BackgroundImage = Resources.Stop;
                AccountsManager.StartAllTasks();
                t.Start();
            }
            else {
                LogForm.PushToLog("Бот остановлен");
                toolStripMenuItem_reload.Enabled = true;
                button_startStop.BackgroundImage = Resources.Start;
                AccountsManager.StopAllTasks();
                t.Stop();
                m = h = s = 0;
            }
            _accountsWorking = !_accountsWorking;
        }

        private void Timer_shutown_Tick(object sender, EventArgs e) {
            if (checkBox_shutownOnTime.Checked && dateTimePicker_timeToStop.Value <= DateTime.Now && _accountsWorking)
                Button_startStop_Click(null, null);
        }

        private void Button_applyToAll_Click(object sender, EventArgs e) {
            if (AccountsManager.ToggleToAll()) {
                LogForm.PushToLog("Теперь действия применяются для всех");
                label_forAll.Text = "Для всех: вкл";
            }
            else {
                LogForm.PushToLog("Теперь действия применяются только для выбранного аккаунта");
                label_forAll.Text = "Для всех: выкл";
            }
        }

        private void ToolStripMenuItem_reload_Click(object sender, EventArgs e) {
            LogForm.PushToLog("Перезагрузка .txt и списков файлов...");
            ChatsTaskSettings.ReloadFromTxts();
            FlooderTaskSettings.ReloadFromTxts();
            AutoansTaskSettings.ReloadFromTxts();
            ReloadFileLists();
            ComboBox_accountsList_SelectedIndexChanged(null, null);
        }

        private void ToolStripMenuItem_typerBot_Click(object sender, EventArgs e) {
            _formTyperForm?.Close();
            _formTyperForm = new TyperForm();
            _formTyperForm.Show(this);
        }

        private void ToolStripMenuItem_antikickBot_Click(object sender, EventArgs e) {
            _formAntikickForm?.Close();
            _formAntikickForm = new AntikickForm();
            _formAntikickForm.Show(this);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(e.Link.LinkData as string);
        }

        private void Button7_Click(object sender, EventArgs e) {
            dataGridView_autoansView.Rows.Add(dataGridView_autoansEditable[0, 0].Value,
                dataGridView_autoansEditable[1, 0].Value,
                dataGridView_autoansEditable[2, 0].Value,
                dataGridView_autoansEditable[3, 0].Value);

            AccountsManager.ApplyToCurrent((a) => a.AutoansTaskSettings.AddNewTarget(new AutoansTarget() {
                Link = (dataGridView_autoansEditable[0, 0].Value ?? "").ToString(),
                NamePlace = dataGridView_autoansEditable[1, 0].Value.ToString(),
                Name = (dataGridView_autoansEditable[2, 0].Value ?? "").ToString(),
                Contains = dataGridView_autoansEditable[3, 0].Value.ToString()
            }));
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void toolStrip_AutoTarget_Click(object sender, EventArgs e) {
            _autoTargetForm?.Close();
            _autoTargetForm = new AutoTargetForm();
            _autoTargetForm.DataGridView = dataGridView_flooderView;
            _autoTargetForm.Show();
        }

        private void button_GetConversation_Click(object sender, EventArgs e) {
            AccountsManager.ApplyToCurrent(async (a) => {
                try {
                    await LoadConversationsAsync(a.VkApi, comboBox_ActivedChat);
                }
                catch {
                    comboBox_ActivedChat.BeginInvoke(new Action(() => {
                        comboBox_ActivedChat.Items.Clear();
                        comboBox_ActivedChat.Text = "Ошибка при загрузке чатов";
                    }));
                }
            });
        }
        private async Task LoadConversationsAsync(VkApi api, ComboBox comboBox_ActivedChat) {
            var conversations = await Task.Run(() => api.Messages.GetConversations(new GetConversationsParams() { Count = 200, Filter = GetConversationFilter.All }));

            if (conversations.Items.Count != 0) {
                List<string> chatItems = new List<string>();
                foreach (var item in conversations.Items) {
                    if (item.Conversation.Peer.Type == ConversationPeerType.Chat) {
                        chatItems.Add("im?sel=c" + item.Conversation.Peer.LocalId +
                            $" ({item.Conversation.ChatSettings.Title})");
                    }
                }

                comboBox_ActivedChat.BeginInvoke(new Action(() => {
                    comboBox_ActivedChat.Items.Clear();
                    comboBox_ActivedChat.Items.AddRange(chatItems.ToArray());
                    comboBox_ActivedChat.SelectedIndex = 0;
                }));
            }
            else {
                comboBox_ActivedChat.BeginInvoke(new Action(() => {
                    comboBox_ActivedChat.Items.Clear();
                    comboBox_ActivedChat.Text = "Нет чатов на аккаунте";
                }));
            }
        }

        private void TimerOptimizer_Tick(object sender, EventArgs e) {
            if (checkBox_optimize.Checked)
                new Optimize();
        }

        private void comboBox_autoansPhrasesSource_SelectedIndexChanged(object sender, EventArgs e) {
            AccountsManager.ApplyToCurrent((a) => a.AutoansTaskSettings.PhrasesFile = comboBox_autoansPhrasesSource.Text);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void comboBox_autoansStickerFile_SelectedIndexChanged(object sender, EventArgs e) {
            AccountsManager.ApplyToCurrent((a) => a.AutoansTaskSettings.StickersFile = comboBox_autoansStickerFile.Text);
            comboBox_autoansStickerId.Items.Clear();
            if (!string.IsNullOrEmpty(comboBox_autoansStickerFile.Text)) {
                comboBox_autoansStickerId.Text = "";
                comboBox_autoansStickerId.Items.Add("По порядку");
                comboBox_autoansStickerId.Items.AddRange(File.ReadAllLines($"Txts\\Stickers\\{comboBox_autoansStickerFile.Text}", Encoding.GetEncoding("windows-1251")));
            }
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void comboBox_autoansStickerId_SelectedIndexChanged(object sender, EventArgs e) {
            AccountsManager.ApplyToCurrent((a) => a.AutoansTaskSettings.StickerId = comboBox_autoansStickerId.Text);
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void button_autoansChange_Click(object sender, EventArgs e) {
            int selIndex = dataGridView_autoansView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selIndex == -1)
                return;
            var from = new AutoansTarget() {
                Link = (dataGridView_autoansView[0, selIndex].Value ?? "").ToString(),
                NamePlace = dataGridView_autoansView[1, selIndex].Value.ToString(),
                Name = (dataGridView_autoansView[2, selIndex].Value ?? "").ToString(),
                Contains = dataGridView_autoansView[3, selIndex].Value.ToString()
            };

            for (int i = 0; i < dataGridView_autoansView.Columns.Count; ++i)
                dataGridView_autoansView[i, selIndex].Value = dataGridView_autoansEditable[i, 0].Value;

            var to = new AutoansTarget() {
                Link = (dataGridView_autoansEditable[0, 0].Value ?? "").ToString(),
                NamePlace = dataGridView_autoansEditable[1, 0].Value.ToString(),
                Name = (dataGridView_autoansEditable[2, 0].Value ?? "").ToString(),
                Contains = dataGridView_autoansEditable[3, 0].Value.ToString()
            };

            AccountsManager.ApplyToCurrent((a) => a.AutoansTaskSettings.ReplaceTarget(from, to));
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void button_autoansRemove_Click(object sender, EventArgs e) {
            int selRow = dataGridView_autoansView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selRow == -1)
                return;
            // dataGridView_flooderView.Rows.Remove(dataGridView_flooderView.Rows[selRow]);
            dataGridView_autoansView.Rows.Remove(dataGridView_autoansView.SelectedRows[0]);

            AccountsManager.ApplyToCurrent((a) => a.AutoansTaskSettings.RemoveTarget(new AutoansTarget() {
                Link = (dataGridView_autoansEditable[0, 0].Value ?? "").ToString(),
                NamePlace = dataGridView_autoansEditable[1, 0].Value.ToString(),
                Name = (dataGridView_autoansEditable[2, 0].Value ?? "").ToString(),
                Contains = dataGridView_autoansEditable[3, 0].Value.ToString()
            }));
            AccountsManager.ApplyToCurrent((a) => a.SaveToDisk());
        }

        private void dataGridView_autoansView_SelectionChanged(object sender, EventArgs e) {
            int selIndex = dataGridView_autoansView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (selIndex == -1)
                return;
            for (int i = 0; i < dataGridView_autoansView.Columns.Count; ++i)
                dataGridView_autoansEditable[i, 0].Value = dataGridView_autoansView[i, selIndex].Value;
        }

        private void button_SavePrivacySettings_Click(object sender, EventArgs e) {
            try {
                //AccountsManager.ApplyToCurrent((a) =>
                //{
                //    var api = a.VkApi;

                //    if (checkBox_closedProfile.Checked)
                //        api.Account.SetPrivacy("closed_profile", "true");
                //    else
                //        api.Account.SetPrivacy("closed_profile", "false");
                //    LogForm.PushToLog("Приватные настройки применены");
                //});
            }
            catch {

            }
        }

        private void checkBox_closedProfile_CheckedChanged(object sender, EventArgs e) {
            ConfigController.PrivaceConfig.ClosedProfile = checkBox_closedProfile.Checked;
            ConfigController.PrivaceConfig.Save();
        }

        private void checkBox_optimize_CheckedChanged(object sender, EventArgs e) {

        }

        private void button_telegramChannel_Click(object sender, EventArgs e) {
            Process.Start("https://t.me/novikov_w");
        }

        private async void button_updater_Click(object sender, EventArgs e) {
            await CheckElinks();
        }

        private void label30_Click(object sender, EventArgs e) {

        }
        public async Task<bool?> CheckElinks() {
            if (File.Exists("Update\\ISB.rar"))
                File.Delete("Update\\ISB.rar");

            Directory.CreateDirectory("Update");

            await StartDownload(Links.Download, "Update\\ISB.rar");

            if (_task.IsCompleted)
                button_updater.Text = "Обновление скачалось";

            return true;
        }

        private Task _task;

        private void radioButton_isbGpt_CheckedChanged(object sender, EventArgs e) {
            ConfigController.AnticapConfig.SelectedMode = SelectedMode.IsbGPT;
            ConfigController.AnticapConfig.Save();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void checkBox_enabledToCustomAudio_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_enabledToCustomAudio.Checked) {

                button_sendVO.Enabled = false;
                button_SelectAudioAndSend.Enabled = true;
            }
            else {
                button_sendVO.Enabled = true;
                button_SelectAudioAndSend.Enabled = false;
            }

            AccountsManager.ApplyToCurrent((a) => {
                a.VoiceTaskSettings.SendCustomAudio = checkBox_enabledToCustomAudio.Checked;
                a.SaveToDisk();
            });
        }

        private void button_SelectAudioAndSend_Click(object sender, EventArgs e) {
            if (_notUserTriggeredChange)
                return;
            var openFileDialog = new OpenFileDialog {
                Title = "Выбор аудиофайла",
                Filter = "MP3|*.mp3",
                DefaultExt = "mp3",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                AccountsManager.ApplyToCurrent((a) => {
                    a.VoiceTaskSettings.Target = textBox_targetVO.Text;
                    a.VoiceTaskSettings.AudioMp3Name = openFileDialog.FileName;
                    new VoiceTask().LaunchTask(a);
                });
            }
        }
        /// <summary>
        /// Скачать обновление
        /// </summary>
        /// <returns></returns>
        public Task StartDownload(string link, string filename) {
            var wc = new WebClient();
            _task = wc.DownloadFileTaskAsync(new Uri(link), filename);
            button_updater.Text = "Скачивание началось...";
            MessageBox.Show("Обновленное приложение будет по пути: Update/ISB.rar", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return _task;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            System.Windows.Forms.Application.Exit();
        }
    }
}