using System;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            // String maps to String class, strings are immutable
            var myString = "This is my CrAzY string";
            Console.WriteLine(myString.ToLower());  // all lowercase
            Console.WriteLine(myString.ToUpper()); // all uppercase
            Console.WriteLine(myString.Trim());  // no whitespace
            Console.WriteLine(myString.Replace('s', 'x'));  // Thix ix my CrAzY xtring

            var numString = "123";
            int numInt = int.Parse(numString);  // changes numString to integer, this will throw an exception
            // or
            int j = Convert.ToInt32(numString);  // will not throw exception, just convert to 0
            Console.WriteLine(numString + numInt, + j);  // 123123123, (int is changed back to string in WriteLine)

            // will convert to currency
            string currency = j.ToString("C");
            Console.WriteLine("Moneda:C " + currency); // $123.00


        }
    }
}
 