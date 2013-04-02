using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_UsingExceptions
{
    // Using Exceptions

    class UsingExceptions
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
            catch
            {
                Console.WriteLine("An error occurred! Better check the code!");
            }
            finally
            {
                Console.WriteLine("Just proving that this code always runs.");
            }

            Console.ReadLine();
        }
    }
}
