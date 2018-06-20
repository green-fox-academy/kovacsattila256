using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            Console.WriteLine("Enter a number:");
            int givenParameter = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of numbers until this:");
            Console.WriteLine(factorio(givenParameter));
        }
        public static int factorio(int givenParameter)
        {
            int fact = 1;
            for (int i = 1; i <= givenParameter; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}