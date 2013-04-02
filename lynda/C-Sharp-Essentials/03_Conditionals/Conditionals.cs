using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Conditionals
{
    class Conditionals
    {
        static void Main(string[] args)
        {
            int theVal = 52;

            if (theVal == 50)
            {
                Console.WriteLine("theVal is 50.");
            }
            else if (theVal == 51)
            {
                Console.WriteLine("theVal is 51.");
            }
            else
            {
                Console.WriteLine("theVal is something else.");
            }


            switch (theVal)
            {
                case 50:
                    Console.WriteLine("switch - theVal is 50.");
                    break;
                case 51:
                    Console.WriteLine("switch - theVal is 51.");
                    break;
                case 52:
                    Console.WriteLine("switch - theVal is 52.");
                    break;

                default:
                    Console.WriteLine("switch - theVal is something else.");
                    break;
            }


            Console.WriteLine();




            // Hold screen
            Console.ReadLine();


        }
    }
}
