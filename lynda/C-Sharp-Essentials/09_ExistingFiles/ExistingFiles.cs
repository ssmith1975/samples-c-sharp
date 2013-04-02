using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _09_ExistingFiles
{
    // Working with Existing Files

    class ExistingFiles
    {
        static void Main(string[] args)
        {
            bool fileExists = false;
            string thePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string theFile = thePath + @"\testfile.txt";

            fileExists = File.Exists(theFile);

            if (fileExists)
            {
                Console.WriteLine("The file exists");
            }
            else
            {
                Console.WriteLine("The file does not exists, creating it...");
                File.Create(theFile);
            }

            if (fileExists)
            {
                Console.WriteLine("It was created on {0}", File.GetCreationTime(theFile));
                Console.WriteLine("It was last accessed on {0}", File.GetLastAccessTime(theFile));

                Console.WriteLine("Moving the file...");
                File.Move(theFile, thePath + @"\newfile.txt");
            }


            Console.ReadLine();
        }
    }
}
