using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            List<Student> list = new List<Student>();
            Console.WriteLine("====Menu====");
            Console.WriteLine("1.Create Student");
            Console.WriteLine("2.Show");
            Console.WriteLine("3.Exit");
            int choice;
            do
            {
                Console.Write("Nhap vao bang chon : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("So luong sinh vien nhap vao : ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Student {0}", (i + 1));
                            list.Add(new Student());
                            Console.Write("Name: ");
                            list[i].name = Console.ReadLine();
                            Console.Write("Age: ");
                            list[i].age = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Grade: ");
                            list[i].grade = Console.ReadLine();
                        }
                        Console.WriteLine("Create success!!");
                        break;
                    case 2:
                        Console.WriteLine("=========================");
                        foreach (Student x in list)
                        {
                            Console.WriteLine(x.ToString());
                        }
                        Console.WriteLine("=========================");
                        break;
                }
            }
            while (choice != 3);
            Console.ReadLine();

        }
    }
}
