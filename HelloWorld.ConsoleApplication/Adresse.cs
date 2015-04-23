using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class Adresse
    {
        private readonly string _straße;
        private readonly string _postleitzahl;
        private readonly string _ort;

        public Adresse(string straße, string postleitzahl, string ort)
        {
            _straße = straße;
            _postleitzahl = postleitzahl;
            _ort = ort;
        }

        public override bool Equals(object obj)
        {
            var andereAdresse = obj as Adresse;
            if (andereAdresse == null)
                return false;

            return andereAdresse._ort == this._ort &&
                   andereAdresse._postleitzahl == this._postleitzahl &&
                   andereAdresse._straße == this._straße;
        }

        public override int GetHashCode()
        {
            var hashCode = 17;
            hashCode = 31 + _straße.GetHashCode() * hashCode;
            hashCode = 31 + _postleitzahl.GetHashCode() * hashCode;
            hashCode = 31 + _ort.GetHashCode() * hashCode;
            return hashCode;
        }
    }

}
