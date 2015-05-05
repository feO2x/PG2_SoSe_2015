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

            _vorname = vorname;
            _nachname = nachname;
        }

        //public Person(string vorname)
        //{
        //    if (string.IsNullOrEmpty(vorname))
        //        _vorname = "DEFAULT";
        //    else
        //        _vorname = vorname;

        //    _nachname = "DEFAULT";
        //}

        public string Vorname
        {
            get { return _vorname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                _vorname = value;
            }
        }

        public string Nachname
        {
            get { return _nachname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                _nachname = value;
            }
        }

        public int Alter
        {
            get { return _alter; }
            set
            {
                if (value < 0 || value > 150)
                    return;
                _alter = value;
            }
        }

        public override string ToString()
        {
            return Vorname + " " + Nachname;
        }

        
    }
}
