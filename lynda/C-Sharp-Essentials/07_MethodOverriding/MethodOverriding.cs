using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _07_MethodOverriding
{
    // Method Overriding

    class baseClass
    {
        public virtual void doSomething()
        {
            Console.WriteLine("This is the baseClass saying hi!");
        }
    }

    class subClass:baseClass
    {
       public override void doSomething()
        {
            //base.doSomething(); // Call baseClass method
            Console.WriteLine("This is the subClass saying hi!");
        }
    }

    class MethodOverriding
    {
        static void Main(string[] args)
        {
            subClass obj1 = new subClass(); // try baseClass type
            baseClass objBase;
            objBase = obj1;

            obj1.doSomething();
            objBase.doSomething();

            Console.ReadLine();
        }
    }
}
