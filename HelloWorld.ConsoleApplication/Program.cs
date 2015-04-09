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
            Person person1 = new Person("Walter", "White");
            Console.WriteLine(person1.Vorname);

            person1.Alter = 52;
            //person1.Alter += 1;
            person1.Alter++;

            Person person2 = new Person(Console.ReadLine());
            person2.Alter = 27;

        }
    }
}
