using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    using ObserverPattern.Clock;
    using ObserverPattern.ClockObservers;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer Pattern example");
            Console.WriteLine("------------------------");

            var consoleClocks = new List<IConsoleClock>();
            var clockSubject = new ClockSubject();

            consoleClocks.Add(new GMTConsoleClock(clockSubject));
            consoleClocks.Add(new SecondsCountingConsoleClock(clockSubject));

            var isRunning = true;
            while (isRunning)
            {
                Console.WriteLine();
                Console.WriteLine("Setting Time to now...");
                clockSubject.SetState(new ClockState());

                Console.WriteLine("Printing updated values from Clock Observers...");

                foreach (var clock in consoleClocks)
                {
                    clock.WriteStateToConsole();
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
