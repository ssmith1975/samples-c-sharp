﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_RethrowingExceptions
{
    // Rethrowing Exceptions

    class RethrowingExceptions
    {
        static void DoSomeMath()
        {
            int x = 10, y = 0;
            int result;
            try {
                result = x/y;
                Console.WriteLine("Result is {0}", result);
            } catch {
                Console.WriteLine("Error in DoSomeMath()");
                throw new ArithmeticException();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                DoSomeMath();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Hmm, there was an error in there, be careful!");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
