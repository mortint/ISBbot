
namespace ISP.Objects.Targets {
    internal sealed class AutoansTarget {
        /// <summary>
        /// ССылка на цель
        /// </summary>
        public string Link;
        /// <summary>
        /// Расположение обращения
        /// </summary>
        public string NamePlace;
        /// <summary>
        /// Обращение
        /// </summary>
        public string Name;
        /// <summary>
        /// Содержимое
        /// </summary>
        public string Contains;

        public AutoansTarget() { }

        public AutoansTarget(AutoansTarget atg) {
            Link = atg.Link;
            NamePlace = atg.NamePlace;
            Name = atg.Name;
            Contains = atg.Contains;
        }

        public override bool Equals(object obj) {
            if (obj == null) return false;
            AutoansTarget atg2 = obj as AutoansTarget;
            if (atg2 == null) return false;
            return Equals(atg2);
        }

        private bool Equals(AutoansTarget other) {
            return string.Equals(Link, other.Link)
                && string.Equals(NamePlace, other.NamePlace)
                && string.Equals(Name, other.Name)
                && string.Equals(Contains, other.Contains);
        }

        public override int GetHashCode() {
            unchecked {
                int hashCode = (Link != null ? Link.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (NamePlace != null ? NamePlace.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Contains != null ? Contains.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
