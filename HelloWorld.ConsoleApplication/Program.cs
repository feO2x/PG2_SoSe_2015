using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;

namespace HelloWorld.ConsoleApplication
{
    

    internal class Program
    {
        private static void Main()
        {
            var reflector = new Reflector();
            var kontakt = new Kontakt { Nachname = "White", Vorname = "Walter" };
            reflector.ReflectOn(kontakt);
        }
    }
}