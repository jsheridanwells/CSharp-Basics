using System;

namespace TextExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a few numbers separated by a hyphen. 
            //Work out if the numbers are consecutive.For example, 
            //if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; 
            //otherwise, display "Not Consecutive".
            var consecutive = "5-6-7-8-9";
            var notConsecutive = "6-2-8-4-8";

            if (Consecutive.IsConsecutive(consecutive))
            {
                Console.WriteLine("Consecutive, dog.");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            if (!Consecutive.IsConsecutive(notConsecutive))
            {
                Console.WriteLine("Not consecutive, yo.");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            // Write a program and ask the user to enter a few numbers separated by a hyphen. 
            // If the user simply presses Enter, without supplying an input, exit immediately; otherwise, 
            // check to see if there are duplicates. If so, display "Duplicate" on the console.
            Console.WriteLine("Give me some numbers. Separate them with a dash. If there are duplicates, I'll tell you");
            Duplicates.IsDuplicated(Console.ReadLine());

            Console.WriteLine("Enter a time in 24-hour time");
            TimeValue.GetTime(Console.ReadLine());


            //Write a program and ask the user to enter a few words separated 
            // by a space. Use the words to create a variable name with 
            // PascalCase. For example, if the user types: 
            // "number of students", display "NumberOfStudents".
            // Make sure that the program is not dependent on the input.
            // So, if the user types "NUMBER OF STUDENTS", 
            // the program should still display "NumberOfStudents".
            Console.WriteLine("Now give me a string. I will Pascal-lize it.");
            Pascal.MakePascal(Console.ReadLine());

            // Write a program and ask the user to enter an English word. Count the number of 
            // vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", 
            // the program should display 6 on the console.
            Console.WriteLine("Give me a word and I'll count the vowels for you.");
            Vowels.VowelCounter(Console.ReadLine());
        }
    }
}
