using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTestCalc_Multiply
    {
        // Test for valid multiplcation results
        [TestMethod]
        public void Multiply_IsValidResultOfSameType()
        {
            // arrange


            Fraction expected1 = new Fraction(8, 1);
            Fraction expected2 = new Fraction(8, 15);
            Fraction expected3 = new Fraction(15, 8);
            Fraction expected4 = new Fraction(70, 15);


            // action

            Fraction actual1 = FractionOperations.Multiply(new Fraction(2), new Fraction(4));
            Fraction actual2 = FractionOperations.Multiply(new Fraction(2, 3), new Fraction(4, 5));
            Fraction actual3 = FractionOperations.Multiply(new Fraction(3, 2), new Fraction(5, 4));
            Fraction actual4 = FractionOperations.Multiply(new Fraction(1, 2, 3), new Fraction(2, 4, 5));

            // assert
            Assert.AreEqual(expected1, actual1, "Multiplying two whole numbers yielded an invalid result");
            Assert.AreEqual(expected2, actual2, "Multiplying two proper fractions yielded an invalid result");
            Assert.AreEqual(expected3, actual3, "Multiplying two improper fractions yielded an invalid result");
            Assert.AreEqual(expected4, actual4, "Multiplying two mixed number fractions yielded an invalid result");
        }

        // Test for valid multiplcation results of any type of fractions
        [TestMethod]
        public void Multiply_IsValidResultOfAnyType()
        {
            // arrange
            Fraction expected1 = new Fraction(2, 5);
            Fraction expected2 = new Fraction(6, 2);
            Fraction expected3 = new Fraction(10, 3);
            Fraction expected4 = new Fraction(10, 6);
            Fraction expected5 = new Fraction(10, 9);
            Fraction expected6 = new Fraction(12,6);
           
            // action
            Fraction actual1 = FractionOperations.Multiply(new Fraction(2), new Fraction(1, 5));
            Fraction actual2 = FractionOperations.Multiply(new Fraction(2), new Fraction(3, 2));
            Fraction actual3 = FractionOperations.Multiply(new Fraction(2), new Fraction(1, 2, 3));
            Fraction actual4 = FractionOperations.Multiply(new Fraction(2, 3), new Fraction(5, 2));
            Fraction actual5 = FractionOperations.Multiply(new Fraction(2, 3), new Fraction(1, 2, 3));
            Fraction actual6 = FractionOperations.Multiply(new Fraction(3, 2), new Fraction(1, 1, 3));
           
            // assert
            Assert.AreEqual(expected1, actual1, "Multiplying whole number with proper fraction yielded an invalid result");
            Assert.AreEqual(expected2, actual2, "Multiplying whole number with improper fraction yielded an invalid result");
            Assert.AreEqual(expected3, actual3, "Multiplying whole number with mixed number fraction fractions yielded an invalid result");
            Assert.AreEqual(expected4, actual4, "Multiplying proper with improper fractions yielded an invalid result");
            Assert.AreEqual(expected3, actual3, "Multiplying proper with mixed number fractions yielded an invalid result");
            Assert.AreEqual(expected4, actual4, "Multiplying improper with mixed number fractions yielded an invalid result");
        }

        // Test for nefative fractions
        [TestMethod]
        public void Multiply_Negatives()
        {
            // arrange
            Fraction fraction1a = new Fraction(2);
            Fraction fraction1b = new Fraction(-3);
            Fraction fraction2a = new Fraction(3, 4);
            Fraction fraction2b = new Fraction(-2, 5);
            Fraction fraction3a = new Fraction(1, 1, 2);
            Fraction fraction3b = new Fraction(-1, 2, 3);
            

            Fraction expected1 = new Fraction(-6, 1);
            Fraction expected2 = new Fraction(-6, 20);
            Fraction expected3 = new Fraction(-15, 6);
            Fraction expected4 = new Fraction(4, 25);

            // action
            Fraction actual1 = FractionOperations.Multiply(fraction1a, fraction1b);
            Fraction actual2 = FractionOperations.Multiply(fraction2a, fraction2b);
            Fraction actual3 = FractionOperations.Multiply(fraction3a, fraction3b);
            Fraction actual4 = FractionOperations.Multiply(fraction2b, fraction2b);

            // assert
            Assert.AreEqual(expected1.WholePart, actual1.WholePart, "Invalid result when multiplying positive whole with negative whole.");
            Assert.AreEqual(expected2, actual2, "Invalid result when multiplying positive proper with negative proper.");
            Assert.AreEqual(expected3, actual3, "Invalid result when multiplying positive mixed number with negative mixed number");
            Assert.AreEqual(expected4, actual4, "Invalid result when multiplying two negative proper fractions.");
        }

        // Test for zero value arguments
        [TestMethod]
        public void Multiply_ZeroArguments()
        {
            // arrange
            Fraction  fraction = new Fraction(0);
            Fraction expected = new Fraction(0);

            // action
            Fraction actual1 = FractionOperations.Multiply(new Fraction(1, 2), fraction);
            Fraction actual2 = FractionOperations.Multiply( fraction, new Fraction(1, 2));

            // assert
            Assert.AreEqual(expected, actual1, "Invalid result when second argument is 0");
            Assert.AreEqual(expected, actual2, "Invalid result when first argument is 0");
        }

    }
}
