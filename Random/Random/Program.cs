using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate a random number
            var random = new Random();
            for (var i = 0; i < 10; i++) 
            {
                Console.WriteLine(random.Next());
            }

            // generate LENGTH random characters
            var Length = 10;
            var randomChar = new Random();
            var buffer = new char[Length];
            for (var i = 0; i < Length; i++) 
            {
                buffer[i] = (char)('a' + randomChar.Next(0, 26));
            }
            Console.WriteLine(new String(buffer));
        }
    }
}
