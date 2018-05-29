using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Create a Sponsor class that has the same fields and methods as the Person class, and has the following additional

    fields:
        company: name of the company
        hiredStudents: number of students hired
    method:
        Introduce(): "Hi, I'm name, a age year old gender who represents company and hired hiredStudents students so far."
        Hire(): increase hiredStudents by 1
        GetGoal(): prints out "Hire brilliant junior software developers."

The Sponsor class has the following constructors:

    Sponsor(name, age, gender, company): beside the given parameters, it sets hiredStudents to 0
    Sponsor(): sets name to Jane Doe, age to 30, gender to female, company to Google and hiredStudents to 0
*/

namespace GreenFoxOrganization
{
    public class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor()
        {
            company = "Google";
            hiredStudents = 0;
        }

        public Sponsor(string name, int age, string gender, string company, int hiredStudents) : base(name, age, gender)
        {
            this.company = company;
            this.hiredStudents = 0;
        }

        public override string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.", Name, Age, Gender, company, hiredStudents);
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
