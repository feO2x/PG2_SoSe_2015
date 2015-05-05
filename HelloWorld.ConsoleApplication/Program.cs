using System;
using System.Collections.Generic;
using System.Threading;
namespace HelloWorld.ConsoleApplication
{
    public delegate void MeineFunktion(ref int value);

    class Program
    {
        static void Main()
        {
            Point point1 = new Point(42.0, 8.0);  // Konstruktoraufruf für Struktur

            point1.Y = 5.0;

            Point point2; // Kein new Aufruf zur Initialisierung der Variable
            point2.X = 42.0; // Stattdessen müssen X und Y manuell gesetzt werden,
            point2.Y = 5.0; // bevor sie genutzt werden können

            Point point3 = new Point(); // Das ist kein Standardkonstruktoraufruf, sondern ein Strukturinitialisierer; hier werden alle Felder einer Struktur auf ihren Defaultwert gesetzt

            Console.WriteLine(point1);
            Console.WriteLine(point2);
            Console.WriteLine(point3);
        }

        
    }


}
