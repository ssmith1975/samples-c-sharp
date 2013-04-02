using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_ExceptionObjects
{
    // Exception Objects
    class ExceptionObjects
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 0;
            int result;

            try
            {
                result = x/y;
                Console.WriteLine("The result is: {0}", result);
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("Whoop! You tried to divide by zero!");
                Console.WriteLine(e.Message);
            }
            catch (System.ArithmeticException e)
            {
                Console.WriteLine("An error occurred! Better check the code!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Just proving that this code always runs.");
            }

            Console.ReadLine();

        }
    }
}
