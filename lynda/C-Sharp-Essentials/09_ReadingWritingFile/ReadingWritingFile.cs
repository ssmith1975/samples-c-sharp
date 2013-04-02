using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _09_ReadingWritingFile
{
    // Reading and Writing to File

    class ReadingWritingFile
    {
        static void Main(string[] args)
        {
            // Get the path to the documents folder from the Environment class
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "examplefile.txt";

            // Check if file exists. If not, create it...
            if (!File.Exists(filePath))
            {
                string content = "This is a text file. " + Environment.NewLine;
                Console.WriteLine("Creating the file...");
                File.WriteAllText(filePath, content);

                Console.WriteLine();

            }

            // Use theAppendAllText method to add text to the content
            string addedText = DateTime.Now + " - Text added to the file." + Environment.NewLine;
            Console.WriteLine("Appending text to file...");
            File.AppendAllText(filePath, addedText);

            Console.WriteLine();


            // Read the contents of the file
            Console.WriteLine("The current contents of the file are: ");
            Console.WriteLine("---------------------------------------");

            string currentContent = File.ReadAllText(filePath);
            Console.WriteLine(currentContent);
            Console.WriteLine();

            // Read the contents of the file line by line
            Console.WriteLine("The current contents of the file line by line are: ");
            Console.WriteLine("---------------------------------------");

            string[] contents = File.ReadAllLines(filePath);
            

            foreach (string s in contents)
            {
                Console.WriteLine(s);
            }
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
