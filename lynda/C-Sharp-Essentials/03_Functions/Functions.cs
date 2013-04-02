using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions
{
    // Functions

    class Functions
    {
        static void Main(string[] args)
        {
            int arg = 25;
            int result;

            // Call function
            result = formula(arg);

            // Display result
            Console.WriteLine("The result is: {0}.", result);

            // Hold screen
            Console.ReadLine();
        }

        static int formula(int theVal)
        {
            return (theVal * 2) / 3 + 15;
        }
    }
}
