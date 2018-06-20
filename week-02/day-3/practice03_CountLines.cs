using System;
using System.IO;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            string enteredFilename = @"d:\Users\A\source\repos\ConsoleApp4\ConsoleApp4\test.txt";
            Console.WriteLine(NumberOfLinesReturner(enteredFilename));
            Console.ReadLine();
        }
        public static int NumberOfLinesReturner(string enteredFilename)
        {
            int counter = 0;
            try
            {
                string[] arrayFilename = File.ReadAllLines(enteredFilename);
                for (int i = 0; i < arrayFilename.Length; i++)
                {
                    counter++;
                }
                return counter;
            }

            catch (Exception)
            {
                return counter;
            }
        }
    }
}