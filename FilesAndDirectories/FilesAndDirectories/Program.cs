using System;

namespace FilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"./myFiles/myText.txt";
            Console.WriteLine(FilesHelper.GetNumWords(path));
            Console.WriteLine(FilesHelper.GetLongestWord(path));
        }
    }
}
