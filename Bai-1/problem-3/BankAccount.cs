﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class BankAccount
    {
        private int id;
        private decimal balance;

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {this.Id}, balance {this.Balance}";
        }
    }
}
