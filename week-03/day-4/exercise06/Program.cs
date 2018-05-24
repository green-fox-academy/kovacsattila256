﻿using System;

namespace BunnyAgain
{
    class Program
    {
        public static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
            Console.WriteLine(BunnyEars(6));
            Console.ReadLine();
        }
        public static int BunnyEars(int numberOfBunnies)
        {
            if (numberOfBunnies == 0)
            {
                return 0;
            }
            else
            {
                int bunnyEarNumber = 0;

                if (numberOfBunnies % 2 == 1)
                {
                    bunnyEarNumber = 2;
                }
                else if (numberOfBunnies % 2 == 0)
                {
                    bunnyEarNumber = 3;
                }
                return BunnyEars(numberOfBunnies - 1) + bunnyEarNumber;
            }
        }
    }
}
