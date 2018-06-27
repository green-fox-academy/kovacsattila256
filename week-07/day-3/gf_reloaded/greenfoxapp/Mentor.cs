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

        public Mentor() : base()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
            this.level = "intermediate";
        }

        public override string Introduce()
        {
            return String.Format($"Hi, I'm {0}, a {1} year old {2} {3} mentor.", Name, Age, Gender, level);
        }

        public override string GetGoal()
        {
            return "Educate brilliant junior software developers.";
        }
    }
}