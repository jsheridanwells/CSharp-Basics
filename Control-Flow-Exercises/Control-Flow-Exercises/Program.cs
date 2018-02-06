using System;

namespace Control_Flow_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // print all numbers between 1 and 100 that are divisible by 3
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i);
                    Console.Write(", ");
                }
            }
            // ask the user for a number over and over again
            //until the user enters "OK"
            // return the sum of all of the numbers
            var sum = 0;
            while (true) 
            {
                Console.WriteLine("Enter a number of type 'OK' to exit");
                string input = Console.ReadLine();
                if (input == "OK") {
                    break;
                }
O                sum += Convert.ToInt32(input);

            }
            Console.WriteLine(sum);

            // print the factorial of a number that a user enters
            Console.WriteLine("Enter a number. I will factorialize it!");

            var myNum = Convert.ToInt32(Console.ReadLine());
            var factorialized = 1;
            for (var i = myNum; i > 0; i--)
            {
                factorialized *= i;
            }
            Console.WriteLine("{0}! is {1}", myNum, factorialized);

            // Write a program that asks for a series of comma-separated numbers
            // return the maximum number
            Console.WriteLine("Give me some numbers. Separate them with a comma. I will tell you the maximum number");
            var input = Console.ReadLine();
            var numbersArr = input.Split(',');
            var max = Convert.ToInt32(numbersArr[0]);
            foreach (var num in numbersArr)
            {
                if (Convert.ToInt32(num) > max) {
                    max = Convert.ToInt32(num);
                }
            }
            Console.WriteLine("Your maximum number is {0}", max);
        }
    }
}
