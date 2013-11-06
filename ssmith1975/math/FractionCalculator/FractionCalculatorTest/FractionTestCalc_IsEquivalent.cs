using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTestCalc_IsEquivalent
    {
        // Valid equivalent fractions
        [TestMethod]
        public void IsEquivalent_IsValidTrue()
        {
            // arrange
            Fraction fraction1a = new Fraction(3);
            Fraction fraction1b = new Fraction(6, 2);
            Fraction fraction2a = new Fraction(1, 4);
            Fraction fraction2b = new Fraction(3, 12);
            Fraction fraction3a = new Fraction(3, 2);
            Fraction fraction3b = new Fraction(6, 4);
            Fraction fraction4a = new Fraction(1, 1, 2);
            Fraction fraction4b = new Fraction(1, 3, 6);
             
            //Boolean expected = true;

            // action
            Boolean actual1 = FractionOperations.IsEquivalent(fraction1a, fraction1b);
            Boolean actual2 = FractionOperations.IsEquivalent(fraction2a, fraction2b);
            Boolean actual3 = FractionOperations.IsEquivalent(fraction3a, fraction3b);
            Boolean actual4 = FractionOperations.IsEquivalent(fraction4a, fraction4b);

            // assert
            Assert.IsTrue(actual1, "Result not equivalent for whole number and improper fraction.");
            Assert.IsTrue(actual2, "Result not equivalent for proper fractions.");
            Assert.IsTrue(actual3, "Result not equivalent for improper fractions.");
            Assert.IsTrue(actual4, "Result not equivalent for mixed number fractions.");

        }

        // Valid false equivalent fractions
        [TestMethod]
        public void IsEquivalent_IsValidFalse()
        {
            // arrange
            Fraction fraction1a = new Fraction(3);
            Fraction fraction1b = new Fraction(6, 3);
            Fraction fraction2a = new Fraction(1, 4);
            Fraction fraction2b = new Fraction(3, 4);
            Fraction fraction3a = new Fraction(3, 2);
            Fraction fraction3b = new Fraction(6, 5);
            Fraction fraction4a = new Fraction(1, 1, 2);
            Fraction fraction4b = new Fraction(1, 3, 4);            

            // action
            Boolean actual1 = FractionOperations.IsEquivalent(fraction1a, fraction1b);
            Boolean actual2 = FractionOperations.IsEquivalent(fraction2a, fraction2b);
            Boolean actual3 = FractionOperations.IsEquivalent(fraction3a, fraction3b);
            Boolean actual4 = FractionOperations.IsEquivalent(fraction4a, fraction4b);

            // assert
            Assert.IsFalse(actual1, "Error: Result equivalent for whole number and improper fraction.");
            Assert.IsFalse(actual2, "Error: Result equivalent for proper fractions.");
            Assert.IsFalse(actual3, "Error: Result equivalent for improper fractions.");
            Assert.IsFalse(actual4, "Error: Result equivalent for mixed number fractions.");
        }
        // Valid for negative fractions
        [TestMethod]
        public void IsEquivalent_IsValidWhenNegative()
        {
            // arrange
            Fraction fraction1a = new Fraction(-3);
            Fraction fraction1b = new Fraction(-6, 3);
            Fraction fraction2a = new Fraction(-1, 4);
            Fraction fraction2b = new Fraction(-3, 4);
            Fraction fraction3a = new Fraction(-3, 2);
            Fraction fraction3b = new Fraction(-6, 5);
            Fraction fraction4a = new Fraction(-1, 1, 2);
            Fraction fraction4b = new Fraction(-1, 3, 4);

            // action
            Boolean actual1 = FractionOperations.IsEquivalent(fraction1a, fraction1b);
            Boolean actual2 = FractionOperations.IsEquivalent(fraction2a, fraction2b);
            Boolean actual3 = FractionOperations.IsEquivalent(fraction3a, fraction3b);
            Boolean actual4 = FractionOperations.IsEquivalent(fraction4a, fraction4b);

            // assert
            Assert.IsFalse(actual1, "Error: Result equivalent for negative whole number and improper fraction.");
            Assert.IsFalse(actual2, "Error: Result equivalent for negative proper fractions.");
            Assert.IsFalse(actual3, "Error: Result equivalent for negative improper fractions.");
            Assert.IsFalse(actual4, "Error: Result equivalent for negative mixed number fractions.");
        }

    }
}
