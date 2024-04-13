namespace ISP.Forms.Dialogs
{
    partial class TwoFactAsker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoFactAsker));
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Skip = new System.Windows.Forms.Button();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Ok
            // 
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ok.Location = new System.Drawing.Point(12, 64);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(83, 23);
            this.button_Ok.TabIndex = 0;
            this.button_Ok.Text = "Ок";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Skip
            // 
            this.button_Skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Skip.Location = new System.Drawing.Point(101, 64);
            this.button_Skip.Name = "button_Skip";
            this.button_Skip.Size = new System.Drawing.Size(87, 23);
            this.button_Skip.TabIndex = 1;
            this.button_Skip.Text = "Пропустить";
            this.button_Skip.UseVisualStyleBackColor = true;
            this.button_Skip.Click += new System.EventHandler(this.button_Skip_Click);
            // 
            // textBox_Code
            // 
            this.textBox_Code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Code.Location = new System.Drawing.Point(12, 38);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(176, 20);
            this.textBox_Code.TabIndex = 2;
            this.textBox_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Code_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Аккаунт запрашивает код\r\nили данные для входа неверны";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TwoFactAsker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(197, 95);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.button_Skip);
            this.Controls.Add(this.button_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TwoFactAsker";
            this.Text = "Двуфакторная авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Skip;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Label label1;
    }
}