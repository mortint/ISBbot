using ISP.Engine.Accounts;
using ISP.Misc;
using ISP.Tasks.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Utils;
using VkNet.Model.Attachments;

namespace ISP.Engine.Helpers
{
    static class AttachmentGetter
    {
        static List<string> audios, documents, images, stickers, videos;
        static Random rnd;

        public static void LoadFromTxts()
        {
            audios = new List<String>(System.IO.File.ReadAllLines("Txts\\Attachments\\audios.txt"));
            documents = new List<String>(System.IO.File.ReadAllLines("Txts\\Attachments\\documents.txt"));
            images = new List<String>(System.IO.File.ReadAllLines("Txts\\Attachments\\images.txt"));
            stickers = new List<String>(System.IO.File.ReadAllLines("Txts\\Attachments\\stickers.txt"));
            videos = new List<String>(System.IO.File.ReadAllLines("Txts\\Attachments\\videos.txt"));
            rnd = new Random();
        }

        public static IReadOnlyCollection<MediaAttachment> VoiceMessage(Account acc, string message)
        {
            var vts = acc.VoiceTaskSettings;
            var api = acc.VkApi;

            WebClient wc = new WebClient();
            string sp = (vts.speed * 0.1).ToString().Replace(",", ".");
            Random rnd = new Random();
            string filename = $"tmp\\{rnd.Next()}.mp3";
            string link = $"https://tts.voicetech.yandex.net/generate?text={message}&format=mp3&lang=ru-RU&speaker={vts.voice}&emotion={vts.emotion}&speed={sp}&key={vts.yandexapi}";
            wc.DownloadFile(link, filename);

            //UPLOAD

            VkParameters upl = new VkParameters
            {
                { "type", "audio_message" }
            };
            UploadServerInfo uploadServerInfo = api.Call("docs.getUploadServer", upl);
            string uplData = ISP.Engine.Network.Network.HttpUploadFile(uploadServerInfo.UploadUrl, filename, "file", "audio/MP3");
            string tg = StrWrk.GetBetween(uplData, "\"file\":\"", "\"}");
            VkParameters sve = new VkParameters
            {
                { "file", tg }
            };
            var readyToSend = api.Call("docs.save", sve).ToReadOnlyCollectionOf<Document>(r => r);

            System.IO.File.Delete(filename);

            return readyToSend;
        }

        public static IReadOnlyCollection<MediaAttachment> RandomImage()
        {
            if (images.Count == 0)
                return null;

            string selected = images[rnd.Next(0, images.Count)];

            var toRet = new List<Photo>
            {
                new Photo()
                {
                    OwnerId = 0,
                    Id = 0
                }
            };
            return toRet.ToReadOnlyCollection();
        }

        public static IReadOnlyCollection<MediaAttachment> RandomSticker()
        {
            if (stickers.Count == 0)
                return null;

            var toRet = new List<MediaAttachment>
            {
                new Sticker()
                {
                    Id = 0
                }
            };
            return toRet.ToReadOnlyCollection();
        }

        public static IReadOnlyCollection<MediaAttachment> RandomVideo()
        {
            if (videos.Count == 0)
                return null;

            var toRet = new List<Video>
            {
                new Video()
                {
                    Id = 0,
                    OwnerId = 0
                }
            };
            return toRet.ToReadOnlyCollection();
        }

        public static IReadOnlyCollection<MediaAttachment> RandomDocument()
        {
            if (documents.Count == 0)
                return null;

            var toRet = new List<Document>
            {
                new Document()
                {
                    Id = 0,
                    OwnerId = 0
                }
            };
            return toRet.ToReadOnlyCollection();
        }

        public static IReadOnlyCollection<MediaAttachment> RandomAudio()
        {
            if (audios.Count == 0)
                return null;

            var toRet = new List<Audio>
            {
                new Audio()
                {
                    Id = 0,
                    OwnerId = 0
                }
            };
            return toRet.ToReadOnlyCollection();
        }
    }
}
