using System;
using System.IO;

namespace HelloWorld.ConsoleApplication
{
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
}