using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount Account = new BankAccount();
            Account.Id = 1;
            Account.Balance = 100;
            List<BankAccount> accounts = new List<BankAccount> { Account };
            Person person = new Person("Tai",20,accounts);
            Console.WriteLine(person.ToString());
            Console.ReadLine();

        }
    }
}
