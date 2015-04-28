using System;
using System.Collections.Generic;
namespace HelloWorld.ConsoleApplication
{
    
    class Program
    {
        static void Main()
        {
            var kartenstapel = new List<Spielkarte>();

            Array alleFarben = Enum.GetValues(typeof(Kartenfarbe));
            Array alleKartenwerte = Enum.GetValues(typeof(Kartenwert));

            foreach (Kartenfarbe farbe in alleFarben)
            {
                foreach (Kartenwert wert in alleKartenwerte)
                {
                    kartenstapel.Add(new Spielkarte(farbe, wert));
                }
            }

            GibAufzählungAus(kartenstapel);

            MischeKartenstapel(ref kartenstapel);

            GibAufzählungAus(kartenstapel);
        }

        private static void MischeKartenstapel(ref List<Spielkarte> kartenstapel)
        {
            var random = new Random();
            var neuerKartenstapel = new List<Spielkarte>();

            while (kartenstapel.Count > 0)
            {
                var index = random.Next(kartenstapel.Count);
                neuerKartenstapel.Add(kartenstapel[index]);
                kartenstapel.RemoveAt(index);
            }
            kartenstapel = neuerKartenstapel;
        }
        private static void GibAufzählungAus<T>(IEnumerable<T> aufzählung)
        {
            foreach (var element in aufzählung)
                Console.WriteLine(element);

            Console.WriteLine();
        }
    }


}
