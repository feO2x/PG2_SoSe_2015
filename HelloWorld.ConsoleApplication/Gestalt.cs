using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public abstract class Gestalt
    {
        public abstract double BerechneFläche();
    }

    public class Rechteck : Gestalt
    {
        private readonly double _breite;
        private readonly double _höhe;

        public Rechteck(double breite, double höhe)
        {
            _breite = breite;
            _höhe = höhe;
        }

        public override double BerechneFläche()
        {
            return _breite * _höhe;
        }
    }

    public class Kreis : Gestalt
    {
        private double _radius;

        public Kreis(double radius)
        {
            _radius = radius;
        }

        public override double BerechneFläche()
        {
            return _radius * _radius * Math.PI;
        }
    }

    public class Dreieck : Gestalt
    {
        private double _breite;
        private double _höhe;

        public Dreieck(double breite, double höhe)
        {
            _breite = breite;
            _höhe = höhe;
        }

        public override double BerechneFläche()
        {
            return 0.5 * _breite * _höhe;
        }
    }

}
