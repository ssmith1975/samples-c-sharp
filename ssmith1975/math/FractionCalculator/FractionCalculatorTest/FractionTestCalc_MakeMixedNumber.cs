using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTestCalc_MakeMixedNumber
    {
        // Test for valid whole number to mixed number conversion
        [TestMethod]
        public void MakeMixedNumber_ValidWholeToMixed()
        {
            // arrange
            Fraction fraction = new Fraction(3);

            Fraction expected = new Fraction(3, 0, 0);

            // action
            Fraction actual = FractionOperations.MakeMixedNumber(fraction);

            // assert 
            Assert.AreEqual(expected, actual, "Invalid whole to mixed conversion.");

        }

        // Test for valid proper fraction to mixed number conversion
        [TestMethod]
        public void MakeMixedNumber_ValidProperToMixed()
        {
            // arrange
            Fraction fraction = new Fraction(2, 3);

            Fraction expected = new Fraction(2, 3);

            // action
            Fraction actual = FractionOperations.MakeMixedNumber(fraction);

            // assert 
            Assert.AreEqual(expected, actual, "Invalid proper fraction to mixed conversion.");
        }

        // Test for valid improper fraction to mixed number conversion
        [TestMethod]
        public void MakeMixedNumber_ValidImproperToMixed()
        {
            // arrange
            Fraction fraction1 = new Fraction(5, 2);
            Fraction fraction2 = new Fraction(9, 3);

            Fraction expected1 = new Fraction(2, 1, 2);
            Fraction expected2 = new Fraction(3);

            // action
            Fraction actual1 = FractionOperations.MakeMixedNumber(fraction1);
            Fraction actual2 = FractionOperations.MakeMixedNumber(fraction2);

            // assert 
            Assert.AreEqual(expected1, actual1, "Invalid improper fraction to mixed conversion (with fractional result).");
            Assert.AreEqual(expected2, actual2, "Invalid improper fraction to mixed conversion (without fractional result).");
        }

        // Test for valid mixed number to mixed number conversion
        [TestMethod]
        public void MakeMixedNumber_ValidMixedToMixed()
        {
            // arrange
            Fraction fraction = new Fraction(1, 2, 3);

            Fraction expected = new Fraction(1, 2, 3);

            // action
            Fraction actual = FractionOperations.MakeMixedNumber(fraction);

            // assert 
            Assert.AreEqual(expected, actual, "Invalid mixed to mixed conversion.");
        }

        // Test for valid negative conversion
        [TestMethod]
        public void MakeMixedNumber_ValidNegativeToMixed()
        {
            // arrange
            Fraction fraction = new Fraction(-4, 3);

            Fraction expected = new Fraction(-1, 1, 3);

            // action
            Fraction actual = FractionOperations.MakeMixedNumber(fraction);

            // assert 
            Assert.AreEqual(expected, actual, "Invalid result when making negative to mixed conversion.");

        }

    }
}
