using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Animal
    {
        public string name { get; set; }
        public Animal(string name)
        {
            this.name = name;
        }
        public void Eat()
        {
            Console.WriteLine(this.name + " is eating.");
        }
    }
}
