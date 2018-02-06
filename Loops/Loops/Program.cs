using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // print every even number from 1 to 10.
            for (var i = 0; i <= 10; i++) 
            {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
            // in revers
            for (var i = 10; i >= 0; i--) 
            {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }
            // iterate over a string
            var myString = "I am a lovely string and I'm going away.";
            for (var i = 0; i < myString.Length; i++) 
            {
                Console.WriteLine(myString[i]);
            }

            // using a foreach
            foreach (var character in myString) 
            {
                Console.WriteLine(character);
            }

            // using an array
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // using a while loop
            while (true) {
                Console.Write("Type your name");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Echo: {0}.", input);
                    continue;
                }
                break;

            }
        }
    }
}
