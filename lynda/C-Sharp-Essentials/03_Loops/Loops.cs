using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            // basic while loop
            int myVal = 15;

            
            Console.WriteLine("Basic while Loops:");

            while (myVal < 20)
            {
                Console.WriteLine("myVal is currently {0}", myVal);
                myVal += 3;
            }


            // do while loop, executes block code at lease once
            myVal = 15;

            Console.WriteLine();
            Console.WriteLine("Do while Loos:");
            do
            {
                Console.WriteLine("myVal is currently {0}", myVal);
                myVal += 3;
            } while (myVal < 20);

            Console.WriteLine();
            Console.WriteLine("For Loos:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i is currently {0}", i);
            }


            Console.WriteLine();
            Console.WriteLine("For Break and Continue...:");
            for (int i = 0; i < 10; i++)
            {

                if (i == 5)
                    continue;
                if (i == 9)
                    break;

                Console.WriteLine("i is currently {0}", i);
            }


            // Hold screen
            Console.ReadLine();

        }
    }
}
