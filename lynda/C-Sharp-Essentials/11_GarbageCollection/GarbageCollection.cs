using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_GarbageCollection
{
    // Garbage Collection

    class GarbageCollection
    {
        static void Main(string[] args)
        {
            // Display total memory
            Console.WriteLine("Allocated memory is: {0}", GC.GetTotalMemory(false));
            Console.WriteLine();
            Console.ReadLine();

            // Declare a byte array
            byte[] myArray = new byte[100000];

            // Display total memory
            Console.WriteLine("Allocated memory is: {0}", GC.GetTotalMemory(false));
            Console.WriteLine();
            Console.ReadLine();

            // Collect garbage
            GC.Collect();

            // Display total memory
            Console.WriteLine("Allocated memory is: {0}", GC.GetTotalMemory(false));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
