using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _06_Queues
{
    // Queues - FIFO
    class Queues
    {
        static void Main(string[] args)
        {
            // Declare queue
            Queue myQ = new Queue();

            // Add items to queue
            myQ.Enqueue("item 1");
            myQ.Enqueue("item 2");
            myQ.Enqueue("item 3");
            myQ.Enqueue("item 4");

            // Disply number of items
            Console.WriteLine("There are {0} items in the Queue", myQ.Count);

            // Dequeue items using a loop and display them
            while (myQ.Count > 0)
            {
                string str = (string)myQ.Dequeue();
                Console.WriteLine("Dequeueing object {0}", str);
            }

            Console.ReadLine();
        }
    }
}
