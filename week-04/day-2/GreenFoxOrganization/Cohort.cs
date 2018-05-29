using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Create a Cohort class that has the following

    fields:
        name: the name of the cohort
        students: a list of Students
        mentors: a list of Mentors
    methods:
        addStudent(Student): adds the given Student to students list
        addMentor(Mentor): adds the given Mentor to mentors list
        info(): prints out "The name cohort has students.size() students and mentors.size() mentors."

The Cohort class has the following constructors:

    Cohort(name): beside the given parameter, it sets students and mentors as empty lists
*/

namespace GreenFoxOrganization
{
    public class Cohort
    {
        private string name;
        private List<Student> students;
        private List<Mentor> mentors;

        public Cohort(string name)
        {
            this.name = name;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public string Info()
        {
            return $"Cohort name: {name}\n" +
                   $"Number of Students: {students.Count}\n" +
                   $"Number of Mentors: {mentors.Count}";
        }
    }
}