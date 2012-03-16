namespace ObserverPattern.Clock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using ObserverPattern.Plumbing;

    public class ClockSubject : Subject
    {
        private ClockState currentClockState;

        public ClockSubject()
        {
            this.currentClockState = new ClockState();
        }

        public ClockState GetState()
        {
            return this.currentClockState;
        }

        public void SetState(ClockState clockState)
        {
            this.currentClockState = clockState;

            Notify();
        }
    }
}
