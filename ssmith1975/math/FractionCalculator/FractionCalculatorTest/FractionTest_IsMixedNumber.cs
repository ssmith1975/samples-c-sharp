using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTest_IsMixedNumber
    {
        // Test when object initiated with various arguments
        [TestMethod]
        public void IsMixedNumber_ValidResult()
        {
            // arrange
            Fraction fraction1 = new Fraction(3);
            Fraction fraction2 = new Fraction(3, 4);
            Fraction fraction3 = new Fraction(3, 2, 5);

            Boolean expected1 = false;
            Boolean expected2 = false;
            Boolean expected3 = true;

            // action
            Boolean actual1 = fraction1.IsMixedNumber();
            Boolean actual2 = fraction2.IsMixedNumber();
            Boolean actual3 = fraction3.IsMixedNumber();

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result with one argument.");
            Assert.AreEqual(expected2, actual2, "Invalid result with two arguments.");
            Assert.AreEqual(expected3, actual3, "Invalid result with three arguments.");

        }

        // Test when object initiated with various arguments, negative fractions
        [TestMethod]
        public void IsMixedNumber_ValidResultNegative()
        {
            // arrange
            Fraction fraction1 = new Fraction(-3);
            Fraction fraction2 = new Fraction(-3, 4);
            Fraction fraction3 = new Fraction(-3, 2, 5);

            Boolean expected1 = false;
            Boolean expected2 = false;
            Boolean expected3 = true;

            // action
            Boolean actual1 = fraction1.IsMixedNumber();
            Boolean actual2 = fraction2.IsMixedNumber();
            Boolean actual3 = fraction3.IsMixedNumber();

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result with one argument, negative whole number.");
            Assert.AreEqual(expected2, actual2, "Invalid result with two arguments, negative proper fraction.");
            Assert.AreEqual(expected3, actual3, "Invalid result with three arguments, negative mixed number.");

        }

    }
}
