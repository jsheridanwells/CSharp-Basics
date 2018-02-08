using System;

namespace TextExercises
{
    public class Pascal
    {
        public static void MakePascal(string str)
        {
            if (String.IsNullOrWhiteSpace(str)) 
            {
                Console.WriteLine("Put in proper input, please.");
            }
            var wordArr = str.Split(' ');
            var pascalized = "";
            foreach(var word in wordArr)
            {
                pascalized += char.ToUpper(word[0]) + word.Substring(1).ToLower();
            }
            Console.WriteLine(pascalized);
        }
    }
}
