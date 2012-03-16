namespace ObserverPattern.ClockObservers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    using ObserverPattern.Clock;
    using ObserverPattern.Plumbing;

    public class SecondsCountingConsoleClock : IObserver, IConsoleClock
    {
        private ClockState currentState;

        private readonly ClockSubject clockSubject;

        public SecondsCountingConsoleClock(ClockSubject clockSubject)
        {
            // register with the clock subject for updates
            this.clockSubject = clockSubject;

            clockSubject.Attach(this);
        }

        public void Update()
        {
            this.currentState = this.clockSubject.GetState();
        }

        public void WriteStateToConsole()
        {
            Console.WriteLine("Second count: " + this.currentState.Time.Second);
        }
    }
}
