using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Muc");
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat("Meo");
            cat.Eat();
            cat.Meow();
            Console.ReadLine();
        }
    }
}
