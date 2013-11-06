using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTest_IsImproper
    {
        // Test when object initiated with a single argument 
        [TestMethod]
        public void IsImproper_IsValidWithOneArugment()
        {
            // arrange
            Fraction fraction1 = new Fraction(3);

            Boolean expected1 = false;

            // action
            Boolean actual1 = fraction1.IsImproper();

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid result with one argument.");

        }

        // Test when object initiated with a two arguments
        [TestMethod]
        public void IsImproper_IsValidWithTwoArguments()
        {
            // arrange
            Fraction fraction2a = new Fraction(2, 3);
            Fraction fraction2b = new Fraction(3, 2);

            Boolean expected2a = false;
            Boolean expected2b = true;

            // action
            Boolean actual2a = fraction2a.IsImproper();
            Boolean actual2b = fraction2b.IsImproper();


            // assert
            Assert.AreEqual(expected2a, actual2a, "Invalid result with two arguments, big denominator.");
            Assert.AreEqual(expected2b, actual2b, "Invalid result with two arguments, small denominator.");

        }

        // Test when object initiated with a three arguments
        [TestMethod]
        public void IsImproper_IsValidWithThreeArguments()
        {
            // arrange
            Fraction fraction3a = new Fraction(1, 2, 3);
            Fraction fraction3b = new Fraction(1, 3, 2);

            Boolean expected3a = false;
            Boolean expected3b = true;

            // action
            Boolean actual3a = fraction3a.IsImproper();
            Boolean actual3b = fraction3b.IsImproper();

            // assert
            Assert.AreEqual(expected3a, actual3a, "Invalid result with two arguments, big denominator.");
            Assert.AreEqual(expected3b, actual3b, "Invalid result with two arguments, small denominator.");
        }

        // Test when object initiated with same numerator and denominator
        [TestMethod]
        public void IsImproper_IsValidSameNumAndDen()
        {
            // arrange
            Fraction fraction4 = new Fraction(3,3);

            Boolean expected4 = true;

            // action
            Boolean actual4 = fraction4.IsImproper();

            // assert
            Assert.AreEqual(expected4, actual4, "Invalid result with same numerator and denominator.");

        }
        // Test when object initiated with negative integers
        [TestMethod]
        public void IsImproper_IsValidWithNegatives()
        {
            // arrange
            Fraction fraction1 = new Fraction(-4, 3);
            Fraction fraction2 = new Fraction(4, -3);
            Fraction fraction3 = new Fraction(-4, -3);
            Fraction fraction4 = new Fraction(-3, 4);

            

            // action
            Boolean actual1 = fraction1.IsImproper();
            Boolean actual2 = fraction2.IsImproper();
            Boolean actual3 = fraction3.IsImproper();
            Boolean actual4 = fraction4.IsImproper();

            // assert
            Assert.AreEqual(true, actual1, "Invalid result with negative numerator.");
            Assert.AreEqual(true, actual2, "Invalid result with negative denominator.");
            Assert.AreEqual(true, actual3, "Invalid result with negative numerator and denominator.");
            Assert.AreEqual(false, actual4, "Invalid result with positive numerator and denominator.");

        }
    }
}
