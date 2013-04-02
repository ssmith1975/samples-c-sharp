using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _06_ArrayLists
{
    class ArrayLists
    {
        // Array List
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();

            // Add values to arraylist
            myAL.Add("one");
            myAL.Add(2);
            myAL.Add("three");
            myAL.Add(4);

            // Insert an element at index 0
            myAL.Insert(0, 1.25f);

            // Display integers and floats
            foreach (object o in myAL)
            {
                if( o is int || o is float)
                    Console.WriteLine("{0}", o);
            }

            Console.ReadLine();
        }
    }
}
