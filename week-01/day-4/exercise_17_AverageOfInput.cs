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
            Console.WriteLine("Add meg az els� sz�mot!");
            firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a m�sodik sz�mot!");
            secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a harmadik sz�mot!");
            thirdNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a negyedik sz�mot!");
            fourthNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az �t�dik sz�mot!");
            fifthNumber = Int32.Parse(Console.ReadLine());
            int sum = (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber);
            int average = (sum / 5);
            Console.Write("A sz�mok �sszege: {0} \r\n",sum);
            Console.Write("A sz�mok �tlaga: {0} \r\n",average);
            Console.ReadKey();
        }
    }
}