using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class Adresse : IEquatable<Adresse>
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

        public bool Equals(Adresse other)
        {
            if (object.ReferenceEquals(other, null))
                return false;

            return other._ort == this._ort &&
                   other._postleitzahl == this._postleitzahl &&
                   other._straße == this._straße;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Adresse);
        }

        public override int GetHashCode()
        {
            var hashCode = 17;
            hashCode = 31 + _straße.GetHashCode() * hashCode;
            hashCode = 31 + _postleitzahl.GetHashCode() * hashCode;
            hashCode = 31 + _ort.GetHashCode() * hashCode;
            return hashCode;
        }

        public static bool operator ==(Adresse ersteAdresse, Adresse zweiteAdresse)
        {
            if (ReferenceEquals(ersteAdresse, null))
                return ReferenceEquals(zweiteAdresse, null);

            return ersteAdresse.Equals(zweiteAdresse);
        }

        public static bool operator !=(Adresse ersteAdresse, Adresse zweiteAdresse)
        {
            return !(ersteAdresse == zweiteAdresse);
        }
    }

}
