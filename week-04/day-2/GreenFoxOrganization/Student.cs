using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create a Student class that has the same fields and methods as the Person class, and has the following additional

    fields:
        previousOrganization: the name of the student’s previous company / school
        skippedDays: the number of days skipped from the course
    methods:
        GetGoal(): prints out "Be a junior software developer."
        Introduce(): "Hi, I'm name, a age year old gender from previousOrganization who skipped skippedDays days from the course already."
        SkipDays(numberOfDays): increases skippedDays by numberOfDays

The Student class has the following constructors:

    Student(name, age, gender, previousOrganization): beside the given parameters, it sets skippedDays to 0
    Student(): sets name to Jane Doe, age to 30, gender to female, previousOrganization to The School of Life, skippedDays to 0
*/

namespace GreenFoxOrganization
{
    public class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student()
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }
        public override string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} from {3}" +
                                 " who skipped {4} days from the course already."
                                 , Name, Age, Gender, previousOrganization, skippedDays);
        }

        public override string GetGoal()
        {
            return "Be a junior software developer.";
        }

        public void SkipDays(int DaysToSkip)
        {
            skippedDays += DaysToSkip;
        }
    }
}