using ISP.Enums.Parser;

namespace ISP.Objects.Targets {
    internal struct TargetData {
        /// <summary>
        /// Тип цели
        /// </summary>
        public readonly TypeOfTarget Type;
        /// <summary>
        /// ID целей
        /// </summary>
        public long? Id1, Id2;

        public TargetData(TypeOfTarget type, string id1, string id2) {
            Type = type;
            Id1 = long.Parse(id1);
            Id2 = long.Parse(id2);
        }

        public TargetData(TypeOfTarget type) {
            Type = type;
            Id1 = Id2 = null;
        }
    }
}
