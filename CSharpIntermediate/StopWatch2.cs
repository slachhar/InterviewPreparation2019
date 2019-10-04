using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class StopWatch2
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _duration;

        public void Start()
        {
            if (_startTime == DateTime.MinValue)
                _startTime = DateTime.Now;
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Stop()
        {
            if (_startTime == DateTime.MinValue)
                _endTime = DateTime.Now;
            else
            {
                throw new InvalidOperationException();
            }
        }

        public TimeSpan Duration
        {
            get
            {
                _duration = _startTime - _endTime;
                _startTime = DateTime.MinValue;
                _endTime = DateTime.MinValue;
                return _duration;
            }
        }
    }
}
