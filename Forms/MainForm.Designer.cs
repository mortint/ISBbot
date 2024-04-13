using System.ComponentModel;
using System.Windows.Forms;

namespace ISP.Forms
{
    partial class MainForm
    {
        private IContainer components = null;
        private TabControl tabControl;
        private TabPage tabPageFlooder;
        private TabPage tabPageAnswer;
        private TabPage tabPageConversations;
        private TabPage tabPageOther;
        private MenuStrip menuStrip;
        private DateTimePicker dateTimePicker_timeToStop;
        private JCS.ToggleSwitch checkBox_shutownOnTime;
        private Button button_startStop;
        private ComboBox comboBox_accountsList;
        private Label label2;
        private Button button_applyToAll;
        private Button button_anticaptchaKeys;
        private Button button_design;
        private TabPage tabPageSettings;
        private PictureBox pictureBox_captPic;
        private TextBox textBox_manualCaptchaAnswer;
        private RadioButton radioButton_captchaManual;
        private RadioButton radioButton_captchaRucap;
        private RadioButton radioButton_captchaAnticap;
        private Label label1;
        private Label label5;
        private NumericUpDown numericUpDown_inviterDelay;
        private Label label15;
        private JCS.ToggleSwitch checkBox_inviterEnabled;
        private NumericUpDown numericUpDown_chatsDelay;
        private NumericUpDown numericUpDown_autoansDelay;
        private Label label9;
        private JCS.ToggleSwitch checkBox_chatsEnabled;
        private Label label7;
        private JCS.ToggleSwitch checkBox_autoansEnabled;
        private Label label6;
        private JCS.ToggleSwitch checkBox_flooderEnabled;
        private NumericUpDown numericUpDown_flooderDelay;
        private Button button_otherBots;
        private ToolStripMenuItem toolStripMenuItem_log;
        private DataGridView dataGridView_flooderView;
        private DataGridView dataGridView_flooderEditable;
        private DataGridView dataGridView_autoansEditable;
        private DataGridView dataGridView_autoansView;
        private DataGridView dataGridView_chatsView;
        private DataGridView dataGridView_chatsEditable;
        private ToolStripMenuItem toolStripMenuItem_help;
        private Button button_resetSettings;
        private Label label19;
        private Label label_forAll;
        private Label label24;
        private Label label25;
        private Label label26;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.button_updater = new System.Windows.Forms.Button();
            this.button_telegramChannel = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.checkBox_optimize = new JCS.ToggleSwitch();
            this.label_workbot = new System.Windows.Forms.Label();
            this.selectionDelay = new System.Windows.Forms.ComboBox();
            this.numericUpDown_flooderDelayMax = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.button_resetSettings = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_inviterDelay = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox_inviterEnabled = new JCS.ToggleSwitch();
            this.numericUpDown_chatsDelay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_autoansDelay = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_chatsEnabled = new JCS.ToggleSwitch();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_autoansEnabled = new JCS.ToggleSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_flooderEnabled = new JCS.ToggleSwitch();
            this.numericUpDown_flooderDelay = new System.Windows.Forms.NumericUpDown();
            this.tabPageFlooder = new System.Windows.Forms.TabPage();
            this.comboBox_flooderStickerId = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBox_flooderStickerFile = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox_flooderPhrasesWithDotsSource = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox_flooderPhrasesSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_flooderPictureSource = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_flooderChange = new System.Windows.Forms.Button();
            this.button_flooderRemove = new System.Windows.Forms.Button();
            this.button_flooderAdd = new System.Windows.Forms.Button();
            this.dataGridView_flooderEditable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridView_flooderView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageAnswer = new System.Windows.Forms.TabPage();
            this.comboBox_autoansStickerId = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.comboBox_autoansStickerFile = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.comboBox_autoansPhrasesSource = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button_autoansChange = new System.Windows.Forms.Button();
            this.button_autoansRemove = new System.Windows.Forms.Button();
            this.button_autoansAdd = new System.Windows.Forms.Button();
            this.dataGridView_autoansEditable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridView_autoansView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPageConversations = new System.Windows.Forms.TabPage();
            this.button_chatsChange = new System.Windows.Forms.Button();
            this.button_chatsRemove = new System.Windows.Forms.Button();
            this.button_chatsAdd = new System.Windows.Forms.Button();
            this.dataGridView_chatsEditable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView_chatsView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPageVoice = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBox_enabledToCustomAudio = new JCS.ToggleSwitch();
            this.button_SelectAudioAndSend = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_yandexKeyVO = new System.Windows.Forms.TextBox();
            this.button_sendVO = new System.Windows.Forms.Button();
            this.numericUpDown_speedVO = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_emotionVO = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_voiceVO = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_targetVO = new System.Windows.Forms.TextBox();
            this.richTextBox_messageVO = new System.Windows.Forms.RichTextBox();
            this.tabPagePrivace = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_GetConversation = new System.Windows.Forms.Button();
            this.comboBox_ActivedChat = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.toggleSwitch2 = new JCS.ToggleSwitch();
            this.label41 = new System.Windows.Forms.Label();
            this.checkBox_closedProfile = new JCS.ToggleSwitch();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_SavePrivacySettings = new System.Windows.Forms.Button();
            this.tabPageOther = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.toggleSwitch4 = new JCS.ToggleSwitch();
            this.label44 = new System.Windows.Forms.Label();
            this.toggleSwitch3 = new JCS.ToggleSwitch();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPageCheating = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.toggleSwitch9 = new JCS.ToggleSwitch();
            this.button4 = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.toggleSwitch8 = new JCS.ToggleSwitch();
            this.label48 = new System.Windows.Forms.Label();
            this.toggleSwitch7 = new JCS.ToggleSwitch();
            this.label47 = new System.Windows.Forms.Label();
            this.toggleSwitch6 = new JCS.ToggleSwitch();
            this.label46 = new System.Windows.Forms.Label();
            this.toggleSwitch5 = new JCS.ToggleSwitch();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_log = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_manager = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_reload = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker_timeToStop = new System.Windows.Forms.DateTimePicker();
            this.checkBox_shutownOnTime = new JCS.ToggleSwitch();
            this.comboBox_accountsList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_manualCaptchaAnswer = new System.Windows.Forms.TextBox();
            this.radioButton_captchaManual = new System.Windows.Forms.RadioButton();
            this.radioButton_captchaRucap = new System.Windows.Forms.RadioButton();
            this.radioButton_captchaAnticap = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_forAll = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.timer_manualCaptcha = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer_shutown = new System.Windows.Forms.Timer(this.components);
            this.label37 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button_otherBots = new System.Windows.Forms.Button();
            this.button_design = new System.Windows.Forms.Button();
            this.button_anticaptchaKeys = new System.Windows.Forms.Button();
            this.button_applyToAll = new System.Windows.Forms.Button();
            this.button_startStop = new System.Windows.Forms.Button();
            this.pictureBox_captPic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_typerBot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_antikickBot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_AutoTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.другиеПроектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSBGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSBGramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSBGPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerOptimizer = new System.Windows.Forms.Timer(this.components);
            this.radioButton_isbGpt = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_flooderDelayMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inviterDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_chatsDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_autoansDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_flooderDelay)).BeginInit();
            this.tabPageFlooder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flooderEditable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flooderView)).BeginInit();
            this.tabPageAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_autoansEditable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_autoansView)).BeginInit();
            this.tabPageConversations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chatsEditable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chatsView)).BeginInit();
            this.tabPageVoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_speedVO)).BeginInit();
            this.tabPagePrivace.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageOther.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPageCheating.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_captPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Controls.Add(this.tabPageFlooder);
            this.tabControl.Controls.Add(this.tabPageAnswer);
            this.tabControl.Controls.Add(this.tabPageConversations);
            this.tabControl.Controls.Add(this.tabPageVoice);
            this.tabControl.Controls.Add(this.tabPagePrivace);
            this.tabControl.Controls.Add(this.tabPageOther);
            this.tabControl.Controls.Add(this.tabPageCheating);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(1, 114);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(694, 426);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPageSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageSettings.Controls.Add(this.button_updater);
            this.tabPageSettings.Controls.Add(this.button_telegramChannel);
            this.tabPageSettings.Controls.Add(this.label22);
            this.tabPageSettings.Controls.Add(this.checkBox_optimize);
            this.tabPageSettings.Controls.Add(this.label_workbot);
            this.tabPageSettings.Controls.Add(this.selectionDelay);
            this.tabPageSettings.Controls.Add(this.numericUpDown_flooderDelayMax);
            this.tabPageSettings.Controls.Add(this.label35);
            this.tabPageSettings.Controls.Add(this.label32);
            this.tabPageSettings.Controls.Add(this.label31);
            this.tabPageSettings.Controls.Add(this.label30);
            this.tabPageSettings.Controls.Add(this.button_resetSettings);
            this.tabPageSettings.Controls.Add(this.label5);
            this.tabPageSettings.Controls.Add(this.numericUpDown_inviterDelay);
            this.tabPageSettings.Controls.Add(this.label15);
            this.tabPageSettings.Controls.Add(this.checkBox_inviterEnabled);
            this.tabPageSettings.Controls.Add(this.numericUpDown_chatsDelay);
            this.tabPageSettings.Controls.Add(this.numericUpDown_autoansDelay);
            this.tabPageSettings.Controls.Add(this.label9);
            this.tabPageSettings.Controls.Add(this.checkBox_chatsEnabled);
            this.tabPageSettings.Controls.Add(this.label7);
            this.tabPageSettings.Controls.Add(this.checkBox_autoansEnabled);
            this.tabPageSettings.Controls.Add(this.label6);
            this.tabPageSettings.Controls.Add(this.checkBox_flooderEnabled);
            this.tabPageSettings.Controls.Add(this.numericUpDown_flooderDelay);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(686, 400);
            this.tabPageSettings.TabIndex = 8;
            this.tabPageSettings.Text = "Настройки";
            // 
            // button_updater
            // 
            this.button_updater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updater.Location = new System.Drawing.Point(247, 369);
            this.button_updater.Name = "button_updater";
            this.button_updater.Size = new System.Drawing.Size(194, 23);
            this.button_updater.TabIndex = 49;
            this.button_updater.Text = "Вышло обновление. Обновить?";
            this.button_updater.UseVisualStyleBackColor = true;
            this.button_updater.Visible = false;
            this.button_updater.Click += new System.EventHandler(this.button_updater_Click);
            // 
            // button_telegramChannel
            // 
            this.button_telegramChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_telegramChannel.Location = new System.Drawing.Point(7, 369);
            this.button_telegramChannel.Name = "button_telegramChannel";
            this.button_telegramChannel.Size = new System.Drawing.Size(165, 23);
            this.button_telegramChannel.TabIndex = 48;
            this.button_telegramChannel.Text = "Telegram канал проекта";
            this.button_telegramChannel.UseVisualStyleBackColor = true;
            this.button_telegramChannel.Click += new System.EventHandler(this.button_telegramChannel_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(552, 379);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "Включить оптимизацию";
            // 
            // checkBox_optimize
            // 
            this.checkBox_optimize.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_optimize.Location = new System.Drawing.Point(505, 376);
            this.checkBox_optimize.Name = "checkBox_optimize";
            this.checkBox_optimize.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_optimize.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_optimize.Size = new System.Drawing.Size(45, 19);
            this.checkBox_optimize.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.checkBox_optimize.TabIndex = 45;
            this.checkBox_optimize.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.checkBox_optimize_CheckedChanged);
            // 
            // label_workbot
            // 
            this.label_workbot.AutoSize = true;
            this.label_workbot.BackColor = System.Drawing.Color.Transparent;
            this.label_workbot.Location = new System.Drawing.Point(7, 8);
            this.label_workbot.Name = "label_workbot";
            this.label_workbot.Size = new System.Drawing.Size(193, 13);
            this.label_workbot.TabIndex = 43;
            this.label_workbot.Text = "Время работы приложения: 00:00:00";
            // 
            // selectionDelay
            // 
            this.selectionDelay.FormattingEnabled = true;
            this.selectionDelay.Items.AddRange(new object[] {
            "Обычная",
            "Рандомная"});
            this.selectionDelay.Location = new System.Drawing.Point(356, 113);
            this.selectionDelay.Name = "selectionDelay";
            this.selectionDelay.Size = new System.Drawing.Size(112, 21);
            this.selectionDelay.TabIndex = 41;
            this.selectionDelay.SelectedIndexChanged += new System.EventHandler(this.SelectionDelay_SelectedIndexChanged);
            // 
            // numericUpDown_flooderDelayMax
            // 
            this.numericUpDown_flooderDelayMax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_flooderDelayMax.Enabled = false;
            this.numericUpDown_flooderDelayMax.Location = new System.Drawing.Point(415, 140);
            this.numericUpDown_flooderDelayMax.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numericUpDown_flooderDelayMax.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_flooderDelayMax.Name = "numericUpDown_flooderDelayMax";
            this.numericUpDown_flooderDelayMax.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_flooderDelayMax.TabIndex = 40;
            this.numericUpDown_flooderDelayMax.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_flooderDelayMax.ValueChanged += new System.EventHandler(this.NumericUpDown_flooderDelayMax_ValueChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(215, 213);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(56, 13);
            this.label35.TabIndex = 38;
            this.label35.Text = "Инвайтер";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(215, 189);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 13);
            this.label32.TabIndex = 35;
            this.label32.Text = "Беседы";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(215, 166);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(76, 13);
            this.label31.TabIndex = 34;
            this.label31.Text = "Автоответчик";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(215, 143);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 13);
            this.label30.TabIndex = 33;
            this.label30.Text = "Флудер";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // button_resetSettings
            // 
            this.button_resetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetSettings.Location = new System.Drawing.Point(161, 238);
            this.button_resetSettings.Name = "button_resetSettings";
            this.button_resetSettings.Size = new System.Drawing.Size(333, 23);
            this.button_resetSettings.TabIndex = 32;
            this.button_resetSettings.Text = "Стереть все настройки в этом аккаунте";
            this.button_resetSettings.UseVisualStyleBackColor = true;
            this.button_resetSettings.Click += new System.EventHandler(this.Button_resetSettings_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(365, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "интервал работы";
            // 
            // numericUpDown_inviterDelay
            // 
            this.numericUpDown_inviterDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_inviterDelay.Location = new System.Drawing.Point(356, 210);
            this.numericUpDown_inviterDelay.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numericUpDown_inviterDelay.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_inviterDelay.Name = "numericUpDown_inviterDelay";
            this.numericUpDown_inviterDelay.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown_inviterDelay.TabIndex = 26;
            this.numericUpDown_inviterDelay.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_inviterDelay.ValueChanged += new System.EventHandler(this.NumericUpDown_antikickDelay_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(471, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "мс";
            // 
            // checkBox_inviterEnabled
            // 
            this.checkBox_inviterEnabled.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_inviterEnabled.Location = new System.Drawing.Point(167, 211);
            this.checkBox_inviterEnabled.Name = "checkBox_inviterEnabled";
            this.checkBox_inviterEnabled.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_inviterEnabled.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_inviterEnabled.Size = new System.Drawing.Size(45, 19);
            this.checkBox_inviterEnabled.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.checkBox_inviterEnabled.TabIndex = 23;
            this.checkBox_inviterEnabled.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.CheckBox_antikickEnabled_CheckedChanged);
            // 
            // numericUpDown_chatsDelay
            // 
            this.numericUpDown_chatsDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_chatsDelay.Location = new System.Drawing.Point(356, 186);
            this.numericUpDown_chatsDelay.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numericUpDown_chatsDelay.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_chatsDelay.Name = "numericUpDown_chatsDelay";
            this.numericUpDown_chatsDelay.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown_chatsDelay.TabIndex = 17;
            this.numericUpDown_chatsDelay.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_chatsDelay.ValueChanged += new System.EventHandler(this.NumericUpDown_chatsDelay_ValueChanged);
            // 
            // numericUpDown_autoansDelay
            // 
            this.numericUpDown_autoansDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_autoansDelay.Location = new System.Drawing.Point(356, 163);
            this.numericUpDown_autoansDelay.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numericUpDown_autoansDelay.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_autoansDelay.Name = "numericUpDown_autoansDelay";
            this.numericUpDown_autoansDelay.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown_autoansDelay.TabIndex = 16;
            this.numericUpDown_autoansDelay.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_autoansDelay.ValueChanged += new System.EventHandler(this.NumericUpDown_autoansDelay_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(471, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "мс";
            // 
            // checkBox_chatsEnabled
            // 
            this.checkBox_chatsEnabled.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_chatsEnabled.Location = new System.Drawing.Point(167, 187);
            this.checkBox_chatsEnabled.Name = "checkBox_chatsEnabled";
            this.checkBox_chatsEnabled.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_chatsEnabled.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_chatsEnabled.Size = new System.Drawing.Size(45, 19);
            this.checkBox_chatsEnabled.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.checkBox_chatsEnabled.TabIndex = 9;
            this.checkBox_chatsEnabled.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.CheckBox_chatsEnabled_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(471, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "мс";
            // 
            // checkBox_autoansEnabled
            // 
            this.checkBox_autoansEnabled.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_autoansEnabled.Location = new System.Drawing.Point(167, 164);
            this.checkBox_autoansEnabled.Name = "checkBox_autoansEnabled";
            this.checkBox_autoansEnabled.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_autoansEnabled.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_autoansEnabled.Size = new System.Drawing.Size(45, 19);
            this.checkBox_autoansEnabled.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.checkBox_autoansEnabled.TabIndex = 5;
            this.checkBox_autoansEnabled.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.CheckBox_autoansEnabled_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(471, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "мс";
            // 
            // checkBox_flooderEnabled
            // 
            this.checkBox_flooderEnabled.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_flooderEnabled.Location = new System.Drawing.Point(167, 141);
            this.checkBox_flooderEnabled.Name = "checkBox_flooderEnabled";
            this.checkBox_flooderEnabled.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_flooderEnabled.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_flooderEnabled.Size = new System.Drawing.Size(45, 19);
            this.checkBox_flooderEnabled.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.checkBox_flooderEnabled.TabIndex = 1;
            this.checkBox_flooderEnabled.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.CheckBox_flooderEnabled_CheckedChanged);
            // 
            // numericUpDown_flooderDelay
            // 
            this.numericUpDown_flooderDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_flooderDelay.Location = new System.Drawing.Point(356, 140);
            this.numericUpDown_flooderDelay.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numericUpDown_flooderDelay.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_flooderDelay.Name = "numericUpDown_flooderDelay";
            this.numericUpDown_flooderDelay.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_flooderDelay.TabIndex = 0;
            this.numericUpDown_flooderDelay.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_flooderDelay.ValueChanged += new System.EventHandler(this.NumericUpDown_flooderDelay_ValueChanged);
            // 
            // tabPageFlooder
            // 
            this.tabPageFlooder.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPageFlooder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageFlooder.Controls.Add(this.comboBox_flooderStickerId);
            this.tabPageFlooder.Controls.Add(this.label29);
            this.tabPageFlooder.Controls.Add(this.comboBox_flooderStickerFile);
            this.tabPageFlooder.Controls.Add(this.label28);
            this.tabPageFlooder.Controls.Add(this.comboBox_flooderPhrasesWithDotsSource);
            this.tabPageFlooder.Controls.Add(this.label27);
            this.tabPageFlooder.Controls.Add(this.comboBox_flooderPhrasesSource);
            this.tabPageFlooder.Controls.Add(this.label4);
            this.tabPageFlooder.Controls.Add(this.comboBox_flooderPictureSource);
            this.tabPageFlooder.Controls.Add(this.label3);
            this.tabPageFlooder.Controls.Add(this.button_flooderChange);
            this.tabPageFlooder.Controls.Add(this.button_flooderRemove);
            this.tabPageFlooder.Controls.Add(this.button_flooderAdd);
            this.tabPageFlooder.Controls.Add(this.dataGridView_flooderEditable);
            this.tabPageFlooder.Controls.Add(this.dataGridView_flooderView);
            this.tabPageFlooder.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlooder.Name = "tabPageFlooder";
            this.tabPageFlooder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlooder.Size = new System.Drawing.Size(686, 400);
            this.tabPageFlooder.TabIndex = 0;
            this.tabPageFlooder.Text = "Флудер";
            // 
            // comboBox_flooderStickerId
            // 
            this.comboBox_flooderStickerId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_flooderStickerId.FormattingEnabled = true;
            this.comboBox_flooderStickerId.Location = new System.Drawing.Point(579, 19);
            this.comboBox_flooderStickerId.Name = "comboBox_flooderStickerId";
            this.comboBox_flooderStickerId.Size = new System.Drawing.Size(90, 21);
            this.comboBox_flooderStickerId.TabIndex = 32;
            this.comboBox_flooderStickerId.SelectedIndexChanged += new System.EventHandler(this.ComboBox_flooderStickerId_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(596, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(54, 13);
            this.label29.TabIndex = 31;
            this.label29.Text = "Стикер id";
            // 
            // comboBox_flooderStickerFile
            // 
            this.comboBox_flooderStickerFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_flooderStickerFile.FormattingEnabled = true;
            this.comboBox_flooderStickerFile.Location = new System.Drawing.Point(451, 19);
            this.comboBox_flooderStickerFile.Name = "comboBox_flooderStickerFile";
            this.comboBox_flooderStickerFile.Size = new System.Drawing.Size(122, 21);
            this.comboBox_flooderStickerFile.TabIndex = 30;
            this.comboBox_flooderStickerFile.SelectedIndexChanged += new System.EventHandler(this.ComboBox_flooderStickerFile_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(458, 3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(109, 13);
            this.label28.TabIndex = 29;
            this.label28.Text = "Файл со стикерами";
            // 
            // comboBox_flooderPhrasesWithDotsSource
            // 
            this.comboBox_flooderPhrasesWithDotsSource.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_flooderPhrasesWithDotsSource.FormattingEnabled = true;
            this.comboBox_flooderPhrasesWithDotsSource.Location = new System.Drawing.Point(293, 19);
            this.comboBox_flooderPhrasesWithDotsSource.Name = "comboBox_flooderPhrasesWithDotsSource";
            this.comboBox_flooderPhrasesWithDotsSource.Size = new System.Drawing.Size(152, 21);
            this.comboBox_flooderPhrasesWithDotsSource.TabIndex = 28;
            this.comboBox_flooderPhrasesWithDotsSource.SelectedIndexChanged += new System.EventHandler(this.ComboBox_flooderPhrasesWithDotsSource_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(317, 3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(105, 13);
            this.label27.TabIndex = 27;
            this.label27.Text = "Источник фраз с ...";
            // 
            // comboBox_flooderPhrasesSource
            // 
            this.comboBox_flooderPhrasesSource.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_flooderPhrasesSource.FormattingEnabled = true;
            this.comboBox_flooderPhrasesSource.Location = new System.Drawing.Point(134, 19);
            this.comboBox_flooderPhrasesSource.Name = "comboBox_flooderPhrasesSource";
            this.comboBox_flooderPhrasesSource.Size = new System.Drawing.Size(152, 21);
            this.comboBox_flooderPhrasesSource.TabIndex = 26;
            this.comboBox_flooderPhrasesSource.SelectedIndexChanged += new System.EventHandler(this.ComboBox_flooderPhrasesSource_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(168, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Источник фраз";
            // 
            // comboBox_flooderPictureSource
            // 
            this.comboBox_flooderPictureSource.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_flooderPictureSource.FormattingEnabled = true;
            this.comboBox_flooderPictureSource.Items.AddRange(new object[] {
            "images.txt (общий)",
            "Папка Upload\\Images"});
            this.comboBox_flooderPictureSource.Location = new System.Drawing.Point(7, 19);
            this.comboBox_flooderPictureSource.Name = "comboBox_flooderPictureSource";
            this.comboBox_flooderPictureSource.Size = new System.Drawing.Size(121, 21);
            this.comboBox_flooderPictureSource.TabIndex = 24;
            this.comboBox_flooderPictureSource.Text = "images.txt (общий)";
            this.comboBox_flooderPictureSource.SelectedIndexChanged += new System.EventHandler(this.ComboBox_flooderPictureSource_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Источник картинок";
            // 
            // button_flooderChange
            // 
            this.button_flooderChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_flooderChange.Location = new System.Drawing.Point(221, 369);
            this.button_flooderChange.Name = "button_flooderChange";
            this.button_flooderChange.Size = new System.Drawing.Size(224, 26);
            this.button_flooderChange.TabIndex = 22;
            this.button_flooderChange.Text = "Изменить";
            this.button_flooderChange.UseVisualStyleBackColor = true;
            this.button_flooderChange.Click += new System.EventHandler(this.Button_flooderChange_Click);
            // 
            // button_flooderRemove
            // 
            this.button_flooderRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_flooderRemove.Location = new System.Drawing.Point(451, 369);
            this.button_flooderRemove.Name = "button_flooderRemove";
            this.button_flooderRemove.Size = new System.Drawing.Size(218, 26);
            this.button_flooderRemove.TabIndex = 21;
            this.button_flooderRemove.Text = "Удалить";
            this.button_flooderRemove.UseVisualStyleBackColor = true;
            this.button_flooderRemove.Click += new System.EventHandler(this.Button_flooderRemove_Click);
            // 
            // button_flooderAdd
            // 
            this.button_flooderAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_flooderAdd.Location = new System.Drawing.Point(7, 369);
            this.button_flooderAdd.Name = "button_flooderAdd";
            this.button_flooderAdd.Size = new System.Drawing.Size(208, 26);
            this.button_flooderAdd.TabIndex = 20;
            this.button_flooderAdd.Text = "Добавить";
            this.button_flooderAdd.UseVisualStyleBackColor = true;
            this.button_flooderAdd.Click += new System.EventHandler(this.Button_flooderAdd_Click);
            // 
            // dataGridView_flooderEditable
            // 
            this.dataGridView_flooderEditable.AllowUserToAddRows = false;
            this.dataGridView_flooderEditable.AllowUserToDeleteRows = false;
            this.dataGridView_flooderEditable.AllowUserToResizeColumns = false;
            this.dataGridView_flooderEditable.AllowUserToResizeRows = false;
            this.dataGridView_flooderEditable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_flooderEditable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewComboBoxColumn2});
            this.dataGridView_flooderEditable.Location = new System.Drawing.Point(7, 303);
            this.dataGridView_flooderEditable.MultiSelect = false;
            this.dataGridView_flooderEditable.Name = "dataGridView_flooderEditable";
            this.dataGridView_flooderEditable.RowHeadersVisible = false;
            this.dataGridView_flooderEditable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_flooderEditable.Size = new System.Drawing.Size(662, 60);
            this.dataGridView_flooderEditable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Ссылка на цель";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 184;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Расположение обращения";
            this.dataGridViewComboBoxColumn1.Items.AddRange(new object[] {
            "Начало",
            "Конец",
            "Вместо ...",
            "В начале и в конце (через :)"});
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Width = 165;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Обращение";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 155;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.HeaderText = "Содержимое";
            this.dataGridViewComboBoxColumn2.Items.AddRange(new object[] {
            "Текст",
            "Изображение",
            "Изображение+текст",
            "Голосовое сообщение",
            "Стикер",
            "Текст+стикер",
            "Видеозапись",
            "Видеозапись+текст",
            "Аудиозапись+текст",
            "Аудиозапись+текст+картинка",
            "Аудиозапись+картинка",
            "Документ+текст",
            "damn.ru"});
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Width = 155;
            // 
            // dataGridView_flooderView
            // 
            this.dataGridView_flooderView.AllowUserToAddRows = false;
            this.dataGridView_flooderView.AllowUserToDeleteRows = false;
            this.dataGridView_flooderView.AllowUserToResizeColumns = false;
            this.dataGridView_flooderView.AllowUserToResizeRows = false;
            this.dataGridView_flooderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_flooderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_flooderView.Location = new System.Drawing.Point(7, 46);
            this.dataGridView_flooderView.MultiSelect = false;
            this.dataGridView_flooderView.Name = "dataGridView_flooderView";
            this.dataGridView_flooderView.ReadOnly = true;
            this.dataGridView_flooderView.RowHeadersVisible = false;
            this.dataGridView_flooderView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_flooderView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_flooderView.Size = new System.Drawing.Size(662, 251);
            this.dataGridView_flooderView.TabIndex = 0;
            this.dataGridView_flooderView.SelectionChanged += new System.EventHandler(this.DataGridView_flooderView_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ссылка на цель";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 165;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Расположение обращения";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 165;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Обращение";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 155;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Содержимое";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 155;
            // 
            // tabPageAnswer
            // 
            this.tabPageAnswer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPageAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageAnswer.Controls.Add(this.comboBox_autoansStickerId);
            this.tabPageAnswer.Controls.Add(this.label34);
            this.tabPageAnswer.Controls.Add(this.comboBox_autoansStickerFile);
            this.tabPageAnswer.Controls.Add(this.label38);
            this.tabPageAnswer.Controls.Add(this.comboBox_autoansPhrasesSource);
            this.tabPageAnswer.Controls.Add(this.label23);
            this.tabPageAnswer.Controls.Add(this.button_autoansChange);
            this.tabPageAnswer.Controls.Add(this.button_autoansRemove);
            this.tabPageAnswer.Controls.Add(this.button_autoansAdd);
            this.tabPageAnswer.Controls.Add(this.dataGridView_autoansEditable);
            this.tabPageAnswer.Controls.Add(this.dataGridView_autoansView);
            this.tabPageAnswer.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnswer.Name = "tabPageAnswer";
            this.tabPageAnswer.Size = new System.Drawing.Size(686, 400);
            this.tabPageAnswer.TabIndex = 1;
            this.tabPageAnswer.Text = "Автоответчик";
            // 
            // comboBox_autoansStickerId
            // 
            this.comboBox_autoansStickerId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_autoansStickerId.FormattingEnabled = true;
            this.comboBox_autoansStickerId.Location = new System.Drawing.Point(414, 19);
            this.comboBox_autoansStickerId.Name = "comboBox_autoansStickerId";
            this.comboBox_autoansStickerId.Size = new System.Drawing.Size(90, 21);
            this.comboBox_autoansStickerId.TabIndex = 50;
            this.comboBox_autoansStickerId.SelectedIndexChanged += new System.EventHandler(this.comboBox_autoansStickerId_SelectedIndexChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(431, 3);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(54, 13);
            this.label34.TabIndex = 49;
            this.label34.Text = "Стикер id";
            // 
            // comboBox_autoansStickerFile
            // 
            this.comboBox_autoansStickerFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_autoansStickerFile.FormattingEnabled = true;
            this.comboBox_autoansStickerFile.Location = new System.Drawing.Point(286, 19);
            this.comboBox_autoansStickerFile.Name = "comboBox_autoansStickerFile";
            this.comboBox_autoansStickerFile.Size = new System.Drawing.Size(122, 21);
            this.comboBox_autoansStickerFile.TabIndex = 48;
            this.comboBox_autoansStickerFile.SelectedIndexChanged += new System.EventHandler(this.comboBox_autoansStickerFile_SelectedIndexChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(293, 3);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(109, 13);
            this.label38.TabIndex = 47;
            this.label38.Text = "Файл со стикерами";
            // 
            // comboBox_autoansPhrasesSource
            // 
            this.comboBox_autoansPhrasesSource.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_autoansPhrasesSource.FormattingEnabled = true;
            this.comboBox_autoansPhrasesSource.Location = new System.Drawing.Point(128, 19);
            this.comboBox_autoansPhrasesSource.Name = "comboBox_autoansPhrasesSource";
            this.comboBox_autoansPhrasesSource.Size = new System.Drawing.Size(152, 21);
            this.comboBox_autoansPhrasesSource.TabIndex = 44;
            this.comboBox_autoansPhrasesSource.SelectedIndexChanged += new System.EventHandler(this.comboBox_autoansPhrasesSource_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(161, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "Источник фраз";
            // 
            // button_autoansChange
            // 
            this.button_autoansChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_autoansChange.Location = new System.Drawing.Point(221, 369);
            this.button_autoansChange.Name = "button_autoansChange";
            this.button_autoansChange.Size = new System.Drawing.Size(224, 26);
            this.button_autoansChange.TabIndex = 22;
            this.button_autoansChange.Text = "Изменить";
            this.button_autoansChange.UseVisualStyleBackColor = true;
            this.button_autoansChange.Click += new System.EventHandler(this.button_autoansChange_Click);
            // 
            // button_autoansRemove
            // 
            this.button_autoansRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_autoansRemove.Location = new System.Drawing.Point(451, 369);
            this.button_autoansRemove.Name = "button_autoansRemove";
            this.button_autoansRemove.Size = new System.Drawing.Size(218, 26);
            this.button_autoansRemove.TabIndex = 21;
            this.button_autoansRemove.Text = "Удалить";
            this.button_autoansRemove.UseVisualStyleBackColor = true;
            this.button_autoansRemove.Click += new System.EventHandler(this.button_autoansRemove_Click);
            // 
            // button_autoansAdd
            // 
            this.button_autoansAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_autoansAdd.Location = new System.Drawing.Point(7, 369);
            this.button_autoansAdd.Name = "button_autoansAdd";
            this.button_autoansAdd.Size = new System.Drawing.Size(208, 26);
            this.button_autoansAdd.TabIndex = 20;
            this.button_autoansAdd.Text = "Добавить";
            this.button_autoansAdd.UseVisualStyleBackColor = true;
            this.button_autoansAdd.Click += new System.EventHandler(this.Button7_Click);
            // 
            // dataGridView_autoansEditable
            // 
            this.dataGridView_autoansEditable.AllowUserToAddRows = false;
            this.dataGridView_autoansEditable.AllowUserToDeleteRows = false;
            this.dataGridView_autoansEditable.AllowUserToResizeColumns = false;
            this.dataGridView_autoansEditable.AllowUserToResizeRows = false;
            this.dataGridView_autoansEditable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_autoansEditable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewComboBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewComboBoxColumn4});
            this.dataGridView_autoansEditable.Location = new System.Drawing.Point(7, 303);
            this.dataGridView_autoansEditable.MultiSelect = false;
            this.dataGridView_autoansEditable.Name = "dataGridView_autoansEditable";
            this.dataGridView_autoansEditable.RowHeadersVisible = false;
            this.dataGridView_autoansEditable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_autoansEditable.Size = new System.Drawing.Size(662, 60);
            this.dataGridView_autoansEditable.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ссылка на цель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 165;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.HeaderText = "Расположение обращения";
            this.dataGridViewComboBoxColumn3.Items.AddRange(new object[] {
            "Начало",
            "Конец",
            "Вместо ...",
            "В начале и в конце (через :)"});
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Width = 164;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Обращение";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 165;
            // 
            // dataGridViewComboBoxColumn4
            // 
            this.dataGridViewComboBoxColumn4.HeaderText = "Содержимое";
            this.dataGridViewComboBoxColumn4.Items.AddRange(new object[] {
            "Текст",
            "Текст+стикер",
            "Текст-ссылка",
            "Изображение",
            "Изображение+текст",
            "Видеозапись",
            "Аудиозапись+текст",
            "Аудиозапись+текст+картинка",
            "Аудиозапись+картинка"});
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.Width = 165;
            // 
            // dataGridView_autoansView
            // 
            this.dataGridView_autoansView.AllowUserToAddRows = false;
            this.dataGridView_autoansView.AllowUserToDeleteRows = false;
            this.dataGridView_autoansView.AllowUserToResizeColumns = false;
            this.dataGridView_autoansView.AllowUserToResizeRows = false;
            this.dataGridView_autoansView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_autoansView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewComboBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewComboBoxColumn6});
            this.dataGridView_autoansView.Location = new System.Drawing.Point(7, 46);
            this.dataGridView_autoansView.MultiSelect = false;
            this.dataGridView_autoansView.Name = "dataGridView_autoansView";
            this.dataGridView_autoansView.ReadOnly = true;
            this.dataGridView_autoansView.RowHeadersVisible = false;
            this.dataGridView_autoansView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_autoansView.Size = new System.Drawing.Size(662, 251);
            this.dataGridView_autoansView.TabIndex = 5;
            this.dataGridView_autoansView.SelectionChanged += new System.EventHandler(this.dataGridView_autoansView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ссылка на цель";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 165;
            // 
            // dataGridViewComboBoxColumn5
            // 
            this.dataGridViewComboBoxColumn5.HeaderText = "Расположение обращения";
            this.dataGridViewComboBoxColumn5.Items.AddRange(new object[] {
            "Начало",
            "Конец",
            "Вместо ...",
            "В начале и в конце (через :)"});
            this.dataGridViewComboBoxColumn5.Name = "dataGridViewComboBoxColumn5";
            this.dataGridViewComboBoxColumn5.ReadOnly = true;
            this.dataGridViewComboBoxColumn5.Width = 164;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Обращение";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 165;
            // 
            // dataGridViewComboBoxColumn6
            // 
            this.dataGridViewComboBoxColumn6.HeaderText = "Содержимое";
            this.dataGridViewComboBoxColumn6.Items.AddRange(new object[] {
            "Текст",
            "Текст+стикер",
            "Текст-ссылка",
            "Изображение",
            "Изображение+текст",
            "Видеозапись",
            "Аудиозапись+текст",
            "Аудиозапись+текст+картинка",
            "Аудиозапись+картинка"});
            this.dataGridViewComboBoxColumn6.Name = "dataGridViewComboBoxColumn6";
            this.dataGridViewComboBoxColumn6.ReadOnly = true;
            this.dataGridViewComboBoxColumn6.Width = 165;
            // 
            // tabPageConversations
            // 
            this.tabPageConversations.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPageConversations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageConversations.Controls.Add(this.button_chatsChange);
            this.tabPageConversations.Controls.Add(this.button_chatsRemove);
            this.tabPageConversations.Controls.Add(this.button_chatsAdd);
            this.tabPageConversations.Controls.Add(this.dataGridView_chatsEditable);
            this.tabPageConversations.Controls.Add(this.dataGridView_chatsView);
            this.tabPageConversations.Location = new System.Drawing.Point(4, 22);
            this.tabPageConversations.Name = "tabPageConversations";
            this.tabPageConversations.Size = new System.Drawing.Size(686, 400);
            this.tabPageConversations.TabIndex = 2;
            this.tabPageConversations.Text = "Беседы";
            // 
            // button_chatsChange
            // 
            this.button_chatsChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chatsChange.Location = new System.Drawing.Point(221, 369);
            this.button_chatsChange.Name = "button_chatsChange";
            this.button_chatsChange.Size = new System.Drawing.Size(224, 26);
            this.button_chatsChange.TabIndex = 22;
            this.button_chatsChange.Text = "Изменить";
            this.button_chatsChange.UseVisualStyleBackColor = true;
            this.button_chatsChange.Click += new System.EventHandler(this.Button_chatsChange_Click);
            // 
            // button_chatsRemove
            // 
            this.button_chatsRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chatsRemove.Location = new System.Drawing.Point(451, 369);
            this.button_chatsRemove.Name = "button_chatsRemove";
            this.button_chatsRemove.Size = new System.Drawing.Size(218, 26);
            this.button_chatsRemove.TabIndex = 21;
            this.button_chatsRemove.Text = "Удалить";
            this.button_chatsRemove.UseVisualStyleBackColor = true;
            this.button_chatsRemove.Click += new System.EventHandler(this.Button_chatsRemove_Click);
            // 
            // button_chatsAdd
            // 
            this.button_chatsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chatsAdd.Location = new System.Drawing.Point(7, 369);
            this.button_chatsAdd.Name = "button_chatsAdd";
            this.button_chatsAdd.Size = new System.Drawing.Size(208, 26);
            this.button_chatsAdd.TabIndex = 20;
            this.button_chatsAdd.Text = "Добавить";
            this.button_chatsAdd.UseVisualStyleBackColor = true;
            this.button_chatsAdd.Click += new System.EventHandler(this.Button_chatsAdd_Click);
            // 
            // dataGridView_chatsEditable
            // 
            this.dataGridView_chatsEditable.AllowUserToAddRows = false;
            this.dataGridView_chatsEditable.AllowUserToDeleteRows = false;
            this.dataGridView_chatsEditable.AllowUserToResizeColumns = false;
            this.dataGridView_chatsEditable.AllowUserToResizeRows = false;
            this.dataGridView_chatsEditable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_chatsEditable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewComboBoxColumn7,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewComboBoxColumn8,
            this.dataGridViewCheckBoxColumn2});
            this.dataGridView_chatsEditable.Location = new System.Drawing.Point(7, 285);
            this.dataGridView_chatsEditable.MultiSelect = false;
            this.dataGridView_chatsEditable.Name = "dataGridView_chatsEditable";
            this.dataGridView_chatsEditable.RowHeadersVisible = false;
            this.dataGridView_chatsEditable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_chatsEditable.Size = new System.Drawing.Size(662, 78);
            this.dataGridView_chatsEditable.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Ссылка на беседу";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 132;
            // 
            // dataGridViewComboBoxColumn7
            // 
            this.dataGridViewComboBoxColumn7.HeaderText = "Работа с названием";
            this.dataGridViewComboBoxColumn7.Items.AddRange(new object[] {
            "Ничего не делать",
            "Заменять на ->",
            "Флудить названиями"});
            this.dataGridViewComboBoxColumn7.Name = "dataGridViewComboBoxColumn7";
            this.dataGridViewComboBoxColumn7.Width = 132;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Название";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 132;
            // 
            // dataGridViewComboBoxColumn8
            // 
            this.dataGridViewComboBoxColumn8.HeaderText = "Аватар";
            this.dataGridViewComboBoxColumn8.Items.AddRange(new object[] {
            "Ничего не делать",
            "Удалять"});
            this.dataGridViewComboBoxColumn8.Name = "dataGridViewComboBoxColumn8";
            this.dataGridViewComboBoxColumn8.Width = 132;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "Флудить сменой аватара";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 131;
            // 
            // dataGridView_chatsView
            // 
            this.dataGridView_chatsView.AllowUserToAddRows = false;
            this.dataGridView_chatsView.AllowUserToDeleteRows = false;
            this.dataGridView_chatsView.AllowUserToResizeColumns = false;
            this.dataGridView_chatsView.AllowUserToResizeRows = false;
            this.dataGridView_chatsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_chatsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewComboBoxColumn9,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewComboBoxColumn10,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView_chatsView.Location = new System.Drawing.Point(7, 6);
            this.dataGridView_chatsView.MultiSelect = false;
            this.dataGridView_chatsView.Name = "dataGridView_chatsView";
            this.dataGridView_chatsView.ReadOnly = true;
            this.dataGridView_chatsView.RowHeadersVisible = false;
            this.dataGridView_chatsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_chatsView.Size = new System.Drawing.Size(662, 273);
            this.dataGridView_chatsView.TabIndex = 10;
            this.dataGridView_chatsView.SelectionChanged += new System.EventHandler(this.DataGridView_chatsView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Ссылка на беседу";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 132;
            // 
            // dataGridViewComboBoxColumn9
            // 
            this.dataGridViewComboBoxColumn9.HeaderText = "Работа с названием";
            this.dataGridViewComboBoxColumn9.Name = "dataGridViewComboBoxColumn9";
            this.dataGridViewComboBoxColumn9.ReadOnly = true;
            this.dataGridViewComboBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewComboBoxColumn9.Width = 132;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Название";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 132;
            // 
            // dataGridViewComboBoxColumn10
            // 
            this.dataGridViewComboBoxColumn10.HeaderText = "Аватар";
            this.dataGridViewComboBoxColumn10.Name = "dataGridViewComboBoxColumn10";
            this.dataGridViewComboBoxColumn10.ReadOnly = true;
            this.dataGridViewComboBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewComboBoxColumn10.Width = 132;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Флудить сменой аватара";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 131;
            // 
            // tabPageVoice
            // 
            this.tabPageVoice.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPageVoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageVoice.Controls.Add(this.label18);
            this.tabPageVoice.Controls.Add(this.checkBox_enabledToCustomAudio);
            this.tabPageVoice.Controls.Add(this.button_SelectAudioAndSend);
            this.tabPageVoice.Controls.Add(this.label11);
            this.tabPageVoice.Controls.Add(this.label13);
            this.tabPageVoice.Controls.Add(this.linkLabel1);
            this.tabPageVoice.Controls.Add(this.label16);
            this.tabPageVoice.Controls.Add(this.textBox_yandexKeyVO);
            this.tabPageVoice.Controls.Add(this.button_sendVO);
            this.tabPageVoice.Controls.Add(this.numericUpDown_speedVO);
            this.tabPageVoice.Controls.Add(this.label8);
            this.tabPageVoice.Controls.Add(this.comboBox_emotionVO);
            this.tabPageVoice.Controls.Add(this.label14);
            this.tabPageVoice.Controls.Add(this.comboBox_voiceVO);
            this.tabPageVoice.Controls.Add(this.label10);
            this.tabPageVoice.Controls.Add(this.label12);
            this.tabPageVoice.Controls.Add(this.textBox_targetVO);
            this.tabPageVoice.Controls.Add(this.richTextBox_messageVO);
            this.tabPageVoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageVoice.Location = new System.Drawing.Point(4, 22);
            this.tabPageVoice.Name = "tabPageVoice";
            this.tabPageVoice.Size = new System.Drawing.Size(686, 400);
            this.tabPageVoice.TabIndex = 4;
            this.tabPageVoice.Text = "Голосовые сообщения";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(181, 295);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(234, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Преобразовать аудио в голосовое сообение";
            // 
            // checkBox_enabledToCustomAudio
            // 
            this.checkBox_enabledToCustomAudio.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_enabledToCustomAudio.Location = new System.Drawing.Point(133, 293);
            this.checkBox_enabledToCustomAudio.Name = "checkBox_enabledToCustomAudio";
            this.checkBox_enabledToCustomAudio.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_enabledToCustomAudio.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_enabledToCustomAudio.Size = new System.Drawing.Size(45, 19);
            this.checkBox_enabledToCustomAudio.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.checkBox_enabledToCustomAudio.TabIndex = 34;
            this.checkBox_enabledToCustomAudio.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.checkBox_enabledToCustomAudio_CheckedChanged);
            // 
            // button_SelectAudioAndSend
            // 
            this.button_SelectAudioAndSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SelectAudioAndSend.Location = new System.Drawing.Point(345, 261);
            this.button_SelectAudioAndSend.Name = "button_SelectAudioAndSend";
            this.button_SelectAudioAndSend.Size = new System.Drawing.Size(210, 26);
            this.button_SelectAudioAndSend.TabIndex = 27;
            this.button_SelectAudioAndSend.Text = "Выбрать аудио и отправить";
            this.button_SelectAudioAndSend.UseVisualStyleBackColor = true;
            this.button_SelectAudioAndSend.Click += new System.EventHandler(this.button_SelectAudioAndSend_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(7, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Текст сообщения";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Не более 1000 преобразований в сутки";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(450, 384);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(237, 13);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Использует сервис \"Yandex SpeechKit Cloud\"";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(456, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Yandex speech kit api ключ";
            // 
            // textBox_yandexKeyVO
            // 
            this.textBox_yandexKeyVO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_yandexKeyVO.Location = new System.Drawing.Point(459, 235);
            this.textBox_yandexKeyVO.Name = "textBox_yandexKeyVO";
            this.textBox_yandexKeyVO.Size = new System.Drawing.Size(210, 20);
            this.textBox_yandexKeyVO.TabIndex = 21;
            this.textBox_yandexKeyVO.TextChanged += new System.EventHandler(this.TextBox_yandexKeyVO_TextChanged);
            // 
            // button_sendVO
            // 
            this.button_sendVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sendVO.Location = new System.Drawing.Point(133, 261);
            this.button_sendVO.Name = "button_sendVO";
            this.button_sendVO.Size = new System.Drawing.Size(210, 26);
            this.button_sendVO.TabIndex = 20;
            this.button_sendVO.Text = "Отправить";
            this.button_sendVO.UseVisualStyleBackColor = true;
            this.button_sendVO.Click += new System.EventHandler(this.Button_sendVO_Click);
            // 
            // numericUpDown_speedVO
            // 
            this.numericUpDown_speedVO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_speedVO.Location = new System.Drawing.Point(311, 234);
            this.numericUpDown_speedVO.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_speedVO.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_speedVO.Name = "numericUpDown_speedVO";
            this.numericUpDown_speedVO.Size = new System.Drawing.Size(142, 20);
            this.numericUpDown_speedVO.TabIndex = 19;
            this.numericUpDown_speedVO.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_speedVO.ValueChanged += new System.EventHandler(this.NumericUpDown_speedVO_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(308, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Скорость речи 1..30";
            // 
            // comboBox_emotionVO
            // 
            this.comboBox_emotionVO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_emotionVO.FormattingEnabled = true;
            this.comboBox_emotionVO.Items.AddRange(new object[] {
            "neutral",
            "good",
            "evil"});
            this.comboBox_emotionVO.Location = new System.Drawing.Point(166, 234);
            this.comboBox_emotionVO.Name = "comboBox_emotionVO";
            this.comboBox_emotionVO.Size = new System.Drawing.Size(139, 21);
            this.comboBox_emotionVO.TabIndex = 17;
            this.comboBox_emotionVO.SelectedIndexChanged += new System.EventHandler(this.ComboBox_emotionVO_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(166, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Эмоция";
            // 
            // comboBox_voiceVO
            // 
            this.comboBox_voiceVO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_voiceVO.FormattingEnabled = true;
            this.comboBox_voiceVO.Items.AddRange(new object[] {
            "zahar",
            "ermil",
            "jane",
            "oksana",
            "alyss",
            "omazh"});
            this.comboBox_voiceVO.Location = new System.Drawing.Point(7, 234);
            this.comboBox_voiceVO.Name = "comboBox_voiceVO";
            this.comboBox_voiceVO.Size = new System.Drawing.Size(153, 21);
            this.comboBox_voiceVO.TabIndex = 15;
            this.comboBox_voiceVO.SelectedIndexChanged += new System.EventHandler(this.ComboBox_voiceVO_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(7, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Голос";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(7, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Цель (лс/чат)";
            // 
            // textBox_targetVO
            // 
            this.textBox_targetVO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_targetVO.Location = new System.Drawing.Point(7, 195);
            this.textBox_targetVO.Name = "textBox_targetVO";
            this.textBox_targetVO.Size = new System.Drawing.Size(662, 20);
            this.textBox_targetVO.TabIndex = 12;
            // 
            // richTextBox_messageVO
            // 
            this.richTextBox_messageVO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox_messageVO.Location = new System.Drawing.Point(7, 22);
            this.richTextBox_messageVO.Name = "richTextBox_messageVO";
            this.richTextBox_messageVO.Size = new System.Drawing.Size(662, 156);
            this.richTextBox_messageVO.TabIndex = 11;
            this.richTextBox_messageVO.Text = "";
            // 
            // tabPagePrivace
            // 
            this.tabPagePrivace.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPagePrivace.Controls.Add(this.groupBox3);
            this.tabPagePrivace.Controls.Add(this.groupBox2);
            this.tabPagePrivace.Controls.Add(this.groupBox1);
            this.tabPagePrivace.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrivace.Name = "tabPagePrivace";
            this.tabPagePrivace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrivace.Size = new System.Drawing.Size(686, 400);
            this.tabPagePrivace.TabIndex = 9;
            this.tabPagePrivace.Text = "Настройки приватности";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_GetConversation);
            this.groupBox3.Controls.Add(this.comboBox_ActivedChat);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(7, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 177);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Чаты";
            // 
            // button_GetConversation
            // 
            this.button_GetConversation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetConversation.Location = new System.Drawing.Point(164, 95);
            this.button_GetConversation.Name = "button_GetConversation";
            this.button_GetConversation.Size = new System.Drawing.Size(330, 23);
            this.button_GetConversation.TabIndex = 2;
            this.button_GetConversation.Text = "Получить";
            this.button_GetConversation.UseVisualStyleBackColor = true;
            this.button_GetConversation.Click += new System.EventHandler(this.button_GetConversation_Click);
            // 
            // comboBox_ActivedChat
            // 
            this.comboBox_ActivedChat.FormattingEnabled = true;
            this.comboBox_ActivedChat.Location = new System.Drawing.Point(164, 68);
            this.comboBox_ActivedChat.Name = "comboBox_ActivedChat";
            this.comboBox_ActivedChat.Size = new System.Drawing.Size(330, 21);
            this.comboBox_ActivedChat.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(262, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Список активных бесед";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label42);
            this.groupBox2.Controls.Add(this.toggleSwitch2);
            this.groupBox2.Controls.Add(this.button_SavePrivacySettings);
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.checkBox_closedProfile);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Location = new System.Drawing.Point(7, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 125);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки приватности";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Только я",
            "Все друзья",
            "Все пользователи"});
            this.comboBox2.Location = new System.Drawing.Point(6, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(172, 21);
            this.comboBox2.TabIndex = 53;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(5, 70);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(107, 13);
            this.label42.TabIndex = 54;
            this.label42.Text = "Выбор ограничения";
            // 
            // toggleSwitch2
            // 
            this.toggleSwitch2.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch2.Location = new System.Drawing.Point(6, 44);
            this.toggleSwitch2.Name = "toggleSwitch2";
            this.toggleSwitch2.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch2.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch2.Size = new System.Drawing.Size(45, 19);
            this.toggleSwitch2.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.toggleSwitch2.TabIndex = 42;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(57, 47);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(155, 13);
            this.label41.TabIndex = 43;
            this.label41.Text = "Запретить импорт контактов";
            // 
            // checkBox_closedProfile
            // 
            this.checkBox_closedProfile.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_closedProfile.Location = new System.Drawing.Point(6, 19);
            this.checkBox_closedProfile.Name = "checkBox_closedProfile";
            this.checkBox_closedProfile.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_closedProfile.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_closedProfile.Size = new System.Drawing.Size(45, 19);
            this.checkBox_closedProfile.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.checkBox_closedProfile.TabIndex = 3;
            this.checkBox_closedProfile.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.checkBox_closedProfile_CheckedChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Location = new System.Drawing.Point(57, 22);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(106, 13);
            this.label40.TabIndex = 41;
            this.label40.Text = "Закрытый профиль";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 73);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные настройки";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(545, 15);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(117, 13);
            this.label39.TabIndex = 52;
            this.label39.Text = "Семейное положение";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(548, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 21);
            this.comboBox1.TabIndex = 51;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(411, 16);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(37, 13);
            this.label36.TabIndex = 50;
            this.label36.Text = "Город";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(414, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 20);
            this.textBox4.TabIndex = 49;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(276, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(49, 13);
            this.label33.TabIndex = 48;
            this.label33.Text = "Возраст";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(279, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 47;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(141, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "Фамилия";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(6, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "Имя";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button_SavePrivacySettings
            // 
            this.button_SavePrivacySettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SavePrivacySettings.Location = new System.Drawing.Point(507, 91);
            this.button_SavePrivacySettings.Name = "button_SavePrivacySettings";
            this.button_SavePrivacySettings.Size = new System.Drawing.Size(158, 23);
            this.button_SavePrivacySettings.TabIndex = 42;
            this.button_SavePrivacySettings.Text = "Применить";
            this.button_SavePrivacySettings.UseVisualStyleBackColor = true;
            this.button_SavePrivacySettings.Click += new System.EventHandler(this.button_SavePrivacySettings_Click);
            // 
            // tabPageOther
            // 
            this.tabPageOther.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPageOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageOther.Controls.Add(this.groupBox4);
            this.tabPageOther.Location = new System.Drawing.Point(4, 22);
            this.tabPageOther.Name = "tabPageOther";
            this.tabPageOther.Size = new System.Drawing.Size(686, 400);
            this.tabPageOther.TabIndex = 3;
            this.tabPageOther.Text = "Прочее";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label45);
            this.groupBox4.Controls.Add(this.toggleSwitch4);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.toggleSwitch3);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Location = new System.Drawing.Point(7, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(671, 121);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вечный онлайн";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(548, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Запустить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(63, 87);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(131, 13);
            this.label45.TabIndex = 46;
            this.label45.Text = "Поддерживать оффлайн";
            // 
            // toggleSwitch4
            // 
            this.toggleSwitch4.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch4.Location = new System.Drawing.Point(12, 83);
            this.toggleSwitch4.Name = "toggleSwitch4";
            this.toggleSwitch4.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch4.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch4.Size = new System.Drawing.Size(45, 19);
            this.toggleSwitch4.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.toggleSwitch4.TabIndex = 45;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(63, 62);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(121, 13);
            this.label44.TabIndex = 44;
            this.label44.Text = "Поддерживать онлайн";
            // 
            // toggleSwitch3
            // 
            this.toggleSwitch3.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch3.Location = new System.Drawing.Point(12, 58);
            this.toggleSwitch3.Name = "toggleSwitch3";
            this.toggleSwitch3.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch3.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch3.Size = new System.Drawing.Size(45, 19);
            this.toggleSwitch3.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.toggleSwitch3.TabIndex = 43;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Location = new System.Drawing.Point(9, 16);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(101, 13);
            this.label43.TabIndex = 42;
            this.label43.Text = "Токен от аккаунта";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(653, 20);
            this.textBox5.TabIndex = 0;
            // 
            // tabPageCheating
            // 
            this.tabPageCheating.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPageCheating.Controls.Add(this.groupBox6);
            this.tabPageCheating.Controls.Add(this.groupBox5);
            this.tabPageCheating.Location = new System.Drawing.Point(4, 22);
            this.tabPageCheating.Name = "tabPageCheating";
            this.tabPageCheating.Size = new System.Drawing.Size(686, 400);
            this.tabPageCheating.TabIndex = 10;
            this.tabPageCheating.Text = "Накрутка";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label53);
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.toggleSwitch9);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.label52);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.label51);
            this.groupBox6.Controls.Add(this.richTextBox2);
            this.groupBox6.Controls.Add(this.label50);
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(7, 213);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(671, 184);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Рассылка в группы";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Location = new System.Drawing.Point(441, 133);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(158, 13);
            this.label53.TabIndex = 50;
            this.label53.Text = "ISB Auto (встроенные группы)";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(394, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(271, 23);
            this.button5.TabIndex = 53;
            this.button5.Text = "Запустить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // toggleSwitch9
            // 
            this.toggleSwitch9.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch9.Location = new System.Drawing.Point(394, 131);
            this.toggleSwitch9.Name = "toggleSwitch9";
            this.toggleSwitch9.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch9.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch9.Size = new System.Drawing.Size(45, 19);
            this.toggleSwitch9.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.toggleSwitch9.TabIndex = 49;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(394, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 23);
            this.button4.TabIndex = 49;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Location = new System.Drawing.Point(396, 31);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(57, 13);
            this.label52.TabIndex = 52;
            this.label52.Text = "ID группы";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(396, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(269, 20);
            this.textBox6.TabIndex = 51;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Location = new System.Drawing.Point(174, 16);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(97, 13);
            this.label51.TabIndex = 50;
            this.label51.Text = "Текст сообщения";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(171, 32);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(219, 146);
            this.richTextBox2.TabIndex = 49;
            this.richTextBox2.Text = "";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Location = new System.Drawing.Point(6, 16);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(33, 13);
            this.label50.TabIndex = 49;
            this.label50.Text = "Цели";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 147);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.label49);
            this.groupBox5.Controls.Add(this.toggleSwitch8);
            this.groupBox5.Controls.Add(this.label48);
            this.groupBox5.Controls.Add(this.toggleSwitch7);
            this.groupBox5.Controls.Add(this.label47);
            this.groupBox5.Controls.Add(this.toggleSwitch6);
            this.groupBox5.Controls.Add(this.label46);
            this.groupBox5.Controls.Add(this.toggleSwitch5);
            this.groupBox5.Controls.Add(this.richTextBox1);
            this.groupBox5.Location = new System.Drawing.Point(7, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(671, 199);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Рассылка";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(548, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 48;
            this.button3.Text = "Разослать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Location = new System.Drawing.Point(198, 170);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(80, 13);
            this.label49.TabIndex = 41;
            this.label49.Text = "Всем друзьям";
            // 
            // toggleSwitch8
            // 
            this.toggleSwitch8.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch8.Location = new System.Drawing.Point(150, 168);
            this.toggleSwitch8.Name = "toggleSwitch8";
            this.toggleSwitch8.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch8.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch8.Size = new System.Drawing.Size(45, 19);
            this.toggleSwitch8.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.toggleSwitch8.TabIndex = 40;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Location = new System.Drawing.Point(198, 145);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(80, 13);
            this.label48.TabIndex = 39;
            this.label48.Text = "Только в чаты";
            // 
            // toggleSwitch7
            // 
            this.toggleSwitch7.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch7.Location = new System.Drawing.Point(150, 143);
            this.toggleSwitch7.Name = "toggleSwitch7";
            this.toggleSwitch7.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch7.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch7.Size = new System.Drawing.Size(45, 19);
            this.toggleSwitch7.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.toggleSwitch7.TabIndex = 38;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(54, 168);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(83, 13);
            this.label47.TabIndex = 37;
            this.label47.Text = "Только онлайн";
            // 
            // toggleSwitch6
            // 
            this.toggleSwitch6.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch6.Location = new System.Drawing.Point(6, 166);
            this.toggleSwitch6.Name = "toggleSwitch6";
            this.toggleSwitch6.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch6.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch6.Size = new System.Drawing.Size(45, 19);
            this.toggleSwitch6.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.toggleSwitch6.TabIndex = 36;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(54, 143);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(90, 13);
            this.label46.TabIndex = 35;
            this.label46.Text = "Только друзьям";
            // 
            // toggleSwitch5
            // 
            this.toggleSwitch5.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch5.Location = new System.Drawing.Point(6, 141);
            this.toggleSwitch5.Name = "toggleSwitch5";
            this.toggleSwitch5.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch5.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toggleSwitch5.Size = new System.Drawing.Size(45, 19);
            this.toggleSwitch5.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.toggleSwitch5.TabIndex = 34;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(659, 113);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage1.Controls.Add(this.label55);
            this.tabPage1.Controls.Add(this.label54);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 400);
            this.tabPage1.TabIndex = 11;
            this.tabPage1.Text = "О проекте";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.Location = new System.Drawing.Point(20, 167);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(665, 208);
            this.label55.TabIndex = 43;
            this.label55.Text = resources.GetString("label55.Text");
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Location = new System.Drawing.Point(289, 140);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(110, 13);
            this.label54.TabIndex = 42;
            this.label54.Text = "Innovation Space Bot";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_log,
            this.toolStripMenuItem_manager,
            this.toolStripMenuItem_help,
            this.toolStripMenuItem_reload});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(695, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem_log
            // 
            this.toolStripMenuItem_log.Name = "toolStripMenuItem_log";
            this.toolStripMenuItem_log.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItem_log.Text = "Лог";
            this.toolStripMenuItem_log.Click += new System.EventHandler(this.ToolStripMenuItem_log_Click);
            // 
            // toolStripMenuItem_manager
            // 
            this.toolStripMenuItem_manager.Name = "toolStripMenuItem_manager";
            this.toolStripMenuItem_manager.Size = new System.Drawing.Size(97, 20);
            this.toolStripMenuItem_manager.Text = "Менеджер .txt";
            this.toolStripMenuItem_manager.Click += new System.EventHandler(this.ToolStripMenuItem_manager_Click);
            // 
            // toolStripMenuItem_help
            // 
            this.toolStripMenuItem_help.Name = "toolStripMenuItem_help";
            this.toolStripMenuItem_help.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem_help.Text = "Премиум";
            this.toolStripMenuItem_help.Click += new System.EventHandler(this.ToolStripMenuItem_help_Click);
            // 
            // toolStripMenuItem_reload
            // 
            this.toolStripMenuItem_reload.Name = "toolStripMenuItem_reload";
            this.toolStripMenuItem_reload.Size = new System.Drawing.Size(145, 20);
            this.toolStripMenuItem_reload.Text = "Перезагрузить контент";
            this.toolStripMenuItem_reload.Click += new System.EventHandler(this.ToolStripMenuItem_reload_Click);
            // 
            // dateTimePicker_timeToStop
            // 
            this.dateTimePicker_timeToStop.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker_timeToStop.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker_timeToStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_timeToStop.Location = new System.Drawing.Point(483, 1);
            this.dateTimePicker_timeToStop.Name = "dateTimePicker_timeToStop";
            this.dateTimePicker_timeToStop.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_timeToStop.TabIndex = 2;
            // 
            // checkBox_shutownOnTime
            // 
            this.checkBox_shutownOnTime.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_shutownOnTime.Location = new System.Drawing.Point(357, 2);
            this.checkBox_shutownOnTime.Name = "checkBox_shutownOnTime";
            this.checkBox_shutownOnTime.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_shutownOnTime.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_shutownOnTime.Size = new System.Drawing.Size(45, 19);
            this.checkBox_shutownOnTime.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.checkBox_shutownOnTime.TabIndex = 3;
            // 
            // comboBox_accountsList
            // 
            this.comboBox_accountsList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_accountsList.FormattingEnabled = true;
            this.comboBox_accountsList.Location = new System.Drawing.Point(123, 542);
            this.comboBox_accountsList.Name = "comboBox_accountsList";
            this.comboBox_accountsList.Size = new System.Drawing.Size(568, 21);
            this.comboBox_accountsList.TabIndex = 17;
            this.comboBox_accountsList.Text = "Загрузка...";
            this.comboBox_accountsList.SelectedIndexChanged += new System.EventHandler(this.ComboBox_accountsList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Выбранный аккаунт:";
            // 
            // textBox_manualCaptchaAnswer
            // 
            this.textBox_manualCaptchaAnswer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_manualCaptchaAnswer.Location = new System.Drawing.Point(560, 86);
            this.textBox_manualCaptchaAnswer.Name = "textBox_manualCaptchaAnswer";
            this.textBox_manualCaptchaAnswer.Size = new System.Drawing.Size(130, 20);
            this.textBox_manualCaptchaAnswer.TabIndex = 12;
            this.textBox_manualCaptchaAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_manualCaptchaAnswer_KeyDown);
            // 
            // radioButton_captchaManual
            // 
            this.radioButton_captchaManual.AutoSize = true;
            this.radioButton_captchaManual.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_captchaManual.Location = new System.Drawing.Point(451, 38);
            this.radioButton_captchaManual.Name = "radioButton_captchaManual";
            this.radioButton_captchaManual.Size = new System.Drawing.Size(66, 17);
            this.radioButton_captchaManual.TabIndex = 13;
            this.radioButton_captchaManual.Text = "вручную";
            this.radioButton_captchaManual.UseVisualStyleBackColor = false;
            this.radioButton_captchaManual.CheckedChanged += new System.EventHandler(this.RadioButton_captchaManual_CheckedChanged);
            // 
            // radioButton_captchaRucap
            // 
            this.radioButton_captchaRucap.AutoSize = true;
            this.radioButton_captchaRucap.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_captchaRucap.Location = new System.Drawing.Point(451, 57);
            this.radioButton_captchaRucap.Name = "radioButton_captchaRucap";
            this.radioButton_captchaRucap.Size = new System.Drawing.Size(96, 17);
            this.radioButton_captchaRucap.TabIndex = 14;
            this.radioButton_captchaRucap.Text = "rucaptcha.com";
            this.radioButton_captchaRucap.UseVisualStyleBackColor = false;
            this.radioButton_captchaRucap.CheckedChanged += new System.EventHandler(this.RadioButton_captchaRucap_CheckedChanged);
            // 
            // radioButton_captchaAnticap
            // 
            this.radioButton_captchaAnticap.AutoSize = true;
            this.radioButton_captchaAnticap.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_captchaAnticap.Location = new System.Drawing.Point(451, 75);
            this.radioButton_captchaAnticap.Name = "radioButton_captchaAnticap";
            this.radioButton_captchaAnticap.Size = new System.Drawing.Size(107, 17);
            this.radioButton_captchaAnticap.TabIndex = 15;
            this.radioButton_captchaAnticap.Text = "anti-captcha.com";
            this.radioButton_captchaAnticap.UseVisualStyleBackColor = false;
            this.radioButton_captchaAnticap.CheckedChanged += new System.EventHandler(this.RadioButton_captchaAnticap_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(448, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Антикапча";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(25, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Старт/стоп";
            // 
            // label_forAll
            // 
            this.label_forAll.AutoSize = true;
            this.label_forAll.BackColor = System.Drawing.Color.Transparent;
            this.label_forAll.Location = new System.Drawing.Point(91, 95);
            this.label_forAll.Name = "label_forAll";
            this.label_forAll.Size = new System.Drawing.Size(86, 13);
            this.label_forAll.TabIndex = 34;
            this.label_forAll.Text = "Для всех: выкл";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(186, 95);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 13);
            this.label24.TabIndex = 35;
            this.label24.Text = "Антикапча";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(261, 95);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 13);
            this.label25.TabIndex = 36;
            this.label25.Text = "Дизайн";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(330, 95);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 13);
            this.label26.TabIndex = 37;
            this.label26.Text = "Доп. боты";
            // 
            // timer_manualCaptcha
            // 
            this.timer_manualCaptcha.Enabled = true;
            this.timer_manualCaptcha.Interval = 1000;
            this.timer_manualCaptcha.Tick += new System.EventHandler(this.Timer_manualCaptcha_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // timer_shutown
            // 
            this.timer_shutown.Enabled = true;
            this.timer_shutown.Interval = 1000;
            this.timer_shutown.Tick += new System.EventHandler(this.Timer_shutown_Tick);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(403, 5);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(76, 13);
            this.label37.TabIndex = 40;
            this.label37.Text = "Остановить в";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            // 
            // button_otherBots
            // 
            this.button_otherBots.BackColor = System.Drawing.Color.Transparent;
            this.button_otherBots.BackgroundImage = global::ISP.Properties.Resources.OtherBots;
            this.button_otherBots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_otherBots.FlatAppearance.BorderSize = 0;
            this.button_otherBots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_otherBots.Location = new System.Drawing.Point(328, 28);
            this.button_otherBots.Name = "button_otherBots";
            this.button_otherBots.Size = new System.Drawing.Size(65, 65);
            this.button_otherBots.TabIndex = 26;
            this.button_otherBots.UseVisualStyleBackColor = false;
            this.button_otherBots.Click += new System.EventHandler(this.Button_otherBots_Click);
            this.button_otherBots.MouseEnter += new System.EventHandler(this.Button_interfaceMouseEnter);
            this.button_otherBots.MouseLeave += new System.EventHandler(this.Button_interfaceMouseLeave);
            // 
            // button_design
            // 
            this.button_design.BackColor = System.Drawing.Color.Transparent;
            this.button_design.BackgroundImage = global::ISP.Properties.Resources.Design;
            this.button_design.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_design.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_design.FlatAppearance.BorderSize = 0;
            this.button_design.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_design.Location = new System.Drawing.Point(252, 28);
            this.button_design.Name = "button_design";
            this.button_design.Size = new System.Drawing.Size(65, 65);
            this.button_design.TabIndex = 21;
            this.button_design.UseVisualStyleBackColor = false;
            this.button_design.Click += new System.EventHandler(this.Button_anticaptchaDesign_Click);
            this.button_design.MouseEnter += new System.EventHandler(this.Button_interfaceMouseEnter);
            this.button_design.MouseLeave += new System.EventHandler(this.Button_interfaceMouseLeave);
            // 
            // button_anticaptchaKeys
            // 
            this.button_anticaptchaKeys.BackColor = System.Drawing.Color.Transparent;
            this.button_anticaptchaKeys.BackgroundImage = global::ISP.Properties.Resources.AnticapKeys;
            this.button_anticaptchaKeys.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_anticaptchaKeys.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_anticaptchaKeys.FlatAppearance.BorderSize = 0;
            this.button_anticaptchaKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anticaptchaKeys.Location = new System.Drawing.Point(176, 28);
            this.button_anticaptchaKeys.Name = "button_anticaptchaKeys";
            this.button_anticaptchaKeys.Size = new System.Drawing.Size(65, 65);
            this.button_anticaptchaKeys.TabIndex = 20;
            this.button_anticaptchaKeys.UseVisualStyleBackColor = false;
            this.button_anticaptchaKeys.Click += new System.EventHandler(this.Button_anticaptchaKeys_Click);
            this.button_anticaptchaKeys.MouseEnter += new System.EventHandler(this.Button_interfaceMouseEnter);
            this.button_anticaptchaKeys.MouseLeave += new System.EventHandler(this.Button_interfaceMouseLeave);
            // 
            // button_applyToAll
            // 
            this.button_applyToAll.BackColor = System.Drawing.Color.Transparent;
            this.button_applyToAll.BackgroundImage = global::ISP.Properties.Resources.ToAll;
            this.button_applyToAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_applyToAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_applyToAll.FlatAppearance.BorderSize = 0;
            this.button_applyToAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_applyToAll.Location = new System.Drawing.Point(100, 28);
            this.button_applyToAll.Name = "button_applyToAll";
            this.button_applyToAll.Size = new System.Drawing.Size(65, 65);
            this.button_applyToAll.TabIndex = 19;
            this.button_applyToAll.UseVisualStyleBackColor = false;
            this.button_applyToAll.Click += new System.EventHandler(this.Button_applyToAll_Click);
            this.button_applyToAll.MouseEnter += new System.EventHandler(this.Button_interfaceMouseEnter);
            this.button_applyToAll.MouseLeave += new System.EventHandler(this.Button_interfaceMouseLeave);
            // 
            // button_startStop
            // 
            this.button_startStop.BackColor = System.Drawing.Color.Transparent;
            this.button_startStop.BackgroundImage = global::ISP.Properties.Resources.Start;
            this.button_startStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_startStop.Enabled = false;
            this.button_startStop.FlatAppearance.BorderSize = 0;
            this.button_startStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_startStop.Location = new System.Drawing.Point(24, 28);
            this.button_startStop.Name = "button_startStop";
            this.button_startStop.Size = new System.Drawing.Size(65, 65);
            this.button_startStop.TabIndex = 0;
            this.button_startStop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_startStop.UseVisualStyleBackColor = false;
            this.button_startStop.Click += new System.EventHandler(this.Button_startStop_Click);
            this.button_startStop.MouseEnter += new System.EventHandler(this.Button_interfaceMouseEnter);
            this.button_startStop.MouseLeave += new System.EventHandler(this.Button_interfaceMouseLeave);
            // 
            // pictureBox_captPic
            // 
            this.pictureBox_captPic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_captPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_captPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_captPic.Location = new System.Drawing.Point(560, 33);
            this.pictureBox_captPic.Name = "pictureBox_captPic";
            this.pictureBox_captPic.Size = new System.Drawing.Size(130, 50);
            this.pictureBox_captPic.TabIndex = 11;
            this.pictureBox_captPic.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_typerBot,
            this.toolStripMenuItem_antikickBot,
            this.toolStrip_AutoTarget,
            this.другиеПроектыToolStripMenuItem});
            this.menuStrip1.Name = "contextMenuStrip_otherBots";
            this.menuStrip1.Size = new System.Drawing.Size(164, 92);
            // 
            // toolStripMenuItem_typerBot
            // 
            this.toolStripMenuItem_typerBot.Name = "toolStripMenuItem_typerBot";
            this.toolStripMenuItem_typerBot.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem_typerBot.Text = "Набор текста";
            this.toolStripMenuItem_typerBot.Click += new System.EventHandler(this.ToolStripMenuItem_typerBot_Click);
            // 
            // toolStripMenuItem_antikickBot
            // 
            this.toolStripMenuItem_antikickBot.Enabled = false;
            this.toolStripMenuItem_antikickBot.Name = "toolStripMenuItem_antikickBot";
            this.toolStripMenuItem_antikickBot.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem_antikickBot.Text = "Антикик";
            this.toolStripMenuItem_antikickBot.Click += new System.EventHandler(this.ToolStripMenuItem_antikickBot_Click);
            // 
            // toolStrip_AutoTarget
            // 
            this.toolStrip_AutoTarget.Name = "toolStrip_AutoTarget";
            this.toolStrip_AutoTarget.Size = new System.Drawing.Size(163, 22);
            this.toolStrip_AutoTarget.Text = "Автоцели";
            this.toolStrip_AutoTarget.Click += new System.EventHandler(this.toolStrip_AutoTarget_Click);
            // 
            // другиеПроектыToolStripMenuItem
            // 
            this.другиеПроектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iSBGroupToolStripMenuItem,
            this.iSBGramToolStripMenuItem,
            this.iSBGPTToolStripMenuItem});
            this.другиеПроектыToolStripMenuItem.Name = "другиеПроектыToolStripMenuItem";
            this.другиеПроектыToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.другиеПроектыToolStripMenuItem.Text = "Другие проекты";
            // 
            // iSBGroupToolStripMenuItem
            // 
            this.iSBGroupToolStripMenuItem.Name = "iSBGroupToolStripMenuItem";
            this.iSBGroupToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.iSBGroupToolStripMenuItem.Text = "ISB Group";
            // 
            // iSBGramToolStripMenuItem
            // 
            this.iSBGramToolStripMenuItem.Name = "iSBGramToolStripMenuItem";
            this.iSBGramToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.iSBGramToolStripMenuItem.Text = "ISB Gram";
            // 
            // iSBGPTToolStripMenuItem
            // 
            this.iSBGPTToolStripMenuItem.Name = "iSBGPTToolStripMenuItem";
            this.iSBGPTToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.iSBGPTToolStripMenuItem.Text = "ISB GPT";
            // 
            // TimerOptimizer
            // 
            this.TimerOptimizer.Enabled = true;
            this.TimerOptimizer.Interval = 43200000;
            this.TimerOptimizer.Tick += new System.EventHandler(this.TimerOptimizer_Tick);
            // 
            // radioButton_isbGpt
            // 
            this.radioButton_isbGpt.AutoSize = true;
            this.radioButton_isbGpt.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_isbGpt.Location = new System.Drawing.Point(451, 93);
            this.radioButton_isbGpt.Name = "radioButton_isbGpt";
            this.radioButton_isbGpt.Size = new System.Drawing.Size(100, 17);
            this.radioButton_isbGpt.TabIndex = 41;
            this.radioButton_isbGpt.Text = "gpt.isbsystem.ru";
            this.radioButton_isbGpt.UseVisualStyleBackColor = false;
            this.radioButton_isbGpt.CheckedChanged += new System.EventHandler(this.radioButton_isbGpt_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 567);
            this.Controls.Add(this.radioButton_isbGpt);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label_forAll);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button_otherBots);
            this.Controls.Add(this.button_design);
            this.Controls.Add(this.button_anticaptchaKeys);
            this.Controls.Add(this.button_applyToAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_accountsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_startStop);
            this.Controls.Add(this.radioButton_captchaAnticap);
            this.Controls.Add(this.radioButton_captchaRucap);
            this.Controls.Add(this.radioButton_captchaManual);
            this.Controls.Add(this.textBox_manualCaptchaAnswer);
            this.Controls.Add(this.pictureBox_captPic);
            this.Controls.Add(this.checkBox_shutownOnTime);
            this.Controls.Add(this.dateTimePicker_timeToStop);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISB | v5.0 by developer vk.com/spyfast";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_flooderDelayMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inviterDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_chatsDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_autoansDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_flooderDelay)).EndInit();
            this.tabPageFlooder.ResumeLayout(false);
            this.tabPageFlooder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flooderEditable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flooderView)).EndInit();
            this.tabPageAnswer.ResumeLayout(false);
            this.tabPageAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_autoansEditable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_autoansView)).EndInit();
            this.tabPageConversations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chatsEditable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chatsView)).EndInit();
            this.tabPageVoice.ResumeLayout(false);
            this.tabPageVoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_speedVO)).EndInit();
            this.tabPagePrivace.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageOther.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPageCheating.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_captPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Timer timer_manualCaptcha;
        private Button button_flooderChange;
        private Button button_flooderRemove;
        private Button button_flooderAdd;
        private Button button_autoansChange;
        private Button button_autoansRemove;
        private Button button_autoansAdd;
        private Button button_chatsChange;
        private Button button_chatsRemove;
        private Button button_chatsAdd;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private NotifyIcon notifyIcon;
        private Label label3;
        private ComboBox comboBox_flooderPhrasesWithDotsSource;
        private Label label27;
        private ComboBox comboBox_flooderPhrasesSource;
        private Label label4;
        private ComboBox comboBox_flooderPictureSource;
        private Timer timer_shutown;
        private ComboBox comboBox_flooderStickerFile;
        private Label label28;
        private ComboBox comboBox_flooderStickerId;
        private Label label29;
        private Label label35;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label37;
        private ToolStripMenuItem toolStripMenuItem_manager;
        private ToolStripMenuItem toolStripMenuItem1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn8;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private ToolStripMenuItem toolStripMenuItem_reload;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewComboBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewComboBoxColumn10;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private ContextMenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem_typerBot;
        private ToolStripMenuItem toolStripMenuItem_antikickBot;
        private TabPage tabPageVoice;
        private LinkLabel linkLabel1;
        private Label label16;
        private TextBox textBox_yandexKeyVO;
        private Button button_sendVO;
        private NumericUpDown numericUpDown_speedVO;
        private Label label8;
        private ComboBox comboBox_emotionVO;
        private Label label14;
        private ComboBox comboBox_voiceVO;
        private Label label10;
        private Label label12;
        private TextBox textBox_targetVO;
        private RichTextBox richTextBox_messageVO;
        private Label label13;
        private ComboBox selectionDelay;
        private NumericUpDown numericUpDown_flooderDelayMax;
        private ComboBox comboBox_autoansStickerId;
        private Label label34;
        private ComboBox comboBox_autoansStickerFile;
        private Label label38;
        private ComboBox comboBox_autoansPhrasesSource;
        private Label label23;
        private ToolStripMenuItem toolStrip_AutoTarget;
        private Label label_workbot;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private Button button_GetConversation;
        private Label label17;
        private ComboBox comboBox_ActivedChat;
        private Label label22;
        private JCS.ToggleSwitch checkBox_optimize;
        private Timer TimerOptimizer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn6;
        private TabPage tabPagePrivace;
        private Button button_SavePrivacySettings;
        private Label label40;
        private JCS.ToggleSwitch checkBox_closedProfile;
        private Button button_telegramChannel;
        private Button button_updater;
        private RadioButton radioButton_isbGpt;
        private ToolStripMenuItem другиеПроектыToolStripMenuItem;
        private ToolStripMenuItem iSBGroupToolStripMenuItem;
        private ToolStripMenuItem iSBGramToolStripMenuItem;
        private ToolStripMenuItem iSBGPTToolStripMenuItem;
        private TabPage tabPageCheating;
        private TabPage tabPage1;
        private Label label18;
        private JCS.ToggleSwitch checkBox_enabledToCustomAudio;
        private Button button_SelectAudioAndSend;
        private Label label11;
        private GroupBox groupBox1;
        private Label label20;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private Label label42;
        private JCS.ToggleSwitch toggleSwitch2;
        private Label label41;
        private Label label39;
        private ComboBox comboBox1;
        private Label label36;
        private TextBox textBox4;
        private Label label33;
        private TextBox textBox3;
        private Label label21;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button2;
        private Label label45;
        private JCS.ToggleSwitch toggleSwitch4;
        private Label label44;
        private JCS.ToggleSwitch toggleSwitch3;
        private Label label43;
        private TextBox textBox5;
        private GroupBox groupBox6;
        private Button button5;
        private Button button4;
        private Label label52;
        private TextBox textBox6;
        private Label label51;
        private RichTextBox richTextBox2;
        private Label label50;
        private ListBox listBox1;
        private GroupBox groupBox5;
        private Button button3;
        private Label label49;
        private JCS.ToggleSwitch toggleSwitch8;
        private Label label48;
        private JCS.ToggleSwitch toggleSwitch7;
        private Label label47;
        private JCS.ToggleSwitch toggleSwitch6;
        private Label label46;
        private JCS.ToggleSwitch toggleSwitch5;
        private RichTextBox richTextBox1;
        private Label label53;
        private JCS.ToggleSwitch toggleSwitch9;
        private Label label55;
        private Label label54;
        private PictureBox pictureBox1;
    }
}
