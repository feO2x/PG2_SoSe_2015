using System;
using System.Collections.Generic;
namespace HelloWorld.ConsoleApplication
{
    
    class Program
    {
        static void Main()
        {
            var zahlenHashSet = new HashSet<int>();
            zahlenHashSet.Add(3);
            zahlenHashSet.Add(5);
            zahlenHashSet.Add(3);
            GibAufzählungAus(zahlenHashSet);

            var farbenHashSet = new HashSet<Farbe>();
            farbenHashSet.Add(new Farbe(128, 0, 0));
            farbenHashSet.Add(new Farbe(0, 128, 0));
            farbenHashSet.Add(new Farbe(128, 0, 0));
            GibAufzählungAus(farbenHashSet);
        }
        private static void GibAufzählungAus<T>(IEnumerable<T> aufzählung)
        {
            foreach (var element in aufzählung)
                Console.WriteLine(element);
        }
    }


}
