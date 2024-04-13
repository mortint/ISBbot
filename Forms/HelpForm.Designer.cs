using System.ComponentModel;
using System.Windows.Forms;

namespace ISP.Forms
{
    partial class HelpForm
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(1, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(460, 335);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage6.Controls.Add(this.richTextBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(452, 309);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Флудер";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(443, 300);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Tag = "";
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(452, 309);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Беседы";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox2.ForeColor = System.Drawing.Color.Black;
            this.richTextBox2.Location = new System.Drawing.Point(5, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox2.Size = new System.Drawing.Size(443, 300);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Tag = "";
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 309);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Автоответчик";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox3.ForeColor = System.Drawing.Color.Black;
            this.richTextBox3.Location = new System.Drawing.Point(3, 3);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox3.Size = new System.Drawing.Size(443, 300);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Tag = "";
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(463, 339);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelpForm";
            this.Text = "ISB :: Помощь";
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private TabControl tabControl2;
        private TabPage tabPage6;
        private RichTextBox richTextBox1;
        private TabPage tabPage1;
        private RichTextBox richTextBox2;
        private TabPage tabPage2;
        private RichTextBox richTextBox3;
    }
}
