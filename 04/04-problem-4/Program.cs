using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<string> list = new List<string> { "one", "two", "three", "four" };
            Console.Write("Random List : ");
            foreach(string x in list)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            int index = random.Next(list.Count);
            Console.WriteLine("Ramdon string");
            Console.WriteLine(list[index]);
            RandomList randomList = new RandomList();
            Console.WriteLine("function random string :");
            randomList.RandomString(list , "six" , "one");
            Console.ReadLine();
        }
    }
}
