using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_problem_2
{
    class Puppy : Dog
    {
        public Puppy(string name) : base(name)
        {

        }
        public void Weep()
        {
            Console.WriteLine(this.name + " is weeping.");
        }
    }
}
