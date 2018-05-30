using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            for (i = 0; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}