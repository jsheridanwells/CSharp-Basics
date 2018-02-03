using System;

namespace Operators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine(a / b); // 3 results. they need to be cast to a float

            Console.WriteLine((float)a / (float)b);  // 3.333333

            Console.WriteLine(a > b);  // true

            Console.WriteLine(a != b);  // false

            Console.WriteLine(a > b && b == a); 


        }
    }
}
