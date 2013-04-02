using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_NamedOptionalParams
{
    // Named Optional Params

    class NamedOptionalParams
    {
        static void myOptionalParamFunc(int param1, double param2 = 3.14159d, string param3 = "placeholder string")
        {
            Console.WriteLine("Called with \n\tparam1 {0}, \n\tparam2 {1}, \n\tparam3 {2}", param1, param2, param3);
        }

        static void myNamedParamExample(string cityName, string stateName, int zipCode)
        {
            Console.WriteLine("Argument passed: \n\tcityName is {0}, \n\tstate {1}, \n\tzipCode {2}", cityName, stateName, zipCode);
        }

        static void Main(string[] args)
        {
            // Named parameters
            myNamedParamExample(stateName: "Washington", zipCode: 98121, cityName: "Seattle");
            myNamedParamExample(cityName: "San Francisco", zipCode: 94109, stateName: "California");
            myNamedParamExample(zipCode: 94109, cityName: "New York", stateName: "New York");
            
            Console.WriteLine();

            // Optional parameters
            myOptionalParamFunc(15);
            myOptionalParamFunc(10, 2.71828d, "a different string");
            /* myNamedParamExample(10, "a different string"); // Error, parameters missing */

            // Now do both
            myOptionalParamFunc(10, param3: "named and optional in same call!");

            Console.ReadLine();
        }
    }
}
