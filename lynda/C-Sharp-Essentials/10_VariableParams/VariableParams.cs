using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_VariableParams
{
    // Variable Parameters

    class VariableParams
    {
        static int addNumbers(params int[] nums)
        {
            int total = 0;

            foreach (int x in nums)
            {
                total += x;
            }

            return total;
        }

        static void Main(string[] args)
        {

            int result;
            result = addNumbers(4, 6, 8);
            Console.WriteLine("result is {0}", result);

            result = addNumbers(12, 20, 31, 5, 7, 9);
            Console.WriteLine("result is {0}", result);


            Console.ReadLine();
        }
    }
}
