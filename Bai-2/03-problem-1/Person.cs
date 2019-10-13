using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_problem_1
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public int Age
        {
            get { return this.age; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public override string ToString()
        {
            return this.FirstName + this.LastName +  "is" + this.Age + "years old.";
        }
    }
}
