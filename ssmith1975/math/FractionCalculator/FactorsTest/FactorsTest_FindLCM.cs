using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorCalculator;

namespace FactorsTest
{
    // Test for FindLCM
    [TestClass]
    public class FactorsTest_FindLCM
    {
        [TestMethod]
        public void FindLCM_ValidResult()
        {
            // arrange
            int num1 = 6;
            int num2 = 4;

            int expectedLCM = 12;
            int actualLCM;

            // action
            actualLCM = Factors.FindLCM(num1, num2);

            // assert
            Assert.AreEqual(expectedLCM, actualLCM, "An invalid LCM was produced.");
        }

        // Result when one negative integer is used in the parameter
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A negative integer was allowed in the argument.")]
        public void FindLCM_WithOneNegativeInteger()
        {
            // arrange
            int num1 = 6;
            int num2 = -8;

            //int expectedGCF = 15;
            int actualLCM;

            // action
            actualLCM = Factors.FindLCM(num1, num2);

        }

        // Result when two negative integers are used in the parameters
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "A negative integer was allowed in the argument.")]
        public void FindLCM_WithTwoNegativeIntegers()
        {
            // arrange
            int num1 = -6;
            int num2 = -8;

            //int expectedGCF = 15;
            int actualLCM;

            // action
            actualLCM = Factors.FindLCM(num1, num2);

        }


        // Result when second parameter is zero
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Zero was allowed in the argument.")]
        public void FindLCM_ArgumentIsZero()
        {
            // arrange
            int num1 = 8;
            int num2 = 0;

            // action
            int actualLCM = Factors.FindLCM(num1, num2);
        }

    }
}
