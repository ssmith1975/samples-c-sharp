using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace _12_DebugAndTrace
{
    // Debug and Trace

    class DebugAndTrace
    {
        static void Main(string[] args)
        {

            // Get the path to the documents folder from the Environment class
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "examplefile.txt";

            // Check if file exists. If not, create it...
            if (!File.Exists(filePath))
            {
                string content = "This is a text file. " + Environment.NewLine;

                Debug.WriteLine("Created with content: {0}", (object)content);
                Debug.Assert(content.Length > 0);

                Debug.Indent();
                Debug.WriteLine("Writing File Data...");
                Debug.Unindent();

                File.WriteAllText(filePath, content);
                
                Console.WriteLine();

            }

            // Use theAppendAllText method to add text to the content
            string addedText = DateTime.Now + " - Text added to the file." + Environment.NewLine;
            Debug.Indent();
            Debug.WriteLine("Appending File Data...");
            Debug.Unindent();

            File.AppendAllText(filePath, addedText);
            Debug.WriteLineIf(addedText.Length > 2, "Text length is greater than 2 characters");
            Debug.Assert(addedText.Length>2, "Tried to call function with empty string");
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
