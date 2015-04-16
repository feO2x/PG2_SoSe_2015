using System;

namespace HelloWorld.ConsoleApplication
{

    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("In Main bevor irgendwas passiert ist");
                FunktionA();
                Console.WriteLine("In Main nach A");
            }
            catch (Exception)
            {
                Console.WriteLine("Im Catch Block");
            }
        }

        private static void FunktionA()
        {
            Console.WriteLine("In A vor B");
            FunctionB();
            Console.WriteLine("In B nach A");
        }

        private static void FunctionB()
        {
            Console.WriteLine("Vor Exception in B");
            throw "Hallo There";
            Console.WriteLine("Nach Exception in B");

            Convert.ToInt32
        }
    }
}
