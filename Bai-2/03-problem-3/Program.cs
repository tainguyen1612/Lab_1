using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so doi tuong can dien : ");
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                try
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch
                {
                    Console.WriteLine("chua dien du thong tin");
                }
            }
            Console.Write("Nhap tien bonus : ");
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            foreach(Person x in persons)
            {
                x.Show();
            }
            Console.ReadLine();
        }
    }
}
