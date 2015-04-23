
using System;
using System.Collections.Generic;
namespace HelloWorld.ConsoleApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            var unendlicheAufzählung = new UnendlicheAufzählung();
            foreach (var element in unendlicheAufzählung)
            {
                Console.WriteLine(element);
            }

        }

        private static void GibAufzählungAus<T>(IEnumerable<T> aufzählung)
        {
            //foreach (var element in aufzählung)
            //{
            //    Console.WriteLine(element);
            //}

            IEnumerator<T> enumerator = aufzählung.GetEnumerator();

            try
            {
                while (enumerator.MoveNext())
                {
                    T element = enumerator.Current;
                    Console.WriteLine(element);
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }
    }

}
