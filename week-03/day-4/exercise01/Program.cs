using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.
            int n = 100;
            CountDown(n);
            Console.ReadLine();
        }
        public static void CountDown(int actualNumber)
        {
            if (actualNumber == 1)
            {
                Console.WriteLine(actualNumber);
            }
            else
            {
                Console.WriteLine(actualNumber);
                actualNumber--;
                CountDown(actualNumber);
            }
        }
    }
}
