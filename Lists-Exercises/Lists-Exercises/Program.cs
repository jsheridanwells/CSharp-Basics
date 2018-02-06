using System;
using System.Collections.Generic;

namespace Lists_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // display number of names based on names in a list
            //var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name to add to the list.");
                var newName = Console.ReadLine();
                if (newName == "")
                {
                    break;
                }

                names.Add(newName);

                if (names.Count == 1)
                {
                    Console.WriteLine("{0} likes your post.", names[0]);
                }
                else if (names.Count == 2)
                {
                    Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
                }
                else
                {
                    Console.WriteLine("{0} people like your post.", names.Count);
                }
            }

            // Reverse the name that the user enters
            //Console.WriteLine("Enter your name and I'll reverse it.");
            //var input = Convert.ToString(Console.ReadLine());

            char[] name = new char[input.Length];
            var count = 0;
            for (var i = name.Length - 1; i >= 0; i--)
            {
                name[i] = input[count];
                count++;
            }
            var reversed = new String(name);
            Console.WriteLine("Your name reversed is: {0}", reversed);

            // Ask the user for 5 unique numbers
            // if there are repeats, throw an error
            // if the numbers are valid, sort them

            Console.WriteLine("Give me 5 unique numbers and I will sort them. They must be unique!");
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                var newNum = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(newNum))
                {
                    Console.WriteLine("Unique numbers, buddy!");
                }
                else 
                {
                    numbers.Add(newNum);
                }
            }
            numbers.Sort();
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }

            // A user enters 5 numbers separated by commas
            // if the list is blank, raise an error
            // if the list is less than 5 numbers, raise an error
            // otherwise, display the three smallest numbers

            Console.WriteLine("Give me 5 numbers, separated by commas, and I'll tell you the three smallest.");

            string[] numArr;

            while (true) 
            {
                string numStr = Console.ReadLine();
                if (numStr.Split(',').Length < 5) 
                {
                    Console.WriteLine("It's less than 5, buddy. Try again.");    
                }
                else
                {
                    numArr = numStr.Split(',');
                    break;
                }
            }

            int[] numbers = new int[numArr.Length];

            for (var i = 0; i < numArr.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numArr[i]);
            }

            Array.Sort(numbers);

            Console.WriteLine("Your three smallest numbers are:");
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
