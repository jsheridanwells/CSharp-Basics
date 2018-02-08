using System;
using System.Collections.Generic;

namespace TextSummaries
{
    public class StringUtility
    {
        public static string summarize(string text, int max = 20)
        {
            if (text.Length >= max)
            {
                //Convert words to array
                var words = text.Split(' ');
                var totalCharacters = 0;
                // create new list to hold summarized words
                var summaryWords = new List<string>();
                foreach (var word in words)
                {
                    // add each word in words
                    summaryWords.Add(word);
                    // add length of each word to total
                    totalCharacters += word.Length + 1;
                    // break the look when total characters is above max
                    if (totalCharacters > max)
                        break;
                }
                // return string with summarWords
                return String.Join(' ', summaryWords) + "...";
            }
            else
            {
                // or return original text if it's less than MAX words
                return text;
            }
        }
    }
}
