using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class Metronom
    {
        // Langform für Events
        //private Action _tick;

        //public event Action Tick
        //{
        //    add { _tick += value; }
        //    remove { _tick -= value; }
        //}

        public event Action Tick; // Üblicherweise nutzt man nur die Kurzvariante zur Definition von Events

        private int _beatsPerMinute = 120;

        public int BeatsPerMinute
        {
            get { return _beatsPerMinute; }
            set
            {
                if (value < 30 || value > 230)
                    throw new ArgumentOutOfRangeException();
                _beatsPerMinute = value;
            }
        }

        private bool _sollStoppen = false;

        public void Start()
        {
            _sollStoppen = false;
            var task = new Task(ErzeugeTicks);  // Die Klasse Task lagert eine Methode auf einen Hintergrundthread aus
            task.Start();  // Dieser Aufruf ist asynchron, d.h. er ist vorbei, sobald ErzeugeTicks auf dem Hintergrundthread eingereiht ist
        }

        private void ErzeugeTicks()
        {
            var anzahlMillisekunden = 60.0 / _beatsPerMinute * 1000.0;
            TimeSpan interval = TimeSpan.FromMilliseconds(anzahlMillisekunden);

            while(_sollStoppen == false)
            {
                if (Tick != null)
                    Tick();
                Thread.Sleep(interval);
            }
        }

        public void Stop()
        {
            _sollStoppen = true;
        }
    }
}
