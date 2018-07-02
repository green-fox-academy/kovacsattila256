using System;
using System.Collections.Generic;
using System.Text;

namespace greenfoxapp
{
    class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization, int skippedDays) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = skippedDays;
        }

        public Student() : this("Jane Doe", 30, "female", "The School of Life", 0)
        {
        }

        public override string GetGoal()
        {
            return "Be a junior software developer.";
        }

        public override string Introduce()
        {
            return $"Hi, I'm {Name}, a {Age} year old {Gender} from {previousOrganization} who skipped {skippedDays} days from the course already.";
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}