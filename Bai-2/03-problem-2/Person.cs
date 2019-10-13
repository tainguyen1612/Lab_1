using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_problem_2
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age , decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
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

        public decimal Salary
        {
            get { return this.salary; }
        }

        public void IncreaseSalary(decimal bonus)
        {
            if(age < 30)
            {
                this.salary = this.salary + bonus * 2;
            }
            else
            {
                this.salary = this.salary + bonus ;
            }

        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + "receives" + " " + this.salary + " " + "leva.";
        }
    }
}
