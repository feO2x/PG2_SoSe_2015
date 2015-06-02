using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Tests
{
    public class Rechteck
    {
        private int _höhe;
        private int _breite;

        public virtual int Höhe
        {
            get { return _höhe; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _höhe = value;
            }
        }

        public virtual int Breite
        {
            get { return _breite; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _breite = value;
            }
        }

        public int BerechneFläche()
        {
            return _höhe * _breite;
        }
    }

    public class Quadrat : Rechteck
    {
        public override int Breite
        {
            get { return base.Breite; }
            set
            {
                base.Breite = value;
                base.Höhe = value;
            }
        }

        public override int Höhe
        {
            get { return base.Höhe; }
            set
            {
                base.Höhe = value;
                base.Breite = value;
            }
        }
    }
}
