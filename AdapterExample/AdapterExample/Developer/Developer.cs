namespace AdapterExample.Developer
{
    using System;

    /// <summary>
    /// Implements a nice normal developer
    /// </summary>
    public class Developer : IDeveloper
    {
        public void EstimateTime()
        {
            Console.WriteLine("I estimate 2 weeks.");
        }

        public void WriteSoftware()
        {
            Console.WriteLine("Created a nice simple solution that gets the job done.");
        }
    }
}
