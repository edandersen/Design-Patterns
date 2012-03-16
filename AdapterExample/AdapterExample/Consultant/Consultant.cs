namespace AdapterExample.Consultant
{
    using System;

    /// <summary>
    /// Implements an overly elaborate waste of time
    /// </summary>
    public class Consultant : IConsultant
    {
        public void PickNumberOutOfAss()
        {
            var randomNumber = new Random().Next(1000);
            Console.WriteLine(String.Format("I estimate {0} weeks.",randomNumber + 1));
        }

        public void OverengineerStuff()
        {
            Console.WriteLine("Implemented an Enterprise SCMERPCRMWTFBBQ solution.");
        }
    }
}
