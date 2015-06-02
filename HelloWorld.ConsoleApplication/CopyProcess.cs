using System;

namespace HelloWorld.ConsoleApplication
{
    public class CopyProcess
    {
        private readonly IReader _reader;
        private readonly IWriter _writer;

        public CopyProcess(IReader reader, IWriter writer)
        {
            if (reader == null) throw new ArgumentNullException("reader");
            if (writer == null) throw new ArgumentNullException("writer");

            _reader = reader;
            _writer = writer;
        }

        public void Copy()
        {
            while (true)
            {
                var readKey = _reader.ReadKey();
                if (readKey.SollEnden)
                    return;
                _writer.Write(readKey.Character);
            }
        }
    }
}