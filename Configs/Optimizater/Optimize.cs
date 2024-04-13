using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ISP.Configs.Optimizater {
    public class Optimize {
        [DllImport("kernel32.dll")]
        static extern bool SetProcessWorkingSetSize(IntPtr hProcess,
             int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);
        public Optimize()
            => SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
    }
}
