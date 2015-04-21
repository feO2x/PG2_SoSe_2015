
using System;
using System.Collections.Generic;
namespace HelloWorld.ConsoleApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringListe = new List<string>()
            {
                "Hello", "World"
            }; // Collection Initialization Syntax
            Stack<string> stringStack = new Stack<string>(5);
            stringStack.Push("Hello");
            stringStack.Push("World");

            GibAufzählungAus(stringListe);
            GibAufzählungAus(stringStack);

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
