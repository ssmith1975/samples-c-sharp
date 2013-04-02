//#define DEBUGCODE
#define JOE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_PreprocessorDirectives
{
    // Preprocessor Directives

    class PreprocessorDirectives
    {
        static void Main(string[] args)
        {
            #region This is the main function
#if DEBUGCODE
            Console.WriteLine("This is a debug code.");
#else
            Console.WriteLine("This only gets written out in non-debug code");
#endif

#if JOE
            Console.WriteLine("Joe wins here!");
#endif
            Console.ReadLine();
            #endregion
        }
    }
}
