using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;


namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTestCalc_FindReciprocal
    {
        // Test for valid reciprocal
        [TestMethod]
        public void FindReciprocal_IsValidResult()
        {
            // arrange
            Fraction fraction1 = new Fraction(3);
            Fraction fraction2 = new Fraction(1, 6);
            Fraction fraction3 = new Fraction(4, 3);
            Fraction fraction4 = new Fraction(1, 2, 5);

            Fraction expected1 = new Fraction(1, 3);
            Fraction expected2 = new Fraction(6, 1);
            Fraction expected3 = new Fraction(3, 4);
            Fraction expected4 = new Fraction(5, 7);

            // action
            Fraction actual1 = FractionOperations.FindReciprocal(fraction1);
            Fraction actual2 = FractionOperations.FindReciprocal(fraction2);
            Fraction actual3 = FractionOperations.FindReciprocal(fraction3);
            Fraction actual4 = FractionOperations.FindReciprocal(fraction4);


            // assert
            Assert.AreEqual(expected1, actual1, "Invalid reciprocal fraction for whole number.");
            Assert.AreEqual(expected2, actual2, "Invalid reciprocal fraction for proper fraction.");
            Assert.AreEqual(expected3, actual3, "Invalid reciprocal fraction for improper fraction.");
            Assert.AreEqual(expected4, actual4, "Invalid reciprocal fraction for mixed number.");

        }

        // Test for valid reciprocal of negative fractions
        [TestMethod]
        public void FindReciprocal_IsValidResultNegative()
        {
            // arrange
            Fraction fraction1 = new Fraction(-3);
            Fraction fraction2 = new Fraction(-1, 6);
            Fraction fraction3 = new Fraction(-4, 3);
            Fraction fraction4 = new Fraction(-1, 2, 5);

            Fraction expected1 = new Fraction(-1, 3);
            Fraction expected2 = new Fraction(-6, 1);
            Fraction expected3 = new Fraction(-3, 4);
            Fraction expected4 = new Fraction(-5, 7);

            // action
            Fraction actual1 = FractionOperations.FindReciprocal(fraction1);
            Fraction actual2 = FractionOperations.FindReciprocal(fraction2);
            Fraction actual3 = FractionOperations.FindReciprocal(fraction3);
            Fraction actual4 = FractionOperations.FindReciprocal(fraction4);


            // assert
            Assert.AreEqual(expected1, actual1, "Invalid reciprocal fraction for negative whole number.");
            Assert.AreEqual(expected2, actual2, "Invalid reciprocal fraction for negative proper fraction.");
            Assert.AreEqual(expected3, actual3, "Invalid reciprocal fraction for negative improper fraction.");
            Assert.AreEqual(expected4, actual4, "Invalid reciprocal fraction for negative mixed number.");

        }


        // Test zero
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A reciprocal for zero was found.")]
        public void FindReciprocal_DivideByZero()
        {
            // assign
            Fraction fraction = new Fraction(0);

            // action
            Fraction actual = FractionOperations.FindReciprocal(fraction);

            Assert.IsNotNull(actual, "Actual fraction object was null.");
        }
    }
}
