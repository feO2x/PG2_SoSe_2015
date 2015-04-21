using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class Stack<T> : IEnumerable<T>
    {
        private T[] _array;

        public Stack(int kapazität)
        {
            if (kapazität < 2)
                throw new ArgumentOutOfRangeException("kapazität", "Die Kapazität muss größer als 1 sein.");
            _array = new T[kapazität];
        }

        public void Push(T element)
        {
            if (Count == _array.Length)
                throw new InvalidOperationException("Der Stack ist voll.");

            _array[Count] = element;
            Count++;
        }

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Der Stack ist leer.");

            Count--;
            T element = _array[Count];
            _array[Count] = default(T);
            return element;
        }

        public int Count { get; private set; }

        public IEnumerator<T> GetEnumerator()
        {
            return new ArrayEnumerator<T>(_array, Count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Stack
    {
        private object[] _array;

        public Stack(int kapazität)
        {
            if (kapazität < 2)
                throw new ArgumentOutOfRangeException("kapazität", "Die Kapazität muss größer als 1 sein.");
            _array = new object[kapazität];
        }

        public void Push(object element)
        {
            if (Count == _array.Length)
                throw new InvalidOperationException("Der Stack ist voll.");

            _array[Count] = element;
            Count++;
        }

        public object Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Der Stack ist leer.");

            Count--;
            object element = _array[Count];
            _array[Count] = null;
            return element;
        }

        public int Count { get; private set; }
    }
}
