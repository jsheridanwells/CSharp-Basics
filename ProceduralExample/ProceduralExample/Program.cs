using System;

namespace ProceduralExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?  I'll reverse it.");
            var name = Console.ReadLine();

            // with ReverseName method, business logic is separate from control flow.
            var reversed = ReverseName(name);

            Console.WriteLine("Your name reversed is: " + reversed);
        }

        // break out method, 
        // first, thing of what data type you are returning
        // then, what parameters
        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            return new string(array);
        }
    }
}
