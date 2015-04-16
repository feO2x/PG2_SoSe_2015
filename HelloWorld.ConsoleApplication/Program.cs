using System;

namespace HelloWorld.ConsoleApplication
{
    public class A
    {
        
    }

    public class B : object
    {
        
    }

    public class C : B
    {
        
    }


    class Program
    {
        static void Main()
        {
            Mitarbeiter mitarbeiter = new Mitarbeiter
                                      {
                                          Name = "Walter White",
                                          AktuellesGehalt = 20000m,
                                          Verhältnis = Mitarbeiter.Manager
                                      };

            Console.WriteLine(mitarbeiter.ToString());
        }
    }
}
