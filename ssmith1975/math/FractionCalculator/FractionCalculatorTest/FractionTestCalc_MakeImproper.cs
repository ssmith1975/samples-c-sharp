using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTestCalc_MakeImproper
    {
        // Test for valid result
        [TestMethod]
        public void MakeImproper_IsValidResult()
        {
            // arrange
            Fraction fraction1 = new Fraction(2);
            Fraction fraction2 = new Fraction(3, 5);
            Fraction fraction3 = new Fraction(4, 3);
            Fraction fraction4 = new Fraction(1, 1, 2);

            Fraction expected1 = new Fraction(2, 1);
            Fraction expected2 = new Fraction(3, 5);
            Fraction expected3 = new Fraction(4, 3);
            Fraction expected4 = new Fraction(3, 2);

            // action
            Fraction actual1 = FractionOperations.MakeImproper(fraction1);
            Fraction actual2 = FractionOperations.MakeImproper(fraction2);
            Fraction actual3 = FractionOperations.MakeImproper(fraction3);
            Fraction actual4 = FractionOperations.MakeImproper(fraction4);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid Improper fraction result for whole number.");
            Assert.AreEqual(expected2, actual2, "Invalid Improper fraction result for proper fraction.");
            Assert.AreEqual(expected3, actual3, "Invalid Improper fraction result for improper fraction.");
            Assert.AreEqual(expected4, actual4, "Invalid Improper fraction result for mixed number.");
        }

        // Test for valid result
        [TestMethod]
        public void MakeImproper_IsValidForNegatives()
        {
            // arrange
            Fraction fraction1 = new Fraction(-2);
            Fraction fraction2 = new Fraction(-3, 5);
            Fraction fraction3 = new Fraction(-4, 3);
            Fraction fraction4 = new Fraction(-1, 1, 2);

            Fraction expected1 = new Fraction(-2, 1);
            Fraction expected2 = new Fraction(-3, 5);
            Fraction expected3 = new Fraction(-4, 3);
            Fraction expected4 = new Fraction(-3, 2);

            // action
            Fraction actual1 = FractionOperations.MakeImproper(fraction1);
            Fraction actual2 = FractionOperations.MakeImproper(fraction2);
            Fraction actual3 = FractionOperations.MakeImproper(fraction3);
            Fraction actual4 = FractionOperations.MakeImproper(fraction4);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid Improper fraction result for negative whole number.");
            Assert.AreEqual(expected2, actual2, "Invalid Improper fraction result for negative proper fraction.");
            Assert.AreEqual(expected3, actual3, "Invalid Improper fraction result for negative improper fraction.");
            Assert.AreEqual(expected4, actual4, "Invalid Improper fraction result for negative mixed number.");
        }       
    }
}
