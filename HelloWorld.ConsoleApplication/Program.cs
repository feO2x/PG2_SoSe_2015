using System;

namespace HelloWorld.ConsoleApplication
{

    class Program
    {
        static int Main()
        {
            try
            {
                Console.WriteLine("In Main bevor irgendwas passiert ist");
                return 42;
                FunktionA();
                Console.WriteLine("In Main nach A");
            }
            catch (Exception)
            {
                Console.WriteLine("Im Catch Block");
                return 0;
            }
            finally
            {
                Console.WriteLine("Im Finally-BLock");
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
            if (new Random().Next() % 2 == 0)
                throw new Exception();
        }
    }
}
