using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            Console.WriteLine("Adj meg egy sz�mot!");
            int yourInputNumber = Int32.Parse(Console.ReadLine());
            if (yourInputNumber % 2 == 0)
            {
            Console.WriteLine("A sz�m p�ros.");
            }
            else
            {
            Console.WriteLine("A sz�m p�ratlan.");
            }
        }
    }
}