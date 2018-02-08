using System;
namespace TextExercises
{
    public class TimeValue
    {
        public static void GetTime(string dateTime)
        {
            var timeArr = dateTime.Split(':');

            if (timeArr.Length != 2)
            {
                Console.WriteLine("That isn't right, buddy.");
            }

            try
            {
                var hour = Convert.ToByte(timeArr[0]);
                var minute = Convert.ToByte(timeArr[1]);

                if (
                    hour >= 0 &&
                    hour <= 24 &&
                    minute >= 0 &&
                    minute <= 59
                )
                {
                    Console.WriteLine("Good job, little buddy.");
                }
                else
                {
                    Console.WriteLine("Invalid time, buck-o.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid time, buck-o.");
            }
        }
    }
}
