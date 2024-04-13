using System.ComponentModel;
using System.Windows.Forms;

namespace ISP.Forms
{
    partial class AnticapSettingsForm
    {
        private IContainer components = null;
        private TextBox textBox_rucapKey;
        private Label label1;
        private Label label2;
        private TextBox textBox_anticapKey;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnticapSettingsForm));
            this.textBox_rucapKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_anticapKey = new System.Windows.Forms.TextBox();
            this.button_rucaptchaBalance = new System.Windows.Forms.Button();
            this.button_anticaptchaBalance = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_getBalanceISBgpt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_keyISbgpt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_rucapKey
            // 
            this.textBox_rucapKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_rucapKey.Location = new System.Drawing.Point(12, 23);
            this.textBox_rucapKey.Name = "textBox_rucapKey";
            this.textBox_rucapKey.Size = new System.Drawing.Size(420, 20);
            this.textBox_rucapKey.TabIndex = 0;
            this.textBox_rucapKey.TextChanged += new System.EventHandler(this.textBox_rucapKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ключ rucaptcha.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ключ anti-captcha.com";
            // 
            // textBox_anticapKey
            // 
            this.textBox_anticapKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_anticapKey.Location = new System.Drawing.Point(12, 65);
            this.textBox_anticapKey.Name = "textBox_anticapKey";
            this.textBox_anticapKey.Size = new System.Drawing.Size(420, 20);
            this.textBox_anticapKey.TabIndex = 2;
            this.textBox_anticapKey.TextChanged += new System.EventHandler(this.textBox_anticapKey_TextChanged);
            // 
            // button_rucaptchaBalance
            // 
            this.button_rucaptchaBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rucaptchaBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_rucaptchaBalance.Location = new System.Drawing.Point(438, 23);
            this.button_rucaptchaBalance.Name = "button_rucaptchaBalance";
            this.button_rucaptchaBalance.Size = new System.Drawing.Size(82, 20);
            this.button_rucaptchaBalance.TabIndex = 33;
            this.button_rucaptchaBalance.Text = "???.??₽";
            this.button_rucaptchaBalance.UseVisualStyleBackColor = true;
            this.button_rucaptchaBalance.Click += new System.EventHandler(this.button_rucaptchaBalance_Click);
            // 
            // button_anticaptchaBalance
            // 
            this.button_anticaptchaBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anticaptchaBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_anticaptchaBalance.Location = new System.Drawing.Point(438, 64);
            this.button_anticaptchaBalance.Name = "button_anticaptchaBalance";
            this.button_anticaptchaBalance.Size = new System.Drawing.Size(82, 20);
            this.button_anticaptchaBalance.TabIndex = 34;
            this.button_anticaptchaBalance.Text = "???.??₽";
            this.button_anticaptchaBalance.UseVisualStyleBackColor = true;
            this.button_anticaptchaBalance.Click += new System.EventHandler(this.button_anticaptchaBalance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Узнать баланс";
            // 
            // button_getBalanceISBgpt
            // 
            this.button_getBalanceISBgpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_getBalanceISBgpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_getBalanceISBgpt.Location = new System.Drawing.Point(438, 103);
            this.button_getBalanceISBgpt.Name = "button_getBalanceISBgpt";
            this.button_getBalanceISBgpt.Size = new System.Drawing.Size(82, 20);
            this.button_getBalanceISBgpt.TabIndex = 38;
            this.button_getBalanceISBgpt.Text = "???.??₽";
            this.button_getBalanceISBgpt.UseVisualStyleBackColor = true;
            this.button_getBalanceISBgpt.Click += new System.EventHandler(this.button_getBalanceISBgpt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ключ gpt.isbsystem.ru";
            // 
            // textBox_keyISbgpt
            // 
            this.textBox_keyISbgpt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_keyISbgpt.Location = new System.Drawing.Point(12, 104);
            this.textBox_keyISbgpt.Name = "textBox_keyISbgpt";
            this.textBox_keyISbgpt.Size = new System.Drawing.Size(420, 20);
            this.textBox_keyISbgpt.TabIndex = 36;
            this.textBox_keyISbgpt.TextChanged += new System.EventHandler(this.textBox_keyISbgpt_TextChanged);
            // 
            // AnticapSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(526, 136);
            this.Controls.Add(this.button_getBalanceISBgpt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_keyISbgpt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_anticaptchaBalance);
            this.Controls.Add(this.button_rucaptchaBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_anticapKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_rucapKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnticapSettingsForm";
            this.Text = "ISB :: Антикапча";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button button_rucaptchaBalance;
        private Button button_anticaptchaBalance;
        private Label label3;
        private Button button_getBalanceISBgpt;
        private Label label4;
        private TextBox textBox_keyISbgpt;
    }
}
