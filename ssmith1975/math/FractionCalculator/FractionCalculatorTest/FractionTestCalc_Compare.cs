using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTestCalc_Compare
    {
        // Test to compare less than of same fraction type
        [TestMethod]
        public void Compare_IsValidLessThanWithSameType()
        {
            // arrange
            Fraction fraction1a = new Fraction(2);
            Fraction fraction1b = new Fraction(3);
            Fraction fraction2a = new Fraction(1, 2);
            Fraction fraction2b = new Fraction(3, 4);
            Fraction fraction3a = new Fraction(3, 2);
            Fraction fraction3b = new Fraction(5, 2);
            Fraction fraction4a = new Fraction(1, 1, 8);
            Fraction fraction4b = new Fraction(2, 1, 2);

            int expected = -1;
            
            // action
            int actual1 = FractionOperations.Compare(fraction1a, fraction1b);
            int actual2 = FractionOperations.Compare(fraction2a, fraction2b);
            int actual3 = FractionOperations.Compare(fraction3a, fraction3b);
            int actual4 = FractionOperations.Compare(fraction4a, fraction4b);
    
            // assert
            Assert.AreEqual(expected, actual1, "Invalid less than comparison result for two whole numbers.");
            Assert.AreEqual(expected, actual2, "Invalid less than comparison result for two proper fractions.");
            Assert.AreEqual(expected, actual3, "Invalid less than comparison result for two improper fractions.");
            Assert.AreEqual(expected, actual4, "Invalid less than comparison result for two mixed number fractions.");

        }

        // Test to compare less than of different fraction type
        [TestMethod]
        public void Compare_IsValidLessThanWithDiffferentTypes()
        {
            // arrange
            Fraction fraction1 = new Fraction(2);         
            Fraction fraction2 = new Fraction(1, 2);           
            Fraction fraction3 = new Fraction(5, 2);                     
            Fraction fraction4 = new Fraction(2, 3, 4);

            int expected = -1;

            // action
            int actual1 = FractionOperations.Compare(fraction2, fraction1);
            int actual2 = FractionOperations.Compare(fraction1, fraction3);
            int actual3 = FractionOperations.Compare(fraction1, fraction4);
            int actual4 = FractionOperations.Compare(fraction2, fraction3);
            int actual5 = FractionOperations.Compare(fraction2, fraction4);
            int actual6 = FractionOperations.Compare(fraction3, fraction4);

            // assert
            Assert.AreEqual(expected, actual1, "Invalid less than comparison result for whole number and improper fraction.");
            Assert.AreEqual(expected, actual2, "Invalid less than comparison result for whole number and proper fraction.");
            Assert.AreEqual(expected, actual3, "Invalid less than comparison result for whole number and improper fraction.");
            Assert.AreEqual(expected, actual4, "Invalid less than comparison result for proper and improper fractions.");
            Assert.AreEqual(expected, actual5, "Invalid less than comparison result for proper and mixed number fractions.");
            Assert.AreEqual(expected, actual6, "Invalid less than comparison result for improper and mixed number fractions.");

        }

        // Test to compare equal than
        [TestMethod]
        public void Compare_IsValidEqualWithSameType()
        {
            // arrange
            Fraction fraction1a = new Fraction(2);
            Fraction fraction1b = new Fraction(2);
            Fraction fraction2a = new Fraction(1, 2);
            Fraction fraction2b = new Fraction(1, 2);
            Fraction fraction3a = new Fraction(3, 2);
            Fraction fraction3b = new Fraction(3, 2);
            Fraction fraction4a = new Fraction(1, 1, 8);
            Fraction fraction4b = new Fraction(1, 1, 8);

            int expected = 0;

            // action
            int actual1 = FractionOperations.Compare(fraction1a, fraction1b);
            int actual2 = FractionOperations.Compare(fraction2a, fraction2b);
            int actual3 = FractionOperations.Compare(fraction3a, fraction3b);
            int actual4 = FractionOperations.Compare(fraction4a, fraction4b);

            // assert
            Assert.AreEqual(expected, actual1, "Invalid equal comparison result for two whole numbers.");
            Assert.AreEqual(expected, actual2, "Invalid equal comparison result for two proper fractions.");
            Assert.AreEqual(expected, actual3, "Invalid equal comparison result for two improper fractions.");
            Assert.AreEqual(expected, actual4, "Invalid equal comparison result for two mixed number fractions.");

        }

        // Test to compare equal of different fraction type
        [TestMethod]
        public void Compare_IsValidEqualWithDiffferentTypes()
        {
            // arrange
            Fraction fraction1 = new Fraction(2);
            Fraction fraction2 = new Fraction(4, 2);
            Fraction fraction3 = new Fraction(11, 4);
            Fraction fraction4 = new Fraction(2, 3, 4);

            int expected = 0;

            // action
            int actual1 = FractionOperations.Compare(fraction1, fraction2);
            int actual2 = FractionOperations.Compare(fraction3, fraction4);


            // assert
            Assert.AreEqual(expected, actual1, "Invalid equal comparison result for whole number and improper fraction.");
            Assert.AreEqual(expected, actual2, "Invalid equal comparison result for improper and mixed number fractions.");

        }

        // Test to compare greater than with same fraction type
        [TestMethod]
        public void Compare_IsValidGreaterThanWithSameType()
        {
            // arrange
            Fraction fraction1a = new Fraction(2);
            Fraction fraction1b = new Fraction(3);
            Fraction fraction2a = new Fraction(1, 2);
            Fraction fraction2b = new Fraction(3, 4);
            Fraction fraction3a = new Fraction(3, 2);
            Fraction fraction3b = new Fraction(5, 2);
            Fraction fraction4a = new Fraction(1, 1, 8);
            Fraction fraction4b = new Fraction(2, 1, 2);

            int expected = 1;

            // action
            int actual1 = FractionOperations.Compare(fraction1b, fraction1a);
            int actual2 = FractionOperations.Compare(fraction2b, fraction2a);
            int actual3 = FractionOperations.Compare(fraction3b, fraction3a);
            int actual4 = FractionOperations.Compare(fraction4b, fraction4a);

            // assert
            Assert.AreEqual(expected, actual1, "Invalid greater than comparison result for two whole numbers.");
            Assert.AreEqual(expected, actual2, "Invalid greater than comparison result for two proper fractions.");
            Assert.AreEqual(expected, actual3, "Invalid greater than comparison result for two improper fractions.");
            Assert.AreEqual(expected, actual4, "Invalid greater than comparison result for two mixed number fractions.");

        }

        // Test to compare greater than of different fraction type
        [TestMethod]
        public void Compare_IsValidGreaterThanWithDiffferentTypes()
        {
            // arrange
            Fraction fraction1 = new Fraction(3);
            Fraction fraction2 = new Fraction(1, 2);
            Fraction fraction3 = new Fraction(5, 2);
            Fraction fraction4 = new Fraction(2, 1, 4);

            int expected = 1;

            // action
            int actual1 = FractionOperations.Compare(fraction1, fraction2);
            int actual2 = FractionOperations.Compare(fraction1, fraction3);
            int actual3 = FractionOperations.Compare(fraction1, fraction4);
            int actual4 = FractionOperations.Compare(fraction3, fraction2);
            int actual5 = FractionOperations.Compare(fraction4, fraction2);
            int actual6 = FractionOperations.Compare(fraction3, fraction4);

            // assert
            Assert.AreEqual(expected, actual1, "Invalid greater than comparison result for whole number and improper fraction.");
            Assert.AreEqual(expected, actual2, "Invalid greater than comparison result for whole number and proper fraction.");
            Assert.AreEqual(expected, actual3, "Invalid greater than comparison result for whole number and improper fraction.");
            Assert.AreEqual(expected, actual4, "Invalid greater than comparison result for proper and improper fractions.");
            Assert.AreEqual(expected, actual5, "Invalid greater than comparison result for proper and mixed number fractions.");
            Assert.AreEqual(expected, actual6, "Invalid greater than comparison result for improper and mixed number fractions.");

        }

        // Compare negative fractions
        [TestMethod]
        public void Compare_Negatives()
        {
            // arrange
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(-1, 2);
            Fraction fraction3 = new Fraction(-1);
            Fraction fraction4 = new Fraction(0);

            // action
            int actual1 = FractionOperations.Compare(fraction1, fraction2);
            int actual2 = FractionOperations.Compare(fraction2, fraction3);
            int actual3 = FractionOperations.Compare(fraction2, fraction1);
            int actual4 = FractionOperations.Compare(fraction3, fraction2);
            int actual5 = FractionOperations.Compare(fraction2, fraction2);
            int actual6 = FractionOperations.Compare(fraction2, fraction4);

            // assert
            Assert.AreEqual(1, actual1, "Invalid result for comparing a positive fraction with a negative fraction.");
            Assert.AreEqual(1, actual2, "Invalid result for comparing a less negative fraction with a negative whole numeber.");
            Assert.AreEqual(-1, actual3, "Invalid result for comparing a negative fraction with a positive fraction.");
            Assert.AreEqual(-1, actual4, "Invalid result for comparing a negative whole number with a less negative fraction.");             
            Assert.AreEqual(0, actual5, "Invalid result for comparing equal fractions that are negative.");
            Assert.AreEqual(-1, actual6, "Invalid result for a negative fraction to zero.");
        }
    }
}
