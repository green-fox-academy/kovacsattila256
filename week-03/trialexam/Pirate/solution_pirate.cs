using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace Pirates
{
    public class PirateCounter
    {
        public static void Main(string[] args)
        {
            var pirates = new List<Pirate>();

            // Given this list...

            pirates.Add(new Pirate("Olaf", false, 12));
            pirates.Add(new Pirate("Uwe", true, 9));
            pirates.Add(new Pirate("Jack", true, 16));
            pirates.Add(new Pirate("Morgan", false, 17));
            pirates.Add(new Pirate("Hook", true, 20));

            // Write a function that takes any list that contains pirates as in the example,
            // And returns a list of names containing the pirates that
            // - have wooden leg and
            // - have more than 15 gold

            foreach (var name in PiratesFilter(pirates))
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }

        public static List<string> PiratesFilter (List<Pirate> pirates)
        {
            List<string> namesOfFilteredPirates = new List<string>();

            for (int i = 0; i < pirates.Count; i++)
            {
                if (pirates[i].HasWoodenLeg == true && pirates[i].Gold > 15)
                {
                    namesOfFilteredPirates.Add(pirates[i].Name);
                }
            }

            return namesOfFilteredPirates;
        }
    }
}