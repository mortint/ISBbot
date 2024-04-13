using ISP.Engine.Accounts;
using ISP.Engine.Helpers;
using ISP.Forms;
using ISP.Objects.Targets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VkNet.Model;
using VkNet.Utils;

namespace ISP.Tasks.Settings {
    internal sealed class AutoansTaskSettings : ISBTaskSettings {
        private class CounterContainer {
            public int PhIndex = -1, StIndex = -1;
        }
        /// <summary>
        /// Список целей
        /// </summary>
        public readonly List<AutoansTarget> Targets;

        public string PhrasesFile, StickersFile, StickerId;
        private static Dictionary<TargetData, CounterContainer> _targetRelatedCounters;
        private List<string> _phrases;
        private static List<MediaAttachment> _videos;
        private List<MediaAttachment> _documents, _images, _stickers;
        private static Random _rnd;

        static AutoansTaskSettings() {
            ReloadFromTxts();
        }
        /// <summary>
        /// Загрузка данных из .txt
        /// </summary>
        public static void ReloadFromTxts() {
            _targetRelatedCounters = new Dictionary<TargetData, CounterContainer>();
            _rnd = new Random();
            _videos = new List<MediaAttachment>();

            Regex videosPattren = new Regex("video(-?[0-9]+)_([0-9]+)");

            foreach (string video in System.IO.File.ReadAllLines("Txts\\Attachments\\videos.txt", Encoding.GetEncoding("windows-1251"))) {
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
        }

        public void LoadAccountSpecific(Account acc) {
            _phrases = new List<string>();
            if (!string.IsNullOrEmpty(PhrasesFile))
                _phrases = new List<string>(System.IO.File.ReadAllLines($"Txts\\Phrases\\Autoans\\{PhrasesFile}", Encoding.GetEncoding(1251)));

            _documents = new List<MediaAttachment>();
            _images = new List<MediaAttachment>();
            _stickers = new List<MediaAttachment>();

            Regex imagesPattren = new Regex("photo(-?[0-9]+)_([0-9]+)");
            Regex stickersPattren = new Regex("([0-9]+)");

            if (!string.IsNullOrEmpty(StickersFile)) {
                foreach (string sticker in System.IO.File.ReadAllLines($"Txts\\Stickers\\{StickersFile}", Encoding.GetEncoding("windows-1251"))) {
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
            }

            foreach (string image in System.IO.File.ReadAllLines("Txts\\Attachments\\images.txt", Encoding.GetEncoding("windows-1251"))) {
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
         /// <param name="target"></param>
        public void AddNewTarget(AutoansTarget target) {
            lock (Targets) {
                Targets.Add(target);
            }
        }
        /// <summary>
        /// Удалить цель
        /// </summary>
        public void ClearTarget() {
            lock (Targets) {
                Targets.Clear();
            }
        }
        /// <summary>
        /// Удалить
        /// </summary>
        public void RemoveTarget(AutoansTarget target) {
            lock (Targets) {
                Targets.Remove(target);
            }
        }
        /// <summary>
        /// Изменить цель
        /// </summary>
        public void ReplaceTarget(AutoansTarget from, AutoansTarget to) {
            lock (Targets) {
                int pos = Targets.IndexOf(from);
                if (pos != -1)
                    Targets[pos] = to;
            }
        }

        public AutoansTaskSettings() {
            Targets = new List<AutoansTarget>();
            PhrasesFile = StickersFile = null;
        }

        public override void Validate() {
            var txtss = new List<string>(Directory.GetFiles("Txts\\Phrases\\Autoans"));
            txtss = txtss.ConvertAll(Path.GetFileName);
            var stks = new List<string>(Directory.GetFiles("Txts\\Stickers"));
            stks = stks.ConvertAll(Path.GetFileName);
            if (!txtss.Contains(PhrasesFile))
                PhrasesFile = null;
            if (!stks.Contains(StickersFile)) {
                StickersFile = null;
                StickerId = null;
            }
        }

        public void ParseDataGridView(DataGridView view) {
            lock (Targets) {
                Targets.Clear();

                foreach (DataGridViewRow row in view.Rows) {
                    Targets.Add(new AutoansTarget() {
                        Link = (row.Cells[0].Value ?? "").ToString(),
                        NamePlace = row.Cells[1].Value.ToString(),
                        Name = (row.Cells[2].Value ?? "").ToString(),
                        Contains = row.Cells[3].Value.ToString()
                    });
                }
            }
        }

        private static CounterContainer CounterContainerFromTarget(Account acc, AutoansTarget at) {
            var td = LinkParser.Parse(acc, at.Link);
            if (!_targetRelatedCounters.Keys.Contains(td))
                _targetRelatedCounters[td] = new CounterContainer();
            return _targetRelatedCounters[td];
        }
        /// <summary>
        /// Получить случайные изображения
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<MediaAttachment> RandomImage() {
            if (_images.Count == 0) {
                LogForm.PushToLog("Нет доступных изображений для автоответа");
                return null;
            }

            var toRet = new List<MediaAttachment>
            {
                _images[_rnd.Next(0, _images.Count)]
            };
            return toRet.ToReadOnlyCollection();
        }
        /// <summary>
        /// Получить стикер
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<MediaAttachment> RandomSticker(Account acc, AutoansTarget at) {
            if (_stickers.Count == 0) {
                LogForm.PushToLog("Нет доступных стикеров для флуда");
                return null;
            }

            List<MediaAttachment> toRet;
            if (StickerId == "По порядку") {
                var ccft = CounterContainerFromTarget(acc, at);
                ccft.StIndex = (ccft.StIndex + 1) % _stickers.Count;

                toRet = new List<MediaAttachment>
                {
                    _stickers[CounterContainerFromTarget(acc, at).StIndex]
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
        /// Получить фразы
        /// </summary>
        /// <returns></returns>
        public string GetPhrase(Account acc, AutoansTarget at) {
            if (_phrases.Count == 0) {
                LogForm.PushToLog("Нет доступных фраз для флуда");
                return null;
            }

            var ccft = CounterContainerFromTarget(acc, at);
            ccft.PhIndex = (ccft.PhIndex + 1) % _phrases.Count;

            return _phrases[ccft.PhIndex];
        }
    }
}
