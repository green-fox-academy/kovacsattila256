using System;

namespace Power
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

            int baseNumber = 5;
            int n = 2;
            Console.WriteLine(Power(baseNumber, n));
            Console.ReadLine();
        }

        public static int Power(int baseNumber, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return Power(baseNumber, n - 1) * baseNumber;
            }
        }
    }
}