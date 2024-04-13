using System;
using System.Threading;

namespace ISP.Misc
{
    internal class SingleSimrunTimer : IDisposable
    {
        private readonly System.Threading.Timer _timer;
        private bool _isRunning = false;
        public SingleSimrunTimer(Action toRun, int timerInMs)
        {
            _timer = new Timer((nullobj) =>
            {
                if (_isRunning)
                    return;
                _isRunning = true;
                toRun();
                _isRunning = false;
            }, null, 0, timerInMs);
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}