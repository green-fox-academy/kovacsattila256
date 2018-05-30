using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("Enter a number: ");
            int enteredNumber = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < enteredNumber; i++)
            {
                if (i == 0)
                {
                    for (int k = 0; k < enteredNumber; k++)
                    {
                        Console.Write("%");
                    }
                    Console.WriteLine();
                }
                for (i = 1; i < enteredNumber - 1; i++)
                {
                    Console.Write("%");
                    for (int l = 1; l < enteredNumber - 1; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                    Console.WriteLine();
                }
                if (i == enteredNumber - 1)
                {
                    for (int m = 0; m < enteredNumber; m++)
                    {
                        Console.Write("%");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}