using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.ClockObservers
{
    public interface IConsoleClock
    {
        void WriteStateToConsole();
    }
}
