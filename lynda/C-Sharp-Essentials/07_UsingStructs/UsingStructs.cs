using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_UsingStructs
{
    class UsingStructs
    {
        public struct Point
        {
            private int xCoord;
            private int yCoord;

            public Point(int x, int y)
            {
                xCoord = x;
                yCoord = y;
            }

            public int x
            {
                get { return xCoord; }
                set { xCoord = value; }
            }

            public int y
            {
                get { return yCoord; }
                set { yCoord = value; }
            }
        }

        static void Main(string[] args)
        {
            Point p1 = new Point(100, 100);
            Point p2 = new Point();
            p2.x = 50;
            p2.y = 75;

            Console.WriteLine("p1: x = {0}, y = {1},", p1.x, p1.y);
            Console.WriteLine("p2: x = {0}, y = {1},", p2.x, p2.y);

            Console.ReadLine();
        }
    }
}
