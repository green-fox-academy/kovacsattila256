using System;
using System.Collections.Generic;
using System.Text;

namespace greenfoxapp
{
    class Sponsor : Person
    {
        string company;
        int hiredStudents;

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
            this.hiredStudents = 0;
        }

        public Sponsor() : this("Jane Doe", 30, "female", "Google")
        {
        }

        public override string Introduce()
        {
            return $"Hi, I'm {Name}, a {Age} year old {Gender} who represents {company} and hired {hiredStudents} students so far.";
        }

        public override string GetGoal()
        {
            return "Hire brilliant junior software developers.";
        }

        public void Hire()
        {
            hiredStudents++;
        }
    }
}