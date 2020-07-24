using System;
using System.Diagnostics;

namespace chapter1
{
    public class Timing
    {
        private TimeSpan duration;
        public Timing()
        {
            duration = new TimeSpan(0);
        }
        public void StopTime() => duration = Process.GetCurrentProcess().Threads[0].TotalProcessorTime;
        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public TimeSpan Result() => duration;

    }
}
