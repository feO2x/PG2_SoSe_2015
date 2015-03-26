using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{


    public class Beispielklasse
    {
        public static int StatischerZähler;
        public int InstanzZähler;

        public static void ErhöheStatischenZähler()
        {
            StatischerZähler++;
        }
        public void ErhöheAlleZähler()
        {
            StatischerZähler++;
            InstanzZähler++;
        }
    }
    class Program
    {
        static void Main()
        {
            Beispielklasse.ErhöheStatischenZähler();

            Beispielklasse objekt1 = new Beispielklasse();
            objekt1.ErhöheAlleZähler();
            objekt1.ErhöheAlleZähler();

            Beispielklasse objekt2 = new Beispielklasse();
            objekt2.ErhöheAlleZähler();

            Console.WriteLine(Beispielklasse.StatischerZähler);
            Console.WriteLine(objekt1.InstanzZähler);
            Console.WriteLine(objekt2.InstanzZähler);
        }
    }
}
