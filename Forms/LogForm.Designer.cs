using System.ComponentModel;
using System.Windows.Forms;

namespace ISP.Forms
{
    partial class LogForm
    {
        private IContainer components = null;
        private RichTextBox richTextBox_log;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.LogUpdater = new System.Windows.Forms.Timer(this.components);
            this.checkBox_EnabledLogger = new JCS.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_log.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.ReadOnly = true;
            this.richTextBox_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_log.Size = new System.Drawing.Size(467, 211);
            this.richTextBox_log.TabIndex = 0;
            this.richTextBox_log.Text = "";
            // 
            // LogUpdater
            // 
            this.LogUpdater.Enabled = true;
            this.LogUpdater.Interval = 1000;
            this.LogUpdater.Tick += new System.EventHandler(this.LogUpdater_Tick);
            // 
            // checkBox_EnabledLogger
            // 
            this.checkBox_EnabledLogger.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_EnabledLogger.Location = new System.Drawing.Point(3, 215);
            this.checkBox_EnabledLogger.Name = "checkBox_EnabledLogger";
            this.checkBox_EnabledLogger.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_EnabledLogger.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_EnabledLogger.Size = new System.Drawing.Size(45, 19);
            this.checkBox_EnabledLogger.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Modern;
            this.checkBox_EnabledLogger.TabIndex = 2;
            this.checkBox_EnabledLogger.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.checkBox_EnabledLogger_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отключить логирование";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(467, 238);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_EnabledLogger);
            this.Controls.Add(this.richTextBox_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogForm";
            this.Text = "ISB :: Логирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Timer LogUpdater;
        private JCS.ToggleSwitch checkBox_EnabledLogger;
        private Label label1;
    }
}
