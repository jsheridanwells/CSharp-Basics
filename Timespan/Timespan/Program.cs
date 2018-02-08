using System;

namespace Timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);

            Console.WriteLine("Timespan: ", timeSpan);
            Console.WriteLine("Timepan 1: ", timeSpan1);
        }
    }
}
