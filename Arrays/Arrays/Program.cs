using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 999;
            numbers[1] = 666;
            numbers[2] = 555;

            Console.WriteLine(numbers);

            bool[] flags = new bool[3];

            Console.Write(flags[0]);

            string[] myStrings = new string[5];

            Console.WriteLine(myStrings[0]);

            var beatles = new string[4] { "john", "paul", "george", "ringo" };
            Console.WriteLine(beatles[0]);
            Console.WriteLine(beatles[1]);
            Console.WriteLine(beatles[2]);
            Console.WriteLine(beatles[3]);
        }
    }
}
