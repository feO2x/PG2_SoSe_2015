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
            A objekt1 = new A();
            objekt1.ErhöheZähler();
            Console.WriteLine(objekt1.Zähler);

            B objekt2 = new B();
            objekt2.ErhöheZähler();
            Console.WriteLine(objekt2.Zähler);

            A objekt3 = new B();
            objekt3.ErhöheZähler();
            Console.WriteLine(objekt3.Zähler);

        }
    }
}
