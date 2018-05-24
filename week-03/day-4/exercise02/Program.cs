using System;

namespace Numberadder
{
    class Program
    {
        static void Main(string[] args)

        // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
        {
            Console.WriteLine(NumberAdder(3));
            Console.ReadLine();
        }

        public static int NumberAdder(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return NumberAdder(n - 1) + n;
            }
        }
    }
}