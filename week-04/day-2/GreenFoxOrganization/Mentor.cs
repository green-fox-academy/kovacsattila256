using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Create a Mentor class that has the same fields and methods as the Person class, and has the following additional

    fields:
        level: the level of the mentor (junior / intermediate / senior)
    methods:
        GetGoal(): prints out "Educate brilliant junior software developers."
        Introduce(): "Hi, I'm name, a age year old gender level mentor."

The Mentor class has the following constructors:

    Mentor(name, age, gender, level)
    Mentor(): sets name to Jane Doe, age to 30, gender to female, level to intermediate
*/

namespace GreenFoxOrganization
{
    public class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }
        public Mentor()
        {
            level = "intermediate";
        }

        public override string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} {3} mentor.", Name, Age, Gender, level);
        }

        public override string GetGoal()
        {
            return "Educate brilliant junior software developers.";
        }
    }
}
