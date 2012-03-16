using System;

namespace AdapterExample
{
    using AdapterExample.Developer;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Adapter Example");
            Console.WriteLine("---------------");
            Console.WriteLine();

            // create a developer and a consultant
            var developer = new Developer.Developer();
            var consultant = new Consultant.Consultant();

            // show the consultant output
            Console.WriteLine("--- Testing Consultant ---");
            Console.Write("Estimating: ");
            consultant.PickNumberOutOfAss();
            Console.Write("Engineering: ");
            consultant.OverengineerStuff();

            Console.WriteLine();

            // test developer output using helper function below that expects IDeveloper
            Console.WriteLine("--- Testing Developer ---");
            TestDeveloper(developer);
            
            Console.WriteLine();

            // create an adapter so that the consultant looks like a developer
            var adapter = new Adapter.ConsultantDeveloperAdapter(consultant);

            // test the adapter using the IDeveloper interface
            Console.WriteLine("--- Testing ConsultantDeveloperAdapter ---");
            TestDeveloper(adapter);

            Console.WriteLine();
            Console.WriteLine("Any key to exit.");
            Console.ReadKey();


        }

        static void TestDeveloper(IDeveloper developer)
        {
            Console.Write("Estimating: ");
            developer.EstimateTime();

            Console.Write("Engineering: ");
            developer.WriteSoftware();
        }
    }
}
