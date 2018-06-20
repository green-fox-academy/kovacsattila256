using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer
            Console.WriteLine("Enter a number:");
            int givenParameter = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sum of numbers until this:");
            Console.WriteLine(sum(givenParameter));
        }
        public static int sum(int givenParameter)
        {
            int summary = 0;
            for (int i = 0; i < givenParameter; i++)
            {
                summary = summary + i;
            }
            return summary;
        }
    }
}