using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_UsingInterfaces
{
    // Interfaces

    interface ITalkative
    {
        void SayHello();
        void SayGoodBye();
    }

    class myExampleClass : ITalkative
    {
        public myExampleClass()
        {
        }

        // Required method
        public void SayHello()
        {
            Console.WriteLine("Saying hello!");
        }

        // Required method
        public void SayGoodBye()
        {
            Console.WriteLine("Saying goodbye!");
        }
    }


    class UsingInterfaces
    {
        static void Main(string[] args)
        {
            myExampleClass myEC = new myExampleClass();

            myEC.SayHello();
            myEC.SayGoodBye();

            Console.ReadLine();
        }
    }
}
