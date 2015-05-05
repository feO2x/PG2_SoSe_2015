using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class MitarbeiterAufschlüsseler
    {
        public void SchlüsseleAuf(IReadOnlyList<Mitarbeiter> mitarbeiterListe)
        {

            // Lösung mit LINQ
            var gruppierung =  mitarbeiterListe.Where(mitarbeiter => mitarbeiter.Verhältnis != Mitarbeiter.Angestellter)
                                               .OrderByDescending(mitarbeiter => mitarbeiter.AktuellesGehalt)
                                               .GroupBy(mitarbeiter => mitarbeiter.Verhältnis);


            foreach (var gruppe in gruppierung)
            {
                var nameDerGruppe = gruppe.Key;
                Console.WriteLine(nameDerGruppe);
                Console.WriteLine("-------------------");

                foreach (var mitarbeiter in gruppe)
                {
                    Console.WriteLine("  {0}, {1}", mitarbeiter.Name, mitarbeiter.AktuellesGehalt);
                }
                Console.WriteLine();
            }

            
        }

        private static bool FiltereAngestelte(Mitarbeiter x)
        {
            return x.Verhältnis != Mitarbeiter.Angestellter;
        }

        private static int VergleicheMitarbeiter(Mitarbeiter x, Mitarbeiter y)
        {
            return (int)y.AktuellesGehalt - (int)x.AktuellesGehalt;
        }
    }
}
//var dictionary = new Dictionary<string, List<Mitarbeiter>>();

//foreach (var mitarbeiter in mitarbeiterListe)
//{
//    if (mitarbeiter.Verhältnis == Mitarbeiter.Angestellter)
//        continue;

//    if (dictionary.ContainsKey(mitarbeiter.Verhältnis) == false)
//        dictionary[mitarbeiter.Verhältnis] = new List<Mitarbeiter>();

//    dictionary[mitarbeiter.Verhältnis].Add(mitarbeiter);
//}

//foreach (var liste in dictionary.Values)
//{
//    liste.Sort(VergleicheMitarbeiter);
//}
