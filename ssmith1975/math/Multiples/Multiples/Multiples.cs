using System;
using System.Collections.Generic;
using System.Linq;
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
 /*
        public IEnumerator GetEnumerator()
        {
            int minVal = Math.Min(this.x, this.y);
            for(int i = 1; i <= minVal; i++) {
                if ((this.x % i == 0) && (this.y % i == 0))
                {
                    yield return i;
                }
            }
        }
 */
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

            /*
            if (val1 > val2)
            {
               return GetGCF(val2, val1);
            }
            else
            {

                if (val2 % val1 == 0)
                {
                    return val1;
                }
                else
                {
                    return GetGCF(val2 % val1, val1);
                }
            }
           */


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
           /* int maxNum = Math.Max(val1, val2);

            for (int i = maxNum; i < val1 * val2; i += maxNum)
            {
                if ((i % val1 == 0) && (i % val2 == 0))
                {
                    return i;
                }
            }
            return val1 * val2;
            */

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

    #region Program class
    class Program
    {

        public static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
         
            // Create Multiples object and subscribe to event handler
            Multiples m = new Multiples();
            m.Changed += new ChangeHandler(ShowMessage);

            Console.WriteLine("Finding common multiples...");

            do {


                do
                {
                    Console.WriteLine();
                    Console.Write("Enter first value between {0} and {1}: ", Multiples.MIN, Multiples.MAX);
                    try
                    {
                        // Prompt user for first number
                        m.X = int.Parse(Console.ReadLine().Trim());
                    }
                    catch
                    {
                        m.X = -1; // for non-integers
                    }


                } while ((m.X < Multiples.MIN) || (m.X > Multiples.MAX));

                do
                {
                    Console.WriteLine();
                    Console.Write("Enter second value between {0} and {1}: ", Multiples.MIN, Multiples.MAX);
                    try
                    {
                        // Prompt user for second number
                        m.Y = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        m.Y = -1; // for non-integers
                    }

                } while ((m.Y < Multiples.MIN) || (m.Y > Multiples.MAX));
 
                
                Console.WriteLine();

                // Display common factors
                Console.WriteLine("Common Factors of both {0} and {1}:", m.X, m.Y);
                Console.WriteLine("-------------------------------------------------");

                foreach (int num in m.ListCommonFactors())
                {
                    Console.WriteLine("{0}: \t{0} x {1} = {2}\t\t{0} x {3} = {4}", num, m.X/num, m.X, m.Y/num, m.Y);
                }

                // Display GCF (greatest common multiple)
                Console.WriteLine();
                Console.WriteLine("The greated common factor is: {0}", m.GCF());

                // Display common multiples
                Console.WriteLine();
                Console.WriteLine("Common Multiples of both {0} and {1}:", m.X, m.Y);
                Console.WriteLine("-------------------------------------------------");

                foreach (int num in m.ListCommonMultiples())
                {
                    Console.WriteLine("{0}: \t{1} x {2} = {0}\t\t{3} x {4} = {0}", num, num/m.X , m.X, num/m.Y, m.Y);
                }

                Console.WriteLine();

                // Display LCM (least common multiple)
                Console.WriteLine("The least common multiple is: {0}", m.LCM());
                Console.WriteLine();

                // Display prime test results
                Console.WriteLine("Is {0} a prime? {1}\t\tIs {2} a prime? {3}", m.X, Multiples.IsPrime(m.X).ToString(), m.Y, Multiples.IsPrime(m.Y).ToString());
                Console.WriteLine();
                
                // Get prime factors for first number
                Hashtable primeFactors = new Hashtable();
                primeFactors = Multiples.GetPrimeFactors(m.X);

                // Display prime factorization for first number
                Console.WriteLine("Prime Factors of {0}:", m.X);
                Console.WriteLine("-------------------------------------------------");
                int countItemX = 1;
                foreach (DictionaryEntry item in primeFactors)
                {
                    Console.Write("{0}^{1}", item.Key, item.Value);
                    if (countItemX != primeFactors.Count)
                    {
                        Console.Write(", ");
                    }

                    countItemX++;

                }
                Console.WriteLine();
                Console.WriteLine();

                // Get prime factors for second number
                primeFactors = Multiples.GetPrimeFactors(m.Y);

                // Display prime factorization for second number
                Console.WriteLine("Prime Factors of {0}:", m.Y);
                Console.WriteLine("-------------------------------------------------");
                int countItemY = 1;
                foreach (DictionaryEntry item in primeFactors)
                {
                    Console.Write("{0}^{1}", item.Key, item.Value);
                    if (countItemY != primeFactors.Count)
                    {
                        Console.Write(", ");
                    }

                    countItemY++;

                }
                Console.WriteLine();
                Console.WriteLine();

                // Prompt user to continue or exit
                Console.WriteLine("Press any key to continue or type \"exit\" to quit this program.");

            } while (Console.ReadLine().Trim() != "exit");


           // Console.ReadLine();
        }
    }
#endregion
}
