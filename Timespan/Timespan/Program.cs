using System;

namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Timespan objects
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);

            // Specifying duration
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; 
            Console.WriteLine("La duraction es: " + duration);

            // Properties of TimeSpan
            Console.WriteLine("Minutes: " + timeSpan.Minutes);  // 2
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);  // 62.05

            // TimeSpans are immutables, some methods can change them
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // Converstion to and from strings
            Console.WriteLine("ToString: " + timeSpan.ToString());

            // Parsing
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
