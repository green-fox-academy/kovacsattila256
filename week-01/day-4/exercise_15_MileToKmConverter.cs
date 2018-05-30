using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            Console.WriteLine("Adjál meg mérföldbe váltandó km-t!");
            int kilometer;
            kilometer = Int32.Parse(Console.ReadLine());
            Console.WriteLine(kilometer / 1.609);
        }
    }
}