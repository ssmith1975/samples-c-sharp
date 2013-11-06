using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FactorCalculator;
namespace FactorsTest
{
    [TestClass]
    public class FactorsTest_ListMultiples
    {
        [TestMethod]
        public void ListMultiples_IsValid()
        {
            // arrange
            int num = 5;
            int maxFactor = 6;

            List<int> ExpectedList = new List<int> { 5, 10, 15, 20, 25, 30 };

            // action
            IEnumerable<int> ActualList = Factors.ListMultiples(num, maxFactor);

            // assert
            CollectionAssert.AreEqual(ExpectedList, ActualList.ToList(), "Invalid multiplication factors");
        }
    }
}
