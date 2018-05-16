using System;
using System.IO;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines 
            // to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            Console.WriteLine("Add a source file with full path: ");
            string sourceFile = Console.ReadLine();

            Console.WriteLine("Add a destination file with full path: ");
            string destFile = Console.ReadLine();

            Console.WriteLine(CopyMachine(sourceFile, destFile));

        }
        public static bool CopyMachine(string sourceFile, string destFile)
        {
            try
            {
            string content = File.ReadAllText(sourceFile);
            File.WriteAllText(destFile, content);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } 
    }    
}