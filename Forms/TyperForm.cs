using ISP.Configs;
using ISP.Misc;
using JCS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ISP.Forms {
    internal sealed partial class TyperForm : CenteredForm {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private readonly List<string> _messages;

        private Thread _workingThread;

        private bool _active;

        private string _nameBefore;
        private string _nameAfter;

        private readonly Random _random;
        public TyperForm() {
            InitializeComponent();
            BackColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorApplications);
            ForeColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb);

            richTextBox.ForeColor = ForeColor;
            button_launch.ForeColor = ForeColor;

            _messages = new List<string>();
            _random = new Random();

            try {
                _messages = new List<string>(File.ReadAllLines("Txts\\typerTexts.txt", Encoding.UTF8));
            }
            catch { }

            if (_messages.Count == 0)
                button_launch.Enabled = false;

            label_textsCount.Text = _messages.Count.ToString();

            numericUpDown_sendingDelay.Value = ConfigController.TyperConfig.SendingDelay;
            numericUpDown_typingDelay.Value = ConfigController.TyperConfig.TypingDelay;
            textBox_name.Text = ConfigController.TyperConfig.Name;
            checkBox_typerPhrasesInOrder.Checked = ConfigController.TyperConfig.InOrder;

            comboBox_placement.SelectedIndex = ConfigController.TyperConfig.NamePlacement;

            try {
                SetForeColor(Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb));
            }
            catch { }

            RegisterHotKey(Handle, 0, 1, Keys.T.GetHashCode());
        }

        public void SetForeColor(Color col) {
            Color colorForSwitches = col.ToArgb() == Color.Black.ToArgb() ? Color.Gray : col;

            ToggleSwitchModernRenderer switchRenderer = new ToggleSwitchModernRenderer() {
                LeftSideBackColor1 = colorForSwitches,
                LeftSideBackColor2 = colorForSwitches,
                ArrowNormalColor = colorForSwitches,
                ArrowHoverColor = Color.White,
                ArrowPressedColor = Color.White
            };

            checkBox_typerPhrasesInOrder.SetRenderer(Cloner.Clone(switchRenderer));

            ConfigController.InterfaceConfig.ForColorAsArgb = col.ToArgb();
            ConfigController.InterfaceConfig.Save();
        }

        private void Running(int index) {
            var message = string.Empty;

            if (checkBox_typerPhrasesInOrder.Checked)
                message = _messages[index];
            else
                message = _messages[_random.Next(_messages.Count)];

            foreach (char c in _nameBefore + message + _nameAfter) {
                if (c == 10)
                    SendKeys.SendWait("^{ENTER}");

                else if (!char.IsControl(c)) {
                    if (char.IsWhiteSpace(c))
                        SendKeys.SendWait(" ");
                    else
                        SendKeys.SendWait("{" + c.ToString() + "}");
                }
                Thread.Sleep((int)numericUpDown_typingDelay.Value);
            }

            SendKeys.SendWait("{ENTER}");
            Thread.Sleep((int)numericUpDown_sendingDelay.Value);
        }

        private void Work() {
            Thread.Sleep(5000);
            int index = -1;

            while (true) {
                if (checkBox_typerPhrasesInOrder.Checked)
                    index = (index + 1) % _messages.Count;

                Running(index);
            }
        }

        private void Button_launch_Click(object sender, EventArgs e) {
            _active = !_active;
            if (_active) {
                button_launch.Text = "Стоп (Alt+T)";
                _nameBefore = _nameAfter = "";
                switch (comboBox_placement.SelectedIndex) {
                    case 0:
                        _nameBefore = textBox_name.Text;
                        break;
                    case 1:
                        _nameAfter = textBox_name.Text;
                        break;
                    case 2:
                        if (textBox_name.Text.Contains(":")) {
                            _nameBefore = textBox_name.Text.Split(':')[0];
                            _nameAfter = textBox_name.Text.Split(':')[1];
                            break;
                        }
                        _nameAfter = _nameBefore = textBox_name.Text;
                        break;
                }
                _workingThread = new Thread(Work) {
                    IsBackground = true
                };

                _workingThread.Start();
            }
            else {
                button_launch.Text = "Старт (Alt+T)";
                _workingThread?.Abort();
            }
        }

        private void NumericUpDown_typingDelay_ValueChanged(object sender, EventArgs e) {
            ConfigController.TyperConfig.TypingDelay = (int)numericUpDown_typingDelay.Value;
            ConfigController.TyperConfig.Save();
        }

        private void NumericUpDown_sendingDelay_ValueChanged(object sender, EventArgs e) {
            ConfigController.TyperConfig.SendingDelay = (int)numericUpDown_sendingDelay.Value;
            ConfigController.TyperConfig.Save();
        }

        private void TextBox_name_TextChanged(object sender, EventArgs e) {
            ConfigController.TyperConfig.Name = textBox_name.Text;
            ConfigController.TyperConfig.Save();
        }

        private void ComboBox_placement_SelectedIndexChanged(object sender, EventArgs e) {
            ConfigController.TyperConfig.NamePlacement = comboBox_placement.SelectedIndex;
            ConfigController.TyperConfig.Save();
        }

        private void TyperForm_FormClosed(object sender, FormClosedEventArgs e) {
            _workingThread?.Abort();
            UnregisterHotKey(Handle, 0);
        }

        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            if (m.Msg != 786 || !button_launch.Enabled)
                return;
            Button_launch_Click(null, null);
        }

        private void checkBox_typerPhrasesInOrder_CheckedChanged(object sender, EventArgs e) {
            ConfigController.TyperConfig.InOrder = checkBox_typerPhrasesInOrder.Checked;
            ConfigController.TyperConfig.Save();
        }
    }
}