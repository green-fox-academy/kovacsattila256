using System;
using System.IO;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.

            try
            {
                Console.WriteLine("Enter a filename with a full path: ");
                string path = Console.ReadLine();
                StreamWriter sw = new StreamWriter(path);
                Console.WriteLine("Enter a word: ");
                string word = Console.ReadLine();
                Console.WriteLine("Enter a number: ");
                int number = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < number; i++)
                {
                    sw.WriteLine(word);
                }
                sw.Dispose();
                Console.ReadLine();

            }
            catch (Exception)
            {
                Console.WriteLine("");
            }
        }
    }
}