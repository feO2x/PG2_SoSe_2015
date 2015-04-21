using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class StringStack
    {
        private string[] _array;

        public StringStack(int kapazität)
        {
            if (kapazität < 2)
                throw new ArgumentOutOfRangeException("kapazität", "Die Kapazität muss größer als 1 sein.");
            _array = new string[kapazität];
        }

        public void Push(string element)
        {
            if (Count == _array.Length)
                throw new InvalidOperationException("Der Stack ist voll.");

            _array[Count] = element;
            Count++;
        }

        public string Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Der Stack ist leer.");

            Count--;
            string element = _array[Count];
            _array[Count] = null;
            return element;
        }

        public int Count { get; private set; }
    }
}
