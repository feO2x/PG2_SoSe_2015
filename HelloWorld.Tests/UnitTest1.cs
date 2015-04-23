using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.ConsoleApplication;

namespace HelloWorld.Tests
{
    [TestClass]
    public class UnitTest1
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
    }
}
