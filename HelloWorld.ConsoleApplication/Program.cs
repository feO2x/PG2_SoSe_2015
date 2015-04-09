using System;
using System.Threading;
using Timer = System.Timers.Timer;

namespace HelloWorld.ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            var meinePerson = new Person("Walter", "White");
            VeränderePerson(meinePerson);
            Console.WriteLine(meinePerson.Nachname);

            int integerWert = 42;
            VerändereInteger(ref integerWert);
            Console.WriteLine(integerWert);

            var timer = new Timer();

            Thread.Sleep(500);
        }

        private static void VeränderePerson(Person person)
        {
            person.Nachname = "Hodor";
        }

        private static void VerändereInteger(ref int i)
        {
            i = 5;
        }
    }
}
