namespace ISP.Forms
{
    partial class AntikickForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntikickForm));
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox_accDefChats = new System.Windows.Forms.ComboBox();
            this.button_deleteAccountDef = new System.Windows.Forms.Button();
            this.button_changeAccountDef = new System.Windows.Forms.Button();
            this.button_addAccountDef = new System.Windows.Forms.Button();
            this.button_deleteChatName = new System.Windows.Forms.Button();
            this.button_changeChatName = new System.Windows.Forms.Button();
            this.button_addChatName = new System.Windows.Forms.Button();
            this.textBox_chatName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listBox_chatsList = new System.Windows.Forms.ListBox();
            this.button_startStop = new System.Windows.Forms.Button();
            this.numericUpDown_antikickDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_accountsToDefendInChat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_partialRejoinDelay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_antikickDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accountsToDefendInChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_partialRejoinDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(456, 319);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "Аккаунт";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(130, 285);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "Название";
            // 
            // comboBox_accDefChats
            // 
            this.comboBox_accDefChats.FormattingEnabled = true;
            this.comboBox_accDefChats.Location = new System.Drawing.Point(337, 334);
            this.comboBox_accDefChats.Name = "comboBox_accDefChats";
            this.comboBox_accDefChats.Size = new System.Drawing.Size(287, 21);
            this.comboBox_accDefChats.TabIndex = 43;
            // 
            // button_deleteAccountDef
            // 
            this.button_deleteAccountDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteAccountDef.Location = new System.Drawing.Point(532, 361);
            this.button_deleteAccountDef.Name = "button_deleteAccountDef";
            this.button_deleteAccountDef.Size = new System.Drawing.Size(92, 26);
            this.button_deleteAccountDef.TabIndex = 42;
            this.button_deleteAccountDef.Text = "Удалить";
            this.button_deleteAccountDef.UseVisualStyleBackColor = true;
            this.button_deleteAccountDef.Click += new System.EventHandler(this.Button_deleteAccountDef_Click);
            // 
            // button_changeAccountDef
            // 
            this.button_changeAccountDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changeAccountDef.Location = new System.Drawing.Point(434, 361);
            this.button_changeAccountDef.Name = "button_changeAccountDef";
            this.button_changeAccountDef.Size = new System.Drawing.Size(92, 26);
            this.button_changeAccountDef.TabIndex = 41;
            this.button_changeAccountDef.Text = "Изменить";
            this.button_changeAccountDef.UseVisualStyleBackColor = true;
            this.button_changeAccountDef.Click += new System.EventHandler(this.Button_changeAccountDef_Click);
            // 
            // button_addAccountDef
            // 
            this.button_addAccountDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addAccountDef.Location = new System.Drawing.Point(337, 361);
            this.button_addAccountDef.Name = "button_addAccountDef";
            this.button_addAccountDef.Size = new System.Drawing.Size(92, 26);
            this.button_addAccountDef.TabIndex = 40;
            this.button_addAccountDef.Text = "Добавить";
            this.button_addAccountDef.UseVisualStyleBackColor = true;
            this.button_addAccountDef.Click += new System.EventHandler(this.Button_addAccountDef_Click);
            // 
            // button_deleteChatName
            // 
            this.button_deleteChatName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteChatName.Location = new System.Drawing.Point(211, 327);
            this.button_deleteChatName.Name = "button_deleteChatName";
            this.button_deleteChatName.Size = new System.Drawing.Size(92, 26);
            this.button_deleteChatName.TabIndex = 38;
            this.button_deleteChatName.Text = "Удалить";
            this.button_deleteChatName.UseVisualStyleBackColor = true;
            this.button_deleteChatName.Click += new System.EventHandler(this.Button_deleteChatName_Click);
            // 
            // button_changeChatName
            // 
            this.button_changeChatName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changeChatName.Location = new System.Drawing.Point(113, 327);
            this.button_changeChatName.Name = "button_changeChatName";
            this.button_changeChatName.Size = new System.Drawing.Size(92, 26);
            this.button_changeChatName.TabIndex = 37;
            this.button_changeChatName.Text = "Изменить";
            this.button_changeChatName.UseVisualStyleBackColor = true;
            this.button_changeChatName.Click += new System.EventHandler(this.Button_changeChatName_Click);
            // 
            // button_addChatName
            // 
            this.button_addChatName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addChatName.Location = new System.Drawing.Point(15, 327);
            this.button_addChatName.Name = "button_addChatName";
            this.button_addChatName.Size = new System.Drawing.Size(92, 26);
            this.button_addChatName.TabIndex = 36;
            this.button_addChatName.Text = "Добавить";
            this.button_addChatName.UseVisualStyleBackColor = true;
            this.button_addChatName.Click += new System.EventHandler(this.Button_addChatName_Click);
            // 
            // textBox_chatName
            // 
            this.textBox_chatName.Location = new System.Drawing.Point(15, 301);
            this.textBox_chatName.Name = "textBox_chatName";
            this.textBox_chatName.Size = new System.Drawing.Size(288, 20);
            this.textBox_chatName.TabIndex = 35;
            this.textBox_chatName.Click += new System.EventHandler(this.ListBox_chatsList_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(385, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Активные аккаунты в этой беседе";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Беседы";
            // 
            // listBox_chatsList
            // 
            this.listBox_chatsList.FormattingEnabled = true;
            this.listBox_chatsList.Location = new System.Drawing.Point(15, 26);
            this.listBox_chatsList.Name = "listBox_chatsList";
            this.listBox_chatsList.Size = new System.Drawing.Size(288, 251);
            this.listBox_chatsList.TabIndex = 32;
            this.listBox_chatsList.SelectedIndexChanged += new System.EventHandler(this.ListBox_chatsList_SelectedIndexChanged);
            // 
            // button_startStop
            // 
            this.button_startStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_startStop.Location = new System.Drawing.Point(336, 395);
            this.button_startStop.Name = "button_startStop";
            this.button_startStop.Size = new System.Drawing.Size(288, 26);
            this.button_startStop.TabIndex = 46;
            this.button_startStop.Text = "Старт";
            this.button_startStop.UseVisualStyleBackColor = true;
            this.button_startStop.Click += new System.EventHandler(this.Button_startStop_Click);
            // 
            // numericUpDown_antikickDelay
            // 
            this.numericUpDown_antikickDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_antikickDelay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown_antikickDelay.Location = new System.Drawing.Point(77, 396);
            this.numericUpDown_antikickDelay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_antikickDelay.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_antikickDelay.Name = "numericUpDown_antikickDelay";
            this.numericUpDown_antikickDelay.Size = new System.Drawing.Size(198, 20);
            this.numericUpDown_antikickDelay.TabIndex = 47;
            this.numericUpDown_antikickDelay.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_antikickDelay.ValueChanged += new System.EventHandler(this.NumericUpDown_antikickDelay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Мс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Интервал:";
            // 
            // dataGridView_accountsToDefendInChat
            // 
            this.dataGridView_accountsToDefendInChat.AllowUserToAddRows = false;
            this.dataGridView_accountsToDefendInChat.AllowUserToDeleteRows = false;
            this.dataGridView_accountsToDefendInChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_accountsToDefendInChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_accountsToDefendInChat.Location = new System.Drawing.Point(337, 26);
            this.dataGridView_accountsToDefendInChat.MultiSelect = false;
            this.dataGridView_accountsToDefendInChat.Name = "dataGridView_accountsToDefendInChat";
            this.dataGridView_accountsToDefendInChat.RowHeadersVisible = false;
            this.dataGridView_accountsToDefendInChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_accountsToDefendInChat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_accountsToDefendInChat.Size = new System.Drawing.Size(287, 290);
            this.dataGridView_accountsToDefendInChat.TabIndex = 50;
            this.dataGridView_accountsToDefendInChat.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_accountsToDefendInChat_CellEndEdit);
            this.dataGridView_accountsToDefendInChat.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView_accountsToDefendInChat_RowsAdded);
            this.dataGridView_accountsToDefendInChat.SelectionChanged += new System.EventHandler(this.DataGridView_accountsToDefendInChat_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Аккаунт";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 215;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id чата";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Задержка при частичном кике:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Мс";
            // 
            // numericUpDown_partialRejoinDelay
            // 
            this.numericUpDown_partialRejoinDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown_partialRejoinDelay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown_partialRejoinDelay.Location = new System.Drawing.Point(183, 367);
            this.numericUpDown_partialRejoinDelay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_partialRejoinDelay.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_partialRejoinDelay.Name = "numericUpDown_partialRejoinDelay";
            this.numericUpDown_partialRejoinDelay.Size = new System.Drawing.Size(92, 20);
            this.numericUpDown_partialRejoinDelay.TabIndex = 51;
            this.numericUpDown_partialRejoinDelay.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.numericUpDown_partialRejoinDelay.ValueChanged += new System.EventHandler(this.NumericUpDown_partialRejoinDelay_ValueChanged);
            // 
            // AntikickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(639, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_partialRejoinDelay);
            this.Controls.Add(this.dataGridView_accountsToDefendInChat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_antikickDelay);
            this.Controls.Add(this.button_startStop);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboBox_accDefChats);
            this.Controls.Add(this.button_deleteAccountDef);
            this.Controls.Add(this.button_changeAccountDef);
            this.Controls.Add(this.button_addAccountDef);
            this.Controls.Add(this.button_deleteChatName);
            this.Controls.Add(this.button_changeChatName);
            this.Controls.Add(this.button_addChatName);
            this.Controls.Add(this.textBox_chatName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBox_chatsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AntikickForm";
            this.Text = "ISB :: Антикик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AntikickForm_FormClosed);
            this.Shown += new System.EventHandler(this.AntikickForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_antikickDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accountsToDefendInChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_partialRejoinDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox_accDefChats;
        private System.Windows.Forms.Button button_deleteAccountDef;
        private System.Windows.Forms.Button button_changeAccountDef;
        private System.Windows.Forms.Button button_addAccountDef;
        private System.Windows.Forms.Button button_deleteChatName;
        private System.Windows.Forms.Button button_changeChatName;
        private System.Windows.Forms.Button button_addChatName;
        private System.Windows.Forms.TextBox textBox_chatName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox_chatsList;
        private System.Windows.Forms.Button button_startStop;
        private System.Windows.Forms.NumericUpDown numericUpDown_antikickDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_accountsToDefendInChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_partialRejoinDelay;
    }
}