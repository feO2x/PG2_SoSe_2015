using System;
using System.Collections.Generic;
using System.Threading;
namespace HelloWorld.ConsoleApplication
{
    public delegate void MeineFunktion(ref int value);

    class Program
    {
        static void Main()
        {
            Func<int, int, int> lambda1 = (int wert1, int wert2) => { return wert1 + wert2; };

            Func<int, int, int> lambda2 = (wert1, wert2) => { return wert1 - wert2; };

            Func<int, int, int> lambda3 = (wert1, wert2) => wert1 + wert2;

            Func<int, int> lambda4 = wert => wert * wert;

            Action lambda5 = () => Console.WriteLine("Hello World");

            MeineFunktion lambda6 = (ref int wert) => wert++;

            Console.WriteLine(lambda1(42, 24));
            Console.WriteLine(lambda2(42, 24));
            Console.WriteLine(lambda3(42, 24));
            Console.WriteLine(lambda4(9));
            lambda5();

            var value = 42;
            lambda6(ref value);
            Console.WriteLine(value);
        }

        
    }


}
