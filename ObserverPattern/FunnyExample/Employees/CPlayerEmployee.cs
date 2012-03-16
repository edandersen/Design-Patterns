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

    public class CPlayerEmployee : IObserver, IConsoleEmployee
    {
        private readonly ManagerSubject managerSubject;

        private ManagerState managerState;

        public CPlayerEmployee(ManagerSubject managersubject)
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
            if (this.managerState.IsInRoom) this.HaveANap();
            else this.MakeMoney();
        }

        private void HaveANap()
        {
            Console.WriteLine("C Player employee is asleep.");
        }

        private void MakeMoney()
        {
            Console.WriteLine("C Player employee is running an illegal gambling ring.");
        }

    }
}
