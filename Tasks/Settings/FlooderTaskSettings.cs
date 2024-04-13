using ISP.Engine.Accounts;
using ISP.Engine.Helpers;
using ISP.Forms;
using ISP.Misc;
using ISP.Objects.Targets;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VkNet.Model;
using VkNet.Utils;

namespace ISP.Tasks.Settings {
    
    internal sealed class FlooderTaskSettings : ISBTaskSettings {
        private class CounterContainer {
            public int PhIndex = -1, PhDotsIndex = -1, StIndex = -1;
        }
        /// <summary>
        /// Список целей
        /// </summary>
        public readonly List<FlooderTarget> Targets;
        /// <summary>
        /// Папка с изображениями
        /// </summary>
        public bool ImagesFromFolder;
        /// <summary>
        /// Файлы с фразами, фразами с точками, стикерами и стикер ID
        /// </summary>
        public string PhrasesFile, PhrasesWithDotsFile, StickersFile, StickerId;

        private static Dictionary<TargetData, CounterContainer> _targetRelatedCounters;
        /// <summary>
        /// Коллекция фраз
        /// </summary>
        private List<string> _phrases, _phrasesWithDots;
        private static List<MediaAttachment> _audios, _videos;
        private List<MediaAttachment> _documents, _images, _stickers;
        private static Random _rnd;

        static FlooderTaskSettings() {
            ReloadFromTxts();
        }
        /// <summary>
        /// Загрузить данные из .txt
        /// </summary>
        public static void ReloadFromTxts() {
            _targetRelatedCounters = new Dictionary<TargetData, CounterContainer>();
            _rnd = new Random();
            _audios = new List<MediaAttachment>();
            _videos = new List<MediaAttachment>();

            var audiosPattren = new Regex("audio_?(-?[0-9]+)_([0-9]+)");
            var videosPattren = new Regex("video(-?[0-9]+)_([0-9]+)");

            foreach (string video in System.IO.File.ReadAllLines("Txts\\Attachments\\videos.txt", Encoding.UTF8)) {
                Match m = videosPattren.Match(video);
                if (m.Success) {
                    _videos.Add(new Video() {
                        OwnerId = long.Parse(m.Groups[1].Value),
                        Id = long.Parse(m.Groups[2].Value)
                    });
                }
                else {
                    LogForm.PushToLog($"{video} - некоррекный формат видео");
                }
            }
            foreach (string audio in System.IO.File.ReadAllLines("Txts\\Attachments\\audios.txt", Encoding.UTF8)) {
                Match m = audiosPattren.Match(audio);
                if (m.Success) {
                    _audios.Add(new Audio() {
                        OwnerId = long.Parse(m.Groups[1].Value),
                        Id = long.Parse(m.Groups[2].Value)
                    });
                }
                else {
                    LogForm.PushToLog($"{audio} - некоррекный формат аудио");
                }
            }
        }
        /// <summary>
        /// Загрузить данные текущего аккаунта
        /// </summary>
        /// <param name="acc"></param>
        public void LoadAccountSpecific(Account acc) {
            _phrases = new List<string>();
            _phrasesWithDots = new List<string>();
            if (!string.IsNullOrEmpty(PhrasesFile))
                _phrases = new List<string>(System.IO.File.ReadAllLines($"Txts\\Phrases\\Simple\\{PhrasesFile}", Encoding.UTF8));
            if (!string.IsNullOrEmpty(PhrasesWithDotsFile))
                _phrasesWithDots = new List<string>(System.IO.File.ReadAllLines($"Txts\\Phrases\\Dots\\{PhrasesWithDotsFile}", Encoding.UTF8));

            _documents = new List<MediaAttachment>();
            _images = new List<MediaAttachment>();
            _stickers = new List<MediaAttachment>();

            Regex imagesPattren = new Regex("photo(-?[0-9]+)_([0-9]+)");
            Regex stickersPattren = new Regex("([0-9]+)");

            if (!string.IsNullOrEmpty(StickersFile))
                foreach (string sticker in System.IO.File.ReadAllLines($"Txts\\Stickers\\{StickersFile}", Encoding.UTF8)) {
                    Match m = stickersPattren.Match(sticker);
                    if (m.Success) {
                        _stickers.Add(new Sticker() {
                            Id = long.Parse(m.Groups[1].Value)
                        });
                    }
                    else {
                        LogForm.PushToLog($"{sticker} - некоррекный формат стикера");
                    }
                }

            if (ImagesFromFolder)
                UploadImages(acc);
            else
                foreach (string image in System.IO.File.ReadAllLines("Txts\\Attachments\\images.txt", Encoding.UTF8)) {
                    Match m = imagesPattren.Match(image);
                    if (m.Success) {
                        _images.Add(new Photo() {
                            OwnerId = long.Parse(m.Groups[1].Value),
                            Id = long.Parse(m.Groups[2].Value)
                        });
                    }
                    else {
                        LogForm.PushToLog($"{image} - некоррекный формат изображения");
                    }
                }
        }
        /// <summary>
        /// Добавить новую цель
        /// </summary>
        public void AddNewTarget(FlooderTarget target) {
            lock (Targets) {
                Targets.Add(target);
            }
        }
        /// <summary>
        /// Очистить цель
        /// </summary>
        public void ClearTarget() {
            lock (Targets) {
                Targets.Clear();
            }
        }
        public void RemoveTarget(FlooderTarget target) {
            lock (Targets) {
                Targets.Remove(target);
            }
        }
        /// <summary>
        /// Изменить цель
        /// </summary>
        /// <param name="from">Текущая цель</param>
        /// <param name="to">Цель, на которую изменить</param>
        public void ReplaceTarget(FlooderTarget from, FlooderTarget to) {
            lock (Targets) {
                int pos = Targets.IndexOf(from);
                if (pos != -1)
                    Targets[pos] = to;
            }
        }

        public FlooderTaskSettings() {
            Targets = new List<FlooderTarget>();
            ImagesFromFolder = false;
            PhrasesFile = PhrasesWithDotsFile = StickersFile = null;
        }

        public override void Validate() {
            var txtss = new List<string>(Directory.GetFiles("Txts\\Phrases\\Simple"));
            txtss = txtss.ConvertAll(Path.GetFileName);
            var txtsd = new List<string>(Directory.GetFiles("Txts\\Phrases\\Dots"));
            txtsd = txtsd.ConvertAll(Path.GetFileName);
            var stks = new List<string>(Directory.GetFiles("Txts\\Stickers"));
            stks = stks.ConvertAll(Path.GetFileName);
            if (!txtss.Contains(PhrasesFile))
                PhrasesFile = null;
            if (!txtsd.Contains(PhrasesWithDotsFile))
                PhrasesWithDotsFile = null;
            if (!stks.Contains(StickersFile)) {
                StickersFile = null;
                StickerId = null;
            }
        }
        public void ParseDataGridView(DataGridView view) {
            lock (Targets) {
                Targets.Clear();

                foreach (DataGridViewRow row in view.Rows) {
                    Targets.Add(new FlooderTarget() {
                        Link = (row.Cells[0].Value ?? "").ToString(),
                        NamePlace = row.Cells[1].Value.ToString(),
                        Name = (row.Cells[2].Value ?? "").ToString(),
                        Contains = row.Cells[3].Value.ToString()
                    });
                }
            }
        }
        /// <summary>
        /// Загрузка изображения на сервер
        /// </summary>
        /// <param name="acc"></param>
        private void UploadImages(Account acc) {
            LogForm.PushToLog(acc, "[Флудер]: загрузка изображений...");
            var imageFiles = Directory.GetFiles("Upload\\Images");
            var api = acc.VkApi;

            var wc = new System.Net.WebClient();

            foreach (string path in imageFiles) {
                var uploadServer = api.Photo.GetWallUploadServer();

                var responseFile = Encoding.ASCII.GetString(wc.UploadFile(uploadServer.UploadUrl, path));
                _images.AddRange(api.Photo.SaveWallPhoto(responseFile, 0));
                LogForm.PushToLog(acc, $"[Флудер]: загрузка {path} завершена");
            }
        }

        private static CounterContainer CounterContainerFromTarget(Account acc, FlooderTarget ft) {
            var td = LinkParser.Parse(acc, ft.Link);
            if (!_targetRelatedCounters.Keys.Contains(td))
                _targetRelatedCounters[td] = new CounterContainer();
            return _targetRelatedCounters[td];
        }
        /// <summary>
        /// Отправить аудио как голосовое сообщение
        /// </summary>
        /// <param name="acc">Текущий аккаунт</param>
        /// <returns></returns>
        public IReadOnlyCollection<MediaAttachment> CustomSendVoiceMessage(Account acc) {
            var vts = acc.VoiceTaskSettings;
            var api = acc.VkApi;
            var wc = new WebClient();

            var uploadUrlResponse = api.Call("docs.getUploadServer", new VkParameters {
                { "type", "audio_message" }
            });

            var uploadUrl = uploadUrlResponse["upload_url"].ToString();
            var fileResponse = JObject.Parse(Encoding.UTF8.GetString(wc.UploadFile(uploadUrl, vts.AudioMp3Name)));
            var fileId = Convert.ToString(fileResponse["file"]);

            var saveDocsResponse = api.Call("docs.save", new VkParameters {
                { "file", fileId }
            });

            var messageId = saveDocsResponse["audio_message"]["id"].ToString();
            var ownerId = saveDocsResponse["audio_message"]["owner_id"].ToString();

            return new List<MediaAttachment> {
                new Document {
                    OwnerId = long.Parse(ownerId),
                    Id = long.Parse(messageId)
                }
            }.ToReadOnlyCollection();
        }
        /// <summary>
        /// Отправить голосовое сообщение
        /// </summary>
        /// <param name="acc">Текущий аккаунт</param>
        /// <param name="message">Текст сообщения</param>
        /// <returns></returns>
        public IReadOnlyCollection<MediaAttachment> VoiceMessage(Account acc, string message) {
            try {
                var vts = acc.VoiceTaskSettings;
                var api = acc.VkApi;

                var wc = new System.Net.WebClient();
                var sp = (vts.Speed * 0.1).ToString().Replace(",", ".");
                var filename = $"tmp\\{_rnd.Next()}.mp3";
                message = WebUtility.UrlEncode(message);
                var link = $"https://tts.voicetech.yandex.net/generate?text={message}&format=mp3&lang=ru-RU&speaker={vts.Voice}&emotion={vts.Emotion}&speed={sp}&key={vts.Yandexapi}";
                wc.DownloadFile(link, filename);

                //UPLOAD

                var upl = new VkParameters {
                    { "type", "audio_message" }
                };

                var uploadServerInfo = api.Call("docs.getUploadServer", upl);
                var uplData = Encoding.UTF8.GetString(wc.UploadFile(new Uri(uploadServerInfo["upload_url"]), filename));
                var fileId = StrWrk.GetBetween(uplData, "\"file\":\"", "\"}");
                VkParameters sve = new VkParameters {
                    { "file", fileId }
                };

                //var readyToSend = api.Call("docs.save", sve).ToReadOnlyCollectionOf();

                System.IO.File.Delete(filename);

                return null;
            }
            catch (Exception ex) {
                LogForm.PushToLog(acc, "Ошибка при отправке голосового сообщения (что-то не так с api ключом?):" + ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Получить случайное изображение 
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<MediaAttachment> RandomImage() {
            if (_images.Count == 0) {
                LogForm.PushToLog("Нет доступных изображений для флуда");
                return null;
            }

            var toRet = new List<MediaAttachment>
            {
                _images[_rnd.Next(0, _images.Count)]
            };
            return toRet.ToReadOnlyCollection();
        }
        /// <summary>
        /// Получить случайный стикер
        /// </summary>
        /// <param name="acc">Текущий аккаунт</param>
        /// <param name="ft">Параметры флудера</param>
        /// <returns></returns>
        public IReadOnlyCollection<MediaAttachment> RandomSticker(Account acc, FlooderTarget ft) {
            if (_stickers.Count == 0) {
                LogForm.PushToLog("Нет доступных стикеров для флуда");
                return null;
            }

            List<MediaAttachment> toRet;
            if (StickerId == "По порядку") {
                var ccft = CounterContainerFromTarget(acc, ft);
                ccft.StIndex = (ccft.StIndex + 1) % _stickers.Count;

                toRet = new List<MediaAttachment>
                {
                    _stickers[CounterContainerFromTarget(acc, ft).StIndex]
                };
            }
            else {
                try {
                    toRet = new List<MediaAttachment>
                    {
                        new Sticker()
                        {
                            Id = long.Parse(new Regex("([0-9]+)").Match(StickerId).Groups[1].Value)
                        }
                    };
                }
                catch {
                    LogForm.PushToLog($"{StickerId} - неверный формат стикера");
                    return null;
                }
            }

            return toRet.ToReadOnlyCollection();
        }
        /// <summary>
        /// Получить случайное видео
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<MediaAttachment> RandomVideo() {
            if (_videos.Count == 0) {
                LogForm.PushToLog("videos.txt пуст");
                return null;
            }

            var toRet = new List<MediaAttachment>
            {
                _videos[_rnd.Next(0, _videos.Count)]
            };
            return toRet.ToReadOnlyCollection();
        }
        /// <summary>
        /// Получить случайный документ
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<MediaAttachment> RandomDocument() {
            if (_documents.Count == 0) {
                LogForm.PushToLog("Папка с документами пуста");
                return null;
            }

            var toRet = new List<MediaAttachment>
            {
                _documents[_rnd.Next(0, _documents.Count)]
            };

            return toRet.ToReadOnlyCollection();
        }
        /// <summary>
        /// Получить случайное аудио
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<MediaAttachment> RandomAudio() {
            if (_audios.Count == 0) {
                LogForm.PushToLog("audios.txt пуст");
                return null;
            }

            var toRet = new List<MediaAttachment>
            {
                _audios[_rnd.Next(0, _audios.Count)]
            };
            return toRet.ToReadOnlyCollection();
        }
        /// <summary>
        /// Получить фразы для флуда
        /// </summary>
        /// <returns></returns>
        public string GetPhrase(Account acc, FlooderTarget ft) {
            if (_phrases.Count == 0) {
                LogForm.PushToLog("Нет доступных фраз для флуда");
                return null;
            }

            var ccft = CounterContainerFromTarget(acc, ft);
            ccft.PhIndex = (ccft.PhIndex + 1) % _phrases.Count;

            return _phrases[ccft.PhIndex];
        }
        /// <summary>
        /// Получить фразы для флуда с точками
        /// </summary>
        /// <returns></returns>
        public string GetPhraseWithDots(Account acc, FlooderTarget ft) {
            if (_phrasesWithDots.Count == 0) {
                LogForm.PushToLog("Нет доступных фраз с точками для флуда");
                return null;
            }

            var ccft = CounterContainerFromTarget(acc, ft);
            ccft.PhDotsIndex = (ccft.PhDotsIndex + 1) % _phrasesWithDots.Count;

            return _phrasesWithDots[ccft.PhDotsIndex++];
        }
    }
}
