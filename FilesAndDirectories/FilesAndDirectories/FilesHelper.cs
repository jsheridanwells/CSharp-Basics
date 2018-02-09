using System;
using System.IO;
    
namespace FilesAndDirectories
{
    public class FilesHelper
    {
        public static int GetNumWords(string path)
        {
            var words = File.ReadAllText(path);
            var wordsArr = words.Split(' ');
            return wordsArr.Length;
        }

        public static string GetLongestWord(string path)
        {
            var words = File.ReadAllText(path);
            var wordsArr = words.Split(' ');
            var longestWord = "";
            foreach (var word in wordsArr)
            {
                if (word.Length > longestWord.Length) {
                    longestWord = word;
                }
            }
            return longestWord;
        }
    }
}
