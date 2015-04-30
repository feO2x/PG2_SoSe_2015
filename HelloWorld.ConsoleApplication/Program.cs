using System;
using System.Collections.Generic;
using System.Threading;
namespace HelloWorld.ConsoleApplication
{
    public class Lauscher
    {
        public void Hörzu()
        {
            Console.WriteLine("Ich hab's gehört");
        }
    }

    class Program
    {
        static void Main()
        {
            var metronom = new Metronom();
            var lauscher = new Lauscher();

            metronom.Tick += lauscher.Hörzu;
            metronom.Tick += Console.Beep;

            // metronom.Tick = null; geht nicht, da ein Event eingesetzt wird

            metronom.Start();

            Console.ReadLine();

            metronom.Stop();

            Console.ReadLine();
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
