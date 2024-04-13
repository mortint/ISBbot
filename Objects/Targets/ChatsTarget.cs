using Newtonsoft.Json;

namespace ISP.Objects.Targets {
    internal sealed class ChatsTarget {
        /// <summary>
        /// Ссылка на цель (чат)
        /// </summary>
        public string Link;
        /// <summary>
        /// Действие с названием
        /// </summary>
        public string TitleMode;
        /// <summary>
        /// Новое название чата
        /// </summary>
        public string Title;
        /// <summary>
        /// Действие с аватаром чата
        /// </summary>
        public string AvatarMode;
        /// <summary>
        /// Фото чата 200х200
        /// </summary>
        [JsonIgnore] public string TargetPhoto200 = null;
        /// <summary>
        /// Спамить сменой аватара
        /// </summary>
        public bool FloodWithAvatar;

        public ChatsTarget() { }

        public override bool Equals(object obj) {
            if (obj == null) return false;
            ChatsTarget ftg2 = obj as ChatsTarget;
            if (ftg2 == null) return false;
            return Equals(ftg2);
        }

        private bool Equals(ChatsTarget other) {
            return string.Equals(Link, other.Link)
                && string.Equals(TitleMode, other.TitleMode)
                && string.Equals(Title, other.Title)
                && string.Equals(AvatarMode, other.AvatarMode)
                && string.Equals(TargetPhoto200, other.TargetPhoto200)
                && FloodWithAvatar == other.FloodWithAvatar;
        }

        public override int GetHashCode() {
            unchecked {
                int hashCode = (Link != null ? Link.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (TitleMode != null ? TitleMode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Title != null ? Title.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (AvatarMode != null ? AvatarMode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (TargetPhoto200 != null ? TargetPhoto200.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ FloodWithAvatar.GetHashCode();
                return hashCode;
            }
        }
    }
}
