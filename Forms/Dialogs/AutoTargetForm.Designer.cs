
namespace ISP.Forms.Dialogs
{
    partial class AutoTargetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoTargetForm));
            this.textBox_From = new System.Windows.Forms.TextBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Before = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.checkBox_appeal = new JCS.ToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_LocAppeal = new System.Windows.Forms.ComboBox();
            this.comboBox_Content = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_From
            // 
            this.textBox_From.Location = new System.Drawing.Point(12, 25);
            this.textBox_From.Name = "textBox_From";
            this.textBox_From.Size = new System.Drawing.Size(100, 20);
            this.textBox_From.TabIndex = 0;
            this.textBox_From.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // button_Apply
            // 
            this.button_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Apply.Location = new System.Drawing.Point(12, 76);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(427, 23);
            this.button_Apply.TabIndex = 1;
            this.button_Apply.Text = "Применить";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "От";
            // 
            // textBox_Before
            // 
            this.textBox_Before.Location = new System.Drawing.Point(118, 25);
            this.textBox_Before.Name = "textBox_Before";
            this.textBox_Before.Size = new System.Drawing.Size(100, 20);
            this.textBox_Before.TabIndex = 3;
            this.textBox_Before.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "До";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(63, 53);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(140, 13);
            this.label37.TabIndex = 42;
            this.label37.Text = "Использовать обращение";
            // 
            // checkBox_appeal
            // 
            this.checkBox_appeal.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_appeal.Location = new System.Drawing.Point(12, 51);
            this.checkBox_appeal.Name = "checkBox_appeal";
            this.checkBox_appeal.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_appeal.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_appeal.Size = new System.Drawing.Size(45, 19);
            this.checkBox_appeal.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.checkBox_appeal.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Расп. Обращения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Содержимое";
            // 
            // comboBox_LocAppeal
            // 
            this.comboBox_LocAppeal.FormattingEnabled = true;
            this.comboBox_LocAppeal.Items.AddRange(new object[] {
            "Начало",
            "Конец",
            "В начале и в конце (через :)"});
            this.comboBox_LocAppeal.Location = new System.Drawing.Point(222, 25);
            this.comboBox_LocAppeal.Name = "comboBox_LocAppeal";
            this.comboBox_LocAppeal.Size = new System.Drawing.Size(111, 21);
            this.comboBox_LocAppeal.TabIndex = 45;
            // 
            // comboBox_Content
            // 
            this.comboBox_Content.FormattingEnabled = true;
            this.comboBox_Content.Items.AddRange(new object[] {
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
            "Документ+текст"});
            this.comboBox_Content.Location = new System.Drawing.Point(339, 24);
            this.comboBox_Content.Name = "comboBox_Content";
            this.comboBox_Content.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Content.TabIndex = 46;
            // 
            // AutoTargetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(452, 115);
            this.Controls.Add(this.comboBox_Content);
            this.Controls.Add(this.comboBox_LocAppeal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.checkBox_appeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Before);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.textBox_From);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoTargetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоцели : ISB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_From;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Before;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label37;
        private JCS.ToggleSwitch checkBox_appeal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_LocAppeal;
        private System.Windows.Forms.ComboBox comboBox_Content;
    }
}