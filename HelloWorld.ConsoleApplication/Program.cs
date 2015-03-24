using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Hallo", "Welt", "Was geht?" };
            string gesuchterWert = "Welt";

            var ergebnis = ÜberprüfeObArrayZeichenfolgeEnthält(stringArray, gesuchterWert);
            Console.WriteLine(ergebnis);

            gesuchterWert = "Foo";
            ergebnis = ÜberprüfeObArrayZeichenfolgeEnthält(stringArray, gesuchterWert);
            Console.WriteLine(ergebnis);
            Console.ReadLine();
        }

        static bool ÜberprüfeObArrayZeichenfolgeEnthält(string[] array, string wert)
        {
            // Ihr Code folgt hier 
            bool rückgabewert = false;
            foreach (string text in array)
            {
                if (text == wert)
                {
                    rückgabewert = true;
                    break;
                }
            }
            return rückgabewert;
        }


    }
}
