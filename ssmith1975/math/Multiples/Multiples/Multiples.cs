using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Multiples
{
    public delegate void ChangeHandler(string message);

    #region Multiples class
    class Multiples
    {
        private int x;
        private int y;
        public const int MAX = 500;
        public const int MIN = 2;
        public event ChangeHandler Changed;

        public int X {
            get {return this.x;}
            set 
            {
                if (value >= MIN && value <= MAX)
                {
                    this.x = value;
                }
                else
                {
                   if(Changed != null)
                       OnChange("Invalid number. Please try again.");
                }    
            }  
        }

        public int Y
        {
            get { return this.y; }
            set 
            {
                if (value >= MIN && value <= MAX)
                {
                    this.y = value;
                }
                else
                {
                    if (Changed != null)
                        OnChange("Invalid number. Please try again.");
                } 
            
            }  
        }

        public Multiples():this(1,1)
        {
       
        }


        public Multiples(int val1, int val2) {
            this.x = val1;
            this.y = val2;
        
        }

        /// <summary>
        /// ListCommonFactors - list of divisors of two numbers
        /// </summary>
        /// <returns>IEnumerable</returns>
        public IEnumerable ListCommonFactors()
        {
            int val1 = this.x;
            int val2 = this.y;

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
        /// ListCommonMultiples - a list of numbers that is divisible by both numbers
        /// </summary>
        /// <returns>IEnumerable</returns>
        public IEnumerable ListCommonMultiples()
        {
            int val1 = this.x;
            int val2 = this.y;
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
        /// Greatest Common Factor - the largest number that divides into x and y
        /// </summary>
        /// <returns></returns>
        public int GCF()
        {
            return Multiples.GetGCF(this.x, this.y);
        }
        /// <summary>
        /// Greatest Common Factor (Static) - the largest number that divides into x and y
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns>int</returns>
        public static int GetGCF(int val1, int val2)
        {

            if (val2  == 0)
            {
                return val1;
            }
            else
            {
                return GetGCF(val2,val1 % val2);
            }
        }

        /// <summary>
        /// Least Common Multiple -- the smallest number that both x and y divides equally into
        /// </summary>
        /// <returns></returns>
        public int LCM()
        {
            return GetLCM(this.x, this.y);
        }


        /// <summary>
        /// Least Common Multiple (Static) - the smallest number that both x and y divides equally into
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns>int</returns>
        public static int GetLCM(int val1, int val2) {
            return val1 * val2 / GetGCF(val1, val2);
        }

        /// <summary>
        /// IsPrime - checks whether or not an integer is a prime number
        /// </summary>
        /// <param name="num"></param>
        /// <returns>bool</returns>
        public static bool IsPrime(int num)
        {
            //bool testPrime = true;

            // Check for even numbers
            if (num % 2 == 0)
            {
                // Return false for even numbers, unless its 2
                if (num != 2)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

            // Check odd number greater than 2
            for (int i = 2; i <= Math.Floor(Math.Sqrt(num)); i++)
            {
                // Note: if any common multiples between the product of two numbers exists,
                if (GetLCM(i, num) != (num * i))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// GetPrimeFactors - returns for a given integer a list of prime factors as key along with the prime's power as value
        /// </summary>
        /// <param name="targetNumber"></param>
        /// <returns>Hashtable</returns>
        public static Hashtable GetPrimeFactors(int targetNumber)
        {

            Hashtable  primesHT = new Hashtable ();

            if (targetNumber < 2) // Check for numbers less than 2
            {
                primesHT.Add(1, 1);
                return primesHT;
            } 
            else if (IsPrime(targetNumber)) // Check for prime numbers
            {
                primesHT.Add(targetNumber, 1);
                return primesHT;
            }

            else
            {
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

        public void OnChange(string text)
        {
            if ((Changed != null) && (text != String.Empty))
            {
                Changed(text);
            }
        }
    }

#endregion

}
