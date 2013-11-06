using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using FactorCalculator;


namespace FactorsTest
{
    [TestClass]
    public class FactorsTest_FindPrimeFactors
    {
        // Test for valid positive, non-zero integer, factorization
        [TestMethod]
        public void FindPrimeFactors_ValidResult()
        {
            // arrange
            int num = 36;

            // 36 = 2^2 * 3^2
            Hashtable HTExpected = new Hashtable();
            Hashtable HTActual = new Hashtable();

            HTExpected.Add(2, 2);
            HTExpected.Add(3, 2);

            // action
            HTActual =  Factors.FindPrimeFactors(num);

            // assert
            CollectionAssert.AreEqual(HTExpected, HTActual, "Invalid key/value." );

           
        }

        // Test positive, non-zero values less than and equal to two
        [TestMethod]
        public void FindPrimeFactors_LessThanEqualToTwo()
        {
            // arrange
            int one = 1;
            int two = 2;

            // 1 = 1^1 
            Hashtable HTExpectedOne = new Hashtable();
            Hashtable HTActualOne = new Hashtable();
            HTExpectedOne.Add(1, 1);

            // 2 = 2 ^1
            Hashtable HTExpectedTwo = new Hashtable();
            Hashtable HTActualTwo = new Hashtable();
            HTExpectedTwo.Add(2, 1);

            // action
            HTActualOne = Factors.FindPrimeFactors(one);
            HTActualTwo = Factors.FindPrimeFactors(two);

            // assert
            CollectionAssert.AreEqual(HTExpectedOne, HTActualOne, "Invalid key/value.");
            CollectionAssert.AreEqual(HTExpectedTwo, HTActualTwo, "Invalid key/value.");
        }

        // Test for positive, prime integer
        [TestMethod]
        public void FindPrimeFactors_PrimeParameter()
        {
            // arrange
            int num = 17;

            // 36 = 2^2 * 3^2
            Hashtable HTExpected = new Hashtable();
            Hashtable HTActual = new Hashtable();

            HTExpected.Add(17, 1);
           

            // action
            HTActual = Factors.FindPrimeFactors(num);

            // assert
            CollectionAssert.AreEqual(HTExpected, HTActual, "Invalid key/value.");

           
        }


        // Test for negative, non-zero integer
        [TestMethod]
        public void FindPrimeFactors_NegativeParameter()
        {
            // arrange
            int num = -12;

            // -12 =  2^2 * 3^1
            Hashtable HTExpected = new Hashtable();
            Hashtable HTActual = new Hashtable();

            HTExpected.Add(-1, 1);
            HTExpected.Add(2, 2);
            HTExpected.Add(3, 1);

            // action
            HTActual = Factors.FindPrimeFactors(num);

            // assert
            CollectionAssert.AreEqual(HTExpected, HTActual, "Invalid key/value.");

           
        }
    }
}
