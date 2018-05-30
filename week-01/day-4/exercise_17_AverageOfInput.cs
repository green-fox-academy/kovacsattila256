using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int fourthNumber;
            int fifthNumber;
            Console.WriteLine("Add meg az elsõ számot!");
            firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második számot!");
            secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a harmadik számot!");
            thirdNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a negyedik számot!");
            fourthNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az ötödik számot!");
            fifthNumber = Int32.Parse(Console.ReadLine());
            int sum = (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber);
            int average = (sum / 5);
            Console.Write("A számok összege: {0} \r\n",sum);
            Console.Write("A számok átlaga: {0} \r\n",average);
            Console.ReadKey();
        }
    }
}