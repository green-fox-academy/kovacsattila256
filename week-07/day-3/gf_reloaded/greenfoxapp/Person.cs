using System;
using System.Collections.Generic;
using System.Text;

namespace greenfoxapp
{
    class Person
    {
        private string name;
        private int age;
        private string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public virtual string Introduce()
        {
            return String.Format($"Hi, I'm {name}, a {age} year old {gender}.");
        }

        public virtual string GetGoal()
        {
            return String.Format("My goal is: Live for the moment!");
        }
    }
}