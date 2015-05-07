using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class Person
    {
        private string _vorname;
        private string _nachname;
        private int _alter;

        public Person(string vorname, string nachname)
        {

            if (string.IsNullOrEmpty(vorname))
                throw new ArgumentNullException("vorname");
            if (string.IsNullOrEmpty(nachname))
                throw new ArgumentNullException("nachname");

            this._vorname = vorname;
            this._nachname = nachname;
        }

        public string Vorname
        {
            get { return _vorname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");
                _vorname = value;
            }
        }

        public string Nachname
        {
            get { return _nachname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");
                _nachname = value;
            }
        }

        public int Alter
        {
            get { return _alter; }
            set
            {
                if (value < 0 || value > 150)
                    throw new ArgumentOutOfRangeException("value");
                _alter = value;
            }
        }

        public string VollerName
        {
            get { return Vorname + " " + Nachname; }
        }

        public override string ToString()
        {
            return Vorname + " " + Nachname;
        }

        
    }
}
