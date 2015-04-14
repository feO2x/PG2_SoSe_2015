using System;

namespace HelloWorld.ConsoleApplication
{
    public class A // Basisklasse
    {
        protected int _zähler;

        public int Zähler
        {
            get { return _zähler; }
        }

        public virtual void ErhöheZähler()
        {
            _zähler++;
        }
    }

    public class B : A // Subklasse 
    {
        public override void ErhöheZähler()
        {
            _zähler += 3;
        }
    }


    class Program
    {
        static void Main()
        {
            Gestalt[] array = new Gestalt[3];
            array[0] = new Rechteck(4.0, 5.0);
            array[1] = new Dreieck(4.0, 5.0);
            array[2] = new Kreis(5.0);

            foreach (Gestalt gestalt in array)
            {
                Console.WriteLine(gestalt.BerechneFläche());
            }

        }
    }
}
