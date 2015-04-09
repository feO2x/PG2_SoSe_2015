using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class PersonMitGetSetMethoden
    {
        private string _vorname;
        private string _nachname;
        private int _alter;

        public string GetVorname()
        {
            return _vorname;
        }

        public void SetVorname(string vorname)
        {
            if (vorname == null || vorname.Length == 0)
            {
                // Exception werfen
                return;
            }
            _vorname = vorname;
        }

        public string GetNachname()
        {
            return _nachname;
        }

        public void SetNachname(string nachname)
        {
            if (string.IsNullOrEmpty(nachname))
                return;
            _nachname = nachname;
        }

        public int GetAlter()
        {
            return _alter;
        }

        public void SetAlter(int alter)
        {
            if (alter < 0 || alter > 150)
                return;

            _alter = alter;
        }
    }
}
