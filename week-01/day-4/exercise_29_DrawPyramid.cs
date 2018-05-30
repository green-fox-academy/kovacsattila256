using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            
            Console.WriteLine("Enter a number: ");

            int numberOfLines = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < numberOfLines - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
            }
            Console.ReadLine();
        }
    }
}