using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            
        }

        static void IntAlsLong(int wert1)
        {
            long longWert = (long)wert1; // Cast (explizite Konvertierung)
            long longWert2 = Convert.ToInt64(wert1); // Konvertierung mit Hilfsklasse
            long longWert3 = wert1; // Implizite Konvertierung
        }

        static void LongAlsInt(long wert)
        {
            int intWert = (int) wert;
        }

        static void DoubleAlsFloat(double wert)
        {
            float floatWert = (float) wert;
        }

        static void StringZuInt(string text)
        {
            int zahl = Convert.ToInt32(text);
        }
    }
}
