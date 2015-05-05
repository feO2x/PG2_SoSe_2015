using System;
using System.Collections.Generic;
using System.Threading;
namespace HelloWorld.ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            List<Person> personen = new List<Person>
            {
                new Person("Walter", "White"),
                new Person("Jesse", "Pinkman"),
                new Person("Hank", "Schrader")
            };

            Action anonymeMethode = delegate()
            {
                foreach (var person in personen)
                {
                    Console.WriteLine(person);
                }
            };

            anonymeMethode();
        }

        private static void GibPersonenAus(List<Person> liste)
        {
            foreach (var person in liste)
            {
                Console.WriteLine(person);
            }
        }
    }


}
