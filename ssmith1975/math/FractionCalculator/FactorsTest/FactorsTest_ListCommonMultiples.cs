using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FactorCalculator;


namespace FactorsTest
{   // Test for listing common multiples
    [TestClass]
    public class FactorsTest_ListCommonMultiples
    {

        // Valid results
        [TestMethod]
       
        public void ListCommonMultiples_ValidResults()
        {
            // arrange
            int num1 = 6;
            int num2 = 8;

            List<int> ExpectedList = new List<int> {24, 48};

            // action
            IEnumerable<int> ActualList = Factors.ListCommonMultiples(num1, num2);

            // assert
            CollectionAssert.AreEqual(ExpectedList, ActualList.ToList(), "Invalid common multiples");
        }


        // One Negative Parameter 
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A negative integer was allowed in the argument.")]
        public void ListCommonMultiples_OneNegativeParameter()
        {

            // arrange
            int num1 = -10;
            int num2 = 8;

            // action
            IEnumerable<int> ActualList = Factors.ListCommonMultiples(num1, num2);

            // assert
            CollectionAssert.AllItemsAreNotNull(ActualList.ToList(), "Null items exists");

        }


        // Zero parameter
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A zero was allowed in the argument.")]
        public void ListCommonMultiples_ZeroParameter()
        {

            // arrange
            int num1 = 0;
            int num2 = 0;

            // action
            IEnumerable<int> ActualList = Factors.ListCommonMultiples(num1, num2);

            // assert
            CollectionAssert.AllItemsAreNotNull(ActualList.ToList(), "Null items exists");


        }

    }
}
