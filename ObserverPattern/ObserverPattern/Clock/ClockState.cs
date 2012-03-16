using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.Clock
{
    public class ClockState
    {
        public ClockState()
        {
            this.Time = DateTime.Now;
        }

        public ClockState(DateTime time)
        {
            this.Time = time;
        }

        public DateTime Time { get; set; }
    }
}
