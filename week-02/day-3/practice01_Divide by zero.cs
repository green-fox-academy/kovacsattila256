using System;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("fail");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}