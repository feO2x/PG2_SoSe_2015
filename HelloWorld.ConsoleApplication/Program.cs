
using System;
using System.Collections.Generic;
namespace HelloWorld.ConsoleApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 42;
            string @string = "Hello";

            object objekt = zahl; // Hier passiert implizit Boxing

            int zahl2 = (int)objekt; // hier Unboxing

        }

        private static void GibAufzählungAus<T>(IEnumerable<T> aufzählung)
        {
            foreach (var element in aufzählung)
            {
                Console.WriteLine(element);
            }
        }
    }

}
