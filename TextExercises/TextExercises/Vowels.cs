using System;
using System.Collections.Generic;

namespace TextExercises
{
    public class Vowels
    {
        public static void VowelCounter(string str)
        {
            var count = 0;
            var vowels = new List<char>(new char[]{ 'a', 'e', 'i', 'o', 'u' });
            foreach (var character in str.ToLower())
            {
                if (vowels.Contains(character))
                {
                    count++;
                }
            }
            Console.WriteLine("Your word has {0} vowels.", count);
        }
    }
}
