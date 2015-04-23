using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class UnendlicheAufzählung : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new UnendlicherEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class UnendlicherEnumerator : IEnumerator<int>
        {
            private int _current;
            private Random _zufallszahlenGenerator = new Random();

            public int Current
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
                _current = _zufallszahlenGenerator.Next();
                return true;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }
        }
    }
}
