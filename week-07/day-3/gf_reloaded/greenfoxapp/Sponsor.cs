using System;
using System.Collections.Generic;
using System.Text;

namespace greenfoxapp
{
    class Sponsor : Person
    {
        string company;
        int hiredStudents;

        public Sponsor(string name, int age, string gender, string company, int hiredStudents) : base(name, age, gender)
        {
            this.company = company;
            this.hiredStudents = 0;
        }

        public Sponsor() : base()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
            this.company = "Google";
            this.hiredStudents = 0;
        }

        public override string Introduce()
        {
            return String.Format($"Hi, I'm {name}, a {age} year old {gender} who represents {company} and hired {hiredStudents} students so far.");
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