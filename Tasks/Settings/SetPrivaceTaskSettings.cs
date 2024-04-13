using System;

namespace ISP.Tasks.Settings {
    internal class SetPrivaceTaskSettings : ISBTaskSettings {
        /// <summary>
        /// Имя 
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        public override void Validate() { }
    }
}
