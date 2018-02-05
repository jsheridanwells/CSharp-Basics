using System;

namespace Control_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Conditionals
    {
        public void validNumbers()
        {
            Console.Write("Enter a number between 1 and 10.");
            var input = Console.Read();
            var num = Convert.ToInt32(input);

            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Your number is valid. Yay!");
            }
            else
            {
                Console.WriteLine("Your number is not valid. Boo!");
            }
        }

        public void showMax()
        {
            Console.WriteLine("Enter two numbers");
            var input1 = Console.Read();
            var input2 = Console.Read();

            int a = Convert.ToInt32(input1);
            int b = Convert.ToInt32(input2);

            if (a > b)
            {
                Console.WriteLine("{0} is bigger", a);
            }
            else 
            {
                Console.WriteLine("{0} is bigger", b);
            }

        }
        public void landscapeOrPortrait()
        {
            Console.WriteLine("Enter the dimensions of an image, width x height");
            var input1 = Console.Read();
            var input2 = Console.Read();

            int height = Convert.ToInt32(input1);
            int width = Convert.ToInt32(input2);

            if (height > width) 
            {
                Console.WriteLine("Your image is a portrait.");
            }
            else if (width > height)
            {
                Console.WriteLine("Your image is a landscape.");
            }
            else 
            {
                Console.WriteLine("Your image must be a square");
            }
        }
        public void checkSpeed()
        {
            Console.WriteLine("Enter the speed");
            int speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());


            int speedLimit = Convert.ToInt32(input2);

            if (speed < speedLimit) {
                Console.WriteLine("You're okay.");
            }
            else if (speed > speedLimit)
            {
                int demerits = (speed - speedLimit) / 5;
                Console.WriteLine("You just got {0} demerits.", demerits);
                if (demerits > 12) 
                {
                    Console.WriteLine("License suspended, buddy!");
                }
        }
    }
}