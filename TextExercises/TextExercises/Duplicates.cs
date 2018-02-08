using System;
using System.Collections.Generic;

namespace TextExercises
{
    public class Duplicates
    {
        public static void IsDuplicated(string str)
        {
            var hasDuplicates = false;
            var myArr = str.Split('-');
            var duplicates = new List<string>();
            if (String.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Input cannot be blank, buck-o.");
                return;
            }

            foreach (var character in myArr)
            {
                if (!duplicates.Contains(character))
                {
                    duplicates.Add(character);
                }
                else
                {
                    hasDuplicates = true;
                }
            }

            if (hasDuplicates)
            {
                Console.WriteLine("Your set of numbers has duplicates");
            }
            else
            {
                Console.WriteLine("No duplicates here, buddy.");
            }
        }
    }
}
