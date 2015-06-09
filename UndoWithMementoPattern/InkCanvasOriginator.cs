using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Ink;

namespace UndoWithMementoPattern
{
    public class InkCanvasOriginator : InkCanvas, IOriginator
    {
        public IMememto GetMemento()
        {
            return new StrokesMemento(Strokes.Clone());
        }

        public void SetMemento(IMememto memento)
        {
            Strokes = new StrokeCollection((IEnumerable<Stroke>) memento.State);
        }

        private class StrokesMemento : IMememto
        {
            private readonly StrokeCollection _strokeCollection;

            public StrokesMemento(StrokeCollection strokeCollection)
            {
                if (strokeCollection == null) throw new ArgumentNullException("strokeCollection");

                _strokeCollection = strokeCollection;
            }

            public object State
            {
                get { return _strokeCollection; }
            }
        }
    }
}