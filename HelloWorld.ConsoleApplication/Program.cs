using System;

namespace HelloWorld.ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            var person = new Person("Walter", "White");
            Console.WriteLine(person.VollerName);

            var point = new Point();
            point.X = 4.2;
            Console.WriteLine(point);
        }
    }
}
