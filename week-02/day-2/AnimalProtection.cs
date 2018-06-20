using System;

namespace AnimalProtection
{
    public class AnimalProtection
    {
        public static void Main(string[] args)
        {
            // Create an animal shelter where we can save and take care of Animals
            //
            // An Animal
            // -  has a `name` and stores it's health state in a boolean
            // -  has a `healCost` field
            // -  has a method named `Heal()`, that sets the `isHealthy` field's status to true
            // -  has a method named `IsAdoptable()` that returns a boolean value whether it can be adopted or not (an animal can be adopted if it is healthy)
            // -  has a method named `ToString()` that represents the Animal in the following format:
            // <name> is not healthy (<heal cost>€), and not adoptable
            // <name> is healthy, and adoptable
            // The animal's name is the same as the class name by default, but it can be set thought constructor as well
            // 
            // We are working with 3 types of Animals
            // -  Cat's healing cost should be a random number between 0 and 6
            // -  Dog's healing cost should be a random number between 1 and 8
            // -  Parrot's healing cost should be a random number between 4 and 10
            //
            // An AnimalShelter 
            // -  has a `budget`
            // -  has an `animals` list
            // -  has an `adopters` name list
            // -  has a method named `Rescue(animal)` this method takes an Animal object as parameter and add the animal to the shelter's list and return the size of the list
            // -  has a method named `Heal()` this method heals the first not healthy Animal, if it is possible by budget, returns the amount of healed animals(0 or 1)
            // -  has a method named `AddAdopter(name)` this method takes a string as parameter and save it as a potential new owner
            // -  has a method named `FindNewOwner()` this method pairs a random name with a random adoptable Animal if it is possible and remove both of them from the lists
            // -  has a method named `EarnDonation(amount)` this method takes a whole number as parameter and increase the shelter's budget by the parameter's value and returns the current budget
            // -  has a method named `ToString()` that represents the shelter in the following format:
            // Budget: <budget>€, There are <animals.count> animal(s) and <potentionalAdopters.count> potential adopter(s)
            // <animal1 name> is not healthy (<heal cost>€), and not adoptable
            // <animal2 name> is healthy, and adoptable
            //
            // The shelter starts with 50€ without any Animal and adopter
            // 
            var animalShelter = new AnimalShelter();

            animalShelter.Rescue(new Cat());
            animalShelter.Rescue(new Dog("Furkesz"));
            animalShelter.Rescue(new Parrot());
            Console.WriteLine(animalShelter.ToString());
            // Budget: 50€, There are 3 animal(s) and 0 potential adopter(s)
            // Cat is not healthy (3€) and not adoptable
            // Furkesz is not healthy (1€) and not adoptable
            // Parrot is not healthy (7€) and not adoptable

            animalShelter.Heal();
            Console.WriteLine(animalShelter.ToString());
            // Budget: 47€, There are 3 animal(s) and 0 potential adopter(s)
            // Cat is healthy and adoptable
            // Furkesz is not healthy (1€) and not adoptable
            // Parrot is not healthy (7€) and not adoptable     

            animalShelter.AddAdopter("Kond");
            Console.WriteLine(animalShelter.ToString());
            // Budget: 47€, There are 3 animal(s) and 1 potential adopter(s)
            // Cat is healthy and adoptable
            // Furkesz is not healthy (1€) and not adoptable
            // Parrot is not healthy (7€) and not adoptable

            animalShelter.FindNewOwner();
            animalShelter.EarnDonation(30);
            Console.WriteLine(animalShelter.ToString());
            // Budget: 77€, There are 2 animal(s) and 0 potential adopter(s)
            // Furkesz is not healthy (1€) and not adoptable
            // Parrot is not healthy (7€) and not adoptable
            
            Console.ReadLine();
        }
    }
}
