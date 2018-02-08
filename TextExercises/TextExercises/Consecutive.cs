using System;
namespace TextExercises
{
    public class Consecutive
    {
        static public bool IsConsecutive(string str)
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
