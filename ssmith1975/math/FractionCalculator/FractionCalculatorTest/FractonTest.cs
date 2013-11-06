using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;


namespace FractionCalculatorTest
{
    // Test for the Fraction class
    [TestClass]
    public class FractonTest
    {
        // Test for valid results
        [TestMethod]
        public void Fraction_ValidResult()
        {
            // arrange
            int whole = 2;
            int num = 3;
            int den = 4;

            Fraction fraction1 = new Fraction(whole);
            Fraction fraction2 = new Fraction(num, den);
            Fraction fraction3 = new Fraction(whole, num, den);

            // assert

            // action
            Assert.AreEqual(whole, fraction1 .WholePart, "Whole part of one parameter is invalid");
            Assert.AreEqual(0, fraction2.WholePart, "Whole part of two parameters is invalid");
            Assert.AreEqual(whole, fraction3.WholePart, "Whole part of three parameters is invalid");

            Assert.AreEqual(0, fraction1.Numerator, "Numerator part of one parameter is invalid");
            Assert.AreEqual(num, fraction2.Numerator, "Numerator part of two parameters is invalid");
            Assert.AreEqual(num, fraction3.Numerator, "Numerator part of three parameters is invalid");

            Assert.AreEqual(0, fraction1.Denominator, "Denominator part of one parameter is invalid");
            Assert.AreEqual(den, fraction2.Denominator, "Denominator part of two parameters is invalid");
            Assert.AreEqual(den, fraction3.Denominator, "Denominator part of three parameters is invalid"); 
           


        }

        // Test for zero as a value for the numerator (0/1)
        [TestMethod]
        public void Fraction_ZeroNumerator()
        {
            // arrange
            int whole = 2;
            int num = 0;
            int den = 4;

            Fraction fraction1 = new Fraction(whole);
            Fraction fraction2 = new Fraction(num, den);
            Fraction fraction3 = new Fraction(whole, num, den);

            // assert

            // action
            Assert.AreEqual(whole, fraction1.WholePart, "Whole part of one parameter is invalid");
            Assert.AreEqual(0, fraction2.WholePart, "Whole part of two parameters is invalid");
            Assert.AreEqual(whole, fraction3.WholePart, "Whole part of three parameters is invalid");

            Assert.AreEqual(0, fraction1.Numerator, "Numerator part of one parameter is invalid");
            Assert.AreEqual(0, fraction2.Numerator, "Numerator part of two parameters is invalid");
            Assert.AreEqual(0, fraction3.Numerator, "Numerator part of three parameters is invalid");

            Assert.AreEqual(0, fraction1.Denominator, "Denominator part of one parameter is invalid");
            Assert.AreEqual(0, fraction2.Denominator, "Denominator part of two parameters is invalid");
            Assert.AreEqual(0, fraction3.Denominator, "Denominator part of three parameters is invalid"); 
           

        }

        // Test for zero as a value of the denominator (1/0)
        [TestMethod]
        public void Fraction_ZeroDenominator()
        {
            // arrange
            int whole = 2;
            int num = 3;
            int den = 0;

            Fraction fraction1 = new Fraction(whole);
            Fraction fraction2 = new Fraction(num, den);
            Fraction fraction3 = new Fraction(whole, num, den);

            // assert

            // action
            Assert.AreEqual(whole, fraction1.WholePart, "Whole part of one parameter is invalid");
            Assert.AreEqual(0, fraction2.WholePart, "Whole part of two parameters is invalid");
            Assert.AreEqual(whole, fraction3.WholePart, "Whole part of three parameters is invalid");

            Assert.AreEqual(0, fraction1.Numerator, "Numerator part of one parameter is invalid");
            Assert.AreEqual(0, fraction2.Numerator, "Numerator part of two parameters is invalid");
            Assert.AreEqual(0, fraction3.Numerator, "Numerator part of three parameters is invalid");

            Assert.AreEqual(0, fraction1.Denominator, "Denominator part of one parameter is invalid");
            Assert.AreEqual(0, fraction2.Denominator, "Denominator part of two parameters is invalid");
            Assert.AreEqual(0, fraction3.Denominator, "Denominator part of three parameters is invalid"); 


        }

        // Test for zero as a value of both numerator and denominator (0/0)
        [TestMethod]
        public void Fraction_ZeroArguments()
        {
            // arrange
            int whole = 0;
            int num = 0;
            int den = 0;

            Fraction fraction1 = new Fraction(whole);
            Fraction fraction2 = new Fraction(num, den);
            Fraction fraction3 = new Fraction(whole, num, den);

            // assert

            // action
            Assert.AreEqual(whole, fraction1.WholePart, "Whole part of one parameter is invalid");
            Assert.AreEqual(whole, fraction2.WholePart, "Whole part of two parameters is invalid");
            Assert.AreEqual(whole, fraction3.WholePart, "Whole part of three parameters is invalid");

            Assert.AreEqual(num, fraction1.Numerator, "Numerator part of one parameter is invalid");
            Assert.AreEqual(num, fraction2.Numerator, "Numerator part of two parameters is invalid");
            Assert.AreEqual(num, fraction3.Numerator, "Numerator part of three parameters is invalid");

            Assert.AreEqual(den, fraction1.Denominator, "Denominator part of one parameter is invalid");
            Assert.AreEqual(den, fraction2.Denominator, "Denominator part of two parameters is invalid");
            Assert.AreEqual(den, fraction3.Denominator, "Denominator part of three parameters is invalid"); 

        }


        // Initiate object with negative argument - first overload 
        [TestMethod]
        public void Fraction_NegativeArguments_1()
        {
            int whole = -5;

            // arrange
            Fraction fraction = new Fraction(whole);
            
            // assert
            Assert.AreEqual(-5, fraction.WholePart, "Invalid whole part for single parameter constructor with a negative argument.");
            Assert.AreEqual(0, fraction.Numerator, "Invalid numerator for single parameter constructor with a negative argument.");
            Assert.AreEqual(0, fraction.Denominator, "Invalid denominator for single parameter constructor with a negative argument.");
        }

        // Initiate object with negative argument - second overload 
        [TestMethod]
        public void Fraction_NegativeArguments_2()
        {
 

            // arrange
            Fraction fraction1 = new Fraction(-2, 5);
            Fraction fraction2 = new Fraction(2, -5);
            Fraction fraction3 = new Fraction(-2, -5);

            // assert
            Assert.AreEqual(0, fraction1.WholePart, "Invalid whole part for two parameters constructor with a negative numerator.");
            Assert.AreEqual(-2, fraction1.Numerator, "Invalid numerator for two parameters constructor with a negative numerator.");
            Assert.AreEqual(5, fraction1.Denominator, "Invalid denominator for two parameters constructor with a negative numerator.");

            Assert.AreEqual(0, fraction2.WholePart, "Invalid whole part for two parameters constructor with a negative denominator.");
            Assert.AreEqual(-2, fraction2.Numerator, "Invalid numerator for two parameters constructor with a negative denominator.");
            Assert.AreEqual(5, fraction2.Denominator, "Invalid denominator for two parameters constructor with a negative denominator.");

            Assert.AreEqual(0, fraction3.WholePart, "Invalid whole part for two parameters constructor with a negative numerator and denominator.");
            Assert.AreEqual(2, fraction3.Numerator, "Invalid numerator for two parameters constructor with a negative and denominator.");
            Assert.AreEqual(5, fraction3.Denominator, "Invalid denominator for two parameters constructor with a negative and denominator.");

        }

        // Initiate object with negative argument - third overload 
        [TestMethod]
        public void Fraction_NegativeArgument_3()
        {
            // arrange
            Fraction fraction1 = new Fraction(1, -2, 5);
            Fraction fraction2 = new Fraction(1, 2, -5);
            Fraction fraction3 = new Fraction(1, -2, -5);
            Fraction fraction4 = new Fraction(-1, -2, 5);
            Fraction fraction5 = new Fraction(-1, 2, -5);
            Fraction fraction6 = new Fraction(-1, -2, -5);


            // assert
            Assert.AreEqual(-1, fraction1.WholePart, "Invalid whole part for three parameters constructor with a positive whole part, negative numerator.");
            Assert.AreEqual(2, fraction1.Numerator, "Invalid numerator for three parameters constructor with apositive whole part,  negative numerator.");
            Assert.AreEqual(5, fraction1.Denominator, "Invalid denominator for three parameters constructor with a positive whole part,  negative numerator.");

            Assert.AreEqual(-1, fraction2.WholePart, "Invalid whole part for three parameters constructor with a positive whole part,  negative denominator.");
            Assert.AreEqual(2, fraction2.Numerator, "Invalid numerator for three parameters constructor with a positive whole part, negative denominator.");
            Assert.AreEqual(5, fraction2.Denominator, "Invalid denominator for three parameters constructor with a positive whole part, negative denominator.");

            Assert.AreEqual(1, fraction3.WholePart, "Invalid whole part for three parameters constructor with a positive whole part,  negative numerator and denominator.");
            Assert.AreEqual(2, fraction3.Numerator, "Invalid numerator for three parameters constructor with a negative numerator and denominator.");
            Assert.AreEqual(5, fraction3.Denominator, "Invalid denominator three two parameters constructor with a positive whole part,  negative numerator and denominator.");

            Assert.AreEqual(1, fraction4.WholePart, "Invalid whole part for three parameters constructor with a negative whole part, negative numerator.");
            Assert.AreEqual(2, fraction4.Numerator, "Invalid numerator for three parameters constructor with a negative whole part,  negative numerator.");
            Assert.AreEqual(5, fraction4.Denominator, "Invalid denominator for three parameters constructor with a negative whole part,  negative numerator.");

            Assert.AreEqual(1, fraction5.WholePart, "Invalid whole part for three parameters constructor with a negative whole part,  negative denominator.");
            Assert.AreEqual(2, fraction5.Numerator, "Invalid numerator for three parameters constructor with a positive whole part, negative denominator.");
            Assert.AreEqual(5, fraction5.Denominator, "Invalid denominator for three parameters constructor with a positive whole part, negative denominator.");

            Assert.AreEqual(-1, fraction6.WholePart, "Invalid whole part for three parameters constructor with a negative whole part,  negative numerator and denominator.");
            Assert.AreEqual(2, fraction6.Numerator, "Invalid numerator for three parameters constructor with a negative numerator and denominator.");
            Assert.AreEqual(5, fraction6.Denominator, "Invalid denominator three two parameters constructor with a positive whole part,  negative numerator and denominator.");


        }

        // Set a value of the whole part
        [TestMethod]
        public void Fraction_SetWholePart()
        {
            // arrange
            Fraction fraction = new Fraction(1, 2, 3);

            // action
            fraction.WholePart = 6;

            // assert
            Assert.AreEqual(6, fraction.WholePart, "Invalid whole part");
        }

        // Set a value of the whole part negative
        [TestMethod]
        public void Fraction_SetWholePartNegative()
        {
            // arrange
            Fraction fraction = new Fraction(1, 2, 3);

            // action
            fraction.WholePart = -6;

            // assert
            Assert.AreEqual(-6, fraction.WholePart, "Invalid result for whole part when whole part set to negative.");
            Assert.AreEqual(2, fraction.Numerator, "Invalid result for numerator when whole part set to negative.");
            Assert.AreEqual(3, fraction.Denominator, "Invalid result for denominator when whole part set to negative.");

        }


        // Set a value of the numerator
        [TestMethod]
        public void Fraction_SetNumerator()
        {

            // arrange
            Fraction fraction = new Fraction(1, 2, 3);

            // action
            fraction.Numerator = 5;

            // assert
            Assert.AreEqual(5, fraction.Numerator, "Invalid numerator");

        }


        // Set a value of the numerator negative
        [TestMethod]
        public void Fraction_SetNumeratorNegative()
        {

            // arrange
            Fraction fraction = new Fraction(1, 2, 3);

            // action
            fraction.Numerator = -5;

            // assert
            Assert.AreEqual(-1, fraction.WholePart, "Invalid result for whole part when numerator set to negative.");
            Assert.AreEqual(5, fraction.Numerator, "Invalid result for numerator when numerator set to negative.");
            Assert.AreEqual(3, fraction.Denominator, "Invalid result for denominator when numerator set to negative.");

        }


        // Set a value of a denominator
        [TestMethod]
        public void Fraction_SetDenominator()
        {
            // arrange
            Fraction fraction = new Fraction(1, 2, 3);

            // action
            fraction.Denominator = 4;

            // assert
            Assert.AreEqual(4, fraction.Denominator, "Invalid denominator");
        }

        // Set a value of a denominator negative
        [TestMethod]        
        public void Fraction_SetDenominatorNegative()
        {
            // arrange
            Fraction fraction = new Fraction(1, 2, 3);

            // action
            fraction.Denominator = -4;

            // assert
            Assert.AreEqual(-1, fraction.WholePart, "Invalid result for whole part when denominator set to negative.");
            Assert.AreEqual(2, fraction.Numerator, "Invalid result for numerator when denominator set to negative.");
            Assert.AreEqual(4, fraction.Denominator, "Invalid result for denominator when denominator set to negative.");
        }


    } // end class



} // end namespace
