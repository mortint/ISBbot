namespace ISP.Objects.Targets {
    internal sealed class FlooderTarget {
        /// <summary>
        /// Ссылка на цель
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

        public FlooderTarget() { }

        public FlooderTarget(FlooderTarget ftg) {
            Link = ftg.Link;
            NamePlace = ftg.NamePlace;
            Name = ftg.Name;
            Contains = ftg.Contains;
        }

        public override bool Equals(object obj) {
            if (obj == null) return false;
            FlooderTarget ftg2 = obj as FlooderTarget;
            if (ftg2 == null) return false;
            return Equals(ftg2);
        }

        private bool Equals(FlooderTarget other) {
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
