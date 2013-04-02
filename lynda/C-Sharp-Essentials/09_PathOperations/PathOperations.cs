using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _09_PathOperations
{

    class PathOperations
    {
        static void Main(string[] args)
        {

            // Get the path to the documents folder from the Environment class
            string thePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Append filename to path
            thePath += @"\testfile.txt";

            //Exercise the path class methods
            Console.WriteLine("The directory name is {0}", Path.GetDirectoryName(thePath));
            Console.WriteLine("The file name is {0}", Path.GetFileName(thePath));
            Console.WriteLine("The file name without extension is {0}", Path.GetFileNameWithoutExtension(thePath));
            Console.WriteLine("Random file name for path is {0}", Path.GetRandomFileName());



            Console.ReadLine();
        }
    }
}
