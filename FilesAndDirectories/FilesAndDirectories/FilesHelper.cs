using System;
using System.IO;
    
namespace FilesAndDirectories
{
    public class FilesHelper
    {
        public static int GetNumWords(string path)
        {
            var wordsArr = makeWordArr(path);
            return wordsArr.Length;
        }

        public static string GetLongestWord(string path)
        {
            var wordsArr = makeWordArr(path);
            var longestWord = "";
            foreach (var word in wordsArr)
            {
                if (word.Length > longestWord.Length) {
                    longestWord = word;
                }
            }
            return longestWord;
        }

        static string[] makeWordArr(string path)
        {
            var words = File.ReadAllText(path);
            return words.Split(' ');
        }
    }
}
