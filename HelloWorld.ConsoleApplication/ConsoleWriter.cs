using System;

namespace HelloWorld.ConsoleApplication
{
    public class ConsoleWriter : IWriter
    {

        public void Write(char value)
        {
            Console.Write(value);
        }
    }
}