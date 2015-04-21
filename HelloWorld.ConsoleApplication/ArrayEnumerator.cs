using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld.ConsoleApplication
{
    public class ArrayEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] _array;
        private readonly int _anzahlElemente;
        private T _current;
        private int _currentPosition = -1;

        public ArrayEnumerator(T[] array, int anzahlElemente)
        {
            _array = array;
            _anzahlElemente = anzahlElemente;
        }

        public T Current
        {
            get { return _current; }
        }

        public void Dispose()
        {
            
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            if (_currentPosition + 1 == _anzahlElemente)
            {
                _current = default(T);
                return false;
            }

            _currentPosition++;
            _current = _array[_currentPosition];
            return true;
        }

        public void Reset()
        {
            _currentPosition = -1;
            _current = default(T);
        }
    }
}
