using System;
using System.Threading;

namespace ISP.Misc {
    /// <summary>
    /// Класс для запуска задачи через таймер
    /// </summary>
    internal class SingleSimrunTimer : IDisposable {
        private readonly System.Threading.Timer _timer;
        private bool _isRunning = false;

        /// <summary>
        /// Конструктор для инициализации таймера выполнения задачи
        /// </summary>
        /// <param name="toRun">Делегат действия, которое нужно выполнить</param>
        /// <param name="timerInMs">Интервал времени в миллисекундах для выполнения задачи</param>
        public SingleSimrunTimer(Action toRun, int timerInMs) {
            _timer = new Timer((nullobj) => {
                if (_isRunning)
                    return;
                _isRunning = true;
                toRun();
                _isRunning = false;
            }, null, 0, timerInMs);
        }

        /// <summary>
        /// Освобождение ресурсов таймера
        /// </summary>
        public void Dispose() {
            _timer?.Dispose();
        }
    }

}