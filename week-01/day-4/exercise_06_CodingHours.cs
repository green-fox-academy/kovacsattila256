using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            {
                Console.WriteLine(5 * 17 * 6 + " Hours coded");
                Console.WriteLine(5 * 6 * 100 / 52 + "% of the worktime spent coding");

                Console.ReadLine();
            }
        }
    }
}