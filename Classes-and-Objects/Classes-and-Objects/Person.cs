using System;
namespace ClassesandObjects
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public void introduce()
        {
            Console.WriteLine("Hola, me llamo " + firstName + " " + lastName);
        }

    }
}
