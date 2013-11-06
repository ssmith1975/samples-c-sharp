using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTestCalc_MakeDecimal
    {
        [TestMethod]
        public void MakeDecimal_IsValidResult()

        {
            // arrange
            Fraction fraction1 = new Fraction(3);
            Fraction fraction2 = new Fraction(1, 5);
            Fraction fraction3 = new Fraction(3, 2);
            Fraction fraction4 = new Fraction(1, 1, 2);

            decimal expected1 = 3.00M;
            decimal expected2 = 0.20M;
            decimal expected3 = 1.5M;
            decimal expected4 = 1.5M;
            double delta = 0.1;

            // action
            decimal actual1 = FractionOperations.MakeDecimal(fraction1);
            decimal actual2 = FractionOperations.MakeDecimal(fraction2);
            decimal actual3 = FractionOperations.MakeDecimal(fraction3);
            decimal actual4 = FractionOperations.MakeDecimal(fraction4);


            // assert
            Assert.AreEqual(Convert.ToDouble(expected1), Convert.ToDouble(actual1), delta, "Invalid whole to decimal conversion.");
            Assert.AreEqual(Convert.ToDouble(expected2), Convert.ToDouble(actual2), delta, "Invalid proper fraction to decimal conversion.");
            Assert.AreEqual(Convert.ToDouble(expected3), Convert.ToDouble(actual3), delta, "Invalid improper fraction to decimal conversion.");
            Assert.AreEqual(Convert.ToDouble(expected4), Convert.ToDouble(actual4), delta, "Mixed number result is invalid");
           
            
        }

        // Convert negative fraction to decimal
        [TestMethod]
        public void MakeDecimal_IsValidNegative()
        {
            // arrange
            Fraction fraction1 = new Fraction(-3);
            Fraction fraction2 = new Fraction(-1, 5);
            Fraction fraction3 = new Fraction(-3, 2);
            Fraction fraction4 = new Fraction(-1, 1, 2);

            decimal expected1 = -3.00M;
            decimal expected2 = -0.20M;
            decimal expected3 = -1.5M;
            decimal expected4 = -1.5M;
            double delta = 0.1;

            // action
            decimal actual1 = FractionOperations.MakeDecimal(fraction1);
            decimal actual2 = FractionOperations.MakeDecimal(fraction2);
            decimal actual3 = FractionOperations.MakeDecimal(fraction3);
            decimal actual4 = FractionOperations.MakeDecimal(fraction4);


            // assert
            Assert.AreEqual(Convert.ToDouble(expected1), Convert.ToDouble(actual1), delta, "Invalid negative whole to decimal conversion.");
            Assert.AreEqual(Convert.ToDouble(expected2), Convert.ToDouble(actual2), delta, "Invalid negative proper fraction to decimal conversion.");
            Assert.AreEqual(Convert.ToDouble(expected3), Convert.ToDouble(actual3), delta, "Invalid negative improper fraction to decimal conversion.");
            Assert.AreEqual(Convert.ToDouble(expected4), Convert.ToDouble(actual4), delta, "Negative mixed number result is invalid");


        }

    }
}
