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
            Person person1 = new Person();
            person1.Vorname = "Walter";
            person1.Nachname = "White";
            person1.Alter = 52;
            //person1.Alter += 1;
            person1.Alter++;

            PersonMitGetSetMethoden person2 = new PersonMitGetSetMethoden();
            person2.SetVorname("Jesse");
            person2.SetNachname("Pinkman");
            person2.SetAlter(27);
            person2.SetAlter(person2.GetAlter() + 1);

        }
    }
}
