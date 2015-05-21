using System;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld.Threading
{
    class Program
    {
        static void Main()
        {
            var jetzigerThread = Thread.CurrentThread;
            Console.WriteLine("Start auf Thread " + jetzigerThread.ManagedThreadId);

            var neuerThread = new Task(ZähleHoch);

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
