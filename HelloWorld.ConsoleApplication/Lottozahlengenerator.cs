using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class Lottozahlengenerator
    {
        private Random _zufallszahlenGenerator = new Random();

        public int[] GeneriereLottozahlen()
        {
            int[] lottozahlen = new int[6];

            int zähler = 0;
            while (zähler < 6)
            {
                var neueZahl = _zufallszahlenGenerator.Next(1, 50);
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
