using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FactorCalculator;

namespace FactorsTest
{
    // Test for common factors
    [TestClass]
    public class FactorsTest_ListCommonFactors
    {
        // Valid results
        [TestMethod]
        public void ListCommonFactors_ValidResults()
        {
            // arrange
            int num1 = 12;
            int num2 = 18;

            List<int> ExpectedList = new List<int>{1, 2, 3, 6};
           
            // action
            IEnumerable<int> ActualList = Factors.ListCommonFactors(num1, num2); 

            // assert
            CollectionAssert.AreEqual(ExpectedList, ActualList.ToList(), "Invalid common factors");
        }


        // One Negative Parameter 
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A negative integer was allowed in the argument.")]
        public void ListCommonFactors_OneNegativeParameter()
        {

            // arrange
            int num1 = -12;
            int num2 = 18;

            // action
            IEnumerable<int> ActualList = Factors.ListCommonFactors(num1, num2);

            // assert
            CollectionAssert.AllItemsAreNotNull(ActualList.ToList(), "Null items exists");
        }

        // Zero parameter
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A zero was allowed in the argument.")]
        public void ListCommonFactors_ZeroParameter()
        {

            // arrange
            int num1 = 4;
            int num2 = 0;

            // action
            IEnumerable<int> ActualList = Factors.ListCommonFactors(num1, num2);

            // assert
            CollectionAssert.AllItemsAreNotNull(ActualList.ToList(), "Null items exists");

        }

    }
}
