using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace _07_AbstractClasses
{
    // Abstract Classes

    abstract class myBaseClass
    {
        public abstract int myMethod(int arg1, int arg2);

    }



    class myDerivedClass : myBaseClass 
    {
        public override int  myMethod(int arg1, int arg2) {
            return arg1 + arg2;
        }

    }


    class AbstractClasses
    {
        static void Main(string[] args)
        {
            /* myBaseClass mbc = new myBaseClass();  // Not possible since myBaseClass is abstract */
            myDerivedClass mdc = new myDerivedClass();
            int result = mdc.myMethod(5,6);

            Console.WriteLine("{0}", result);

            Console.ReadLine();
        }
    }
}
