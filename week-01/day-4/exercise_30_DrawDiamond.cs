using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was
            
            Console.WriteLine("Enter a number: ");

            int length = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < length - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < length * 2 - i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}