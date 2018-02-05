using ClassesandObjects.Math;
using System;

namespace ClassesandObjects
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person jeremy = new Person();
            jeremy.firstName = "Jeremy";
            jeremy.lastName = "Wells";
            jeremy.introduce();

            Calculator myCalc = new Calculator();
            Console.WriteLine(myCalc.add(4, 5));
        }

    }
}
