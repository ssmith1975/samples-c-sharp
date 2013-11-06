using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorCalculator;


namespace FactorsTest
{
    // Test for IsPrime
    [TestClass]
    public class FactorsTest_IsPrime
    {
        // Test for valid results
        [TestMethod]
        public void IsPrime_ValidResult()
        {
            // arrange
            int prime = 7;
            int nonPrime = 4;
            int one = 1;
            int two = 2;


            Boolean expectedPrime = true;
            Boolean expectedNonePrime = false;
            Boolean expectedOne = false;
            Boolean expectedTwo = true;


            // action
            Boolean actualPrime = Factors.IsPrime(prime);
            Boolean actualNonPrime = Factors.IsPrime(nonPrime);
            Boolean actualOne = Factors.IsPrime(one);
            Boolean actualTwo = Factors.IsPrime(two);


            // assert
            Assert.AreEqual(expectedPrime, actualPrime, "Invalid result for a prime integer");
            Assert.AreEqual(expectedNonePrime, actualNonPrime, "Invalid result for a non-prime, non-zero integer");

            Assert.AreEqual(expectedOne, actualOne, "Invalid result for one");
            Assert.AreEqual(expectedTwo, actualTwo, "Invalid result for a two");

        }

        // Test negative integer for prime
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A negative integer was allowed in the argument.")]
        public void IsPrime_WithNegative()
        {
            // arrange
            int num = -12;

            Boolean actual;

            // action
            actual = Factors.IsPrime(num);

        }

        // Test zero for prime
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A zero was allowed in the argument.")]
        public void IsPrime_WithZero()
        {
            // arrange
            int num = 0;

            Boolean actual;
             
            // action
            actual = Factors.IsPrime(num);

        }




    }
}
