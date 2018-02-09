using System;
// System.IO contains classes for working with files
using System.IO;

// File provides static methods for working with files
// FileInfo provides instance methods
/*
Create()
Copy()
Delete()
Exists()
GetAttributes()
Move()
ReadAllText()
*/

// Directory and DirectoryInfo is the same for directories
// Path class has directory path info

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // everything with File class is static methods
            // good for performing methods on files without creating new objects
            // if it is being used alot, OS performs security checks
            // which will affect performance
            var path = @"./temp/";
            File.Copy(path + "myFile.txt", @"./copy/myFile.txt", true);
            File.Delete(path + "myFile.txt");

            var fileInfo = new FileInfo(path);
            // this will allow fileInfo methods on path;
        }
    }
}
