using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class Gehaltsrechner
    {
        public virtual decimal BerechneGehaltserhöhung(Mitarbeiter mitarbeiter)
        {
            if (mitarbeiter.Verhältnis == Mitarbeiter.Manager)
                return mitarbeiter.AktuellesGehalt * 0.5m;
            if (mitarbeiter.Verhältnis == Mitarbeiter.Teamleiter)
                return mitarbeiter.AktuellesGehalt * 0.2m;
            if (mitarbeiter.Verhältnis == Mitarbeiter.Angestellte)
                return mitarbeiter.AktuellesGehalt * 0.05m;

            return -(mitarbeiter.AktuellesGehalt * 0.2m);
        }
    }

    public class GehaltrechnerMitTracking : Gehaltsrechner
    {
        private int _anzahlAufrufe = 0;

        public override decimal BerechneGehaltserhöhung(Mitarbeiter mitarbeiter)
        {
            _anzahlAufrufe++;
            return base.BerechneGehaltserhöhung(mitarbeiter);
        }
    }

    public class Mitarbeiter
    {
        public const string Manager = "Manager";
        public const string Teamleiter = "Teamleiter";
        public const string Angestellte = "Angestellte";

        public string Name { get; set; }
        public string Verhältnis { get; set; }
        public decimal AktuellesGehalt { get; set; }
    }
}
