using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create an Animal class

Every animal has a hunger value, which is a whole number
Every animal has a thirst value, which is a whole number
when creating a new animal object these values are created with the default 50 value
Every animal can eat() which decreases their hunger by one
Every animal can drink() which decreases their thirst by one
Every animal can play() which increases both by one
*/

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal donkey = new Animal();
            Animal worm = new Animal();
            Animal goat = new Animal();
        }
    }
}
class Animal
{
    public int hunger = 50;
    public int thirst = 50;

    public Animal(int hunger, int thirst)
    {
        this.hunger = hunger;
        this.thirst = thirst;
    }

    public void eat()
    {
        hunger -= 1;
    }

    public void drink()
    {
        thirst -= 1;
    }
    public void play()
    {
        thirst += 1;
        hunger += 1;
    }
}
