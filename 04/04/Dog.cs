using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Dog : Animal
    {
        public Dog(string name):base(name)
        {

        }
        public void Bark()
        {
            Console.WriteLine(this.name + " is barking.");
        }
    }
}
