using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel student = new Hotel();
            List<Hotel> list = new List<Hotel>();
            Console.WriteLine("====Menu====");
            Console.WriteLine("1.Create Bill");
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
                            Console.WriteLine("ID {0}", (i + 1));
                            list.Add(new Hotel());
                            Console.Write("Price per day : ");
                            list[i].price_per_day = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Number day : ");
                            list[i].num_day = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Season: ");
                            list[i].season = Console.ReadLine();
                            Console.Write("Discount: ");
                            list[i].discount = Console.ReadLine();
                        }
                        Console.WriteLine("Create success!!");
                        break;
                    case 2:
                        Console.WriteLine("=========================");
                        foreach (Hotel x in list)
                        {
                            x.tinh_tien();
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
