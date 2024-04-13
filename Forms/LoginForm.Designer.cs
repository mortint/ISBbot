
namespace ISP.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button_Enter = new System.Windows.Forms.Button();
            this.label_hwid = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_copyHwid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Enter
            // 
            this.button_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Enter.Location = new System.Drawing.Point(15, 59);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(138, 23);
            this.button_Enter.TabIndex = 0;
            this.button_Enter.Text = "Войти";
            this.button_Enter.UseVisualStyleBackColor = true;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // label_hwid
            // 
            this.label_hwid.AutoSize = true;
            this.label_hwid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hwid.Location = new System.Drawing.Point(12, 11);
            this.label_hwid.Name = "label_hwid";
            this.label_hwid.Size = new System.Drawing.Size(47, 16);
            this.label_hwid.TabIndex = 2;
            this.label_hwid.Text = "Ключ: ";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(15, 33);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(282, 20);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown);
            // 
            // button_copyHwid
            // 
            this.button_copyHwid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_copyHwid.Location = new System.Drawing.Point(159, 59);
            this.button_copyHwid.Name = "button_copyHwid";
            this.button_copyHwid.Size = new System.Drawing.Size(138, 23);
            this.button_copyHwid.TabIndex = 4;
            this.button_copyHwid.Text = "Копировать ключ";
            this.button_copyHwid.UseVisualStyleBackColor = true;
            this.button_copyHwid.Click += new System.EventHandler(this.button_copyHwid_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(317, 95);
            this.Controls.Add(this.button_copyHwid);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_hwid);
            this.Controls.Add(this.button_Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISB v4.6 :: Авторизация";
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Label label_hwid;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_copyHwid;
    }
}