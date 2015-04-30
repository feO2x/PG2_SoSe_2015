using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class AsciiBaum
    {
        private readonly int _anzahlZeilen;
        private readonly char _buchstabe;
        private int _aktuelleZeile;
        private int _anzahlLeerzeichen;
        private int _anzahlBuchstaben = 1;

        public AsciiBaum(int anzahlZeilen, char buchstabe = '*')
        {
            if (anzahlZeilen < 2)
                throw new ArgumentOutOfRangeException("anzahlZeilen", "Anzahl Zeilen darf nicht kleiner als 2 sein");

            _anzahlZeilen = anzahlZeilen;
            _buchstabe = buchstabe;
            _anzahlLeerzeichen = anzahlZeilen - 1;
        }

        public bool IsFertig
        {
            get { return _aktuelleZeile == _anzahlZeilen; }
        }

        public void GibNächsteZeileAus()
        {
            if (IsFertig)
                return;

            for (int i = 0; i < _anzahlLeerzeichen; i++)
            {
                Console.Write(' ');
            }
            _anzahlLeerzeichen--;

            for (int i = 0; i < _anzahlBuchstaben; i++)
            {
                Console.Write(_buchstabe);
            }
            _anzahlBuchstaben += 2;
            _aktuelleZeile++;
            Console.WriteLine();
        }
    }
}
