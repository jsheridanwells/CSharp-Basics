using System;

namespace ReferenceAndValueTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //VALUE TYPES:::
            // create an int
            int a = 10;
            // copy the int
            int b = a;
            // increment the int
            b++;
            Console.WriteLine(b);  // 11
            Console.WriteLine(a);  // 10
            // these are value types, a copy of that value is pasted into a 
            // new location in memory

            //REFERENCE TYPES:::
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;

            array2[0] = 10;

            Console.WriteLine(array2[0]);  // 10
            Console.WriteLine(array1[0]);  // 10 !!!! (array2 has changed array1)

            Console.WriteLine("array1:{0} array2:{1}", array1, array2);  

        }
    }
}
