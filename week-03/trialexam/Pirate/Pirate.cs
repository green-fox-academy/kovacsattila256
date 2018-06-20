using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Pirate
    {
        public string Name;
        public bool HasWoodenLeg;
        public int Gold;

        public Pirate(string name, bool hasWoodenLeg, int gold)
        {
            Name = name;
            HasWoodenLeg = hasWoodenLeg;
            Gold = gold;
        }
    }
}
