using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Id = 1;
            account.Balance = 15;

            Console.WriteLine($"Account {account.Id}, balance {account.Balance}");
        }
    }
}
