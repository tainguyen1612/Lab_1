using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public string grade { get; set; }
        public override string ToString()
        {
            return  this.name + " is " + this.age + " . " + this.grade + " student.";
        }
    }
}
