using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTest_IsUnit
    {
        [TestMethod]
        public void IsUnit_IsValidResult()
        {

            // arrange
            Fraction fraction1 = new Fraction(3);
            Fraction fraction2 = new Fraction(3, 4);
            Fraction fraction3 = new Fraction(3, 2, 5);
            Fraction fraction4 = new Fraction(1, 4);
            Fraction fraction5 = new Fraction(2, 1, 4);

            Boolean expected1 = false;
            Boolean expected2 = false;
            Boolean expected3 = false;
            Boolean expected4 = true;
            Boolean expected5 = false;

            // action
            Boolean actual1 = fraction1.IsUnit();
            Boolean actual2 = fraction2.IsUnit();
            Boolean actual3 = fraction3.IsUnit();
            Boolean actual4 = fraction4.IsUnit();
            Boolean actual5 = fraction5.IsUnit();


            // assert
            Assert.IsNotNull(actual1, "Invalid result with one argument, result is null.");
            Assert.AreEqual(expected1, actual1, "Invalid result with one argument, numerator is not one.");


            Assert.AreEqual(expected2, actual2, "Invalid result with two argument, numerator is not one");
            Assert.AreEqual(expected3, actual3, "Invalid result with three arguments, numerator is not one.");
            Assert.AreEqual(expected4, actual4, "Invalid result with two arguments, numerator is one.");
            Assert.AreEqual(expected5, actual5, "Invalid result with three arguments, numerator is one.");
        }

        // Test for negative fractions
        [TestMethod]
        public void IsUnit_IsValidResultNegative()
        {

            // arrange
            Fraction fraction1 = new Fraction(-3);
            Fraction fraction2 = new Fraction(-3, 4);
            Fraction fraction3 = new Fraction(-3, 2, 5);
            Fraction fraction4 = new Fraction(-1, 4);
            Fraction fraction5 = new Fraction(-2, 1, 4);

            Boolean expected1 = false;
            Boolean expected2 = false;
            Boolean expected3 = false;
            Boolean expected4 = true;
            Boolean expected5 = false;

            // action
            Boolean actual1 = fraction1.IsUnit();
            Boolean actual2 = fraction2.IsUnit();
            Boolean actual3 = fraction3.IsUnit();
            Boolean actual4 = fraction4.IsUnit();
            Boolean actual5 = fraction5.IsUnit();


            // assert
            Assert.IsNotNull(actual1, "Invalid result with one argument, result is null.");
            Assert.AreEqual(expected1, actual1, "Invalid result with one argument, numerator is not one; negative whole number.");


            Assert.AreEqual(expected2, actual2, "Invalid result with two argument, numerator is not one; negative proper fraction");
            Assert.AreEqual(expected3, actual3, "Invalid result with three arguments, numerator is not one; negative mixed number.");
            Assert.AreEqual(expected4, actual4, "Invalid result with two arguments, numerator is one; negative proper fraction.");
            Assert.AreEqual(expected5, actual5, "Invalid result with three arguments, numerator is one; negative mixed number.");
        }

    }
}
