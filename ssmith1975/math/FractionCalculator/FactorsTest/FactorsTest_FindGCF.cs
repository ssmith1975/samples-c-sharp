using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorCalculator;

namespace FactorsTest
{
    // Test for FindGCF
    [TestClass]
    public class FactorsTest_FindGCF
    {
        // Test for valid result as expected
        [TestMethod]
        public void FindGCF_ValidResult()
        {
            // arrange
            int num1 = 30;
            int num2 = 45;

            int expectedGCF = 15;
            int actualGCF;

            // action
            actualGCF = Factors.FindGCF(num1, num2);

            // assert
            Assert.AreEqual(expectedGCF, actualGCF, "An invalid GCF was produced.");
        }

        // Result when one negative integer is used in the parameter
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A negative integer was allowed in the argument.")]
        public void FindGCF_WithOneNegativeInteger()
        {
            // arrange
            int num1 = 30;
            int num2 = -45;

            //int expectedGCF = 15;
            int actualGCF;

            // action
            actualGCF = Factors.FindGCF(num1, num2);

        }

        // Result when two negative integers are used in the parameters
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A negative integer was allowed in the argument.")]
        public void FindGCF_WithTwoNegativeIntegers()
        {
            // arrange
            int num1 = -30;
            int num2 = -45;

            //int expectedGCF = 15;
            int actualGCF;

            // action
            actualGCF = Factors.FindGCF(num1, num2);

        }

        // Result when second parameter is zero
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Zero was allowed in the argument.")]
        public void FindGCF_ArgumentIsZero()
        {
            // arrange
            int num1 = 5;
            int num2 = 0;

            //int expectedGCF = 0;
            // action
            int actualGCF = Factors.FindGCF(num1, num2);

        }
    }
}
