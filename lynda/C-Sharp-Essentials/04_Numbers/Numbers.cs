using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Numbers
{
    // Double vs Decimal data types to demonstration precision
    class Numbers
    {
        static void Main(string[] args)
        {
            // Doubles, used for scientific calculations for better CPU performance
            double twentienth = 0.2f;
            double one = 1.0f;

            Console.WriteLine("{0}", one - twentienth);

            // Decimals, used for financial calculations for better accuracy
            decimal onetwentieth = 0.2m;
            decimal realone = 1.0m;

            Console.WriteLine("{0}", realone - onetwentieth);

            // Hold screen
            Console.ReadLine();
        }
    }
}
