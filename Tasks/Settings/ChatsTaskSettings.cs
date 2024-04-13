using ISP.Engine.Accounts;
using ISP.Engine.Helpers;
using ISP.Forms;
using ISP.Objects.Targets;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ISP.Tasks.Settings {

    internal sealed class ChatsTaskSettings : ISBTaskSettings {
        private class CounterContainer {
            public int TitleIndex = -1;
        }

        private static Dictionary<TargetData, CounterContainer> _targetRelatedCounters;
        /// <summary>
        /// Список целей
        /// </summary>
        public readonly List<ChatsTarget> Targets;
        /// <summary>
        /// Список названий чата для флуда
        /// </summary>
        private static List<string> _titlesToFlood;

        static ChatsTaskSettings() {
            ReloadFromTxts();
        }
        /// <summary>
        /// Загрузить данные из .txt
        /// </summary>
        public static void ReloadFromTxts() {
            _titlesToFlood = new List<string>(File.ReadAllLines("Txts\\titles.txt", Encoding.GetEncoding("windows-1251")));
            _targetRelatedCounters = new Dictionary<TargetData, CounterContainer>();
        }

        public ChatsTaskSettings() {
            Targets = new List<ChatsTarget>();
        }

        private static CounterContainer CounterContainerFromTarget(Account acc, ChatsTarget ctg) {
            var td = LinkParser.Parse(acc, ctg.Link);
            if (!_targetRelatedCounters.Keys.Contains(td))
                _targetRelatedCounters[td] = new CounterContainer();
            return _targetRelatedCounters[td];
        }
        /// <summary>
        /// Добавить новую цель
        /// </summary>
        public void AddNewTarget(ChatsTarget target) {
            lock (Targets) {
                Targets.Add(target);
            }
        }
        /// <summary>
        /// Удалить цель
        /// </summary>
        public void RemoveTarget(ChatsTarget target) {
            lock (Targets) {
                Targets.Remove(target);
            }
        }
        /// <summary>
        /// Изменить цель
        /// </summary>
        public void ReplaceTarget(ChatsTarget from, ChatsTarget to) {
            lock (Targets) {
                int pos = Targets.IndexOf(from);
                if (pos != -1)
                    Targets[pos] = to;
            }
        }

        public void ParseDataGridView(DataGridView view) {
            lock (Targets) {
                Targets.Clear();

                foreach (DataGridViewRow row in view.Rows) {
                    Targets.Add(new ChatsTarget() {
                        Link = (row.Cells[0].Value ?? "").ToString(),
                        TitleMode = row.Cells[1].Value.ToString(),
                        Title = (row.Cells[2].Value ?? "").ToString(),
                        AvatarMode = row.Cells[3].Value.ToString(),
                        FloodWithAvatar = (bool)row.Cells[4].Value
                    });
                }
            }
        }

        public override void Validate() {
            var avs = new List<string>(Directory.GetFiles("Upload\\Avatars"));
            avs = avs.ConvertAll(Path.GetFileName);
            foreach (var target in Targets)
                if (target.AvatarMode != "Ничего не делать" &&
                    !avs.Contains(target.AvatarMode))
                    target.AvatarMode = "Ничего не делать";
        }
        /// <summary>
        /// Получить доступные названия чата для смены
        /// </summary>
        /// <param name="acc"></param>
        /// <param name="ctg"></param>
        /// <returns></returns>
        public string GetTitle(Account acc, ChatsTarget ctg) {
            if (_titlesToFlood.Count == 0) {
                LogForm.PushToLog("Нет доступных названий бесед для флуда");
                return null;
            }

            var ccft = CounterContainerFromTarget(acc, ctg);
            ccft.TitleIndex = (ccft.TitleIndex + 1) % _titlesToFlood.Count;

            return _titlesToFlood[ccft.TitleIndex];
        }
    }
}
