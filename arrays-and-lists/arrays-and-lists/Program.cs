using System;
using System.Collections.Generic;

namespace arrays_and_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers.Add(6);
            numbers.AddRange(new int[3] {6, 7, 8 });

            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
            // #IndexOf()
            Console.WriteLine(numbers.IndexOf(1));
        }
    }
}
