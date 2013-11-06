using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTestCalc_MakeEquivalenct
    {
        // Test for valid result for whole number
        [TestMethod]
        public void MakeEquivalent_ValidWResultWhole()
        {
            // arrange
            Fraction fraction = new Fraction(2);
            int factor1 = 3;

            Fraction expected1 = new Fraction(6, 3);

            // action
            Fraction actual1 = FractionOperations.MakeEquivalent(fraction, factor1);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result for whole number");
        }

        // Test for valid result for proper fraction
        [TestMethod]
        public void MakeEquivalent_ValidResultProper()
        {
            // arrange
            Fraction fraction = new Fraction(2, 3);
            int factor1 = 4;

            Fraction expected1 = new Fraction(8, 12);

            // action
            Fraction actual1 = FractionOperations.MakeEquivalent(fraction, factor1);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result for proper fraction");
        }

        // Test for valid result for improper fraction
        [TestMethod]
        public void MakeEquivalent_ValidResultImproper()
        {
            // arrange
            Fraction fraction = new Fraction(4, 3);
            int factor1 = 7;

            Fraction expected1 = new Fraction(28, 21);

            // action
            Fraction actual1 = FractionOperations.MakeEquivalent(fraction, factor1);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result for improper fraction");
        }

        // Test for valid result for proper fraction
        [TestMethod]
        public void MakeEquivalent_ValidWMixedumber()
        {
            // arrange
            Fraction fraction = new Fraction(1, 2, 3);
            int factor1 = 6;

            Fraction expected1 = new Fraction(30, 18);

            // action
            Fraction actual1 = FractionOperations.MakeEquivalent(fraction, factor1);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result for mixed number fraction");
        }

        // Test for valid result for negative fraction
        [TestMethod]
        public void MakeEquivalent_ValidNegative()
        {
            // arrange
            Fraction fraction = new Fraction(-1, 2, 3);
            int factor1 = 6;

            Fraction expected1 = new Fraction(-30, 18);

            // action
            Fraction actual1 = FractionOperations.MakeEquivalent(fraction, factor1);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result for neagtive mixed number fraction");
        }


        // Test for negative factor value
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A negative integer was allowed in the factor argument.")]
        public void MakeEquivalent_WithNegativeFactor()
        {
            // arrange
            Fraction fraction = new Fraction(2, 3);
            int factor1 = -4;

            Fraction expected1 = new Fraction(-8, -12);

            // action
            Fraction actual1 = FractionOperations.MakeEquivalent(fraction, factor1);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result for improper fraction");
        }

        // Test for ero factor value
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A zero value was allowed in the factor argument.")]
        public void MakeEquivalent_WithZeroFactor()
        {
            // arrange
            Fraction fraction = new Fraction(2, 3);
            int factor1 = 0;

            Fraction expected1 = new Fraction(2, 3);

            // action
            Fraction actual1 = FractionOperations.MakeEquivalent(fraction, factor1);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result for improper fraction");
        }

    }
}
