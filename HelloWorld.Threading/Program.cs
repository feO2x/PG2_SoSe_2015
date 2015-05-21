using System;
using System.Threading;

namespace HelloWorld.Threading
{
    class Program
    {
        static void Main()
        {
            var jetzigerThread = Thread.CurrentThread;
            Console.WriteLine("Start auf Thread " + jetzigerThread.ManagedThreadId);

            var neuerThread = new Thread(ZähleHoch)
                              {
                                  Name = "Neuer Thread",
                                  //IsBackground = true
                              };
            neuerThread.Start();

            Console.ReadLine();

        }

        private static void ZähleHoch()
        {
            for (var i = 0; i < 50; i++)
            {
                Console.WriteLine("Durchlauf {0} auf Thread {1}", i + 1, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(400);
            }
        }
    }
}
