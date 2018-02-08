using System;

namespace Text_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Jeremy Wells   ";
            Console.WriteLine(fullName.Trim()); // takes off whitespace trailing at end
            Console.WriteLine(fullName.ToUpper()); // JEREMY WELLS
            Console.WriteLine(fullName.ToLower()); // jeremy wells

            // substrings
            var index = fullName.IndexOf(" ");
            var first = fullName.Substring(0, index);
            var last = fullName.Substring(index);
            Console.WriteLine(first + last);

            // but #Split() is easier:
            var names = fullName.Split(" ");
            Console.WriteLine(names[0] + names[1]);

            // methods to check if value is null
            if (String.IsNullOrEmpty(null))  // this is a legacy method
            {
                Console.WriteLine("No null values, buddy.");
            }

            if (String.IsNullOrWhiteSpace("   ")) // this one is more versatile.
            {
                Console.WriteLine("No white space, buddy.");
            }

            // converting
            var ageInput = "25";
            var age = Convert.ToByte(ageInput);

            var myFloat = 29.95f;
            var price = myFloat.ToString("C0");  //  converts float to currency, round to $30

        }
    }
}
