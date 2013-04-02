using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_SealedClasses
{
    // Sealed Classes

    public sealed class myExample
    {
        public static string myMethod(int arg1)
        {
            return String.Format("You sent me the number {0}", arg1);
        }
    }
    /*
    // Derivation of myExample is not possible
    public class mySubClass : myExample
    {
        // code
    }
    */
    class SealedClasses
    {
        static void Main(string[] args)
        {
            //myExample me = new myExample();
            Console.WriteLine(myExample.myMethod(10));

            Console.ReadLine();
        }
    }
}
