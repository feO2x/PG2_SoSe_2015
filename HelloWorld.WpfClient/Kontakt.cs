using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld.WpfClient
{
    public class Kontakt
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime? Geburtsdatum { get; set; }

        public string VollerName
        { get { return Vorname + " " + Nachname; } }

        public override string ToString()
        {
            return VollerName;
        }
    }
}
