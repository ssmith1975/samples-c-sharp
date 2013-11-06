using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;

namespace FractionCalculatorTest
{
    [TestClass]
    public class FractionTest_ToString
    {
        [TestMethod]
        public void ToString_IsValid()
        {
            // arrange
            Fraction fraction1 = new Fraction(2);
            Fraction fraction2 = new Fraction(-4);
            Fraction fraction3 = new Fraction(1, 2);
            Fraction fraction4 = new Fraction(-3, 2);
            Fraction fraction5= new Fraction(1, 2, 3);
            Fraction fraction6 = new Fraction(-2, 4, 5);

            string expected1 = "2";
            string expected2 = "-4";
            string expected3 = "1/2";
            string expected4 = "-3/2";
            string expected5 = "1 2/3";
            string expected6 = "-2 4/5";

            // action
            string actual1 = fraction1.ToString();
            string actual2 = fraction2.ToString();
            string actual3 = fraction3.ToString();
            string actual4 = fraction4.ToString();
            string actual5 = fraction5.ToString();
            string actual6 = fraction6.ToString();



            // assert
            Assert.AreEqual(expected1, actual1, "Invalid string for positive whole integer.");
            Assert.AreEqual(expected2, actual2, "Invalid string for negative whole integer.");
            Assert.AreEqual(expected3, actual3, "Invalid string for positive proper fraction.");
            Assert.AreEqual(expected4, actual4, "Invalid string for negative improper fraction.");
            Assert.AreEqual(expected5, actual5, "Invalid string for positive mixed number fraction.");
            Assert.AreEqual(expected6, actual6, "Invalid string for negative mixed number fraction.");
           

        }
    }
}
