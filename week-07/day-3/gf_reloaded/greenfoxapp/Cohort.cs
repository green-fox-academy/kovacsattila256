using System;
using System.Collections.Generic;
using System.Text;

namespace greenfoxapp
{
    class Cohort
    {
        private string name;
        private List<Student> students;
        private List<Mentor> mentors;

        public Cohort(string name)
        {
            this.name = name;
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
