using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_ConstAndEnum
{

    class ConstAndEnum
    {

        enum Temperatures
        { // related constants
            FREEZING = 32,
            LUKEWARM = 65,
            ROOMTEM = 72,
            HOT = 100,
            BOILING = 212
        }

        static void Main(string[] args)
        {
            const int freezingPointDegF = 32;
            const int boilingPointDegF = 212;

            int myTemp = 30;

            if (myTemp > freezingPointDegF && myTemp < boilingPointDegF)
            {
                Console.WriteLine("At this temperature, water is a liguid.");
            }
            else
            {
                Console.WriteLine("Water is not a liquid at this temperature.");
            }


            Console.WriteLine();


            if (myTemp > (int)Temperatures.FREEZING && myTemp < (int)Temperatures.BOILING)
            {
                Console.WriteLine("Enum - At this temperature, water is a liguid.");
            }
            else
            {
                Console.WriteLine("Enum - Water is not a liquid at this temperature.");
            }

            // Hold screen
            Console.ReadLine();

        }
    }
}
