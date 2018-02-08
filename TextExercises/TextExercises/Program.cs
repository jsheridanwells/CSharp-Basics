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

            if (IsConsecutive(consecutive)) {
                Console.WriteLine("Consecutive, dog.");
            }
            else 
            {
                Console.WriteLine("Failed");
            }
            if (!IsConsecutive(notConsecutive))
            {
                Console.WriteLine("Not consecutive, yo.");
            }
            else
            {
                Console.WriteLine("Failed");
            }

        }
        static bool IsConsecutive(string str)
        {
            var numArr = str.Split('-');
            int[] myInts = Array.ConvertAll(numArr, int.Parse);
            var response = true;
            for (var i = 0; i < myInts.Length; i++)
            {
                if (myInts[i] != (myInts[0] + i)) 
                {
                    response = false;
                }
            }
            return response;
        }
    }
}
