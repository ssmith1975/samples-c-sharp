using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Multiples
{
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

            do
            {


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
                    Console.WriteLine("{0}: \t{0} x {1} = {2}\t\t{0} x {3} = {4}", num, m.X / num, m.X, m.Y / num, m.Y);
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
                    Console.WriteLine("{0}: \t{1} x {2} = {0}\t\t{3} x {4} = {0}", num, num / m.X, m.X, num / m.Y, m.Y);
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
