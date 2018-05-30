using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("Enter a number: ");

            int numberOfLines = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= i ; j++)
                {
                    Console.Write("*");
                }
            }
            Console.ReadLine();
        }
    }
}