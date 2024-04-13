using ISP.Engine.Accounts;
using ISP.Misc;

namespace ISP.Tasks {
    internal abstract class ISBTask {
        protected SingleSimrunTimer PeriodicTimer;

        public abstract void LaunchTask(Account acc);
        public abstract void StopTask();
    }
}
