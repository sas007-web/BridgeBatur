using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;

namespace Bridge.Tests
{
    /// <summary>
    /// Indeholder enhedstests for billetteringssystemet til brobetaling.
    /// Tester bil- og motorcykelklasserne samt deres metoder.
    /// </summary>
    [TestClass()]
    public class BridgeTests
    {
        /// <summary>
        /// Tester at metoden <see cref="Car.Price"/> returnerer den korrekte faste pris på 230 kr.
        /// </summary>
        [TestMethod()]
        public void Car_Price_ShouldReturnCorrectValue()
        {
            // Arrange
            Car car = new Car();
            double expectedPrice = 230;

            // Act
            double actualPrice = car.Price();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, "Price-metoden bør returnere 230.");
        }

        /// <summary>
        /// Tester at metoden <see cref="Car.VehicleType"/> returnerer den korrekte type "Car".
        /// </summary>
        [TestMethod()]
        public void Car_VehicleType_ShouldReturnCar()
        {
            // Arrange
            Car car = new Car();
            string expectedType = "Car";

            // Act
            string actualType = car.VehicleType();

            // Assert
            Assert.AreEqual(expectedType, actualType, "VehicleType-metoden bør returnere 'Car'.");
        }

        /// <summary>
        /// Tester at metoden <see cref="MC.Price"/> returnerer den korrekte faste pris på 120 kr.
        /// </summary>
        [TestMethod()]
        public void MC_Price_ShouldReturnCorrectValue()
        {
            // Arrange
            MC mc = new MC();
            double expectedPrice = 120;

            // Act
            double actualPrice = mc.Price();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, "Price-metoden bør returnere 120.");
        }

        /// <summary>
        /// Tester at metoden <see cref="MC.VehicleType"/> returnerer den korrekte type "MC".
        /// </summary>
        [TestMethod()]
        public void MC_Vehicle_ShouldReturnMC()
        {
            // Arrange
            MC mc = new MC();
            string expectedType = "MC";

            // Act
            string actualType = mc.VehicleType();

            // Assert
            Assert.AreEqual(expectedType, actualType, "VehicleType-metoden bør returnere 'MC'.");
        }

        /// <summary>
        /// Tester at der kastes en exception, hvis en nummerplade overstiger 7 tegn.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlate_ShouldThrowException_IfLongerThan7Characters()
        {
            // Arrange
            Vehicle car = new Car();

            // Act & Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => car.LicensePlate = "ABCDEFGH");

            // Kontrollerer den præcise fejlmeddelelse (valgfrit)
            Assert.AreEqual("License plate cannot be longer than 7 characters.", ex.Message);
        }

        /// <summary>
        /// Tester at en nummerplade med 7 tegn accepteres korrekt.
        /// </summary>
        [TestMethod]
        public void LicensePlate_ShouldAcceptValidLength()
        {
            // Arrange
            Vehicle car = new Car();
            string validLicense = "ABC1234"; // Præcis 7 tegn

            // Act
            car.LicensePlate = validLicense;

            // Assert
            Assert.AreEqual(validLicense, car.LicensePlate, "Nummerpladen bør accepteres, når den er inden for grænsen.");
        }

        /// <summary>
        /// Tester at BroBizz-rabat bliver korrekt anvendt på en bil.
        /// </summary>
        [TestMethod]
        public void Car_Price_ShouldApplyBrobizzDiscount()
        {
            // Arrange
            Vehicle car = new Car { HasBroBizz = true };
            double expectedPrice = 230 * 0.9; // 10% rabat

            // Act
            double actualPrice = car.GetPrice();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.01, "BroBizz-rabatten bør anvendes korrekt.");
        }

        /// <summary>
        /// Tester at prisen forbliver uændret, når BroBizz ikke anvendes på en bil.
        /// </summary>
        [TestMethod]
        public void Car_Price_ShouldNotApplyBrobizzDiscount_IfNotUsed()
        {
            // Arrange
            Vehicle car = new Car { HasBroBizz = false };
            double expectedPrice = 230; // Ingen rabat

            // Act
            double actualPrice = car.GetPrice();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.01, "Prisen bør forblive uændret, hvis BroBizz ikke anvendes.");
        }

        /// <summary>
        /// Tester at BroBizz-rabat bliver korrekt anvendt på en motorcykel.
        /// </summary>
        [TestMethod]
        public void MC_Price_ShouldApplyBrobizzDiscount()
        {
            // Arrange
            Vehicle mc = new MC { HasBroBizz = true };
            double expectedPrice = 120 * 0.9; // 10% rabat

            // Act
            double actualPrice = mc.GetPrice();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.01, "BroBizz-rabatten bør anvendes korrekt.");
        }
    }
}
