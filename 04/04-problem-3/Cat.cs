using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_problem_3
{
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }
        public void Meow()
        {
            Console.WriteLine(this.name + " is meowing.");
        }
    }
}
