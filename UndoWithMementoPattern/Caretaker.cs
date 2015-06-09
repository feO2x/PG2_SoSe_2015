using System;
using System.Collections.Generic;

namespace UndoWithMementoPattern
{
    public class Caretaker
    {
        private readonly IOriginator _originator;
        private readonly Stack<IMememto> _memetoStack = new Stack<IMememto>();

        public Caretaker(IOriginator originator)
        {
            if (originator == null) throw new ArgumentNullException("originator");

            _originator = originator;
            RequestMemento();
        }

        public void RequestMemento()
        {
            var memento = _originator.GetMemento();
            _memetoStack.Push(memento);
        }

        public void Undo()
        {
            if (_memetoStack.Count <= 1)
                return;

            _memetoStack.Pop();
            _originator.SetMemento(_memetoStack.Peek());
        }
    }
}