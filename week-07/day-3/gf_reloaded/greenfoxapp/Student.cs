using System;
using System.Collections.Generic;
using System.Text;

namespace greenfoxapp
{
    class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;
        private int numberOfDays;

        public Student(string name, int age, string gender, string previousOrganization, int skippedDays) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = skippedDays;
        }

        public Student() : base()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public override string GetGoal()
        {
            return "Be a junior software developer.";
        }

        public override string Introduce()
        {
            return String.Format($"Hi, I'm {0}, a {1} year old {2} from {previousOrganization} who skipped {skippedDays} days from the course already.", Name, Age, Gender);
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}