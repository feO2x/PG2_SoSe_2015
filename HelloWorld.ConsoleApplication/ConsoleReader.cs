using System;

namespace HelloWorld.ConsoleApplication
{
    public class ConsoleReader : IReader
    {
        public ReadInfo ReadKey()
        {
            var consoleKeyInfo = Console.ReadKey(true);
            return new ReadInfo(consoleKeyInfo.KeyChar,
                                consoleKeyInfo.Key == ConsoleKey.Escape);
        }
    }
}