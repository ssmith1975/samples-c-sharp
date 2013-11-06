using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTestCalc_Divide
    {
        // Test for valid division results
        [TestMethod]
        public void Divide_IsValidResult()
        {
            // arrange


            Fraction expected1 = new Fraction(2, 4);
            Fraction expected2 = new Fraction(10, 12);
            Fraction expected3 = new Fraction(12, 10);
            Fraction expected4 = new Fraction(25, 42);


            // action

            Fraction actual1 = FractionOperations.Divide(new Fraction(2), new Fraction(4));
            Fraction actual2 = FractionOperations.Divide(new Fraction(2, 3), new Fraction(4, 5));
            Fraction actual3 = FractionOperations.Divide(new Fraction(3, 2), new Fraction(5, 4));
            Fraction actual4 = FractionOperations.Divide(new Fraction(1, 2, 3), new Fraction(2, 4, 5));

            // assert
            Assert.AreEqual(expected1, actual1, "Dividing two whole numbers yielded an invalid result");
            Assert.AreEqual(expected2, actual2, "Dividing two proper fractions yielded an invalid result");
            Assert.AreEqual(expected3, actual3, "Dividing two improper fractions yielded an invalid result");
            Assert.AreEqual(expected4, actual4, "Dividing two mixed number fractions yielded an invalid result");
        }

        // Test for valid multiplcation results of any type of fractions
        [TestMethod]
        public void Divide_AnyThing()
        {
            // arrange
            Fraction expected1 = new Fraction(10, 1);
            Fraction expected2 = new Fraction(4, 3);
            Fraction expected3 = new Fraction(6, 5);
            Fraction expected4 = new Fraction(4, 15);
            Fraction expected5 = new Fraction(6, 15);
            Fraction expected6 = new Fraction(9, 8);

            // action
            Fraction actual1 = FractionOperations.Divide(new Fraction(2), new Fraction(1, 5));
            Fraction actual2 = FractionOperations.Divide(new Fraction(2), new Fraction(3, 2));
            Fraction actual3 = FractionOperations.Divide(new Fraction(2), new Fraction(1, 2, 3));
            Fraction actual4 = FractionOperations.Divide(new Fraction(2, 3), new Fraction(5, 2));
            Fraction actual5 = FractionOperations.Divide(new Fraction(2, 3), new Fraction(1, 2, 3));
            Fraction actual6 = FractionOperations.Divide(new Fraction(3, 2), new Fraction(1, 1, 3));

            // assert
            Assert.AreEqual(expected1, actual1, "Dividing whole number with proper fraction yielded an invalid result");
            Assert.AreEqual(expected2, actual2, "Dividing whole number with improper fraction yielded an invalid result");
            Assert.AreEqual(expected3, actual3, "Dividing whole number with mixed number fraction fractions yielded an invalid result");
            Assert.AreEqual(expected4, actual4, "Dividing proper with improper fractions yielded an invalid result");
            Assert.AreEqual(expected3, actual3, "Dividing proper with mixed number fractions yielded an invalid result");
            Assert.AreEqual(expected4, actual4, "Dividing improper with mixed number fractions yielded an invalid result");
        }

        // Test for valid division results with negatives
        [TestMethod]
        public void Divide_IsValidResultNegatives()
        {
            // arrange
            Fraction expected1 = new Fraction(-3, 4);
            Fraction expected2 = new Fraction(3, 4);
    
            // action
            Fraction actual1 = FractionOperations.Divide(new Fraction(1, 2), new Fraction(2, -3));
            Fraction actual2 = FractionOperations.Divide(new Fraction(-1, 2), new Fraction(-2, 3));

            // assert
            Assert.AreEqual(expected1, actual1, "Dividing positive fraction by negative fraction yielded an invalid result");
            Assert.AreEqual(expected2, actual2, "Dividing two negative fractions yielded an invalid result");
        }

        // Test divide by zero
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A fraction divided by zero was allowed.")]
        public void Divide_ByZero()
        {
            // assign
            Fraction fraction = new Fraction(0);

            // action
            Fraction actual = FractionOperations.Divide(new Fraction(1,2), fraction);

            Assert.IsNotNull(actual, "Actual fraction object was null.");
        }
    }
}
