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

        public void ErhöheZähler()
        {
            _zähler++;
        }
    }

    public class B : A // Subklasse 
    {
        public void ErhöheZählerUmDrei()
        {
            _zähler += 3;
        }
    }

    public class C : A
    {
        public void ErhöheZählerUmFünf()
        {
            for (int i = 0; i < 5; i++)
            {
                ErhöheZähler();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            B objekt1 = new B();
            objekt1.ErhöheZähler();
            objekt1.ErhöheZählerUmDrei();
            Console.WriteLine(objekt1.Zähler);

            A objekt2 = new A();
            objekt2.ErhöheZähler();
            Console.WriteLine(objekt2.Zähler);

            A objekt3 = new B(); // Ist-Eine-Beziehung
            objekt3.ErhöheZähler();
            // objekt3.ErhöheZählerUmDrei(); Geht nicht, da Variablentyp A ist
            Console.WriteLine(objekt3.Zähler);

            B objekt4 = (B)objekt3;
            objekt4.ErhöheZählerUmDrei();
            A objekt5 = new C();
            // B objekt6 = (B)objekt5; Exception: falscher Downcast

            B objekt6 = objekt5 as B;
            B objekt7 = objekt3 as B;

        }
    }
}
