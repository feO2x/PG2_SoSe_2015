using HelloWorld.ConsoleApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    [TestClass]
    public class AdresseObjektgleichheitstests
    {
        [TestMethod]
        public void ZweiAdressenMitIdentischenWertenErzeugenDenselbenHashCode()
        {
            // Arrange
            var ersteAdresse = new Adresse("Universitätsstr.", "93053", "Regensburg");
            var zweiteAdresse = new Adresse("Universitätsstr.", "93053", "Regensburg");

            // Act
            var ersterHashCode = ersteAdresse.GetHashCode();
            var zweiteHashCode = zweiteAdresse.GetHashCode();

            // Assert
            Assert.AreEqual(ersterHashCode, zweiteHashCode);
        }

        [TestMethod]
        public void EqualsGibtTrueZurückBeiAnderemObjektMitIdentischenWerten()
        {
            // Arrange
            var ersteAdresse = new Adresse("Universitätsstr.", "93053", "Regensburg");
            var zweiteAdresse = new Adresse("Universitätsstr.", "93053", "Regensburg");

            // Act und Assert in einem Schritt
            Assert.IsTrue(ersteAdresse.Equals(zweiteAdresse));
        }

        [TestMethod]
        public void EqualsGibtFalseZurückBeiUnterschiedlichenObjektenMitUnterschiedlichenWerten()
        {
            // Arrange
            var ersteAdresse = new Adresse("Universitätsstr.", "93053", "Regensburg");
            var zweiteAdresse = new Adresse("Beispielstr.", "93047", "Regensburg");

            Assert.IsFalse(ersteAdresse.Equals(zweiteAdresse));
        }

        [TestMethod]
        public void EqualsGibtFalseZurückWennNullÜbergebenWird()
        {
            var adresse = new Adresse("Foo", "Bar", "Baz");

            Assert.IsFalse(adresse.Equals(null));
        }

        [TestMethod]
        public void EqualsGibtFalseZurückWennObjektEinerAnderenKlasseÜbergebenWird()
        {
            var adresse = new Adresse("Foo", "Bar", "Baz");
            var anderesObjekt = new Farbe(128, 128, 128);

            Assert.IsFalse(adresse.Equals(anderesObjekt));
        }
    }
}
