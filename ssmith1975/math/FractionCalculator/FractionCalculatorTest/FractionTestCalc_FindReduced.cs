using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTestCalc_FindReduced
    {
        // Test for valid reduced fractions
        [TestMethod]
        public void FindReduced_IsValid()
        {
            // arrange
            Fraction fraction1 = new Fraction(3);
            Fraction fraction2 = new Fraction(3, 6);
            Fraction fraction3 = new Fraction(6, 3);
            Fraction fraction4 = new Fraction(1, 3, 6);

            Fraction expected1 = new Fraction(3, 1);
            Fraction expected2 = new Fraction(1, 2);
            Fraction expected3 = new Fraction(2, 1);
            Fraction expected4 = new Fraction(3, 2);

            // action
            Fraction actual1 = FractionOperations.FindReduced(fraction1);
            Fraction actual2 = FractionOperations.FindReduced(fraction2);
            Fraction actual3 = FractionOperations.FindReduced(fraction3);
            Fraction actual4 = FractionOperations.FindReduced(fraction4);


            // assert
            Assert.AreEqual(expected1, actual1, "Invalid reduced fraction for whole number.");
            Assert.AreEqual(expected2, actual2, "Invalid reduced fraction for proper fraction.");
            Assert.AreEqual(expected3, actual3, "Invalid reduced fraction for improper fraction.");
            Assert.AreEqual(expected4, actual4, "Invalid reduced fraction for mixed number.");
        }

        // Test for valid reduced fractions when negative
        [TestMethod]
        public void FindReduced_IsValidNegative()
        {
            // arrange
            Fraction fraction1 = new Fraction(-3);
            Fraction fraction2 = new Fraction(-3, 6);
            Fraction fraction3 = new Fraction(-6, 3);
            Fraction fraction4 = new Fraction(-1, 3, 6);

            Fraction expected1 = new Fraction(-3, 1);
            Fraction expected2 = new Fraction(-1, 2);
            Fraction expected3 = new Fraction(-2, 1);
            Fraction expected4 = new Fraction(-3, 2);

            // action
            Fraction actual1 = FractionOperations.FindReduced(fraction1);
            Fraction actual2 = FractionOperations.FindReduced(fraction2);
            Fraction actual3 = FractionOperations.FindReduced(fraction3);
            Fraction actual4 = FractionOperations.FindReduced(fraction4);


            // assert
            Assert.AreEqual(expected1, actual1, "Invalid reduced fraction for negative whole number.");
            Assert.AreEqual(expected2, actual2, "Invalid reduced fraction for negative proper fraction.");
            Assert.AreEqual(expected3, actual3, "Invalid reduced fraction for negative improper fraction.");
            Assert.AreEqual(expected4, actual4, "Invalid reduced fraction for negative mixed number.");


        }

    }
}
