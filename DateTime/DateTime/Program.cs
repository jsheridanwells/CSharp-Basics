using System;

namespace DateTimeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a date with given values
            var myDate = new DateTime(2018, 8, 2);

            // Declare NOW
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("This hour: " + now.Hour);
            Console.WriteLine("This minute: " + now.Minute);

            // DateTimes are immutable, but can be changed with methods
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("Manana es: ", tomorrow);
            Console.WriteLine("Ayer fue: ", yesterday);

            // Date and Time Formats:
            Console.WriteLine(now.ToShortDateString());  // 2/8/18
            Console.WriteLine(now.ToLongDateString());  // Thursday, February 8, 2018
            Console.WriteLine(now.ToShortTimeString());  // 10:40 AM
            Console.WriteLine(now.ToLongTimeString());  //  10:40:00 AM

        }
    }
}
