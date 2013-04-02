using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_DefiningProperties
{
    // Class Properties

    class DefiningProperties
    {
        static void Main(string[] args)
        {
            // Create some Wine objects
            Wine w1 = new Wine(2003, "Cheteau Ste. Michelle Merlot", "Seven Hill", 23.50m);
            Wine w2 = new Wine(2005, "Mark Ryan Dissident", "Ciel du Chanel", 40.00m);

            // Write out proper values
            Console.WriteLine("Wine 1: {0}, {1}", w1.MenuDescription, w1.Price);
            Console.WriteLine("Wine 2: {0}, {1}", w2.MenuDescription, w2.Price);
            Console.WriteLine();

            // Change wholesale price
            w2.Price = 45.0m;
            Console.WriteLine("Wine 2: {0}, {1}", w2.MenuDescription, w2.Price);

            Console.ReadLine();
        }
    }
}
