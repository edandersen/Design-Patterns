using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.Plumbing
{
    public class Subject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.RemoveAll(o => o == observer);
        }

        public void Notify()
        {
            foreach (var observer in this.observers)
            {
                observer.Update();
            }
        }
    }
}
