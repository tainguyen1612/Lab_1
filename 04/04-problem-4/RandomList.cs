using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_problem_4
{
    class RandomList
    {
        public void RandomString(List<string> lst , string x, string y)
        {
            lst.Add(x);
            Console.WriteLine("them mot phan tu");
            foreach (string item in lst)
            {
                Console.Write(item.ToString()+ " ");
            }
            lst.Remove(y);
            Console.WriteLine("\nxoa mot phan tu");
            foreach (string item in lst)
            {
                Console.Write(item.ToString() + " ");
            }
        }
    }
}
