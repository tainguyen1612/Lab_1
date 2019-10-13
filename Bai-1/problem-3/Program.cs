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
            BankAccount bank = new BankAccount();
            List<BankAccount> list = new List<BankAccount>();
            Console.WriteLine("====Menu====");
            Console.WriteLine("1.Create Account");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.Show");
            Console.WriteLine("5.Exit");
            int choice;
            do
            {
                Console.Write("Nhap vao bang chon : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("So luong account nhap vao : ");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Account {0}", (i + 1));
                            
                            Console.Write("ID : ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            if(!(list.Exists(x=> x.Id == a)))
                            {
                                list.Add(new BankAccount());
                                list[i].Id = a;
                                Console.Write("So du: ");
                                list[i].Balance = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Create success!!");
                            }
                            else
                            {
                                Console.WriteLine("ID da ton tai");
                                continue;
                            }
                        }                       
                        break;
                    case 2:
                        Console.Write("Nhap ID account : ");
                        int id = int.Parse(Console.ReadLine());
                        foreach (BankAccount x in list)
                        {
                            if(x.Id == id)
                            {
                                Console.Write("Nhap so tien gui vao : ");
                                int gui = int.Parse(Console.ReadLine());
                                x.Deposit(gui);
                                Console.WriteLine("Gui tien thanh cong");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("ID khong ton tai");
                                break;
                            }
                        }

                        break;
                    case 3:
                        Console.Write("Nhap ID account : ");
                        int id2 = int.Parse(Console.ReadLine());
                        foreach (BankAccount x in list)
                        {
                            if (x.Id == id2)
                            {
                                Console.Write("Nhap so tien rut : ");
                                int rut = int.Parse(Console.ReadLine());
                                if(rut<=x.Balance)
                                {
                                    x.Withdraw(rut);
                                    Console.WriteLine("Rut tien thanh cong");
                                }
                                else
                                    Console.WriteLine("Rut tien rut vuot qua so du");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("ID khong ton tai");
                                break;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("=========================");
                        foreach (BankAccount x in list)
                        {
                            Console.WriteLine(x.ToString());
                        }
                        Console.WriteLine("=========================");
                        break;
                }
            }
            while (choice != 5);
            Console.ReadLine();
        }
    }
}
