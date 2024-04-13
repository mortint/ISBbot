using ISP.Configs;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ISP.Forms {
    public sealed partial class TxtManagerForm : CenteredForm {
        public TxtManagerForm() {
            InitializeComponent();
            BackColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorApplications);
            ForeColor = Color.FromArgb(ConfigController.InterfaceConfig.ForColorAsArgb);
            richTextBox_accountsList.Text = File.ReadAllText("Txts\\accounts.txt", Encoding.GetEncoding("windows-1251"));
            richTextBox_typerTexts.Text = File.ReadAllText("Txts\\typerTexts.txt", Encoding.GetEncoding("windows-1251"));
            richTextBox_audioList.Text = File.ReadAllText("Txts\\Attachments\\audios.txt", Encoding.GetEncoding("windows-1251"));
            richTextBox_pictureList.Text = File.ReadAllText("Txts\\Attachments\\images.txt", Encoding.GetEncoding("windows-1251"));
            richTextBox_videoList.Text = File.ReadAllText("Txts\\Attachments\\videos.txt", Encoding.GetEncoding("windows-1251"));
            richTextBox_avatarTitles.Text = File.ReadAllText("Txts\\titles.txt", Encoding.GetEncoding("windows-1251"));
        }

        private void Button_openPhrases_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", "Txts\\Phrases\\Simple");
        }

        private void Button_openPhrasesWithDots_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", "Txts\\Phrases\\Dots");
        }

        private void Button_openPicsFolder_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", "Upload\\Images");
        }

        private void Button_openDocsFolder_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", "Upload\\Documents");
        }

        private void Button_openStickers_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", "Txts\\Stickers");
        }

        private void RichTextBox_TagBasedTextSave(object sender, EventArgs e) {
            RichTextBox rtb = (RichTextBox)sender;
            File.WriteAllText(rtb.Tag.ToString(), rtb.Text, Encoding.GetEncoding("windows-1251"));
        }

        private void button_openAvatars_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", "Upload\\Avatars");
        }
    }
}
