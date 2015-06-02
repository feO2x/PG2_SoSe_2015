using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    [TestClass]
    public class RechteckTests
    {
        [TestMethod]
        public void BerechneFlächeFunktioniertFürRechteck()
        {
            var rechteck = new Rechteck();
            ÜberprüfeFläche(rechteck);
        }

        [TestMethod]
        public void BerechneFlächeFunktioniertFürQuadrat()
        {
            var quadrat = new Quadrat();
            ÜberprüfeFläche(quadrat);
        }

        private static void ÜberprüfeFläche(Rechteck rechteck)
        {
            rechteck.Höhe = 4;
            rechteck.Breite = 5;
            Assert.AreEqual(20, rechteck.BerechneFläche());
        }
    }
}
