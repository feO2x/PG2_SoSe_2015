using System;
using System.Collections.Generic;
using System.Threading;
namespace HelloWorld.ConsoleApplication
{
    public delegate void MeineFunktion(ref int value);

    class Program
    {
        static void Main()
        {
            var mitarbeiter = new List<Mitarbeiter>
                              {
                                  new Mitarbeiter { Name = "Aaberg, Jesper", Verhältnis = Mitarbeiter.Manager, AktuellesGehalt = 6000m },
                                  new Mitarbeiter { Name = "Adams, Ellen", Verhältnis = Mitarbeiter.Angestellter, AktuellesGehalt = 2050m },
                                  new Mitarbeiter { Name = "Adams, Terry", Verhältnis = Mitarbeiter.Angestellter, AktuellesGehalt = 2600m },
                                  new Mitarbeiter { Name = "Pfeiffer, Michael", Verhältnis = Mitarbeiter.Manager, AktuellesGehalt = 6300m },
                                  new Mitarbeiter { Name = "Philips, Carol", Verhältnis = Mitarbeiter.Teamleiter, AktuellesGehalt = 3800m },
                                  new Mitarbeiter { Name = "Poe, Toni", Verhältnis = Mitarbeiter.Manager, AktuellesGehalt = 7400 },
                                  new Mitarbeiter { Name = "Hicks, Cassie", Verhältnis = Mitarbeiter.Teamleiter, AktuellesGehalt = 3550m },
                                  new Mitarbeiter { Name = "Argentiero, Luca", Verhältnis = Mitarbeiter.Angestellter, AktuellesGehalt = 2200m },
                                  new Mitarbeiter { Name = "Perry, Brian", Verhältnis = Mitarbeiter.Angestellter, AktuellesGehalt = 2800m },
                                  new Mitarbeiter { Name = "Ramos, Luciana", Verhältnis = Mitarbeiter.Angestellter, AktuellesGehalt = 3000m },
                                  new Mitarbeiter { Name = "Barber, David", Verhältnis = Mitarbeiter.Teamleiter, AktuellesGehalt = 4000m },
                                  new Mitarbeiter { Name = "Jamison, Jay", Verhältnis = Mitarbeiter.Teamleiter, AktuellesGehalt = 3750m },
                              };

            var aufschlüsseler = new MitarbeiterAufschlüsseler();
            aufschlüsseler.SchlüsseleAuf(mitarbeiter);

            Console.ReadLine();
        }

        
    }


}
