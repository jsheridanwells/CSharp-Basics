using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // arrays are instantiated with var(or type), identifier, memory allocation and size.
            int[] numbers = new int[3];
            numbers[0] = 999;
            numbers[1] = 666;
            numbers[2] = 555;

            Console.WriteLine(numbers);

            // by default, boolean arrays are false
            // int arrays are zero
            // string arrays are "a"
            bool[] flags = new bool[3];

            Console.Write(flags[0]);  // false, false, false

            string[] myStrings = new string[5];

            Console.WriteLine(myStrings[0]);  // "a"

            // arrays can be assigned elements at instantiations with a following block {}
            var beatles = new string[4] { "john", "paul", "george", "ringo" };
            Console.WriteLine(beatles[0]);
            Console.WriteLine(beatles[1]);
            Console.WriteLine(beatles[2]);
            Console.WriteLine(beatles[3]);
        }
    }
}
