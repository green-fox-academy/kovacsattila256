using System;
using System.IO;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            string path = @"C:\Users\A\source\repos\ConsoleApp4\ConsoleApp4\my-file.txt";
            try
            {
                File.WriteAllText(path, "kovacs attila");
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
        }
    }
}