using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfString stack = new StackOfString();
            stack.Push("tai");
            stack.Push("tai1");
            stack.Push("tai2");

            Console.WriteLine("stack sau khi them");
            foreach(var x in stack.List)
            {
                Console.Write(x.ToString()+ " ");
            }

            stack.Pop();
            Console.WriteLine();
            Console.WriteLine("stack sau khi xoa");
            foreach (var x in stack.List)
            {
                Console.Write(x.ToString() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Stack sau khi peek : {0}", stack.Peek());
            Console.WriteLine("Kiem tra stack cos emty");
            if(stack.IsEmpty())
            {
                Console.WriteLine("Stack co emty");
            }
            else
            {
                Console.WriteLine("Stack khong emty");
            }
            Console.ReadLine();
        }
    }
}
