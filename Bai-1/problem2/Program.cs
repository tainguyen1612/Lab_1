using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Id = 1;
            account.Deposit(15);
            account.Withdraw(10);

            Console.WriteLine(account.ToString());
        }
    }
}
