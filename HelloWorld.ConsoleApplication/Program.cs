using System;
using System.Data;
using System.IO;

namespace HelloWorld.ConsoleApplication
{
    public interface IWriter
    {
        void Write(char value);
    }

    public class ConsoleWriter : IWriter
    {

        public void Write(char value)
        {
            Console.Write(value);
        }
    }

    public class FileWriter : IWriter, IDisposable
    {
        private readonly StreamWriter _streamWriter;

        public FileWriter(string path)
        {
            _streamWriter = new StreamWriter(path);
        }

        public void Write(char value)
        {
            _streamWriter.Write(value);
        }

        public void Dispose()
        {
            _streamWriter.Dispose();
        }
    }


    class Program
    {
        static void Main()
        {
            // Composition Root
            var reader = new ConsoleReader();
            //var writer = new FileWriter("text.txt");
            var writer = new ConsoleWriter();
            var copyProcess = new CopyProcess(reader, writer);

            // Application logic
            copyProcess.Copy();

            //writer.Dispose();
        }
    }

    public interface IReader
    {
        ReadInfo ReadKey();
    }

    public struct ReadInfo
    {
        private char _character;
        private bool _sollEnden;

        public ReadInfo(char character, bool sollEnden)
        {
            _character = character;
            _sollEnden = sollEnden;
        }

        public char Character
        {
            get { return _character; }
        }

        public bool SollEnden
        {
            get { return _sollEnden; }
        }
    }

    public class ConsoleReader : IReader
    {
        public ReadInfo ReadKey()
        {
            var consoleKeyInfo = Console.ReadKey(true);
            return new ReadInfo(consoleKeyInfo.KeyChar,
                                consoleKeyInfo.Key == ConsoleKey.Escape);
        }
    }

    public enum Ausgabeziel
    {
        Konsole,
        Datei
    }
}