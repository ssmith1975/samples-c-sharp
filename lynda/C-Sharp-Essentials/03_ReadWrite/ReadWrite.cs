using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_ReadWrite
{
    class ReadWrite
    {
        static void Main(string[] args)
        {
            // Write to screen
            Console.WriteLine("Hello World!");

            // Prompt user for name
            Console.WriteLine("What is your name?");

            // Read user input
            string str = Console.ReadLine();

            // Write output to screen
            Console.WriteLine("Why, hello there {0}!", str);


            // Buiding Strings
            int mySeconds = 60 * 60 * 24 * 365;

            // Display seconds
            Console.WriteLine("Theree are {0} seconds in a year.", mySeconds);


            // Hold screen
            Console.ReadLine();

        }
    }
}
