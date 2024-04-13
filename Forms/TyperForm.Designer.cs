using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ISP.Forms
{
    partial class TyperForm
    {
        private IContainer components = null;
        private RichTextBox richTextBox;
        private Button button_launch;
        private Label label4;
        private NumericUpDown numericUpDown_sendingDelay;
        private Label label3;
        private NumericUpDown numericUpDown_typingDelay;
        private Label label_textsCount;
        private Label label1;
        private TextBox textBox_name;
        private Label label2;
        private ComboBox comboBox_placement;
        private Label label5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TyperForm));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button_launch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_sendingDelay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_typingDelay = new System.Windows.Forms.NumericUpDown();
            this.label_textsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_placement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.checkBox_typerPhrasesInOrder = new JCS.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sendingDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_typingDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Location = new System.Drawing.Point(254, 11);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(239, 91);
            this.richTextBox.TabIndex = 15;
            this.richTextBox.Text = "После нажатия на старт через 5 секунд начнётся ввод текста (за это время необходи" +
    "мо поместить курсор в поле ввода)\n\nОстановка производится нажатием на стоп или A" +
    "lt+T\n";
            // 
            // button_launch
            // 
            this.button_launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_launch.Location = new System.Drawing.Point(7, 148);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(241, 23);
            this.button_launch.TabIndex = 14;
            this.button_launch.Text = "Старт (Alt+T)";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.Button_launch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Задержка между отправками сообщений (мс):";
            // 
            // numericUpDown_sendingDelay
            // 
            this.numericUpDown_sendingDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_sendingDelay.Location = new System.Drawing.Point(7, 85);
            this.numericUpDown_sendingDelay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_sendingDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_sendingDelay.Name = "numericUpDown_sendingDelay";
            this.numericUpDown_sendingDelay.Size = new System.Drawing.Size(241, 20);
            this.numericUpDown_sendingDelay.TabIndex = 12;
            this.numericUpDown_sendingDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_sendingDelay.ValueChanged += new System.EventHandler(this.NumericUpDown_sendingDelay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Задержка между нажатиями клавиш (мс):";
            // 
            // numericUpDown_typingDelay
            // 
            this.numericUpDown_typingDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_typingDelay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown_typingDelay.Location = new System.Drawing.Point(7, 44);
            this.numericUpDown_typingDelay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_typingDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_typingDelay.Name = "numericUpDown_typingDelay";
            this.numericUpDown_typingDelay.Size = new System.Drawing.Size(241, 20);
            this.numericUpDown_typingDelay.TabIndex = 10;
            this.numericUpDown_typingDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_typingDelay.ValueChanged += new System.EventHandler(this.NumericUpDown_typingDelay_ValueChanged);
            // 
            // label_textsCount
            // 
            this.label_textsCount.AutoSize = true;
            this.label_textsCount.Location = new System.Drawing.Point(168, 9);
            this.label_textsCount.Name = "label_textsCount";
            this.label_textsCount.Size = new System.Drawing.Size(13, 13);
            this.label_textsCount.TabIndex = 9;
            this.label_textsCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сообщений в typerTexts.txt:";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_name.Location = new System.Drawing.Point(7, 121);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(241, 20);
            this.textBox_name.TabIndex = 16;
            this.textBox_name.TextChanged += new System.EventHandler(this.TextBox_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Обращение";
            // 
            // comboBox_placement
            // 
            this.comboBox_placement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_placement.FormattingEnabled = true;
            this.comboBox_placement.Items.AddRange(new object[] {
            "В начале",
            "В конце",
            "В начале и в конце (через :)"});
            this.comboBox_placement.Location = new System.Drawing.Point(254, 121);
            this.comboBox_placement.Name = "comboBox_placement";
            this.comboBox_placement.Size = new System.Drawing.Size(233, 21);
            this.comboBox_placement.TabIndex = 18;
            this.comboBox_placement.SelectedIndexChanged += new System.EventHandler(this.ComboBox_placement_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Расположение обращения";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(302, 151);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(103, 13);
            this.label30.TabIndex = 35;
            this.label30.Text = "Фразы по порядку";
            // 
            // checkBox_typerPhrasesInOrder
            // 
            this.checkBox_typerPhrasesInOrder.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_typerPhrasesInOrder.Location = new System.Drawing.Point(254, 149);
            this.checkBox_typerPhrasesInOrder.Name = "checkBox_typerPhrasesInOrder";
            this.checkBox_typerPhrasesInOrder.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_typerPhrasesInOrder.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_typerPhrasesInOrder.Size = new System.Drawing.Size(45, 19);
            this.checkBox_typerPhrasesInOrder.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.checkBox_typerPhrasesInOrder.TabIndex = 34;
            this.checkBox_typerPhrasesInOrder.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.checkBox_typerPhrasesInOrder_CheckedChanged);
            // 
            // TyperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(499, 180);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.checkBox_typerPhrasesInOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_placement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.button_launch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_sendingDelay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_typingDelay);
            this.Controls.Add(this.label_textsCount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TyperForm";
            this.Text = "ISB :: Набор текста";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TyperForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sendingDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_typingDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label30;
        private JCS.ToggleSwitch checkBox_typerPhrasesInOrder;
    }
}
