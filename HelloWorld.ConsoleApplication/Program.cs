using System;
using System.Collections.Generic;
using System.Threading;
namespace HelloWorld.ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Func<int, int> @delegate = BerechneQuadrat;
        }

        public static int BerechneQuadrat(int zahl)
        {
            return zahl * zahl;
        }

        
        private static void GibAufzählungAus<T>(IEnumerable<T> aufzählung)
        {
            foreach (var element in aufzählung)
                Console.WriteLine(element);

            Console.WriteLine();
        }
    }


}
