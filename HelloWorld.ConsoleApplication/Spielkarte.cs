using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class Spielkarte : IEquatable<Spielkarte>
    {
        private readonly Kartenfarbe _farbe;
        private readonly Kartenwert _wert;

        public Kartenfarbe Farbe
        {
            get { return _farbe; }
        }

        public Kartenwert Wert
        {
            get { return _wert; }
        }

        public Spielkarte(Kartenfarbe farbe, Kartenwert wert)
        {
            _farbe = farbe;
            _wert = wert;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Spielkarte);
        }

        public override int GetHashCode()
        {
            return ((int)_farbe) << 16 + (int)_wert;
        }

        public bool Equals(Spielkarte other)
        {
            if (ReferenceEquals(other, null))
                return false;

            return _wert == other._wert &&
                   _farbe == other._farbe;
        }

        public static bool operator ==(Spielkarte erste, Spielkarte zweite)
        {
            if (ReferenceEquals(erste, null))
                return ReferenceEquals(zweite, null);

            return erste.Equals(zweite);
        }

        public static bool operator !=(Spielkarte erste, Spielkarte zweite)
        {
            return !(erste == zweite);
        }

        public override string ToString()
        {
            return _farbe + " " + _wert;
        }
    }
}
