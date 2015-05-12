using System;
using System.Runtime.Serialization;

namespace HelloWorld.ConsoleApplication
{
    [DataContract]
    public class Kontakt
    {
        [DataMember]
        public string Vorname { get; set; }

        [DataMember]
        public string Nachname { get; set; }

        public string VollerName
        {
            get { return Vorname + " " + Nachname; }
        }

        [DataMember]
        public DateTime? Geburtsdatum { get; set; }

        [DataMember]
        public string Telefon { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}