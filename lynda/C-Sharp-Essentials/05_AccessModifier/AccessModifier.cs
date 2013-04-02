using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_AccessModifier
{
    // Access Modifiers

    class AccessModifier
    {
        static void Main(string[] args)
        {

            Wine w1 = new Wine("Mark Ryan Dissident", 52.00m);
            Wine w2 = new Wine("DeLille Chaleur Estate", 75.00m);

            string str = w1.Name;
            w1.Description = "Dark and brooding";

            Console.WriteLine("w1: {0} - {1}", w1.Name, w1.Price);
            Console.WriteLine("w2: {0} - {1}", w2.Name, w2.Price);

            Console.ReadLine();
        }
    }
}
