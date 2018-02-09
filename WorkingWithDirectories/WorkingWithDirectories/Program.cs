using System;
using System.IO;

namespace WorkingWithDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates /temp directory in current directory
            Directory.CreateDirectory(@"./temp");
            // returns string array with all files and all directories in /folder1
            Directory.GetFiles(@"./temp/folder1", "*", SearchOption.AllDirectories);
            // show all files using a 

        }
    }
}
