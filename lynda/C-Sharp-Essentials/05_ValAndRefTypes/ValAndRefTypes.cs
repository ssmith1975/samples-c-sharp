using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_ValAndRefTypes
{
    // Reference vs Values

    public class Point
    {
        public int x;
        public int y;
    }


    class ValAndRefTypes
    {

        static void testFunc1(int arg1)
        {
            arg1 += 10;
            Console.WriteLine("arg1 is {0}", arg1);
        }
        static void testFunc2(Point pt)
        {
            Console.WriteLine("pt.x is {0}", pt.x);
            pt.x += 10;
            Console.WriteLine("pt.x is {0}", pt.x);
        }
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine("i is {0}", i);
            testFunc1(i);
            Console.WriteLine("i is {0}", i);
            Console.WriteLine();

            Point p = new Point();
            p.x = 10;
            p.y = 10;
            
            Console.WriteLine("p.x is {0}", p.x);
            testFunc2(p);
            Console.WriteLine("p.x is {0}", p.x);


            Console.ReadLine();
        }
    }
}
