using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;


namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTestCalc_Add
    {
        // Test valid addition results of two whole numbers
        [TestMethod]
        public void Add_WholeAndWhole()
        {
            // arrange
            Fraction fraction1 = new Fraction(1);
            Fraction fraction2 = new Fraction(2);
            
            Fraction expected = new Fraction(3, 1);

            // aciton
            Fraction actual = FractionOperations.Add(fraction1, fraction2);

            // assert
            Assert.AreEqual(expected, actual, "Invalid sum of two whole numbers.");
        }

        // Test valid addition results of two proper fractions
        [TestMethod]
        public void Add_ProperAndProper()
        {
            // arrange
            Fraction fraction1 = new Fraction(2, 5);
            Fraction fraction2 = new Fraction(1, 5);
            Fraction fraction3 = new Fraction(1, 4);

            Fraction expected1 = new Fraction(3, 5);
            Fraction expected2 = new Fraction(9, 20);

            // aciton
            Fraction actual1 = FractionOperations.Add(fraction1, fraction2);
            Fraction actual2 = FractionOperations.Add(fraction2, fraction3);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid sum of two proper fractions with same denominators.");
            Assert.AreEqual(expected2, actual2, "Invalid sum of two proper fractions with different denominators.");

        }

        // Test valid addition results of two improper fractions
        [TestMethod]
        public void Add_ImproperAndImproper()
        {
            // arrange
            Fraction fraction1 = new Fraction(3, 2);
            Fraction fraction2 = new Fraction(4, 2);
            Fraction fraction3 = new Fraction(5, 3);

            Fraction expected1 = new Fraction(7, 2);
            Fraction expected2 = new Fraction(22, 6);

            // aciton
            Fraction actual1 = FractionOperations.Add(fraction1, fraction2);
            Fraction actual2 = FractionOperations.Add(fraction2, fraction3);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid sum of two improper fractions with same denominators.");
            Assert.AreEqual(expected2, actual2, "Invalid sum of two improper fractions with different denominators.");

        }

        // Test valid addition results of two mixed fractions
        [TestMethod]
        public void Add_MixedAndMixed()
        {
            // arrange
            Fraction fraction1 = new Fraction(1, 1, 5);
            Fraction fraction2 = new Fraction(2, 2, 5);
            Fraction fraction3 = new Fraction(1, 2, 3);

            Fraction expected1 = new Fraction(18, 5);
            Fraction expected2 = new Fraction(61, 15);

            // aciton
            Fraction actual1 = FractionOperations.Add(fraction1, fraction2);
            Fraction actual2 = FractionOperations.Add(fraction2, fraction3);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid sum of two improper fractions with same denominators.");
            Assert.AreEqual(expected2, actual2, "Invalid sum of two improper fractions with different denominators.");

        }

        // Test valid addition results of any kind of fraction
        [TestMethod]
        public void Add_MixedTypedPositives()
        {
            // arrange
            Fraction fraction1 = new Fraction(1);
            Fraction fraction2 = new Fraction(1, 2);
            Fraction fraction3 = new Fraction(3, 2);
            Fraction fraction4 = new Fraction(1, 2, 3);

            Fraction expected1 = new Fraction(3, 2);
            Fraction expected2 = new Fraction(5, 2);
            Fraction expected3 = new Fraction(8, 3);

            Fraction expected4 = new Fraction(4, 2);
            Fraction expected5 = new Fraction(13, 6);

            Fraction expected6 = new Fraction(19, 6);

            // aciton
            Fraction actual1 = FractionOperations.Add(fraction1, fraction2);
            Fraction actual2 = FractionOperations.Add(fraction1, fraction3);
            Fraction actual3 = FractionOperations.Add(fraction1, fraction4);

            Fraction actual4 = FractionOperations.Add(fraction2, fraction3);
            Fraction actual5 = FractionOperations.Add(fraction2, fraction4);
            Fraction actual6 = FractionOperations.Add(fraction3, fraction4);



            // assert
            Assert.AreEqual(expected1, actual1, "Invalid sum of a whole number and a proper fraction.");
            Assert.AreEqual(expected2, actual2, "Invalid sum of whole number and an improper fraction.");
            Assert.AreEqual(expected3, actual3, "Invalid sum of whole number and an mixed number fraction.");

            Assert.AreEqual(expected4, actual4, "Invalid sum of a proper fraction and  an improper fraction.");
            Assert.AreEqual(expected5, actual5, "Invalid sum of a proper fraction and a mixed number fraction.");
            Assert.AreEqual(expected5, actual5, "Invalid sum of an improper fraction a mixed number fraction.");
            


        }
  
        // Test valid addition results with negative fractions
        [TestMethod]
        public void Add_WithNegatives()
        {  
            // arrange
            Fraction fraction1a = new Fraction(-2);
            Fraction fraction1b = new Fraction(3);
            Fraction fraction2a = new Fraction(-1, 5);
            Fraction fraction2b = new Fraction(3, 5);
            Fraction fraction2c = new Fraction(-2, 5);
            Fraction fraction3a = new Fraction(-1, 1, 5); 
            Fraction fraction3b = new Fraction(1, 3, 5); 
            Fraction fraction3c = new Fraction(-1, 2, 5);

            Fraction expected1 = new Fraction(1, 1);
            Fraction expected2 = new Fraction(2, 5);
            Fraction expected3 = new Fraction(-3, 5);
            Fraction expected4 = new Fraction(2, 5);
            Fraction expected5 = new Fraction(-13, 5);

            // action
            Fraction actual1 = FractionOperations.Add(fraction1a, fraction1b);
            Fraction actual2 = FractionOperations.Add(fraction2a, fraction2b);
            Fraction actual3 = FractionOperations.Add(fraction2a, fraction2c);
            Fraction actual4 = FractionOperations.Add(fraction3a, fraction3b);
            Fraction actual5 = FractionOperations.Add(fraction3a, fraction3c);

            // assert
            Assert.AreEqual(expected1, actual1, "Invalid sum of negative whole and positive whole.");
            Assert.AreEqual(expected2, actual2, "Invalid sum of negative proper fraction and positive proper fraction.");
            Assert.AreEqual(expected3, actual3, "Invalid sum of two negative proper fractions.");
            Assert.AreEqual(expected4, actual4, "Invalid sum of negative mixed number fraction and positive mixed number fraction.");
            Assert.AreEqual(expected5, actual5, "Invalid sum of two negative mixed number fractions.");

        }
    }


}
