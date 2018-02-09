using System;

namespace ProceduralExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?  I'll reverse it.");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            var reversed = new string(array);

            Console.WriteLine("Your name reversed is: " + reversed);
        }
    }
}
