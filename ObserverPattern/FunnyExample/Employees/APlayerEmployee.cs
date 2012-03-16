namespace ObserverPattern.ClockObservers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    using FunnyExample.Employees;
    using FunnyExample.Manager;

    using ObserverPattern.Clock;
    using ObserverPattern.Plumbing;

    public class APlayerEmployee : IObserver, IConsoleEmployee
    {
        public APlayerEmployee(ManagerSubject managersubject)
        {
            managersubject.Attach(this);
        }

        public void Update()
        {
            // do nothing as we don't care about state in this Observer
        }

        private void PerformExemplaryWork()
        {
            Console.WriteLine("A Player employee is Working Hard as usual!");
        }

        public void WriteStateToConsole()
        {
            this.PerformExemplaryWork();
        }
    }
}
