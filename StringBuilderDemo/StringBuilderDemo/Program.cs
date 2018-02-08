using System;
using System.Text;  // brings in StringBuilder

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10); // // creates 10 dashes
            builder.AppendLine(); // adds new line
            builder.Append("Header"); // adds header below
            builder.AppendLine(); // adds another new line
            builder.Append('-', 10); // // creates 10 more dashes
            Console.WriteLine(builder); 

            builder.Replace('-', '+');// replaces dashes with plusses
            Console.WriteLine(builder);

            // string builder helps do several string manipulation methods
            // without having to create new string objects in memory

            // methods can be chained:
            builder.Append('{', 30).AppendLine().Append("yeah!");
            Console.WriteLine(builder);
        }
    }
}
