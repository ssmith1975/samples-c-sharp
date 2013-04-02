using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingDelegates
{
    // Using Delegates

    class UsingDelegates
    {
        // Declare delegate
        public delegate int NumberFunction(int x);

        // Declare functins
        static int Square(int num)
        {
            return num * num;
        }

        static int Cube(int num)
        {
            return num * num * num;
        }


        static void Main(string[] args)
        {
            NumberFunction f = Square;
            Console.WriteLine("The result of the delegate is {0}", f(5));
            
            // Now change the delegate
            f = Cube;
            Console.WriteLine("The result of the delegate is {0}", f(5));

            Console.ReadLine();
        }
    }
}
