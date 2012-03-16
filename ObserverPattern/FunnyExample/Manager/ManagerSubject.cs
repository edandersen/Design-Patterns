namespace ObserverPattern.Clock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using FunnyExample.Manager;

    using ObserverPattern.Plumbing;

    public class ManagerSubject : Subject
    {
        private ManagerState currentManagerState;

        public ManagerSubject()
        {
            this.currentManagerState = new ManagerState();
        }

        public ManagerState GetState()
        {
            return this.currentManagerState;
        }

        public void SetState(ManagerState managerState)
        {
            this.currentManagerState = managerState;

            Notify();
        }
    }
}
