using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTest_IsWholeNumber
    {
        // Test when object initiated with various arguments
        [TestMethod]
        public void IsWholeNumber_IsValidResult()
        {

            // arrange
            Fraction fraction1 = new Fraction(3);
            Fraction fraction2 = new Fraction(3, 4);
            Fraction fraction3 = new Fraction(3, 2, 5);

            Boolean expected1 = true;
            Boolean expected2 = false;
            Boolean expected3 = false;

            // action
            Boolean actual1 = fraction1.IsWholeNumber();
            Boolean actual2 = fraction2.IsWholeNumber();
            Boolean actual3 = fraction3.IsWholeNumber();

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result with one argument.");
            Assert.AreEqual(expected2, actual2, "Invalid result with two arguments.");
            Assert.AreEqual(expected3, actual3, "Invalid result with three arguments.");
        }

        // Test when object initiated with various arguments, negative fractions
        [TestMethod]
        public void IsWholeNumber_IsValidResultNegative()
        {

            // arrange
            Fraction fraction1 = new Fraction(-3);
            Fraction fraction2 = new Fraction(-3, 4);
            Fraction fraction3 = new Fraction(-3, 2, 5);

            Boolean expected1 = true;
            Boolean expected2 = false;
            Boolean expected3 = false;

            // action
            Boolean actual1 = fraction1.IsWholeNumber();
            Boolean actual2 = fraction2.IsWholeNumber();
            Boolean actual3 = fraction3.IsWholeNumber();

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result with one argument; negative whole number.");
            Assert.AreEqual(expected2, actual2, "Invalid result with two arguments; negative fraction.");
            Assert.AreEqual(expected3, actual3, "Invalid result with three arguments; negative mixed number.");
        }
    }
}
