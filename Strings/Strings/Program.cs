using System;

namespace Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //strings can be declared with var or string
            var firstName = "Jeremy";
            var lastName = "Wells";

            // string.format can insert variables into a string given as arguments, zero-indexed
            var fullName = string.Format("Me llamo {0} {1}", firstName, lastName);
            Console.WriteLine(fullName);

            // join can concatenate an array of strings, first argument is the separator 
            var beatles = new string[4] { "John", "Paul", "George", "Ringo" };
            var myBand = string.Join(", ", beatles);
            Console.WriteLine(myBand);

            // verbatim strings can be written by appending an @. no need to escape characters
            var text = @"http://google.com";
            Console.WriteLine(text);

        }
    }
}
