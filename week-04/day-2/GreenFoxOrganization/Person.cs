using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Create a Person class with the following fields:

    name: the name of the person
    age: the age of the person (whole number)
    gender: the gender of the person (male / female)

And the following methods:

    Introduce(): prints out "Hi, I'm name, a age year old gender."
    GetGoal(): prints out "My goal is: Live for the moment!"

And the following constructors:

    Person(name, age, gender)
    Person(): sets name to Jane Doe, age to 30, gender to female
*/

namespace GreenFoxOrganization
{
    public class Person
    {
        private string name;
        private int age;
        private string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
        }

        public virtual string Introduce()
        {
            return String.Format("Hi, my name is {0}, I'm {1} years old {2}.", Name, Age, Gender);
        }
        public virtual string GetGoal()
        {
            return String.Format("My goal is: Live for the moment!");
        }
    }
}
