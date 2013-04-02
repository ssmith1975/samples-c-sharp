using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_Arrays
{
    // Arrays

    class Arrays
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array
            int[] manyValues = { 1, 18, 745, 34, 16, 94, 73, 4, 17, 200 };

            // Access an array element by index
            Console.WriteLine("The fourth number is {0}", manyValues[3]);

            // Declare an array of strings
            string[] myStrings = {"Joe", "Marini", "Teachers", "Hello"};

            // Display each item in the myStrings
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}", myStrings[i]);
            }

            // Copy myStrings to a new array
            int[] otherValues = manyValues;
            otherValues[3] = 0; // A change in otherValues will alter manyValues
            Console.WriteLine("The fourth number is {0}", manyValues[3]);

            //Assort array
            Array.Sort(manyValues);
            Console.WriteLine("The fourth number is {0}", manyValues[3]);

            Console.ReadLine();

        }
    }
}
