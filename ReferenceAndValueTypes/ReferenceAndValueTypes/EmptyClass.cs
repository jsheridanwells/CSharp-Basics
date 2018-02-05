using System;
namespace ReferenceAndValueTypes
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);  // 1, this is a value type

            var myPerson = new Person() { Age = 20 };
            MakeOld(myPerson);
            Console.WriteLine(myPerson.Age); // 30, we just copied a reference to the object
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
