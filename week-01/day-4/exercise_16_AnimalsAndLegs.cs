using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            int numberOfChickens;
            int numberOfPigs;
            Console.WriteLine("Add meg a csirk�k sz�m�t!");
            numberOfChickens = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a gyeszn�k sz�m�t!");
            numberOfPigs = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Az �sszes l�bak sz�ma: ");
            Console.Write(numberOfChickens *2 + numberOfPigs * 4);
        }
    }
}
