using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace FactorCalculator
{
    public class Factors
    {

        /// <summary>
        /// Greatest Common Factor (Static) - the largest number that divides into x and y, positive, non-zero integers.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns>Greatest Common Factor</returns>
        public static int FindGCF(int val1, int val2)
        {

            // Throw an error when either value is zero or negative  
            // Check first arcument  
            if (val1 <= 0)
            {
                // when val1 zero...
                throw new System.ArgumentException("Invalid argument used. Only non-zero integers are allowed.");
            }

            // Check second argument
            if (val2 <= 0)
            {
                // when val2 is zero...
                throw new System.ArgumentException("Invalid argument used. Only non-zero integers are allowed.");
            } 
         
           if( (val1 % val2) ==  0  )
           {
                return val2;
           } 
           else
           {  // When val2 is not zero...
                return FindGCF(val2,val1 % val2);
           } 
        }

        /// <summary>
        /// Least Common Multiple (Static) - the smallest number that both x and y divides equally into; x and y are positive, non-zero integers.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns>int</returns>
        public static int FindLCM(int val1, int val2)
        {

            // Throw an error when either value is zero or negative  
            // Check first arcument  
            if (val1 <= 0)
            {
                // when val1 zero...
                throw new System.ArgumentException("Invalid argument used. Only non-zero integers are allowed.");
            }

            // Check second argument
            if (val2 <= 0)
            {
                // when val2 is zero...
                throw new System.ArgumentException("Invalid argument used. Only non-zero integers are allowed.");
            } 

            return val1 * val2 / FindGCF(val1, val2);
        }


        /// <summary>
        /// IsPrime - checks whether or not a positive, non-zero integer is a prime number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>bool</returns>
        public static bool IsPrime(int num)
        {

            // Throw an error when either value is zero or negative    
            if ( num <= 0 )
            {
                // when num is zero or negative...
                throw new System.ArgumentException("Invalid argument used. Only positive, non-zero integers are allowed.");
            }

            // Check for even numbers
            if (num % 2 == 0)
            {
                // Return false for even numbers, unless its 2
                if (num != 2)
                {
                    return false;
                }
                else
                { // Two is a prime
                    return true;
                }

            } else if (num == 1)
            { //  One is not considered a prime
                return false;
            }
            else
            {

                // Check odd number greater than 2
                for (int i = 2; i <= Math.Floor(Math.Sqrt(num)); i++)
                {
                    // Note: if any common multiples between the product of two numbers exists,
                    if (FindLCM(i, num) != (num * i))
                    { // Return false for composite numbers
                        return false;
                    }
                }

            }
            // Return true for prime numbers
            return true;
        }

        /// <summary>
        /// FindPrimeFactors - returns for a given integer a list of prime factors as key along with the prime's power as value.
        /// </summary>
        /// <param name="targetNumber"></param>
        /// <returns>Hashtable</returns>
        public static Hashtable FindPrimeFactors(int targetNumber)
        {

            Hashtable primesHT = new Hashtable();

            // Take care of negative integers

            if(targetNumber  < 0) {
                targetNumber = Math.Abs(targetNumber);
                primesHT.Add(-1, 1);
             }

            if (targetNumber <= 2) 
            { // Check for numbers less than or equal to 2
                primesHT.Add(targetNumber, 1);
                
                return primesHT;
            }
            else if (IsPrime(targetNumber)) 
            { // Check for prime numbers
                primesHT.Add(targetNumber, 1);
                return primesHT;
            }

            else
            { // All other numbers...
                // Iterate through numbers less than the target number
                for (int i = 2; i <= targetNumber; i++)
                {
                    // Look for prime numbers
                    if (IsPrime(i) && (targetNumber > 1))
                    {
                        int powerCount = 0;

                        // Check if prime number divides the target number
                        while ((targetNumber % i == 0) && (targetNumber > 1))
                        {
                            // Keep track of how many times the target number gets divided by the prime number
                            targetNumber = targetNumber / i;
                            powerCount++;
                        }

                        // Add prime number to hashtable if it has a positive non-zero count
                        if (powerCount > 0)
                        {
                            primesHT.Add(i, powerCount);
                        }
                    }

                    // Break from for loop when target number becomes 1
                    if (targetNumber == 1)
                    {
                        break;
                    }
                }
            }
            return primesHT;
        }

        /// <summary>
        /// ListCommonFactors - list of divisors of two numbers; posistive, non-zero integers.
        /// </summary>
        /// <returns>IEnumerable</returns>
        public static IEnumerable<int> ListCommonFactors(int val1, int val2)
        {

            // Throw an error when either value is zero or negative  
            // Check first arcument  
            if ( (val1 <= 0) || (val2 <= 0) )
            {
                // when val1 zero...
                throw new ArgumentException("Invalid argument used. Only non-zero integers are allowed.");
            }

            // Get the smaller of the two arguments
            int minVal = Math.Min(val1, val2);

            for (int i = 1; i <= minVal; i++)
            {
                if ((val1 % i == 0) && (val2 % i == 0))
                {
                    yield return i;
                }
            }

        }

        /// <summary>
        /// ListCommonMultiples - a list of numbers that is divisible by both numbers; positive, non-zero integers.
        /// </summary>
        /// <returns>IEnumerable</returns>
        public static IEnumerable<int> ListCommonMultiples(int val1, int val2)
        {

            // Throw an error when either value is zero or negative  
            // Check first arcument  
            if ((val1 <= 0) || (val2 <= 0))
            {
                // when val1 zero...
                throw new ArgumentException("Invalid argument used. Only non-zero integers are allowed.");
            }

            // Get the larger of the two arguments
            int maxNum = Math.Max(val1, val2);

            for (int i = maxNum; i <= val1 * val2; i += maxNum)
            {
                if ((i % val1 == 0) && (i % val2 == 0))
                {
                    yield return i;
                }
            }
        }

        /// <summary>
        /// ListMultiples - a list of numbers that are divisible by an defined integer and a maximum factor.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="maxFactor"></param>
        /// <returns>IEnumerable</returns>
        public static IEnumerable<int> ListMultiples(int num, int maxFactor)
        {
            for (int i = 1; i<= maxFactor; i++)
            {
                yield return i * num;
            }
        }


    } // end class



} // end namespace
