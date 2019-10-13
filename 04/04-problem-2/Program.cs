using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy("Bug");
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            Console.ReadLine();
        }
    }
}
