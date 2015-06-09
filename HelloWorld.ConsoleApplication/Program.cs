using System;
using System.Data;

namespace HelloWorld.ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            var randomAdapter = new RandomAdapter(new Random());
            var generator = new Lottozahlengenerator(randomAdapter);

            var lottozahlen = generator.GeneriereLottozahlen();
        }
    }
}