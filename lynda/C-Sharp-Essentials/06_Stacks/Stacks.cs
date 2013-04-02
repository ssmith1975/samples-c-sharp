using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _06_Stacks
{
    // Stacks (LIFO)

    class Stacks
    {
        static void Main(string[] args)
        {
            // Declare stack collection
            Stack myStack = new Stack();
            
            // Push elements onto the stack
            myStack.Push("item 1");
            myStack.Push("item 2");
            myStack.Push("item 3");

            // Display number of items
            Console.WriteLine("{0} Items on the stack", myStack.Count);

            // Have a peek at the item on top
            Console.WriteLine("{0}", myStack.Peek());

            // Pop off an element
            myStack.Pop(); // gets top value

            // Have a peek at the item on top
            Console.WriteLine("{0}", myStack.Peek());

            // Clear stack
            myStack.Clear();

            // Display number of items
            Console.WriteLine("{0} Items on the stack", myStack.Count);

            Console.ReadLine();

        }
    }
}
