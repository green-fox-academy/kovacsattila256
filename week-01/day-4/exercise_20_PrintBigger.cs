using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Adj meg egy sz�mot!");
            int yourInputNumber1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy m�sik sz�mot!");
            int yourInputNumber2 = Int32.Parse(Console.ReadLine());
            if (yourInputNumber1 > yourInputNumber2)
            {
                Console.Write("A nagyobb sz�m: {0}", yourInputNumber1);
            }
            if (yourInputNumber1 < yourInputNumber2)
            {
                Console.Write("A nagyobb sz�m: {0} \r\n", yourInputNumber2);
            }
        }
    }
}