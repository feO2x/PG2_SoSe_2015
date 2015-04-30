using System;
using System.Collections.Generic;
using System.Threading;
namespace HelloWorld.ConsoleApplication
{
    public delegate int FunktionMitZahl(int zahl);
    
    class Program
    {
        private static AsciiBaum _asciiBaum;
        private static Timer _timer;

        static void Main()
        {
            _asciiBaum = new AsciiBaum(10);
            var duration = 500;
            _timer = new Timer(new TimerCallback(WennTimerTickt), null, duration, duration);

            Console.ReadLine();
        }

        private static void WennTimerTickt(object state)
        {
            _asciiBaum.GibNächsteZeileAus();
            if (_asciiBaum.IsFertig)
                _timer.Dispose();
        }

        
        private static void GibAufzählungAus<T>(IEnumerable<T> aufzählung)
        {
            foreach (var element in aufzählung)
                Console.WriteLine(element);

            Console.WriteLine();
        }
    }


}
