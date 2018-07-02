using System;
using System.Collections.Generic;
using System.Text;

namespace greenfoxapp
{
    class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public Mentor() : this("Jane Doe", 30, "female", "intermediate") { }

        public override string Introduce()
        {
            return $"Hi, I'm {Name}, a {Age} year old {Gender} {level} mentor.";
        }

        public override string GetGoal()
        {
            return "Educate brilliant junior software developers.";
        }
    }
}