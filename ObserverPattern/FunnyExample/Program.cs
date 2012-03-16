using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyExample
{
    using FunnyExample.Employees;
    using FunnyExample.Manager;

    using ObserverPattern.Clock;
    using ObserverPattern.ClockObservers;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer Pattern funny example");
            Console.WriteLine("------------------------------");

            var employees = new List<IConsoleEmployee>();
            var managerSubject = new ManagerSubject();

            employees.Add(new APlayerEmployee(managerSubject));
            employees.Add(new BPlayerEmployee(managerSubject));
            employees.Add(new CPlayerEmployee(managerSubject));

            var isRunning = true;
            var lastState = false;
            while (isRunning)
            {
                Console.WriteLine();
                Console.WriteLine("Toggling Manager state...");
                managerSubject.SetState(new ManagerState(!lastState));
                lastState = !lastState;

                Console.WriteLine("Manager is in office: " + managerSubject.GetState().IsInRoom);

                Console.WriteLine("Checking employee status...");

                foreach (var employee in employees)
                {
                    employee.WriteStateToConsole();
                }

                Console.WriteLine();
                Console.WriteLine("X key to exit, any key to repeat.");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.X)
                {
                    isRunning = false;
                }
            }
        }
    }
}
