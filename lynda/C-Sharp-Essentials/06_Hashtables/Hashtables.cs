using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

// Hashtables (Dictionaries)

namespace _06_Hashtables
{
    class Hashtables
    {
        static void Main(string[] args)
        {
            // Declare hashtable
            Hashtable myHT = new Hashtable();

            // Add items to hashtable using key/value pairs
            myHT.Add("SEA", "Seattle Tacoma Airport");
            myHT.Add("SFO", "San Francisco Airport");
            myHT["IAD"] = "Washington Dulles Airport";
           
            // Display the a value
            Console.WriteLine("Value for key {0} is {1}", "SEA", myHT["SEA"]);

            // Remove item from hashtable
            myHT.Remove("SEA");

            // Check if key exists display its value
            if (myHT.ContainsKey("SEA"))
            {
                Console.WriteLine("Value for key {0} is {1}", "SEA", myHT["SEA"]);
            }

            Console.ReadLine();
        }
    }
}
