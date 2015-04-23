using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApplication
{
    public class Farbe
    {
        public Farbe(byte rot, byte grün, byte blau)
        {
            Rot = rot; Grün = grün; Blau = blau;
        }
        public byte Rot { get; private set; }
        public byte Grün { get; private set; }
        public byte Blau { get; private set; }

        public override bool Equals(object obj)
        {
            Farbe anderesObjekt = obj as Farbe;
            if (anderesObjekt == null)
                return false;

            return anderesObjekt.Rot == this.Rot &&
                   anderesObjekt.Grün == this.Grün &&
                   anderesObjekt.Blau == this.Blau;
        }

        public override int GetHashCode()
        {
            return (int)Rot + ((int)Grün << 8) + ((int)Blau << 16);
        }

        public override string ToString()
        {
            return string.Format("R {0} G {1} B {2}", Rot, Grün, Blau);
        }
    }
}
