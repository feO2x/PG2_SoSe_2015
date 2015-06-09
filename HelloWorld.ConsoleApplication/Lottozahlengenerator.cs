using System;

namespace HelloWorld.ConsoleApplication
{
    public interface IZufallszahlengenerator
    {
        int ErzeugeZahlZwischen(int minimum, int maximum);
    }

    public class RandomAdapter : IZufallszahlengenerator
    {
        private readonly Random _random;
        public RandomAdapter(Random random)
        {
            if (random == null) throw new ArgumentNullException("random");
            _random = random;
        }

        public int ErzeugeZahlZwischen(int minimum, int maximum)
        {
            return _random.Next(minimum, maximum + 1);
        }
    }

    public class Lottozahlengenerator
    {
        private readonly IZufallszahlengenerator _zufallszahlenGenerator;

        public Lottozahlengenerator(IZufallszahlengenerator zufallszahlenGenerator)
        {
            if (zufallszahlenGenerator == null) throw new ArgumentNullException("zufallszahlenGenerator");

            _zufallszahlenGenerator = zufallszahlenGenerator;
        }

        public int[] GeneriereLottozahlen()
        {
            int[] lottozahlen = new int[6];

            int zähler = 0;
            while (zähler < 6)
            {
                var neueZahl = _zufallszahlenGenerator.ErzeugeZahlZwischen(1, 49);
                if (ÜberprüfeObZahlEindeutigIst(neueZahl, lottozahlen))
                {
                    lottozahlen[zähler] = neueZahl;
                    zähler++;
                }
            }

            return lottozahlen;
        }

        private bool ÜberprüfeObZahlEindeutigIst(int neueZahl, int[] lottozahlen)
        {
            foreach (int lottozahl in lottozahlen)
            {
                if (lottozahl == neueZahl)
                    return false;
            }
            return true;
        }
    }
}