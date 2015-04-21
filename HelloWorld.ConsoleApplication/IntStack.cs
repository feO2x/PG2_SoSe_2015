using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class IntStack
    {
        private int[] _array;

        public IntStack(int kapazität)
        {
            if (kapazität < 2)
                throw new ArgumentOutOfRangeException("kapazität", "Die Kapazität muss größer als 1 sein.");
            _array = new int[kapazität];
        }

        public void Push(int element)
        {
            if (Count == _array.Length)
                throw new InvalidOperationException("Der Stack ist voll.");

            _array[Count] = element;
            Count++;
        }

        public int Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Der Stack ist leer.");

            Count--;
            int element = _array[Count];
            _array[Count] = 0;
            return element;
        }

        public int Count { get; private set; }
    }
}
