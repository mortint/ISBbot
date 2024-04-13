using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ISP.Forms
{
    partial class DesignForm
    {
        private IContainer components = null;
        private TextBox textBox_general;
        private Button button_fileFindGeneral;
        private Label label1;
        private Button button_resetImgGeneral;
        private ColorDialog colorDialog;
        private OpenFileDialog openFileDialog;
        private Button button_resetImgTabs;
        private Label label2;
        private Button button_fileFindTabs;
        private TextBox textBox_tabs;
        private PictureBox pictureBox;
        private Label label3;
        private Button button_resetColor;
        private Button button_selectColor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            this.textBox_general = new System.Windows.Forms.TextBox();
            this.button_fileFindGeneral = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_resetImgGeneral = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_resetImgTabs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_fileFindTabs = new System.Windows.Forms.Button();
            this.textBox_tabs = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_resetColor = new System.Windows.Forms.Button();
            this.button_selectColor = new System.Windows.Forms.Button();
            this.button_selecColorApp = new System.Windows.Forms.Button();
            this.button_resetColorApp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_ColorApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorApp)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_general
            // 
            this.textBox_general.Location = new System.Drawing.Point(9, 22);
            this.textBox_general.Name = "textBox_general";
            this.textBox_general.ReadOnly = true;
            this.textBox_general.Size = new System.Drawing.Size(305, 20);
            this.textBox_general.TabIndex = 0;
            // 
            // button_fileFindGeneral
            // 
            this.button_fileFindGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fileFindGeneral.Location = new System.Drawing.Point(320, 19);
            this.button_fileFindGeneral.Name = "button_fileFindGeneral";
            this.button_fileFindGeneral.Size = new System.Drawing.Size(27, 23);
            this.button_fileFindGeneral.TabIndex = 1;
            this.button_fileFindGeneral.Text = "...";
            this.button_fileFindGeneral.UseVisualStyleBackColor = true;
            this.button_fileFindGeneral.Click += new System.EventHandler(this.button_fileFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фоновое изображение";
            // 
            // button_resetImgGeneral
            // 
            this.button_resetImgGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetImgGeneral.Location = new System.Drawing.Point(351, 19);
            this.button_resetImgGeneral.Name = "button_resetImgGeneral";
            this.button_resetImgGeneral.Size = new System.Drawing.Size(27, 23);
            this.button_resetImgGeneral.TabIndex = 3;
            this.button_resetImgGeneral.Text = "Х";
            this.button_resetImgGeneral.UseVisualStyleBackColor = true;
            this.button_resetImgGeneral.Click += new System.EventHandler(this.button_resetImgGeneral_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // button_resetImgTabs
            // 
            this.button_resetImgTabs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetImgTabs.Location = new System.Drawing.Point(351, 58);
            this.button_resetImgTabs.Name = "button_resetImgTabs";
            this.button_resetImgTabs.Size = new System.Drawing.Size(27, 23);
            this.button_resetImgTabs.TabIndex = 7;
            this.button_resetImgTabs.Text = "Х";
            this.button_resetImgTabs.UseVisualStyleBackColor = true;
            this.button_resetImgTabs.Click += new System.EventHandler(this.button_resetImgTabs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фоновое изображение на вкладках";
            // 
            // button_fileFindTabs
            // 
            this.button_fileFindTabs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fileFindTabs.Location = new System.Drawing.Point(320, 58);
            this.button_fileFindTabs.Name = "button_fileFindTabs";
            this.button_fileFindTabs.Size = new System.Drawing.Size(27, 23);
            this.button_fileFindTabs.TabIndex = 5;
            this.button_fileFindTabs.Text = "...";
            this.button_fileFindTabs.UseVisualStyleBackColor = true;
            this.button_fileFindTabs.Click += new System.EventHandler(this.button_fileFindTabs_Click);
            // 
            // textBox_tabs
            // 
            this.textBox_tabs.Location = new System.Drawing.Point(9, 61);
            this.textBox_tabs.Name = "textBox_tabs";
            this.textBox_tabs.ReadOnly = true;
            this.textBox_tabs.Size = new System.Drawing.Size(305, 20);
            this.textBox_tabs.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox.Location = new System.Drawing.Point(9, 99);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(305, 23);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Цвет текста";
            // 
            // button_resetColor
            // 
            this.button_resetColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetColor.Location = new System.Drawing.Point(351, 99);
            this.button_resetColor.Name = "button_resetColor";
            this.button_resetColor.Size = new System.Drawing.Size(27, 23);
            this.button_resetColor.TabIndex = 10;
            this.button_resetColor.Text = "Х";
            this.button_resetColor.UseVisualStyleBackColor = true;
            this.button_resetColor.Click += new System.EventHandler(this.button_resetColor_Click);
            // 
            // button_selectColor
            // 
            this.button_selectColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selectColor.Location = new System.Drawing.Point(318, 99);
            this.button_selectColor.Name = "button_selectColor";
            this.button_selectColor.Size = new System.Drawing.Size(27, 23);
            this.button_selectColor.TabIndex = 11;
            this.button_selectColor.Text = "...";
            this.button_selectColor.UseVisualStyleBackColor = true;
            this.button_selectColor.Click += new System.EventHandler(this.button_selectColor_Click);
            // 
            // button_selecColorApp
            // 
            this.button_selecColorApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selecColorApp.Location = new System.Drawing.Point(318, 139);
            this.button_selecColorApp.Name = "button_selecColorApp";
            this.button_selecColorApp.Size = new System.Drawing.Size(27, 23);
            this.button_selecColorApp.TabIndex = 15;
            this.button_selecColorApp.Text = "...";
            this.button_selecColorApp.UseVisualStyleBackColor = true;
            this.button_selecColorApp.Click += new System.EventHandler(this.button_selecColorApp_Click);
            // 
            // button_resetColorApp
            // 
            this.button_resetColorApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetColorApp.Location = new System.Drawing.Point(351, 139);
            this.button_resetColorApp.Name = "button_resetColorApp";
            this.button_resetColorApp.Size = new System.Drawing.Size(27, 23);
            this.button_resetColorApp.TabIndex = 14;
            this.button_resetColorApp.Text = "Х";
            this.button_resetColorApp.UseVisualStyleBackColor = true;
            this.button_resetColorApp.Click += new System.EventHandler(this.button_resetColorApp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цвет приложения";
            // 
            // pictureBox_ColorApp
            // 
            this.pictureBox_ColorApp.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox_ColorApp.Location = new System.Drawing.Point(9, 139);
            this.pictureBox_ColorApp.Name = "pictureBox_ColorApp";
            this.pictureBox_ColorApp.Size = new System.Drawing.Size(305, 23);
            this.pictureBox_ColorApp.TabIndex = 12;
            this.pictureBox_ColorApp.TabStop = false;
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(385, 175);
            this.Controls.Add(this.button_selecColorApp);
            this.Controls.Add(this.button_resetColorApp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_ColorApp);
            this.Controls.Add(this.button_selectColor);
            this.Controls.Add(this.button_resetColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_resetImgTabs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_fileFindTabs);
            this.Controls.Add(this.textBox_tabs);
            this.Controls.Add(this.button_resetImgGeneral);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_fileFindGeneral);
            this.Controls.Add(this.textBox_general);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DesignForm";
            this.Text = "ISB :: Дизайн приложения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button button_selecColorApp;
        private Button button_resetColorApp;
        private Label label4;
        private PictureBox pictureBox_ColorApp;
    }
}
