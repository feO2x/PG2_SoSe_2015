using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public abstract class Mitarbeiterverwalter
    {
        public abstract Mitarbeiter[] LadeMitarbeiter();

        public abstract void SpeichereMitarbeiter(Mitarbeiter[] alleMitarbeiter);
    }

    public interface IMitarbeiterVerwalter
    {
        Mitarbeiter[] LadeMitarbeiter();
        void SpeichereMitarbeiter(Mitarbeiter[] alleMitarbeiter);

    }

    public class DbMitarbeiterVerwalter : IMitarbeiterVerwalter
    {

        public Mitarbeiter[] LadeMitarbeiter()
        {
            // Man könnte hier auf DB zugreifen, Objekte erstellen
            return new Mitarbeiter[256];
        }

        public void SpeichereMitarbeiter(Mitarbeiter[] alleMitarbeiter)
        {
            // Objekte zu Daten und an DB senden
        }
    }
    public class DatenbankMitarbeiterverwalter : Mitarbeiterverwalter
    {
        public override Mitarbeiter[] LadeMitarbeiter()
        {
            // Hier könnten wir auf eine Datenbank zugreifen
            // und Mitarbeiter laden
            return new Mitarbeiter[256];
        }

        public override void SpeichereMitarbeiter(Mitarbeiter[] alleMitarbeiter)
        {
            // Speichern in Datenbank
        }
    }

    public class DateiMitarbeiterverwalter : Mitarbeiterverwalter
    {
        public override Mitarbeiter[] LadeMitarbeiter()
        {
            // Hier könnten alle Daten aus Dateien geladen werden
            return new Mitarbeiter[128];
        }

        public override void SpeichereMitarbeiter(Mitarbeiter[] alleMitarbeiter)
        {
            // Speichere in Datei
        }
    }

    public class ErhöheGehaltsprozess
    {
        private Gehaltsrechner _gehaltsrechner;
        private Mitarbeiterverwalter _mitarbeiterveralter;

        public ErhöheGehaltsprozess(Gehaltsrechner gehaltsrechner,
                                    Mitarbeiterverwalter mitarbeiterverwalter)
        {
            _gehaltsrechner = gehaltsrechner;
            _mitarbeiterveralter = mitarbeiterverwalter;
        }

        public void FühreAus()
        {
            var alleMitarbeiter = _mitarbeiterveralter.LadeMitarbeiter();
            foreach (var mitarbeiter in alleMitarbeiter)
            {
                mitarbeiter.AktuellesGehalt += _gehaltsrechner.BerechneGehaltserhöhung(mitarbeiter);
            }

            _mitarbeiterveralter.SpeichereMitarbeiter(alleMitarbeiter);
        }
    }
}
