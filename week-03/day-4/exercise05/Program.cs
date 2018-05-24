using System;

namespace Bunny
{
    class Program
    {
        public static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively
            // (without loops or multiplication).
            Console.WriteLine(BunnyEars(30));
            Console.ReadLine();
        }
        public static int BunnyEars(int numberOfBunnies)
        {
            if (numberOfBunnies == 1)
            {
                return 2;
            }
            else
            {
                return BunnyEars(numberOfBunnies - 1) + 2;
            }
        }
    }
}
