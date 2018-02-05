using System;

namespace Enums
{
    public enum ShippingMethod
    {
        Regular = 1,
        FirstClass = 2,
        Express = 3
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // notice that #method is not an int, it's of type ShippingMethod
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);  // 3

            // if the value '3' is submitted from another part of the application
            // it would need to be converted to a ShippingMethod to use this enum
            var methodId = 3;  // it is an int of 3
            Console.WriteLine((ShippingMethod)methodId);  // returns Express

            // all enums have method #ToString()
            // Note #WriteLine automatically converts a value to a string
            Console.WriteLine(method.ToString()); // prints "Express" as a string

            // parse changes the type of a value, in this case to an Enum
            // typeof specifies type (ShippingMethod) and the value to parse (methodName)
            // shippingMethod is now an Enum
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
