using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;

namespace HelloWorld.ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Copy(Ausgabeziel.Datei);
        }

        public static void Copy(Ausgabeziel ausgabeziel)
        {
            StreamWriter streamWriter = null;
            if (ausgabeziel == Ausgabeziel.Datei)
                streamWriter = new StreamWriter("Datei.txt");

            while (true)
            {
                var readKey = Console.ReadKey(true);
                if (readKey.Key == ConsoleKey.Escape)
                    break;
                if (ausgabeziel == Ausgabeziel.Konsole)
                    Console.Write(readKey.KeyChar);
                else if(ausgabeziel == Ausgabeziel.Datei)
                    streamWriter.Write(readKey.KeyChar);
            }

            if (ausgabeziel == Ausgabeziel.Datei)
                streamWriter.Close();
        }
    }

    internal enum Ausgabeziel
    {
        Konsole,
        Datei
    }
}