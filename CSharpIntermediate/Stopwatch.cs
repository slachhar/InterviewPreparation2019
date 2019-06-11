using System;

namespace CSharpIntermediate
{
    public class Stopwatch
    {
        public TimeSpan TimespanStopWatch { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; private set; }
        public Boolean IsClockRunning { get; set; }

        public void Start()
        {
            if (!IsClockRunning)
            {
                StartTime = DateTime.Now;
                IsClockRunning = true;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Stop()
        {
            EndTime = DateTime.Now;
            IsClockRunning = false;
        }

        public TimeSpan Duration()
        {
            return (StartTime - EndTime) > TimeSpan.Zero ? (StartTime - EndTime) : (StartTime - DateTime.Now);
        }
    }
}