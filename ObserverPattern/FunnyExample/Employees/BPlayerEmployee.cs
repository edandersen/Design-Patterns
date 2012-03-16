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

    public class BPlayerEmployee : IObserver, IConsoleEmployee
    {
        private readonly ManagerSubject managerSubject;

        private ManagerState managerState;

        public BPlayerEmployee(ManagerSubject managersubject)
        {
            this.managerSubject = managersubject;

            managersubject.Attach(this);
        }

        public void Update()
        {
            this.managerState = this.managerSubject.GetState();
        }

        public void WriteStateToConsole()
        {
            if (this.managerState.IsInRoom) this.LookBusy();
            else this.GoofOff();
        }

        private void LookBusy()
        {
            Console.WriteLine("B Player employee looks like he is working hard!");
        }

        private void GoofOff()
        {
            Console.WriteLine("B Player employee is looking at pictures of cats on the internet.");
        }

    }
}
